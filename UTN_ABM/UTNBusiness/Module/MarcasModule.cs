
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Interfaces;
using UTNBusiness.Models;

namespace UTNBusiness.Module
{
    public class MarcasModule : IMarcasModule
    {
        private readonly string sqlconString;

        public MarcasModule(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("El connection string no puede ser nulo o vacío.", nameof(connectionString));
            }

            sqlconString = connectionString;
        }


        public async Task<List<Marca>> ObtenerMarcas()
        {
            // Crea una nueva lista para almacenar los objetos Articulos.
            var lista = new List<Marca>();

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
            var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
             SqlCommand command = new SqlCommand("ObtenerMarcas", conn)
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
                    lista.Add(new Marca
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
                return new List<Marca>();
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
    }
}
