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
    public partial class zreportedificio : Form
    {
        public zreportedificio()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            reportedificio1.Load(@"C:\Users\Leonal\source\repos\PROYECTOFINAL\reportedificio.rpt");
            crystalReportViewer1.ReportSource = reportedificio1;
            crystalReportViewer1.Refresh();
        }

        private void zreportedificio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportedificio2x reporte = new reportedificio2x();
            reporte.SetParameterValue("@EDIFICIO1", textBox1.Text);
            crystalReportViewer2.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportedificio3x reporte = new reportedificio3x();
            reporte.SetParameterValue("@EDIFICIO2", textBox2.Text);
            crystalReportViewer3.ReportSource = reporte;


            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = true;
            crystalReportViewer4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportedificio4 reporte = new reportedificio4();
            reporte.SetParameterValue("@EDIFICIO3", textBox3.Text);
            crystalReportViewer4.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
