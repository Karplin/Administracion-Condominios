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
    class zcrudapartamento : zcrudcondomines 
    { 
            public string numero { get; set; }
            public int edificio { get; set; }


            SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
            SqlCommand comando;


            //-------------------------------------------------------------------METODO INSERTAR-------------------------------------------------------------------------------


            public void insertar()
            {
                try
                {
                    cone.Open();
                    comando = new SqlCommand($"INSERT INTO APARTAMENTOS VALUES('{numero}',{edificio})", cone);
                    comando.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("GUARDADO COMPLETADO");

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }


            }


            //-------------------------------------------------------------------METODO ELIMINAR-------------------------------------------------------------------------------
            public  void eliminar()
            {

                try
                {
                    cone.Open();
                    comando = new SqlCommand($"DELETE FROM APARTAMENTOS WHERE numero='{numero}'", cone);
                    comando.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("ELIMINADO");


                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);

                }
            }

            //-------------------------------------------------------------------METODO ACTUALIZAR-------------------------------------------------------------------------------
            public  void actuali()
            {
            try { 
                string query = "UPDATE APARTAMENTOS SET numero = @numero, edificio = @edificio WHERE numero = @numero";
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@edificio", edificio);
                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("ATUALIZACION REALIZADA");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);

            }

        }



        }
    }
