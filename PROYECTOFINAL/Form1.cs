using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace PROYECTOFINAL
{
    interface Icrudcondomines
    {
         string cedula { get; set; }
         string nombre { get; set; }
         string correo { get; set; }
         string telefono { get; set; }
         string manzana { get; set; }
         int edificio { get; set; }
         string apto { get; set; }

        void insertar();
        void eliminar();
        void actuali();
    }

    public partial class Form1 : Form
    {
        SqlConnection conebd = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {

                general formulariox = new general();
                formulariox.Show();
                this.Hide();
                timer1.Enabled = false;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        

        public void login()
        {

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT nombreusuario, contrasena FROM usuarios WHERE nombreusuario='" + textBox1.Text + "'AND contrasena='" + textBox2.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Login EXITOSO");
                            timer1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Login INCORRECTO");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            crearcuenta nuevacuenta = new crearcuenta();
            nuevacuenta.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
