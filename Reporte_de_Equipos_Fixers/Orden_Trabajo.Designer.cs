namespace Reporte_de_Equipos_Fixers
{
    partial class frmOrden_Trabajo
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
            this.lblDatosOrdenTitulo = new System.Windows.Forms.Label();
            this.lblIDorden = new System.Windows.Forms.Label();
            this.lblIDEquipo = new System.Windows.Forms.Label();
            this.lblIDTecnico = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtIDorden = new System.Windows.Forms.TextBox();
            this.txtIDEquipo = new System.Windows.Forms.TextBox();
            this.txtIDTecnico = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dataGridOrdenT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosOrdenTitulo
            // 
            this.lblDatosOrdenTitulo.AutoSize = true;
            this.lblDatosOrdenTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosOrdenTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblDatosOrdenTitulo.Name = "lblDatosOrdenTitulo";
            this.lblDatosOrdenTitulo.Size = new System.Drawing.Size(146, 17);
            this.lblDatosOrdenTitulo.TabIndex = 0;
            this.lblDatosOrdenTitulo.Text = "Datos de La Orden";
            // 
            // lblIDorden
            // 
            this.lblIDorden.AutoSize = true;
            this.lblIDorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDorden.Location = new System.Drawing.Point(12, 25);
            this.lblIDorden.Name = "lblIDorden";
            this.lblIDorden.Size = new System.Drawing.Size(80, 13);
            this.lblIDorden.TabIndex = 1;
            this.lblIDorden.Text = "ID de La Orden";
            // 
            // lblIDEquipo
            // 
            this.lblIDEquipo.AutoSize = true;
            this.lblIDEquipo.Location = new System.Drawing.Point(12, 51);
            this.lblIDEquipo.Name = "lblIDEquipo";
            this.lblIDEquipo.Size = new System.Drawing.Size(71, 13);
            this.lblIDEquipo.TabIndex = 2;
            this.lblIDEquipo.Text = "ID del Equipo";
            // 
            // lblIDTecnico
            // 
            this.lblIDTecnico.AutoSize = true;
            this.lblIDTecnico.Location = new System.Drawing.Point(12, 77);
            this.lblIDTecnico.Name = "lblIDTecnico";
            this.lblIDTecnico.Size = new System.Drawing.Size(77, 13);
            this.lblIDTecnico.TabIndex = 3;
            this.lblIDTecnico.Text = "ID del Técnico";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(12, 103);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(70, 13);
            this.lblIDCliente.TabIndex = 4;
            this.lblIDCliente.Text = "ID del Cliente";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(12, 129);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 5;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtIDorden
            // 
            this.txtIDorden.Enabled = false;
            this.txtIDorden.Location = new System.Drawing.Point(98, 22);
            this.txtIDorden.Name = "txtIDorden";
            this.txtIDorden.Size = new System.Drawing.Size(34, 20);
            this.txtIDorden.TabIndex = 10;
            // 
            // txtIDEquipo
            // 
            this.txtIDEquipo.Location = new System.Drawing.Point(98, 48);
            this.txtIDEquipo.Name = "txtIDEquipo";
            this.txtIDEquipo.Size = new System.Drawing.Size(34, 20);
            this.txtIDEquipo.TabIndex = 1;
            // 
            // txtIDTecnico
            // 
            this.txtIDTecnico.Location = new System.Drawing.Point(98, 74);
            this.txtIDTecnico.Name = "txtIDTecnico";
            this.txtIDTecnico.Size = new System.Drawing.Size(34, 20);
            this.txtIDTecnico.TabIndex = 2;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(98, 100);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(34, 20);
            this.txtIDCliente.TabIndex = 3;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.ItemHeight = 13;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Abierto",
            "Cerrado"});
            this.cmbEstatus.Location = new System.Drawing.Point(97, 126);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(98, 21);
            this.cmbEstatus.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(10, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(91, 19);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.Green;
            this.btnActualizar.Location = new System.Drawing.Point(220, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(301, 19);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dataGridOrdenT
            // 
            this.dataGridOrdenT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenT.Location = new System.Drawing.Point(211, 26);
            this.dataGridOrdenT.Name = "dataGridOrdenT";
            this.dataGridOrdenT.Size = new System.Drawing.Size(367, 150);
            this.dataGridOrdenT.TabIndex = 15;
            this.dataGridOrdenT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenT_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDorden);
            this.groupBox1.Controls.Add(this.lblIDEquipo);
            this.groupBox1.Controls.Add(this.lblIDTecnico);
            this.groupBox1.Controls.Add(this.lblIDCliente);
            this.groupBox1.Controls.Add(this.lblEstatus);
            this.groupBox1.Controls.Add(this.txtIDorden);
            this.groupBox1.Controls.Add(this.cmbEstatus);
            this.groupBox1.Controls.Add(this.txtIDEquipo);
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.txtIDTecnico);
            this.groupBox1.Location = new System.Drawing.Point(5, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 156);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnVer);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Location = new System.Drawing.Point(5, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(436, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmOrden_Trabajo
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 271);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridOrdenT);
            this.Controls.Add(this.lblDatosOrdenTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmOrden_Trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orden de Trabajo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosOrdenTitulo;
        private System.Windows.Forms.Label lblIDorden;
        private System.Windows.Forms.Label lblIDEquipo;
        private System.Windows.Forms.Label lblIDTecnico;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtIDorden;
        private System.Windows.Forms.TextBox txtIDEquipo;
        private System.Windows.Forms.TextBox txtIDTecnico;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dataGridOrdenT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}