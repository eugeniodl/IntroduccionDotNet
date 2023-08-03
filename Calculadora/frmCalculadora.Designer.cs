namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(366, 39);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(288, 228);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 106);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(156, 284);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(60, 50);
            this.btnDec.TabIndex = 3;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            // 
            // btnNumber0
            // 
            this.btnNumber0.Location = new System.Drawing.Point(24, 284);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(126, 50);
            this.btnNumber0.TabIndex = 4;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(222, 228);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(60, 50);
            this.btnSubstract.TabIndex = 5;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnNumber3
            // 
            this.btnNumber3.Location = new System.Drawing.Point(156, 228);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(60, 50);
            this.btnNumber3.TabIndex = 6;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Location = new System.Drawing.Point(90, 228);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(60, 50);
            this.btnNumber2.TabIndex = 7;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Location = new System.Drawing.Point(24, 228);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(60, 50);
            this.btnNumber1.TabIndex = 8;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(222, 172);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 50);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnNumber6
            // 
            this.btnNumber6.Location = new System.Drawing.Point(156, 172);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(60, 50);
            this.btnNumber6.TabIndex = 10;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Location = new System.Drawing.Point(90, 172);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(60, 50);
            this.btnNumber5.TabIndex = 11;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Location = new System.Drawing.Point(24, 172);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(60, 50);
            this.btnNumber4.TabIndex = 12;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(222, 116);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 50);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnNumber9
            // 
            this.btnNumber9.Location = new System.Drawing.Point(156, 116);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(60, 50);
            this.btnNumber9.TabIndex = 14;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Location = new System.Drawing.Point(90, 116);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(60, 50);
            this.btnNumber8.TabIndex = 15;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Location = new System.Drawing.Point(24, 116);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(60, 50);
            this.btnNumber7.TabIndex = 16;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 50);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 50);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "<-";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 352);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnNumber0);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.txtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Button btnEqual;
        private Button btnAdd;
        private Button btnDec;
        private Button btnNumber0;
        private Button btnSubstract;
        private Button btnNumber3;
        private Button btnNumber2;
        private Button btnNumber1;
        private Button btnMultiply;
        private Button btnNumber6;
        private Button btnNumber5;
        private Button btnNumber4;
        private Button btnDivide;
        private Button btnNumber9;
        private Button btnNumber8;
        private Button btnNumber7;
        private Button btnReset;
        private Button btnDelete;
    }
}