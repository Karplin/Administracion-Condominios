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
    class zcrudmanzana : abstracto   
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string buscar { get; set; }

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;

    //-------------------------------------------------------------------METODO INSERTAR-------------------------------------------------------------------------------


        public override void insertar()
        {
            try
            {
                cone.Open();
                comando = new SqlCommand($"INSERT INTO MANZANAS VALUES('{nombre}')", cone);
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
        public override void eliminar()
        {

            try
            {
                cone.Open();
                comando = new SqlCommand($"DELETE FROM MANZANAS WHERE nombre='{nombre}'", cone);
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
        public override void actuali()
        {
            try { 
            string query = "UPDATE MANZANAS SET nombre = @nombre WHERE id = @id";
            cone.Open();
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            cone.Close();
            MessageBox.Show("ACTUALIZADO");
        }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);

                }

}










    }
}
