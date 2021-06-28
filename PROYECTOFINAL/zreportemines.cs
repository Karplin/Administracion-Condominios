using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Web.UI;


namespace PROYECTOFINAL
{
 
    public partial class zreportemines : Form
    {   
        
        public zreportemines()
        {
            InitializeComponent();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {     
         reportecondomines1.Load(@"C:\Users\Leonal\source\repos\PROYECTOFINAL\reportecondomines.rpt");
         crystalReportViewer1.ReportSource = reportecondomines1;
         crystalReportViewer1.Refresh();

        }

        private void zreportemines_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportecondominesx2 reporte = new reportecondominesx2();
            reporte.SetParameterValue("@MINES1", textBox1.Text);
            crystalReportViewer2.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;
            crystalReportViewer3.Visible = false;
            crystalReportViewer4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportecondominesx3 reporte = new reportecondominesx3();
            reporte.SetParameterValue("@MINES2", textBox2.Text);
            crystalReportViewer3.ReportSource = reporte;

            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
            crystalReportViewer3.Visible = true;
            crystalReportViewer4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportecondominesx4 reporte = new reportecondominesx4();
            reporte.SetParameterValue("@MINES3", textBox3.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
