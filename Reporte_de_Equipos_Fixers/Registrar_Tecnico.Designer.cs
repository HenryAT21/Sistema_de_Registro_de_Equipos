namespace Reporte_de_Equipos_Fixers
{
    partial class frmRegistrar_Tecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar_Tecnico));
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.labelRNombreTec = new System.Windows.Forms.Label();
            this.lblRTelefono = new System.Windows.Forms.Label();
            this.txtRNombreTec = new System.Windows.Forms.TextBox();
            this.txtRTelefonoTec = new System.Windows.Forms.TextBox();
            this.btnRGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnRActualizar = new System.Windows.Forms.Button();
            this.btnRBorrar = new System.Windows.Forms.Button();
            this.lblIDRTec = new System.Windows.Forms.Label();
            this.txtIDRTec = new System.Windows.Forms.TextBox();
            this.dataGridTecnico = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTecnico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.AutoSize = true;
            this.lblTituloDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDatos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new System.Drawing.Size(139, 17);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "Datos del Técnico";
            // 
            // labelRNombreTec
            // 
            this.labelRNombreTec.AutoSize = true;
            this.labelRNombreTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRNombreTec.Location = new System.Drawing.Point(6, 42);
            this.labelRNombreTec.Name = "labelRNombreTec";
            this.labelRNombreTec.Size = new System.Drawing.Size(44, 13);
            this.labelRNombreTec.TabIndex = 1;
            this.labelRNombreTec.Text = "Nombre";
            // 
            // lblRTelefono
            // 
            this.lblRTelefono.AutoSize = true;
            this.lblRTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTelefono.Location = new System.Drawing.Point(6, 69);
            this.lblRTelefono.Name = "lblRTelefono";
            this.lblRTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblRTelefono.TabIndex = 2;
            this.lblRTelefono.Text = "Teléfono";
            // 
            // txtRNombreTec
            // 
            this.txtRNombreTec.Location = new System.Drawing.Point(61, 39);
            this.txtRNombreTec.Name = "txtRNombreTec";
            this.txtRNombreTec.Size = new System.Drawing.Size(129, 20);
            this.txtRNombreTec.TabIndex = 1;
            // 
            // txtRTelefonoTec
            // 
            this.txtRTelefonoTec.Location = new System.Drawing.Point(61, 66);
            this.txtRTelefonoTec.Name = "txtRTelefonoTec";
            this.txtRTelefonoTec.Size = new System.Drawing.Size(100, 20);
            this.txtRTelefonoTec.TabIndex = 2;
            // 
            // btnRGuardar
            // 
            this.btnRGuardar.Location = new System.Drawing.Point(6, 19);
            this.btnRGuardar.Name = "btnRGuardar";
            this.btnRGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnRGuardar.TabIndex = 3;
            this.btnRGuardar.Text = "Guardar";
            this.btnRGuardar.UseVisualStyleBackColor = true;
            this.btnRGuardar.Click += new System.EventHandler(this.btnRGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(87, 19);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnRActualizar
            // 
            this.btnRActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRActualizar.Location = new System.Drawing.Point(168, 19);
            this.btnRActualizar.Name = "btnRActualizar";
            this.btnRActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnRActualizar.TabIndex = 5;
            this.btnRActualizar.Text = "Actualizar";
            this.btnRActualizar.UseVisualStyleBackColor = true;
            this.btnRActualizar.Click += new System.EventHandler(this.btnRActualizar_Click);
            // 
            // btnRBorrar
            // 
            this.btnRBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnRBorrar.Location = new System.Drawing.Point(249, 19);
            this.btnRBorrar.Name = "btnRBorrar";
            this.btnRBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnRBorrar.TabIndex = 6;
            this.btnRBorrar.Text = "Borrar";
            this.btnRBorrar.UseVisualStyleBackColor = true;
            this.btnRBorrar.Click += new System.EventHandler(this.btnRBorrar_Click);
            // 
            // lblIDRTec
            // 
            this.lblIDRTec.AutoSize = true;
            this.lblIDRTec.Enabled = false;
            this.lblIDRTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDRTec.Location = new System.Drawing.Point(6, 16);
            this.lblIDRTec.Name = "lblIDRTec";
            this.lblIDRTec.Size = new System.Drawing.Size(18, 13);
            this.lblIDRTec.TabIndex = 9;
            this.lblIDRTec.Text = "ID";
            // 
            // txtIDRTec
            // 
            this.txtIDRTec.Enabled = false;
            this.txtIDRTec.Location = new System.Drawing.Point(61, 13);
            this.txtIDRTec.Name = "txtIDRTec";
            this.txtIDRTec.Size = new System.Drawing.Size(35, 20);
            this.txtIDRTec.TabIndex = 8;
            // 
            // dataGridTecnico
            // 
            this.dataGridTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTecnico.Location = new System.Drawing.Point(12, 135);
            this.dataGridTecnico.Name = "dataGridTecnico";
            this.dataGridTecnico.Size = new System.Drawing.Size(337, 133);
            this.dataGridTecnico.TabIndex = 10;
            this.dataGridTecnico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTecnico_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDRTec);
            this.groupBox1.Controls.Add(this.labelRNombreTec);
            this.groupBox1.Controls.Add(this.txtIDRTec);
            this.groupBox1.Controls.Add(this.lblRTelefono);
            this.groupBox1.Controls.Add(this.txtRNombreTec);
            this.groupBox1.Controls.Add(this.txtRTelefonoTec);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnRGuardar);
            this.groupBox2.Controls.Add(this.btnVer);
            this.groupBox2.Controls.Add(this.btnRActualizar);
            this.groupBox2.Controls.Add(this.btnRBorrar);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(125, 51);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistrar_Tecnico
            // 
            this.AcceptButton = this.btnRGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTecnico);
            this.Controls.Add(this.lblTituloDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRegistrar_Tecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Tecnico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTecnico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label labelRNombreTec;
        private System.Windows.Forms.Label lblRTelefono;
        private System.Windows.Forms.TextBox txtRNombreTec;
        private System.Windows.Forms.TextBox txtRTelefonoTec;
        private System.Windows.Forms.Button btnRGuardar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnRActualizar;
        private System.Windows.Forms.Button btnRBorrar;
        private System.Windows.Forms.Label lblIDRTec;
        private System.Windows.Forms.TextBox txtIDRTec;
        private System.Windows.Forms.DataGridView dataGridTecnico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}