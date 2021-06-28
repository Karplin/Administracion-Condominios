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
    public partial class consultamines : Form
    {
        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        public consultamines()
        {
            InitializeComponent();
        }

        private void consultamines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.condominesx' table. You can move, or remove it, as needed.
            this.condominesxTableAdapter.Fill(this.condominesDataSet.condominesx);

        }

        private void cManzanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultazana consultar1 = new consultazana();
            consultar1.Show();
            this.Hide();
        }

        private void cEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaedificio consultar2 = new consultaedificio();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

            if (indice == 0)
            {
                label3.Visible = true;
                label3.Location = new Point (385, 260);
                label4.Visible = false;
                label5.Visible = false;

                textBox1.Visible = true;
                textBox1.Location = new Point(317,280);
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            else if (indice == 1)
            {

                label3.Visible = false;
                label4.Visible = true;
                label4.Location = new Point(385, 260);
                label5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox2.Location = new Point(317, 280);
                textBox3.Visible = false;

            }
            else if (indice == 2)
            {


                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label5.Location = new Point(385, 260);

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox3.Location = new Point(317, 280);

            }



        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM condominesx where cedula like ('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM condominesx where correo like ('" + textBox2.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cone.Open();

            SqlCommand cmd = cone.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM condominesx where edificio like ('" + textBox3.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cone.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            zreportemines reporte = new zreportemines();
            reporte.Show();
        }
    }
}
