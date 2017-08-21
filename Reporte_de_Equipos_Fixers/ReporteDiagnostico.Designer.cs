namespace Reporte_de_Equipos_Fixers
{
    partial class frmReporteDiagnostico
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
            this.crystalReportDiagnostico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportDiagnostico
            // 
            this.crystalReportDiagnostico.ActiveViewIndex = -1;
            this.crystalReportDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportDiagnostico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportDiagnostico.Location = new System.Drawing.Point(0, 0);
            this.crystalReportDiagnostico.Name = "crystalReportDiagnostico";
            this.crystalReportDiagnostico.Size = new System.Drawing.Size(687, 429);
            this.crystalReportDiagnostico.TabIndex = 0;
            // 
            // frmReporteDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 429);
            this.Controls.Add(this.crystalReportDiagnostico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReporteDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Diagnóstico";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportDiagnostico;
    }
}