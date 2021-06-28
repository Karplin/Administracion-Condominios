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
    public partial class consultaedificio : Form
    {

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        public consultaedificio()
        {
            InitializeComponent();
        }

        private void cManzanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultamines consultar1 = new consultamines();
            consultar1.Show();
            this.Hide();
        }

        private void cEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultazana consultar2 = new consultazana();
            consultar2.Show();
            this.Hide();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapago consultar3 = new consultapago();
            consultar3.Show();
            this.Hide();
        }

        private void reclamacionesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void consultaedificio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.edificios' table. You can move, or remove it, as needed.
            this.edificiosTableAdapter.Fill(this.condominesDataSet.edificios);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

            if (indice == 0)
            {
                label2.Visible = true;
                label2.Location = new Point(360, 270);
                label3.Visible = false;
                label4.Visible = false;

                textBox1.Visible = true;
                textBox1.Location = new Point(307, 290);
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            else if (indice == 1)
            {

                label2.Visible = false;
                label3.Visible = true;
                label3.Location = new Point(360, 270);
                label4.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox2.Location = new Point(307, 290);
                textBox3.Visible = false;

            }
            else if (indice == 2)
            {


                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label4.Location = new Point(360, 270);

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox3.Location = new Point(307, 290);

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM edificios where numero like ('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM edificios where manzana like ('" + textBox2.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM edificios where cant_aptos like ('" + textBox3.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zreportedificio reporte = new zreportedificio();
            reporte.Show();
        }
    }
}
