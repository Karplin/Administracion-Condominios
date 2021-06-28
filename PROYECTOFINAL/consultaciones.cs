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
    public partial class consultaciones : Form
    {

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;

        public consultaciones()
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
            consultapago consultar4 = new consultapago();
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

        private void consultaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet1.reclamaciones' table. You can move, or remove it, as needed.
            this.reclamacionesTableAdapter.Fill(this.condominesDataSet1.reclamaciones);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM reclamaciones where edificio like ('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zreportereclamaciones reporte = new zreportereclamaciones();
            reporte.Show();
        }
    }
}
