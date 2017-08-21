using System;
using CRUD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmGEquipos : Form
    {
        Operacion oper = new Operacion();
        public frmGEquipos()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*estas condiciones son con fin de muestra ya que 
         todavia no se ha podido implementar el inicio de secion a travez de la base de datos*/
            if (txtUsuario.Text == "daniel" || txtUsuario.Text == "belmarin") //condiciona el texbox de usuario para saber cuando se cumpla uno de los dos requisitos
            {
                if (txtPass.Text == "1234" || txtPass.Text == "12345")//condiciona el texbox de usuario para saber cuando se cumpla uno de los dos requisitos
                {//una vez cumplidos dos de los cuatro requisitos se abrirá la ventana siguiente
                    frmPantalla_Principal frpp = new frmPantalla_Principal();
                    frpp.Show();
                    this.Hide();
                }
                else
                {//mensaje para cuando la contraseña es incorrecta
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }

            else
            {//mensaje para cuando el usuario es incorrecto
                MessageBox.Show("El usuario es incorrecto");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {/*abre la ventana para registrar usuarios. Esta ventana se usará mejor cuando 
         alla interacción de login entre la base de datos y el programa*/
            frmRegistro_Usuario fr = new frmRegistro_Usuario();
            fr.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {//botón para cerrar
            this.Close();
        }
    }
}
