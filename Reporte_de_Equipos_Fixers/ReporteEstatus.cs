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
    public partial class frmReporteEstatus : Form
    {
        public frmReporteEstatus(string nombre_reporte_est)
        {
            InitializeComponent();
            TopMost = true;

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte_est);
            crystalReportEstado.ReportSource = cryRpt;
            crystalReportEstado.Refresh();
        }
    }
}
