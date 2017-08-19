using CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmTrabajos : Form
    {
        public frmTrabajos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();

            try//manejador de errores
            {
                oper.ConsultaSinResultado("INSERT INTO cliente (nombre_apellido, telefono, email) VALUES ('" + txtNombreCliente.Text + "', '" + txtTelefono.Text + "', '" + txtEmail.Text + "')");
                //con esta consulta se insertarán los datos del cliente
                oper.ConsultaSinResultado("INSERT INTO equipos (marca_modelo, service_tag, accesorios, problema, solucion) VALUES ('" + txtMarcaModelo.Text + "', '"+ txtST.Text +"','" + txtAccesorios.Text + "', '" + txtProblema.Text + "', '" + txtSolucion.Text + "')");
                //con esta consulta se insertarán los datos del equipo del cliente
                oper.ConsultaSinResultado("INSERT INTO orden_trabajo (service_tag, estatus) VALUES ('"+ txtST.Text +"', '"+ cmbEstatus.Text +"')");
                //con esta consulta se insertarán datos de la orden de trabajo
                oper.ConsultaSinResultado("UPDATE orden_trabajo SET fk_id_equipo = (SELECT e.id_equipo FROM equipos e WHERE e.service_tag = '"+ txtST.Text +"'), fk_id_tecnico = (SELECT t.id_tecnico FROM tecnico t WHERE t.nombre = '"+ txtNombreTecnico.Text +"'), fk_id_cliente = (SELECT c.id_cliente FROM cliente c WHERE c.nombre_apellido = '"+ txtNombreCliente.Text +"') WHERE orden_trabajo.service_tag = '"+ txtST.Text +"'");
                //y este UPDATE es para que automaticamente se actualicen las llaves foraneas de la tabla orden_trabajo
            }
            catch (Exception error)//manejador de errores
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {//abre la ventana para ver el reporte completo
            frmReporteCompleto fr = new frmReporteCompleto();
            fr.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();//conexión a la base de datos
            //estos códigos son para visualizar el estatus de una orden a partir de su service_tag y así actualizar su estado de abierto a cerrado y biseversa
            DataTable dtTrabajo = oper.ConsultaConResultado("SELECT orden_trabajo.estatus FROM orden_trabajo WHERE service_tag = '"+ txtST.Text +"'");
            foreach (DataRow dr in dtTrabajo.Rows)
            {
                string estatus;
                estatus = dr["estatus"].ToString();
                cmbEstatus.Text = estatus;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try//manejador de errores
            {
                Operacion oper = new Operacion();//conexión a la base de datos
                oper.ConsultaSinResultado("UPDATE orden_trabajo SET estatus = '" + cmbEstatus.Text + "' WHERE service_tag = '" + txtST.Text + "'");
                //esta es la consulta para actualizar el estatus
            }
            catch (Exception ex)//manejador de errores
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //todavia sin implementar
        }
    }
}
