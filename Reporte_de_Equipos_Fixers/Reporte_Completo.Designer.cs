namespace Reporte_de_Equipos_Fixers
{
    partial class frmReporteCompleto
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
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioBtnCliente = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.radioBtnTecnico = new System.Windows.Forms.RadioButton();
            this.radioBtnEstatus = new System.Windows.Forms.RadioButton();
            this.radioBtnEquipo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Location = new System.Drawing.Point(12, 63);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.Size = new System.Drawing.Size(760, 234);
            this.dataGridReporte.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(579, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radioBtnCliente
            // 
            this.radioBtnCliente.AutoSize = true;
            this.radioBtnCliente.Location = new System.Drawing.Point(12, 22);
            this.radioBtnCliente.Name = "radioBtnCliente";
            this.radioBtnCliente.Size = new System.Drawing.Size(57, 17);
            this.radioBtnCliente.TabIndex = 0;
            this.radioBtnCliente.TabStop = true;
            this.radioBtnCliente.Text = "Cliente";
            this.radioBtnCliente.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(364, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(660, 19);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Mostrar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // radioBtnTecnico
            // 
            this.radioBtnTecnico.AutoSize = true;
            this.radioBtnTecnico.Location = new System.Drawing.Point(75, 22);
            this.radioBtnTecnico.Name = "radioBtnTecnico";
            this.radioBtnTecnico.Size = new System.Drawing.Size(64, 17);
            this.radioBtnTecnico.TabIndex = 0;
            this.radioBtnTecnico.TabStop = true;
            this.radioBtnTecnico.Text = "Tecnico";
            this.radioBtnTecnico.UseVisualStyleBackColor = true;
            // 
            // radioBtnEstatus
            // 
            this.radioBtnEstatus.AutoSize = true;
            this.radioBtnEstatus.Location = new System.Drawing.Point(145, 22);
            this.radioBtnEstatus.Name = "radioBtnEstatus";
            this.radioBtnEstatus.Size = new System.Drawing.Size(60, 17);
            this.radioBtnEstatus.TabIndex = 0;
            this.radioBtnEstatus.TabStop = true;
            this.radioBtnEstatus.Text = "Estatus";
            this.radioBtnEstatus.UseVisualStyleBackColor = true;
            // 
            // radioBtnEquipo
            // 
            this.radioBtnEquipo.AutoSize = true;
            this.radioBtnEquipo.Location = new System.Drawing.Point(211, 22);
            this.radioBtnEquipo.Name = "radioBtnEquipo";
            this.radioBtnEquipo.Size = new System.Drawing.Size(58, 17);
            this.radioBtnEquipo.TabIndex = 0;
            this.radioBtnEquipo.TabStop = true;
            this.radioBtnEquipo.Text = "Equipo";
            this.radioBtnEquipo.UseVisualStyleBackColor = true;
            // 
            // frmReporteCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 346);
            this.Controls.Add(this.radioBtnEquipo);
            this.Controls.Add(this.radioBtnEstatus);
            this.Controls.Add(this.radioBtnTecnico);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.radioBtnCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReporteCompleto";
            this.Text = "Reporte Completo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioBtnCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.RadioButton radioBtnTecnico;
        private System.Windows.Forms.RadioButton radioBtnEstatus;
        private System.Windows.Forms.RadioButton radioBtnEquipo;
    }
}