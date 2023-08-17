using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjActivities
{
    public partial class frmActivities : Form
    {
        private bool _HasChanges;
        private bool _IsNewActivity;

        public frmActivities()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            lstActivities.Enabled = false;
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            txtActivity.Enabled = false;

            txtActivity.Clear();

            lstActivities.Enabled = lstActivities.Items.Count > 0;
            lstActivities.SelectedIndex = -1;

            _HasChanges = false;
        }

        private void txtActivity_TextChanged(object sender, EventArgs e)
        {
            _HasChanges = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewActivity();
        }

        private void AddNewActivity()
        {
            if (_HasChanges)
            {
                if (MessageBox.Show("¿Guardar cambios?", "Guardar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!SaveChanges())
                    {
                        return;
                    }
                }
            }
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;

            txtActivity.Enabled = true;
            txtActivity.Clear();
            txtActivity.Focus();

            _IsNewActivity = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private bool SaveChanges()
        {
            if (txtActivity.Text.Length == 0)
            {
                MessageBox.Show("Debe escribir la actividad",
                    "Guardar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (_IsNewActivity)
            {
                lstActivities.Items.Add(txtActivity.Text);
                Reset();
            }
            else
            {
                lstActivities.Items[lstActivities.SelectedIndex]
                    = txtActivity.Text;
                MessageBox.Show("Guardado correctamente");
            }


            return true;
        }

        private void lstActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedActivity();
        }

        private void LoadSelectedActivity()
        {
            if (lstActivities.SelectedIndex >= 0 &&
                lstActivities.SelectedIndex < lstActivities.Items.Count)
            {
                txtActivity.Text =
                    lstActivities.Items[lstActivities.SelectedIndex].ToString();
                btnSave.Enabled = true;
                txtActivity.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;

                _IsNewActivity = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }

        private void DeleteActivity()
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lstActivities.SelectedIndex >= 0 &&
    lstActivities.SelectedIndex < lstActivities.Items.Count)
                {
                    lstActivities.Items.RemoveAt(lstActivities.SelectedIndex);
                    Reset();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            if (_HasChanges)
            {
                if (MessageBox.Show("¿Guardar cambios?", "Guardar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!SaveChanges())
                    {
                        return;
                    }
                }
            }
            Reset();
        }

        private void frmActivities_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Guardar cambios?",
                "Guardar", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                if(!SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }
            if(r == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
