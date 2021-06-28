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
    public partial class manzanas : Form
    {

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;

        public manzanas()
        {
            InitializeComponent();
        }

        private void manzanas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.manzanas' table. You can move, or remove it, as needed.
            this.manzanasTableAdapter.Fill(this.condominesDataSet.manzanas);

            tabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condomines irmines = new condomines();
            irmines.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            zcrudmanzana insertar = new zcrudmanzana();
            insertar.nombre = textBox1.Text;
            insertar.insertar();
            limpio();
            tabla();

            abstracto hola = new zcrudmanzana();
        

           
        }

        //-------------------------------------------------------------------METODO PARA ACTUALIZAR LA TABLA CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
       public void tabla()
        {

            comando = new SqlCommand("Select * from manzanas", cone);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }
    

        //-------------------------------------------------------------------METODO PARA LIMPIAR LOS CAMPOS CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
        public void limpio()
        {
            textBox1.Text = "";

        }

        private void condominesDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zcrudmanzana borrar = new zcrudmanzana();
            borrar.nombre = textBox1.Text;
            borrar.eliminar();
            tabla();
            limpio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zcrudmanzana actualizar = new zcrudmanzana();
            actualizar.id = int.Parse(textBox3.Text);
            actualizar.nombre = textBox1.Text;
            actualizar.buscar = textBox2.Text;
            actualizar.actuali();
            tabla();
            limpio();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            busqueda();
            tabla();
        }

        //-------------------------------------------------------------------METODO PARA BUSCAR UN USUARIO-------------------------------------------------------------------------------
        public void busqueda()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM MANZANAS WHERE nombre = @nombre", cone);
                comando.Parameters.AddWithValue("@nombre", textBox2.Text);
                cone.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    textBox3.Text = registro["id"].ToString();
                    textBox1.Text = registro["Nombre"].ToString();


                }
                cone.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
