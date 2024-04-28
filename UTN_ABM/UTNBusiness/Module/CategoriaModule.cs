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
    public class CategoriaModule : ICategoriaModule
    {
        private readonly string sqlconString;

        public  CategoriaModule(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("El connection string no puede ser nulo o vacío.", nameof(connectionString));
            }

            sqlconString = connectionString;
        }

        public async Task<Categoria> AgregarCategorias(Categoria obj)
        {
            var conn = new SqlConnection(sqlconString);

            SqlCommand command = new SqlCommand("AgregarCategoria", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            conn.Open();


            try
            {
                command.Parameters.Add(new SqlParameter("@Id", obj.Id));
                command.Parameters.Add(new SqlParameter("@Descripcion", obj.Descripcion));
                


                var reader = command.ExecuteReader();


                try
                {
                    while (reader.Read())
                    {
                        /// Validacion para Identity, devuelve el valor de las tres formas
                        if (reader[0].GetType() == typeof(int))
                        {
                            obj.Id = reader.GetInt32(0);
                        }
                        else
                        if (reader[0].GetType() == typeof(decimal))
                        {
                            obj.Id = (int)reader.GetDecimal(0);
                        }
                        else
                        {
                            obj.Id = (int)reader.GetInt64(0);

                        }


                    }
                }
                catch (Exception ex)
                {
                    var error = "Error parseando datos de sql: " + ex.Message;
                    return null;
                }

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


            return obj;
        
    }

        public async Task<List<Categoria>> ObtenerCategorias()
        {
            // Crea una nueva lista para almacenar los objetos Categorias.
            var lista = new List<Categoria>();

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
            var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
            SqlCommand command = new SqlCommand("ObtenerCategorias", conn)
            {
                // Establece el tipo de comando como procedimiento almacenado.
                CommandType = System.Data.CommandType.StoredProcedure
            };

            // Abre la conexion a la base de datos.
            conn.Open();

            // Ejecuta y lee los resultados de la consulta SQL
            var reader = command.ExecuteReader();

            try
            {
                // Itera a traves de cada fila devuelta por el lector de datos.
                while (reader.Read())
                {
                    // Crea un nuevo objeto Articulos y lo agrega a la lista.
                    lista.Add(new Categoria
                    {
                        // Asigna valores a las propiedades del objeto Marca utilizando los datos leidos.
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1)

                    });
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepcion que ocurra durante el proceso de lectura de datos.
                var error = "Error parseando datos de SQL: " + ex.Message;

                // Devuelve una nueva lista vacia de objetos Articulos.
                return new List<Categoria>();
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

            // Devuelve la lista de objetos Categoria que se han leido de la base de datos.
            return lista;
        }
    }
}
