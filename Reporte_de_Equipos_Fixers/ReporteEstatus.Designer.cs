namespace Reporte_de_Equipos_Fixers
{
    partial class frmReporteEstatus
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
            this.crystalReportEstado = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportEstado
            // 
            this.crystalReportEstado.ActiveViewIndex = -1;
            this.crystalReportEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportEstado.Location = new System.Drawing.Point(0, 0);
            this.crystalReportEstado.Name = "crystalReportEstado";
            this.crystalReportEstado.Size = new System.Drawing.Size(698, 439);
            this.crystalReportEstado.TabIndex = 0;
            // 
            // frmReporteEstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 439);
            this.Controls.Add(this.crystalReportEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReporteEstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Por Estatus";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportEstado;
    }
}