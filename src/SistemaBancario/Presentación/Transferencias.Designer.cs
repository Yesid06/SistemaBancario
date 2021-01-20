namespace SistemaBancario.Presentación
{
    partial class Transferencias
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
            this.lblMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MontoVdTransf = new System.Windows.Forms.Label();
            this.lblMontoRest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTranferir = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblNdCuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(109, 24);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MontoVdTransf
            // 
            this.MontoVdTransf.AutoSize = true;
            this.MontoVdTransf.Location = new System.Drawing.Point(32, 54);
            this.MontoVdTransf.Name = "MontoVdTransf";
            this.MontoVdTransf.Size = new System.Drawing.Size(114, 13);
            this.MontoVdTransf.TabIndex = 3;
            this.MontoVdTransf.Text = "Valor de Transferencia";
            // 
            // lblMontoRest
            // 
            this.lblMontoRest.AutoSize = true;
            this.lblMontoRest.Location = new System.Drawing.Point(68, 86);
            this.lblMontoRest.Name = "lblMontoRest";
            this.lblMontoRest.Size = new System.Drawing.Size(78, 13);
            this.lblMontoRest.TabIndex = 4;
            this.lblMontoRest.Text = "Monto restante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // btnTranferir
            // 
            this.btnTranferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTranferir.FlatAppearance.BorderSize = 0;
            this.btnTranferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranferir.Location = new System.Drawing.Point(112, 145);
            this.btnTranferir.Name = "btnTranferir";
            this.btnTranferir.Size = new System.Drawing.Size(88, 23);
            this.btnTranferir.TabIndex = 6;
            this.btnTranferir.Text = "Tranferir";
            this.btnTranferir.UseVisualStyleBackColor = false;
            this.btnTranferir.Click += new System.EventHandler(this.btnTranferir_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuenta.Location = new System.Drawing.Point(155, 114);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(141, 13);
            this.txtCuenta.TabIndex = 7;
            // 
            // lblNdCuenta
            // 
            this.lblNdCuenta.AutoSize = true;
            this.lblNdCuenta.Location = new System.Drawing.Point(51, 114);
            this.lblNdCuenta.Name = "lblNdCuenta";
            this.lblNdCuenta.Size = new System.Drawing.Size(95, 13);
            this.lblNdCuenta.TabIndex = 8;
            this.lblNdCuenta.Text = "Número de cuenta";
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 193);
            this.Controls.Add(this.lblNdCuenta);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.btnTranferir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMontoRest);
            this.Controls.Add(this.MontoVdTransf);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonto);
            this.Name = "Transferencias";
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.Transferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label MontoVdTransf;
        private System.Windows.Forms.Label lblMontoRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTranferir;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblNdCuenta;
    }
}