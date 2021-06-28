using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL
{

    public partial class cuota : Form
    {

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;
        SqlDataReader dr;
        public cuota()
        {
            InitializeComponent();
        }

        private void cuota_Load(object sender, EventArgs e)
        {
            llenarcampos(comboBox1);
            DateTime fecha = DateTime.Now;
            textBox8.Text= fecha.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            general menu = new general();
            menu.Show();
            this.Hide();
        }


        public void llenarcampos(ComboBox cb)
        {
            try
            {
                cone.Open();
                comando = new SqlCommand("Select nombre from condominesx", cone);
                dr = comando.ExecuteReader();
                while(dr.Read())
                {

                    cb.Items.Add(dr["nombre"].ToString());

                }

                dr.Close();
                cone.Close();

            }catch(Exception error)
            {

                MessageBox.Show(error.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cone.Open();

            SqlCommand cm = new SqlCommand("select*from condominesx where nombre ='" + comboBox1.Text + "'", cone);
            SqlDataReader dx = cm.ExecuteReader();
            if(dx.Read() == true)
            {
                textBox1.Text = dx["cedula"].ToString();
                textBox2.Text = dx["nombre"].ToString();
                textBox3.Text = dx["correo"].ToString();
                textBox4.Text = dx["telefono"].ToString();
                textBox5.Text = dx["manzana"].ToString();
                textBox6.Text = dx["edificio"].ToString();
                textBox7.Text = dx["apto"].ToString();
            }
            cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
            limpio();
            
        }


        //-------------------------------------------------------------------METODO INSERTAR-------------------------------------------------------------------------------


        public void insertar()
        {
            try
            {
                cone.Open();
                comando = new SqlCommand($"INSERT INTO PAGOS VALUES('{textBox8.Text}','{textBox1.Text}','{textBox2.Text}','{ textBox3.Text}','{textBox4.Text}','{textBox5.Text}',{ textBox6.Text},'{textBox7.Text}','{comboBox2.Text}')", cone);
                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("PAGO EXITOSO");
                cone.Open();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


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

    }
}
