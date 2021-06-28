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
    class zcrudcondomines : Icrudcondomines
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string manzana { get; set; }
        public int edificio { get; set; }
        public string apto { get; set; }

        SqlConnection cone = new SqlConnection("Data Source=DESKTOP-F0HC34O\\SQLSERVER;Initial Catalog=condomines;Integrated Security=True");
        SqlCommand comando;


        //-------------------------------------------------------------------METODO INSERTAR-------------------------------------------------------------------------------


        public  void insertar()
        {
            try
            {
                cone.Open();
                comando = new SqlCommand($"INSERT INTO CONDOMINESX VALUES('{cedula}','{nombre}','{correo}','{telefono}','{manzana}',{edificio},'{apto}')", cone);
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
        public void eliminar()
        {

            try
            {
                cone.Open();
                comando = new SqlCommand($"DELETE FROM CONDOMINESX WHERE cedula='{cedula}'", cone);
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
        public void actuali()
        {
            try
            {
                string query = "UPDATE CONDOMINESX SET cedula = @cedula, nombre = @nombre, correo = @correo, telefono = @telefono, manzana = @manzana, edificio = @edificio, apto = @apto WHERE cedula = @cedula";
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@manzana", manzana);
                comando.Parameters.AddWithValue("@edificio", edificio);
                comando.Parameters.AddWithValue("@apto", apto);

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
