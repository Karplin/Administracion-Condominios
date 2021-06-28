using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class crearcuenta : Form
    {
        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        public crearcuenta()
        {
            InitializeComponent();
        }

        private void crearcuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text) { 

            nuevousuario();
            limpiatext();



            }
            else
            {

                MessageBox.Show("LA CONTRASEÑA NO ES CORRECTA");

            }
    }

        public void nuevousuario()
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("COMPLETE LOS CAMPOS");


            }
            else
            {
                try
                {
                    cone.Open();
                    comando = new SqlCommand($"INSERT INTO usuarios VALUES('{textBox1.Text}','{textBox2.Text}')", cone);
                    comando.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("CREACION EXITOSA");
                    this.Close();
                    Form1 principal = new Form1();
                    principal.Show();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }


            }


        }

        public void limpiatext()
        {

            textBox1.Text = "";
            textBox2.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
