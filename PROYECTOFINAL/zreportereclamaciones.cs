using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class zreportereclamaciones : Form
    {
        public zreportereclamaciones()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            reportereclamaciones1.Load(@"C:\Users\Leonal\source\repos\PROYECTOFINAL\reportereclamaciones.rpt");
            crystalReportViewer1.ReportSource = reportereclamaciones1;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportereclamaciones2 reporte = new reportereclamaciones2();
            reporte.SetParameterValue("@RECLAMACION", textBox1.Text);
            crystalReportViewer2.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
