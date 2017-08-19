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

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmRegistrar_Empleado : Form
    {
        public frmRegistrar_Empleado()
        {
            InitializeComponent();
        }

        private void btnRGuardar_Click(object sender, EventArgs e)
        {
            try//manejador de errores
            {
                Operacion oper = new Operacion();//conexión a la base de datos
                oper.ConsultaSinResultado("INSERT INTO tecnico (nombre, telefono) VALUES ('" + txtRNombreTec.Text + "', '" + txtRTelefonoTec.Text + "')");
                //esta consulta agrega un nuevo empleado a la tabla técnico en la base de datos
            }
            catch (Exception ex)
            {//muetsra un mensaje de error en caso de que suceda
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();//conexion a la base de datos
            //estos codigos son para poner los datos de un técnico en su respectivo textBox y así poder actualizarlos
            DataTable dtTecnico = oper.ConsultaConResultado("SELECT * FROM tecnico WHERE id_tecnico= '" + txtIDRTec.Text + "'");
            foreach (DataRow dr in dtTecnico.Rows)
            {
                string id_tecnico, nombre, telefono;
                id_tecnico = dr["id_tecnico"].ToString();
                nombre = dr["nombre"].ToString();
                telefono = dr["telefono"].ToString();
                txtIDRTec.Text = id_tecnico;
                txtRNombreTec.Text = nombre;
                txtRTelefonoTec.Text = telefono;
            }
        }

        private void btnRActualizar_Click(object sender, EventArgs e)
        {//para actualizar los técnicos
            try//manejador de errores
            {
                Operacion oper = new Operacion();
                oper.ConsultaSinResultado("UPDATE tecnico SET nombre = '" + txtRNombreTec.Text + "', telefono = '" + txtRTelefonoTec.Text + "'");
                //esta consulta actualiza el técnico que elijamos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRBorrar_Click(object sender, EventArgs e)
        {//para borrar los técnicos
            try
            {
                Operacion oper = new Operacion();
                oper.ConsultaSinResultado("DELETE FROM tecnico WHERE id_tecnico = '"+ txtIDRTec.Text +"'");
                //esta es la consulta para borrar un técnico filtrado por id

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
