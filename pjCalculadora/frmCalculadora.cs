using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCalculadora
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
            _OperandTxt = "0";
            _Operator = "";

            txtResult.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;
            SetOperandTxt(buttonText);
        }

        private void SetOperandTxt(string value)
        {
            // Si el valor es numérico
            if(value == "9" || value == "8" || value == "7" ||
                value == "6" || value == "5" || value == "4" ||
                value == "3" || value == "2" || value == "1" ||
                value == "0")
            {
                if (_OperandTxt == "0")
                    _OperandTxt = "";

                _OperandTxt += value;
                txtResult.Text = _OperandTxt;
            }
            // Si el valor es el operador
            else if(value == "+" || value == "-" || value == "*" ||
                value == "/" )
            {
                if (_Operator != "" && _OperandTxt != "")
                    DoOperation();

                _Operator = value;
                if (_OperandTxt != "")
                {
                    _Operand = decimal.Parse(_OperandTxt);
                    _OperandTxt = "";
                }
            }
            // Si el valor es igual
            else if(value == "=")
            {
                if (_Operator != "" && _OperandTxt != "")
                    DoOperation();
            }
            // Si el valor es punto
            else if(value == ",")
            {
                if(_OperandTxt.IndexOf(",") < 0)
                {
                    _OperandTxt = _OperandTxt + ",";
                    txtResult.Text = _OperandTxt;
                }
            }
        }

        private void DoOperation()
        {
            decimal result = 0;
            if (_Operator == "+")
                result = _Operand + decimal.Parse(_OperandTxt);
            else if(_Operator == "-")
                result = _Operand - decimal.Parse(_OperandTxt);
            else if( _Operator == "*")
                result = _Operand * decimal.Parse(_OperandTxt);
            else if(_Operator == "/")
                result = _Operand / decimal.Parse(_OperandTxt);
            _Operator = "";
            _OperandTxt = result.ToString();
            txtResult.Text = _OperandTxt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if (_OperandTxt.Length > 1)
                _OperandTxt = _OperandTxt.Substring(0, _OperandTxt.Length - 1);
            else
                _OperandTxt = "0";

            txtResult.Text = _OperandTxt;
        }
    }
}
