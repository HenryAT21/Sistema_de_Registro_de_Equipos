using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CRUD;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmReporteCompleto : Form
    {
        public frmReporteCompleto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion(); //la conexion a la base de datos

            if (txtBuscar.Text.Length == 0)
            {
                //esta condicion sirve para que cuando el txtBuscar este vacio muestre el reporte completo en el dataGridView
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM reporte_completo ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnCliente.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de cliente este chequeado, la busqueda se filtrara por nombre_apellido
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM reporte_completo WHERE nombre_apellido='" + txtBuscar.Text.Trim() + "' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnTecnico.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de tecnico este chequeado, la busqueda se filtrara por nombre del tecnico
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM reporte_completo WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnEstatus.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de estatus este chequeado, la busqueda se filtrara por el estado de la orden de trabajo
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM reporte_completo WHERE estatus like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnEquipo.Checked == true)
            {
                //esta condicion es para cuando el boton radioButton de equipo este chequeado, la busqueda se filtrara por marca y modelo del equipo
                DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM reporte_completo WHERE marca_modelo like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();

            if (radioBtnTecnico.Checked == true)
            {/*esta condicion sirve para que cuando el radioButton de nombre este chequeado, 
                la lista de empleados se vaya cambiando en tiempo real dependiendo la letra que se ponga*/
                DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_completo WHERE nombre like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnCliente.Checked == true)
            {//igual que la primera condicion
                DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_completo WHERE nombre_apellido like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnEstatus.Checked == true)
            {//igual que la segunda condicion
                DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_completo WHERE estatus like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }

            if (radioBtnEquipo.Checked == true)
            {//igual que la tercera condicion
                DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_completo WHERE marca_modelo like '%" + txtBuscar.Text.Trim() + "%' ");
                dataGridReporte.DataSource = dt;
                return;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try //manejador de errores
            {
                Operacion oper = new Operacion();
                DataSet ds = new DataSet();
                //para mostrar el reporte de los empleados en el crystalReportViewer
                DataTable dt_cliente = oper.ConsultaConResultado("SELECT * FROM REPORTE_COMPLETO");//esta es una consulta a una vista creada en la base de datos
                ds.Tables.Add(dt_cliente);
                ds.Tables[0].TableName = "REPORTE_COMPLETO";

                ds.WriteXml(@"C:\sistema\xml\Reporte Fixers\REPORTE_COMPLETO.xml");
                ReporteCliente fr = new ReporteCliente("CrystalReportFixers.rpt");//al abrir el formulario ReporteCliente se cargará con lo que esta indicado en parentesis que este caso es CrystalReportFixers.rpt
                fr.Show();
            }
            catch (Exception error)
            {
                //para mostrar un mensaje de error en caso de que suceda
                MessageBox.Show(error.Message);
            }
        }
    }
}
