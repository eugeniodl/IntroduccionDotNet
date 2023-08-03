using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        private decimal _Operand;
        private string _OperandTxt;
        private string _Operator;

        public frmCalculadora()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            _Operand = 0;
            _OperandTxt = "";
            _Operator = "";
            txtResult.Text = "0";
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetOperandTxt(e.KeyChar.ToString());
        }

        private void SetOperandTxt(string value)
        {
            // Si el valor es numérico
            if(value == "9" || value == "8" || value == "7" ||
                value == "6" || value == "5" || value == "4" ||
                value == "3" || value == "2" || value == "1" || value == "0")
            {
                _OperandTxt = _OperandTxt + value;
                txtResult.Text = _OperandTxt;
            }
            // Si el valor es operador
            else if(value == "+" || value == "-" || value == "*"
                || value == "/")
            {

            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnText = btn.Text;
            SetOperandTxt(btnText);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if(_OperandTxt.Length > 1)
                _OperandTxt = _OperandTxt.Substring(0, _OperandTxt.Length - 1);
            else
                _OperandTxt = "0";

            txtResult.Text = _OperandTxt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
