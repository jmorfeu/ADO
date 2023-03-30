using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Dal
{
     public class Conexion
    {
        public void InsertEstudiantes(Estudiantes estudiantes)
        {
           string connectionString = ConfigurationManager.AppSettings["connectionString"];
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertEstudiante", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                       
                        cmd.Parameters.AddWithValue("@Nombre", estudiantes.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", estudiantes.Apellido);
                    
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                   
                    conn.Close();
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}
