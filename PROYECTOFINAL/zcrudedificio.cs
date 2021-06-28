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
    class zcrudedificio : virtuales
    {
        public int numero { get; set; }
        public string cant_pisos { get; set; }
        public string cant_aptos { get; set; }
        public string manzana { get; set; }
        public string buscar { get; set; }

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;


        //-------------------------------------------------------------------METODO INSERTAR-------------------------------------------------------------------------------


        public override void guardar()
        {
            try
            {
                cone.Open();
                comando = new SqlCommand($"INSERT INTO EDIFICIOS VALUES({numero},'{cant_pisos}','{cant_aptos}','{manzana}')", cone);
                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("GUARDADO EXITOSO");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


        }


        //-------------------------------------------------------------------METODO ELIMINAR-------------------------------------------------------------------------------
        public override  void borrar()
        {

            try
            {
                cone.Open();
                comando = new SqlCommand($"DELETE FROM EDIFICIOS WHERE numero='{numero}'", cone);
                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show(" ELIMINADO");


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);

            }
        }

        //-------------------------------------------------------------------METODO ACTUALIZAR-------------------------------------------------------------------------------
        public override  void editar()
        {
            try { 
            string query = "UPDATE EDIFICIOS SET numero = @numero, cant_pisos = @cant_pisos, cant_aptos = @cant_aptos, manzana = @manzana WHERE numero = @numero";
            cone.Open();
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@cant_pisos", cant_pisos);
            comando.Parameters.AddWithValue("@cant_aptos", cant_aptos);
            comando.Parameters.AddWithValue("@manzana", manzana);
            comando.ExecuteNonQuery();
            cone.Close();
            MessageBox.Show("Actualizado");

        }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);

                }

}




    }
}
