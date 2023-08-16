namespace pjConversionMedidas
{
    partial class frmMedidas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstR = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pjConversionMedidas.Properties.Resources.cinta;
            this.pictureBox1.Location = new System.Drawing.Point(55, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE MEDIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE VALOR EN METROS";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(291, 237);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(125, 27);
            this.txtMetros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(467, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 29);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstR
            // 
            this.lstR.FormattingEnabled = true;
            this.lstR.ItemHeight = 20;
            this.lstR.Location = new System.Drawing.Point(65, 289);
            this.lstR.Name = "lstR";
            this.lstR.Size = new System.Drawing.Size(531, 184);
            this.lstR.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(65, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(191, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 541);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstR);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMedidas";
            this.Text = "Control de medidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtMetros;
        private Button btnCalcular;
        private ListBox lstR;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}