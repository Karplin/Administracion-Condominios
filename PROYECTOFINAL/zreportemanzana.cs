using System;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class zreportemanzana : Form
    {
        public zreportemanzana()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            reportemanzana1.Load(@"C:\Users\Leonal\source\repos\PROYECTOFINAL\reportemanzana.rpt");
            crystalReportViewer1.ReportSource = reportemanzana1;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void zreportemanzana_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportemanzana reporte = new reportemanzana();
            reporte.SetParameterValue("@REGISTRO",textBox1.Text);
            crystalReportViewer1.ReportSource= reporte;
            crystalReportViewer1.Visible = true;
            crystalReportViewer2.Visible = false;
        }

        private void crystalReportViewer2_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}