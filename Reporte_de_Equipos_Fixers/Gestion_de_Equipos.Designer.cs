namespace Reporte_de_Equipos_Fixers
{
    partial class frmGEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGEquipos));
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            resources.ApplyResources(this.btnCrear, "btnCrear");
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.lblPass.Name = "lblPass";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // frmGEquipos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGEquipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
    }
}

