namespace Reporte_de_Equipos_Fixers
{
    partial class frmPantalla_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantalla_Principal));
            this.menuStripPantallaP = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEditarTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorEstatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPantallaP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPantallaP
            // 
            this.menuStripPantallaP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStripPantallaP.Location = new System.Drawing.Point(0, 0);
            this.menuStripPantallaP.Name = "menuStripPantallaP";
            this.menuStripPantallaP.Size = new System.Drawing.Size(708, 24);
            this.menuStripPantallaP.TabIndex = 0;
            this.menuStripPantallaP.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Tag = "";
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.ordenesDeTrabajoToolStripMenuItem});
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("equiposToolStripMenuItem.Image")));
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenesDeTrabajoToolStripMenuItem.Image")));
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de Trabajo";
            this.ordenesDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeTrabajoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarOrdenesToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // buscarOrdenesToolStripMenuItem
            // 
            this.buscarOrdenesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarOrdenesToolStripMenuItem.Image")));
            this.buscarOrdenesToolStripMenuItem.Name = "buscarOrdenesToolStripMenuItem";
            this.buscarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarOrdenesToolStripMenuItem.Text = "Buscar Ordenes";
            this.buscarOrdenesToolStripMenuItem.Click += new System.EventHandler(this.buscarOrdenesToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEditarTécnicoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // registrarEditarTécnicoToolStripMenuItem
            // 
            this.registrarEditarTécnicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarEditarTécnicoToolStripMenuItem.Image")));
            this.registrarEditarTécnicoToolStripMenuItem.Name = "registrarEditarTécnicoToolStripMenuItem";
            this.registrarEditarTécnicoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registrarEditarTécnicoToolStripMenuItem.Text = "Registrar/Editar Técnico";
            this.registrarEditarTécnicoToolStripMenuItem.Click += new System.EventHandler(this.registrarEditarTécnicoToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crystalReportsToolStripMenuItem,
            this.reportePorEstatusToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // crystalReportsToolStripMenuItem
            // 
            this.crystalReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("crystalReportsToolStripMenuItem.Image")));
            this.crystalReportsToolStripMenuItem.Name = "crystalReportsToolStripMenuItem";
            this.crystalReportsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.crystalReportsToolStripMenuItem.Text = "Reporte Con Diagnostico";
            this.crystalReportsToolStripMenuItem.Click += new System.EventHandler(this.crystalReportsToolStripMenuItem_Click);
            // 
            // reportePorEstatusToolStripMenuItem
            // 
            this.reportePorEstatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportePorEstatusToolStripMenuItem.Image")));
            this.reportePorEstatusToolStripMenuItem.Name = "reportePorEstatusToolStripMenuItem";
            this.reportePorEstatusToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.reportePorEstatusToolStripMenuItem.Text = "Reporte Por Estatus";
            this.reportePorEstatusToolStripMenuItem.Click += new System.EventHandler(this.reportePorEstatusToolStripMenuItem_Click);
            // 
            // frmPantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 261);
            this.Controls.Add(this.menuStripPantallaP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPantallaP;
            this.MaximizeBox = false;
            this.Name = "frmPantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPantalla_Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPantalla_Principal_KeyDown);
            this.menuStripPantallaP.ResumeLayout(false);
            this.menuStripPantallaP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPantallaP;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEditarTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorEstatusToolStripMenuItem;
    }
}