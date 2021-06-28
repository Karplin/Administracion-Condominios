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
    public partial class zreportepago : Form
    {
        public zreportepago()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            reportepago1.Load(@"C:\Users\Leonal\source\repos\PROYECTOFINAL\reportepago.rpt");
            crystalReportViewer1.ReportSource = reportepago1;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportepago2 reporte = new reportepago2();

            reporte.SetParameterValue("@FECHAINI", dateTimePicker1.Text);
            reporte.SetParameterValue("@FECHAFI", dateTimePicker2.Text);
            crystalReportViewer2.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;
        }

        private void zreportepago_Load(object sender, EventArgs e)
        {

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
    }
}
