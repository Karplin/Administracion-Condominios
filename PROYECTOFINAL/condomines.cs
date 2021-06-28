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
    public partial class condomines : Form
    {
        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        public condomines()
        {
            InitializeComponent();
        }

        private void condomines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condominesDataSet.condominesx' table. You can move, or remove it, as needed.
            this.condominesxTableAdapter.Fill(this.condominesDataSet.condominesx);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zcrudcondomines borrar = new zcrudcondomines();
            borrar.cedula = textBox1.Text;
            borrar.nombre = textBox2.Text;
            borrar.correo = textBox3.Text;
            borrar.telefono = textBox4.Text;
            borrar.manzana = textBox5.Text;
            borrar.edificio = int.Parse(textBox6.Text);
            borrar.apto = textBox7.Text;
            borrar.eliminar();
            tabla();
            limpio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zcrudcondomines actualizar = new zcrudcondomines();
            actualizar.cedula = textBox1.Text;
            actualizar.nombre = textBox2.Text;
            actualizar.correo = textBox3.Text;
            actualizar.telefono = textBox4.Text;
            actualizar.manzana = textBox5.Text;
            actualizar.edificio = int.Parse(textBox6.Text);
            actualizar.apto = textBox7.Text;
            actualizar.actuali();
            tabla();
            limpio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zcrudcondomines insertar = new zcrudcondomines();
            insertar.cedula = textBox1.Text;
            insertar.nombre = textBox2.Text;
            insertar.correo = textBox3.Text;
            insertar.telefono = textBox4.Text;
            insertar.manzana = textBox5.Text;
            insertar.edificio = int.Parse(textBox6.Text);
            insertar.apto = textBox7.Text;
            insertar.insertar();
            limpio();
            tabla();
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

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

      

            //-------------------------------------------------------------------METODO PARA ACTUALIZAR LA TABLA CUANDO SE REALICE UNA FUNCION-------------------------------------------------------------------------------
            public void tabla()
            {

                comando = new SqlCommand("Select * from condominesx", cone);
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
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


            }

            //-------------------------------------------------------------------METODO PARA BUSCAR UN USUARIO-------------------------------------------------------------------------------
            public void busqueda()
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM CONDOMINESX WHERE cedula = @cedula", cone);
                    comando.Parameters.AddWithValue("@cedula", textBox8.Text);
                    cone.Open();
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        textBox1.Text = registro["cedula"].ToString();
                        textBox2.Text = registro["nombre"].ToString();
                        textBox3.Text = registro["correo"].ToString();
                        textBox4.Text = registro["telefono"].ToString();
                        textBox5.Text = registro["manzana"].ToString();
                        textBox6.Text = registro["edificio"].ToString();
                        textBox7.Text = registro["apto"].ToString();

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
