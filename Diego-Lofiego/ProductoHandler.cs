using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
    public class ProductoHandler : DbHandler
    {
        private Producto DataReader(long id, string descripciones, double costo, double precioVenta, int stock, long idUsuario)
        {
            Producto producto = new Producto(id, descripciones, costo, precioVenta, stock, idUsuario);
                                  
            return producto;
        }

        public Producto Get(long id)
        {
            Producto producto = new Producto();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM [SistemaGestion].[dbo].[Producto] WHERE Id = @id";
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {                        
                        if (dataReader.HasRows & dataReader.Read()) //verifico que haya filas y que data reader haya leido
                        {
                            producto = DataReader(Convert.ToInt32(dataReader["Id"]), dataReader["Descripciones"].ToString(), Convert.ToInt32(dataReader["Costo"]), Convert.ToInt32(dataReader["PrecioVenta"]), Convert.ToInt32(dataReader["Stock"]), Convert.ToInt32(dataReader["IdUsuario"]));                                  
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return producto;
        }

        public List<Producto> Get()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [SistemaGestion].[dbo].[Producto]", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {   
                        if (dataReader.HasRows) //verifico que haya filas
                        {
                            while (dataReader.Read())
                            {
                                productos.Add(DataReader(Convert.ToInt32(dataReader["Id"]), dataReader["Descripciones"].ToString(), Convert.ToInt32(dataReader["Costo"]), Convert.ToInt32(dataReader["PrecioVenta"]), Convert.ToInt32(dataReader["Stock"]), Convert.ToInt32(dataReader["IdUsuario"])));
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return productos;
        }

        public void Delete(long idProducto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryDelete = "DELETE FROM [SistemaGestion].[dbo].[Producto] WHERE Id = @idProducto";

                SqlParameter sqlParameter = new SqlParameter("idProducto", SqlDbType.BigInt);
                sqlParameter.Value = idProducto;

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection))
                {
                    sqlCommand.Parameters.Add(sqlParameter);
                    sqlCommand.ExecuteScalar(); // aca se ejecuta el delete
                }

                sqlConnection.Close();
            }
        }

        public void Add(Producto producto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "INSERT INTO [SistemaGestion].[dbo].[Producto] (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario);";

                SqlParameter descripcionesParameter = new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones };
                SqlParameter costoParameter = new SqlParameter("Costo", SqlDbType.Int) { Value = producto.Costo };
                SqlParameter precioVentaParameter = new SqlParameter("PrecioVenta", SqlDbType.Int) { Value = producto.PrecioVenta };
                SqlParameter stockParameter = new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock };
                SqlParameter idUsuarioParameter = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario };

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                {
                    sqlCommand.Parameters.Add(descripcionesParameter);
                    sqlCommand.Parameters.Add(costoParameter);
                    sqlCommand.Parameters.Add(precioVentaParameter);
                    sqlCommand.Parameters.Add(stockParameter);
                    sqlCommand.Parameters.Add(idUsuarioParameter);
                    sqlCommand.ExecuteNonQuery(); // aca se ejecuta el insert
                }

                sqlConnection.Close();
            }
        }
    }
}
