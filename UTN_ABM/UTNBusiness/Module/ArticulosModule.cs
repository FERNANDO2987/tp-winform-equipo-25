using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Interfaces;
using UTNBusiness.Models;




namespace UTNBusiness.Module
{
    public class ArticulosModule : IArticulosModule
    {

        private readonly string sqlconString;

        public ArticulosModule(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("El connection string no puede ser nulo o vacío.", nameof(connectionString));
            }

            sqlconString = connectionString;
        }

        public async Task<Articulos> AgregarArticulos(Articulos articulos)
        {

            var conn = new SqlConnection(sqlconString);

          SqlCommand command = new SqlCommand("AgregarArticulo", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            conn.Open();
     

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", articulos.Id));
                command.Parameters.Add(new SqlParameter("@Codigo", articulos.Codigo));
                command.Parameters.Add(new SqlParameter("@Nombre", articulos.Nombre));
                command.Parameters.Add(new SqlParameter("@Descripcion", articulos.Descripcion));
                command.Parameters.Add(new SqlParameter("@IdMarca", articulos.IdMarca));
                command.Parameters.Add(new SqlParameter("@IdCategoria", articulos.IdCategoria));
                command.Parameters.Add(new SqlParameter("@Precio", articulos.Precio));

                await command.ExecuteNonQueryAsync();

            }

            catch (Exception ex)
            {
                var error = "Error parseando datos de sql: " + ex.Message;
                return null;

            }
            finally
            {
               
                conn.Close();


            }


            return articulos;
        }

        public async Task<List<Articulos>> BuscarArticuloPorCriterio(string valorBusqueda)
        {
            // Crea una nueva lista para almacenar los objetos Articulos.
            var lista = new List<Articulos>();

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
            var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
            SqlCommand command = new SqlCommand("BuscarArticuloPorCriterio", conn)
            {
                // Establece el tipo de comando como procedimiento almacenado.
                CommandType = System.Data.CommandType.StoredProcedure
            };

            // Agrega un parometro al comando SQL para pasar el ID de los artoculos.
            command.Parameters.Add(new SqlParameter("@valorBusqueda", valorBusqueda));

            // Abre la conexion a la base de datos.
            conn.Open();

            // Ejecuta y lee los resultados de la consulta SQL
            var reader = command.ExecuteReader();

            try
            {
                // Itera a traves de cada fila devuelta por el lector de datos.
                while (reader.Read())
                {
                    lista.Add(new Articulos
                    {
                        // Asigna valores a las propiedades del objeto Articulos utilizando los datos leidos.
                        Id = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Descripcion = reader.GetString(3),
                        IdMarca = reader.GetInt32(4),
                        IdCategoria = reader.GetInt32(5),
                        Precio = reader.GetDecimal(6)
                    });
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepcion que ocurra durante el proceso de lectura de datos.
                var error = "Error parseando datos de SQL: " + ex.Message;

                // Devuelve una nueva lista vacia de objetos Articulos.
                return new List<Articulos>();
            }
            finally
            {
                // Cierra el lector de datos para liberar recursos.
                reader.Close();
                // Libera los recursos asociados con el comando SQL.
                command.Dispose();
                // Cierra la conexion a la base de datos para liberar recursos y finalizar la conexion.
                conn.Close();
            }

            // Devuelve la lista de objetos Marca que se han leido de la base de datos.
            return lista;
        }

        public async Task<bool> EliminarArticulos(int id)
        {
            try
            {
         

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
             var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
             SqlCommand command = new SqlCommand("EliminarArticulo", conn)
            {
                // Establece el tipo de comando como procedimiento almacenado.
                CommandType = System.Data.CommandType.StoredProcedure
            };

            // Agrega un parometro al comando SQL para pasar el ID de los artoculos.
            command.Parameters.Add(new SqlParameter("@idArticulos", id));


            // Abre la conexion a la base de datos.
            conn.Open();


            int FilasAfectadas = command.ExecuteNonQuery();

                // verifica si se elimino al menos una fila de la base de datos.
                return FilasAfectadas > 0;
                
            }
            catch (Exception ex)
            {
                // Captura cualquier excepcion que ocurra durante el proceso de lectura de datos.
                var error = "Error parseando datos de SQL: " + ex.Message;

                // devuelve falso en caso de error al eliminar
                return false;
            }
          
        }

        public Task<Articulos> ModificarArticulos(Articulos articulos)
        {
            // falta hacer
            throw new NotImplementedException();
        }

        public async Task<List<Articulos>> ObtenerArticulos(int id)
        {
            // Crea una nueva lista para almacenar los objetos Articulos.
            var lista = new List<Articulos>();

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
            var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
            SqlCommand command = new SqlCommand("ObtenerArticulos", conn)
            {
                // Establece el tipo de comando como procedimiento almacenado.
                CommandType = System.Data.CommandType.StoredProcedure
            };

            // Abre la conexion a la base de datos.
            conn.Open();

            // Agrega un parometro al comando SQL para pasar el ID de los artoculos.
            command.Parameters.Add(new SqlParameter("@idArticulos", id));

            // Ejecuta y lee los resultados de la consulta SQL
            var reader = command.ExecuteReader();

            try
            {
                // Itera a traves de cada fila devuelta por el lector de datos.
                while (reader.Read())
                {
                    // Crea un nuevo objeto Articulos y lo agrega a la lista.
                    lista.Add(new Articulos
                    {
                        // Asigna valores a las propiedades del objeto Articulos utilizando los datos leidos.
                        Id = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Descripcion = reader.GetString(3),
                        IdMarca = reader.GetInt32(4),
                        IdCategoria = reader.GetInt32(5),  
                        Precio = reader.GetDecimal(6)
                    });
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepcion que ocurra durante el proceso de lectura de datos.
                var error = "Error parseando datos de SQL: " + ex.Message;

                // Devuelve una nueva lista vacia de objetos Articulos.
                return new List<Articulos>();
            }
            finally
            {
                // Cierra el lector de datos para liberar recursos.
                reader.Close();
                // Libera los recursos asociados con el comando SQL.
                command.Dispose();
                // Cierra la conexion a la base de datos para liberar recursos y finalizar la conexion.
                conn.Close();
            }

            // Devuelve la lista de objetos Articulos que se han leido de la base de datos.
            return lista;
        }

    }
}
