using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class consultapago : Form
    {
        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;

        public consultapago()
        {
            InitializeComponent();
        }

        private void cManzanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultamines consultar1 = new consultamines();
            consultar1.Show();
            this.Hide();
        }

        private void cManzanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultazana consultar2 = new consultazana();
            consultar2.Show();
            this.Hide();
        }

        private void cEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaedificio consultar3 = new consultaedificio();
            consultar3.Show();
            this.Hide();
        }

        private void cReclamacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaciones consultar4 = new consultaciones();
            consultar4.Show();
            this.Hide();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            general menux = new general();
            menux.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void consultapago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet1.pagos' table. You can move, or remove it, as needed.
            this.pagosTableAdapter.Fill(this.condominesDataSet1.pagos);


       
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zreportepago reporte = new zreportepago();
            reporte.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

 

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaSQL = "SELECT * FROM PAGOS WHERE FECHA BETWEEN  '"+dateTimePicker1.Text + "'AND'" + dateTimePicker2.Text+"'";

            SqlDataAdapter adaptador = new SqlDataAdapter(cadenaSQL, cone);
            DataSet DS = new DataSet();
            adaptador.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
