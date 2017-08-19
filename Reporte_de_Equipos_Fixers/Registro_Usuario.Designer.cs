namespace Reporte_de_Equipos_Fixers
{
    partial class frmRegistro_Usuario
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
            this.txtRUsuario = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.lblRPass = new System.Windows.Forms.Label();
            this.lblRUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.btnRCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRUsuario
            // 
            this.txtRUsuario.Location = new System.Drawing.Point(79, 48);
            this.txtRUsuario.Name = "txtRUsuario";
            this.txtRUsuario.Size = new System.Drawing.Size(126, 20);
            this.txtRUsuario.TabIndex = 1;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(79, 90);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.PasswordChar = '•';
            this.txtRPass.Size = new System.Drawing.Size(126, 20);
            this.txtRPass.TabIndex = 2;
            // 
            // lblRPass
            // 
            this.lblRPass.AutoSize = true;
            this.lblRPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRPass.Location = new System.Drawing.Point(12, 93);
            this.lblRPass.Name = "lblRPass";
            this.lblRPass.Size = new System.Drawing.Size(61, 13);
            this.lblRPass.TabIndex = 11;
            this.lblRPass.Text = "Contraseña";
            // 
            // lblRUsuario
            // 
            this.lblRUsuario.AutoSize = true;
            this.lblRUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRUsuario.Location = new System.Drawing.Point(12, 51);
            this.lblRUsuario.Name = "lblRUsuario";
            this.lblRUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblRUsuario.TabIndex = 10;
            this.lblRUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Crear Usuario";
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.Location = new System.Drawing.Point(12, 135);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(108, 13);
            this.lblConfPass.TabIndex = 15;
            this.lblConfPass.Text = "Confirmar Contraseña";
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(126, 132);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '•';
            this.txtConfPass.Size = new System.Drawing.Size(126, 20);
            this.txtConfPass.TabIndex = 3;
            // 
            // btnRCrear
            // 
            this.btnRCrear.Location = new System.Drawing.Point(15, 213);
            this.btnRCrear.Name = "btnRCrear";
            this.btnRCrear.Size = new System.Drawing.Size(75, 23);
            this.btnRCrear.TabIndex = 4;
            this.btnRCrear.Text = "Crear";
            this.btnRCrear.UseVisualStyleBackColor = true;
            this.btnRCrear.Click += new System.EventHandler(this.btnRCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(111, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(206, 213);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(124, 23);
            this.btnRegistrarEmpleado.TabIndex = 6;
            this.btnRegistrarEmpleado.Text = "Registrar Empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);
            // 
            // frmRegistro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 269);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRCrear);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.lblConfPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRUsuario);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.lblRPass);
            this.Controls.Add(this.lblRUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRegistro_Usuario";
            this.Text = "Registro de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRUsuario;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.Label lblRPass;
        private System.Windows.Forms.Label lblRUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Button btnRCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
    }
}