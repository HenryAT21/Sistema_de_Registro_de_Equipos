using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReporteCliente : Form
    {
        public ReporteCliente(string nombre_reporte)
        {
            InitializeComponent();
            
            //Clase de Crystal Report para manejar los datos en el crystalReportViewer
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
