using CRUD;
using System;
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
    public partial class frmPantalla_Principal : Form
    {
        public frmPantalla_Principal()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void frmPantalla_Principal_KeyDown(object sender, KeyEventArgs e)
        {/*esta condicion es para que cuando se precione la tecla de escape la
         pantalla principal se minimise*/
            if (e.KeyCode == Keys.Escape)
            {
                WindowState = FormWindowState.Minimized;
                TopMost = false;
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {//muestra el formulario para el CRUD de clientes
            frmCliente fr = new frmCliente();
            fr.Show(this);//esto hace que se muestre el formulario. Al tener "this" no permite que se oculte detras de la pantalla principal
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {//muestra el formulario para los equipos 
            frmEquipos fr = new frmEquipos();
            fr.Show(this);
        }

        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {//formulario para orden de trabajo
            frmOrden_Trabajo fr = new frmOrden_Trabajo();
            fr.Show(this);
        }

        private void buscarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {//formulario para el buscador de ordenes
            frmBuscarOrdenes fr = new frmBuscarOrdenes();
            fr.Show(this);
        }

        private void registrarEditarTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {//formulario para el CRUD de empleado
            frmRegistrar_Tecnico fr = new frmRegistrar_Tecnico();
            fr.Show(this);
        }

        private void crystalReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {//este codigo es para mostrar el reporte
            Operacion oper = new Operacion();//conexión a la base de datos
            DataSet ds = new DataSet();

            DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_con_diagnostico");
            //consulta a una vista creada en la base de datos
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "reporte_con_diagnostico";
            ds.WriteXml(@"C:\sistema\xml\Reporte Fixers\reporte_con_diagnostico.xml");//ubicación del xml del reporte
            frmReporteDiagnostico fr = new frmReporteDiagnostico("CrystalReportFixersDiag.rpt");
            fr.Show(this);
        }

        private void frmPantalla_Principal_Load(object sender, EventArgs e)
        {//este codigo es para que la ventana principal se ajuste a la pantalla
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {//este codigo hace que cuando se cierre la pantalla principal, se vuelva a mostrar el cuadro de login
            if (MessageBox.Show("Seguro que desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                frmGEquipos fr = new frmGEquipos();
                fr.Show();
            }
        }

        private void reportePorEstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacion oper = new Operacion();
            DataSet ds = new DataSet();

            DataTable dt = oper.ConsultaConResultado("SELECT * FROM reporte_estatus");
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "reporte_estatus";
            ds.WriteXml(@"C:\sistema\xml\Reporte Fixers\reporte_estatus.xml");
            frmReporteEstatus fr = new frmReporteEstatus("CrystalReportFixersEstado.rpt");
            fr.Show(this);
        }
    }
}
