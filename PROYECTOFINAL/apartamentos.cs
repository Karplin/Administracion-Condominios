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
    public partial class apartamentos : Form
    {

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        public apartamentos()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manzanas irmanzana = new manzanas();
            irmanzana.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edificios irficio = new edificios();
            irficio.Show();
            this.Hide();
        }

        private void apartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condomines irmines = new condomines();
            irmines.Show();
            this.Hide();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            general menu = new general();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void apartamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.apartamentos' table. You can move, or remove it, as needed.
            this.apartamentosTableAdapter.Fill(this.condominesDataSet.apartamentos);
            tabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            zcrudapartamento insertar = new zcrudapartamento();
            insertar.numero = textBox1.Text;
            insertar.edificio = int.Parse(textBox2.Text);
            insertar.insertar();
            limpio();
            tabla();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            zcrudapartamento borrar = new zcrudapartamento();
            borrar.numero = textBox1.Text;
            borrar.edificio = int.Parse(textBox2.Text);
            borrar.eliminar();
            tabla();
            limpio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zcrudapartamento actualizar = new zcrudapartamento();
            actualizar.numero = textBox1.Text;
            actualizar.edificio = int.Parse(textBox2.Text);
            actualizar.actuali();
            tabla();
            limpio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        //-------------------------------------------------------------------METODO PARA ACTUALIZAR LA TABLA CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
        public void tabla()
        {

            comando = new SqlCommand("Select * from apartamentos", cone);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        //-------------------------------------------------------------------METODO PARA LIMPIAR LOS CAMPOS CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
        public void limpio()
        {
            textBox1.Text = "";
            textBox2.Text = "";


        }


        //-------------------------------------------------------------------METODO PARA BUSCAR UN USUARIO-------------------------------------------------------------------------------
        public void busqueda()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM APARTAMENTOS WHERE numero = @numero", cone);
                comando.Parameters.AddWithValue("@numero", textBox3.Text);
                cone.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    textBox1.Text = registro["numero"].ToString();
                    textBox2.Text = registro["edificio"].ToString();


                }
                cone.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
