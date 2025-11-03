namespace AquaSave.Forms
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.btnInicioSe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txCorreo
            // 
            this.txCorreo.Location = new System.Drawing.Point(59, 53);
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.Size = new System.Drawing.Size(160, 22);
            this.txCorreo.TabIndex = 2;
            // 
            // txContrasena
            // 
            this.txContrasena.Location = new System.Drawing.Point(59, 113);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(160, 22);
            this.txContrasena.TabIndex = 3;
            // 
            // btnInicioSe
            // 
            this.btnInicioSe.Location = new System.Drawing.Point(83, 157);
            this.btnInicioSe.Name = "btnInicioSe";
            this.btnInicioSe.Size = new System.Drawing.Size(110, 23);
            this.btnInicioSe.TabIndex = 4;
            this.btnInicioSe.Text = "Iniciar Sesion";
            this.btnInicioSe.UseVisualStyleBackColor = true;
            this.btnInicioSe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInicioSe);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.txCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.Button btnInicioSe;
        private System.Windows.Forms.Button button2;
    }
}