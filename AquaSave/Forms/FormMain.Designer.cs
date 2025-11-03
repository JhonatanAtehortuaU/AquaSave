namespace AquaSave.Forms
{
    partial class FormMain
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.dataGridDiarios = new System.Windows.Forms.DataGridView();
            this.dataGridSemanales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSemanales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(395, 204);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 16);
            this.lblBienvenida.TabIndex = 0;
            // 
            // dataGridDiarios
            // 
            this.dataGridDiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridDiarios.Location = new System.Drawing.Point(0, 331);
            this.dataGridDiarios.Name = "dataGridDiarios";
            this.dataGridDiarios.RowHeadersVisible = false;
            this.dataGridDiarios.RowHeadersWidth = 51;
            this.dataGridDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDiarios.Size = new System.Drawing.Size(800, 119);
            this.dataGridDiarios.TabIndex = 0;
            this.dataGridDiarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDiarios_CellDoubleClick);
            // 
            // dataGridSemanales
            // 
            this.dataGridSemanales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSemanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSemanales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridSemanales.Location = new System.Drawing.Point(0, 0);
            this.dataGridSemanales.Name = "dataGridSemanales";
            this.dataGridSemanales.RowHeadersVisible = false;
            this.dataGridSemanales.RowHeadersWidth = 51;
            this.dataGridSemanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSemanales.Size = new System.Drawing.Size(800, 134);
            this.dataGridSemanales.TabIndex = 1;
            this.dataGridSemanales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSemanales_CellDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSemanales);
            this.Controls.Add(this.dataGridDiarios);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSemanales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.DataGridView dataGridDiarios;
        private System.Windows.Forms.DataGridView dataGridSemanales;
    }
}