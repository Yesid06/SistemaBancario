namespace SistemaBancario.Presentación
{
    partial class Menu
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
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetiros = new System.Windows.Forms.Button();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Location = new System.Drawing.Point(28, 22);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(96, 13);
            this.lblNumCuenta.TabIndex = 0;
            this.lblNumCuenta.Text = "Número de Cuenta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(28, 93);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label6";
            // 
            // btnRetiros
            // 
            this.btnRetiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetiros.FlatAppearance.BorderSize = 0;
            this.btnRetiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiros.Location = new System.Drawing.Point(68, 151);
            this.btnRetiros.Name = "btnRetiros";
            this.btnRetiros.Size = new System.Drawing.Size(111, 27);
            this.btnRetiros.TabIndex = 6;
            this.btnRetiros.Text = "Retiros";
            this.btnRetiros.UseVisualStyleBackColor = false;
            this.btnRetiros.Click += new System.EventHandler(this.btnRetiros_Click);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransferencias.FlatAppearance.BorderSize = 0;
            this.btnTransferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencias.Location = new System.Drawing.Point(68, 184);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(111, 27);
            this.btnTransferencias.TabIndex = 7;
            this.btnTransferencias.Text = "Transferencia";
            this.btnTransferencias.UseVisualStyleBackColor = false;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDepositos.FlatAppearance.BorderSize = 0;
            this.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositos.Location = new System.Drawing.Point(68, 217);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(111, 27);
            this.btnDepositos.TabIndex = 8;
            this.btnDepositos.Text = "Depósitos";
            this.btnDepositos.UseVisualStyleBackColor = false;
            this.btnDepositos.Click += new System.EventHandler(this.btnDepositos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 277);
            this.Controls.Add(this.btnDepositos);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.btnRetiros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumCuenta);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetiros;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.Button btnDepositos;
    }
}