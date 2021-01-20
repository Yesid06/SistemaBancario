namespace SistemaBancario.Presentación
{
    partial class Depositos
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
            this.MontoVdTransf = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtEsta = new System.Windows.Forms.TextBox();
            this.lblNdCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MontoVdTransf
            // 
            this.MontoVdTransf.AutoSize = true;
            this.MontoVdTransf.Location = new System.Drawing.Point(13, 27);
            this.MontoVdTransf.Name = "MontoVdTransf";
            this.MontoVdTransf.Size = new System.Drawing.Size(91, 13);
            this.MontoVdTransf.TabIndex = 28;
            this.MontoVdTransf.Text = "Valor de Deposito";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(13, 53);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(81, 13);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Establecimiento";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Location = new System.Drawing.Point(125, 103);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 25);
            this.btnDepositar.TabIndex = 22;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtEsta
            // 
            this.txtEsta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEsta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEsta.Location = new System.Drawing.Point(125, 53);
            this.txtEsta.MaxLength = 30;
            this.txtEsta.Name = "txtEsta";
            this.txtEsta.Size = new System.Drawing.Size(200, 13);
            this.txtEsta.TabIndex = 21;
            // 
            // lblNdCuenta
            // 
            this.lblNdCuenta.AutoSize = true;
            this.lblNdCuenta.Location = new System.Drawing.Point(13, 71);
            this.lblNdCuenta.Name = "lblNdCuenta";
            this.lblNdCuenta.Size = new System.Drawing.Size(95, 13);
            this.lblNdCuenta.TabIndex = 31;
            this.lblNdCuenta.Text = "Número de cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Número de cuenta";
            // 
            // Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNdCuenta);
            this.Controls.Add(this.MontoVdTransf);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtEsta);
            this.Name = "Depositos";
            this.Text = "Depositos";
            this.Load += new System.EventHandler(this.Depositos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MontoVdTransf;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtEsta;
        private System.Windows.Forms.Label lblNdCuenta;
        private System.Windows.Forms.Label label1;
    }
}