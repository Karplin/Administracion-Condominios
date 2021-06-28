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
    public partial class edificios : Form
    {


        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;

        public edificios()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condomines irmines = new condomines();
            irmines.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manzanas irzana = new manzanas();
            irzana.Show();
            this.Hide();
        }

        private void apartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartamentos irmento = new apartamentos();
            irmento.Show();
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

        private void edificios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.edificios' table. You can move, or remove it, as needed.
            this.edificiosTableAdapter.Fill(this.condominesDataSet.edificios);
            tabla();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zcrudedificio insertar = new zcrudedificio();
            insertar.numero = int.Parse(textBox1.Text);
            insertar.cant_pisos = textBox2.Text;
            insertar.cant_aptos = textBox3.Text;
            insertar.manzana = textBox4.Text;
    
            insertar.guardar();
            limpio();
            tabla();
        }


        //-------------------------------------------------------------------METODO PARA ACTUALIZAR LA TABLA CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
        public void tabla()
        {

            comando = new SqlCommand("Select * from edificios", cone);
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
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zcrudedificio borrar = new zcrudedificio();
            borrar.numero = int.Parse(textBox1.Text);
            borrar.cant_pisos = textBox2.Text;
            borrar.cant_aptos = textBox3.Text;
            borrar.manzana = textBox4.Text;
            borrar.borrar();
            tabla();
            limpio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zcrudedificio actualizar = new zcrudedificio();
            actualizar.numero = int.Parse(textBox1.Text);
            actualizar.cant_pisos= textBox2.Text;
            actualizar.cant_aptos = textBox3.Text;
            actualizar.manzana = textBox4.Text;
            actualizar.editar();
            tabla();
            limpio();
        }



        //-------------------------------------------------------------------METODO PARA BUSCAR UN USUARIO-------------------------------------------------------------------------------
        public void busqueda()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM EDIFICIOS WHERE numero = @numero", cone);
                comando.Parameters.AddWithValue("@numero", textBox5.Text);
                cone.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    textBox1.Text = registro["numero"].ToString();
                    textBox2.Text = registro["cant_pisos"].ToString();
                    textBox3.Text = registro["cant_aptos"].ToString();
                    textBox4.Text = registro["manzana"].ToString();


                }
                cone.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            busqueda();
        }
    }
}
