namespace AquaSave.Forms
{
    partial class FormRegistro
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
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txNombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInicioSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(74, 215);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(110, 23);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txContrasena
            // 
            this.txContrasena.Location = new System.Drawing.Point(52, 178);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(160, 22);
            this.txContrasena.TabIndex = 9;
            // 
            // txCorreo
            // 
            this.txCorreo.Location = new System.Drawing.Point(52, 111);
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.Size = new System.Drawing.Size(160, 22);
            this.txCorreo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correo";
            // 
            // txNombreCompleto
            // 
            this.txNombreCompleto.Location = new System.Drawing.Point(52, 52);
            this.txNombreCompleto.Name = "txNombreCompleto";
            this.txNombreCompleto.Size = new System.Drawing.Size(160, 22);
            this.txNombreCompleto.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Completo";
            // 
            // btnInicioSe
            // 
            this.btnInicioSe.Location = new System.Drawing.Point(74, 253);
            this.btnInicioSe.Name = "btnInicioSe";
            this.btnInicioSe.Size = new System.Drawing.Size(110, 23);
            this.btnInicioSe.TabIndex = 13;
            this.btnInicioSe.Text = "Iniciar Sesion";
            this.btnInicioSe.UseVisualStyleBackColor = true;
            this.btnInicioSe.Click += new System.EventHandler(this.btnInicioSe_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 297);
            this.Controls.Add(this.btnInicioSe);
            this.Controls.Add(this.txNombreCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.txCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInicioSe;
    }
}