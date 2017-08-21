namespace Reporte_de_Equipos_Fixers
{
    partial class frmEquipos
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
            this.lblEquipos = new System.Windows.Forms.Label();
            this.lblDEquipo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblServiceTag = new System.Windows.Forms.Label();
            this.lblAccesorios = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.txtIDEquipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtServiceTag = new System.Windows.Forms.TextBox();
            this.txtAccesorios = new System.Windows.Forms.TextBox();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dataGridEquipos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipos.Location = new System.Drawing.Point(12, 9);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(167, 17);
            this.lblEquipos.TabIndex = 0;
            this.lblEquipos.Text = "Datos de Los Equipos";
            // 
            // lblDEquipo
            // 
            this.lblDEquipo.AutoSize = true;
            this.lblDEquipo.Location = new System.Drawing.Point(6, 25);
            this.lblDEquipo.Name = "lblDEquipo";
            this.lblDEquipo.Size = new System.Drawing.Size(18, 13);
            this.lblDEquipo.TabIndex = 1;
            this.lblDEquipo.Text = "ID";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(6, 51);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(83, 13);
            this.lblmarca.TabIndex = 2;
            this.lblmarca.Text = "Marca y Modelo";
            // 
            // lblServiceTag
            // 
            this.lblServiceTag.AutoSize = true;
            this.lblServiceTag.Location = new System.Drawing.Point(6, 77);
            this.lblServiceTag.Name = "lblServiceTag";
            this.lblServiceTag.Size = new System.Drawing.Size(65, 13);
            this.lblServiceTag.TabIndex = 3;
            this.lblServiceTag.Text = "Service Tag";
            // 
            // lblAccesorios
            // 
            this.lblAccesorios.AutoSize = true;
            this.lblAccesorios.Location = new System.Drawing.Point(6, 103);
            this.lblAccesorios.Name = "lblAccesorios";
            this.lblAccesorios.Size = new System.Drawing.Size(59, 13);
            this.lblAccesorios.TabIndex = 4;
            this.lblAccesorios.Text = "Accesorios";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(291, 25);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico.TabIndex = 5;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Location = new System.Drawing.Point(291, 93);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Size = new System.Drawing.Size(48, 13);
            this.lblSolucion.TabIndex = 6;
            this.lblSolucion.Text = "Solución";
            // 
            // txtIDEquipo
            // 
            this.txtIDEquipo.Enabled = false;
            this.txtIDEquipo.Location = new System.Drawing.Point(95, 22);
            this.txtIDEquipo.Name = "txtIDEquipo";
            this.txtIDEquipo.Size = new System.Drawing.Size(32, 20);
            this.txtIDEquipo.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(129, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // txtServiceTag
            // 
            this.txtServiceTag.Location = new System.Drawing.Point(95, 74);
            this.txtServiceTag.Name = "txtServiceTag";
            this.txtServiceTag.Size = new System.Drawing.Size(119, 20);
            this.txtServiceTag.TabIndex = 2;
            // 
            // txtAccesorios
            // 
            this.txtAccesorios.Location = new System.Drawing.Point(95, 100);
            this.txtAccesorios.Name = "txtAccesorios";
            this.txtAccesorios.Size = new System.Drawing.Size(129, 20);
            this.txtAccesorios.TabIndex = 3;
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(380, 90);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(178, 58);
            this.txtSolucion.TabIndex = 5;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(380, 22);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(217, 62);
            this.txtDiagnostico.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(87, 13);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(210, 13);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(291, 13);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dataGridEquipos
            // 
            this.dataGridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipos.Location = new System.Drawing.Point(15, 199);
            this.dataGridEquipos.Name = "dataGridEquipos";
            this.dataGridEquipos.Size = new System.Drawing.Size(647, 176);
            this.dataGridEquipos.TabIndex = 17;
            this.dataGridEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEquipos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDEquipo);
            this.groupBox1.Controls.Add(this.lblmarca);
            this.groupBox1.Controls.Add(this.lblServiceTag);
            this.groupBox1.Controls.Add(this.lblAccesorios);
            this.groupBox1.Controls.Add(this.lblDiagnostico);
            this.groupBox1.Controls.Add(this.lblSolucion);
            this.groupBox1.Controls.Add(this.txtDiagnostico);
            this.groupBox1.Controls.Add(this.txtIDEquipo);
            this.groupBox1.Controls.Add(this.txtSolucion);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtAccesorios);
            this.groupBox1.Controls.Add(this.txtServiceTag);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 164);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnVisualizar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Location = new System.Drawing.Point(26, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 45);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(459, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEquipos
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 431);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridEquipos);
            this.Controls.Add(this.lblEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipos";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipos;
        private System.Windows.Forms.Label lblDEquipo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblServiceTag;
        private System.Windows.Forms.Label lblAccesorios;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.TextBox txtIDEquipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtServiceTag;
        private System.Windows.Forms.TextBox txtAccesorios;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dataGridEquipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}