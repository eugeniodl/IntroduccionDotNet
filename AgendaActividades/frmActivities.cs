using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActividades
{
    public partial class frmActivities : Form
    {
        private bool _HasChanges;
        private bool _IsNewAct;

        public frmActivities()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            this.lstAct.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.txtAct.Enabled = false;

            // enable/disable the listbox based on number items
            this.lstAct.Enabled = this.lstAct.Items.Count > 0;
            this.lstAct.SelectedIndex = -1;

            _HasChanges = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddNewAct();
        }

        private void AddNewAct()
        {
            if(_HasChanges)
            {
                if(MessageBox.Show("¿Guardar cambios?", "Guardar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    if(!this.SaveChanges())
                    {
                        return;
                    }
                }
            }
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;

            txtAct.Enabled = true;
            txtAct.Clear();
            txtAct.Focus();

            _IsNewAct = true;
        }

        private bool SaveChanges()
        {
            if(txtAct.Text.Length == 0)
            {
                MessageBox.Show("Debe escribir un nombre para la actividad",
                    "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(_IsNewAct)
            {
                this.lstAct.Items.Add(txtAct.Text);
                this.Reset();
            }
            else
            {
                this.lstAct.Items[lstAct.SelectedIndex] = txtAct.Text;
                MessageBox.Show("Guardado correctamente");
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void frmActivities_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Guardar cambios?", "Guardar",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                if(!this.SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if(r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteAct();
        }

        private void DeleteAct()
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar?",
                "Confirmar eliminación", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                if(lstAct.SelectedIndex >= 0 && lstAct.SelectedIndex < lstAct.Items.Count)
                {
                    this.lstAct.Items.RemoveAt(lstAct.SelectedIndex);
                    Reset();
                }
            }
        }

        private void txtAct_TextChanged(object sender, EventArgs e)
        {
            _HasChanges = true;
        }
    }
}
