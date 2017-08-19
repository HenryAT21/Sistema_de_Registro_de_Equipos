namespace Reporte_de_Equipos_Fixers
{
    partial class frmCliente
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
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(15, 167);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCliente.TabIndex = 26;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 202);
            this.Controls.Add(this.btnGuardarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarCliente;
    }
}