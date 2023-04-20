using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DProducto
    {
        private string connectionString = "Data Source=DESKTOP-MH893DO;Initial Catalog=Tecsup;Integrated Security=True;";

        public List<Producto> Mostrar()
        {
            SqlConnection connection = null;
            SqlParameter param = null;
            SqlCommand command = null;
            List<Producto> productos = null;

            try
            {
                connection = new SqlConnection(connectionString);

                connection.Open();
                command = new SqlCommand("USP_GetProducts", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                productos = new List<Producto>();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.IdProducto = reader["IdProducto"].ToString();
                    producto.Codigo = reader["Codigo"].ToString();



                    productos.Add(producto);
                }

                connection.Close();
                return productos;

            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }
            finally
            {
                connection = null;
                command = null;
                param  = null;  
                productos = null;
            }

            
        }


        public void Insertar(Producto producto)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertProduct", connection); // Nombre del procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Codigo", producto.Codigo);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
