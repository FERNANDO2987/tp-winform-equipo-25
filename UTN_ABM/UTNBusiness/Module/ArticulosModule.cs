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
        private readonly IConfiguration _configuration;

        public ArticulosModule(IConfiguration configuration)
        {
            _configuration = configuration;
            sqlconString = _configuration["ConnectionString:UTNString"];
        }

        public Task<Articulos> AgregarArticulos(Articulos articulos)
        {
            //Falta hacer
            throw new NotImplementedException();
        }

        public Task<Articulos> EliminarArticulos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Articulos> ModificarArticulos(Articulos articulos)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Articulos>> ObtenerArticulos(int id)
        {
            // Crea una nueva lista para almacenar los objetos Articulos.
            var lista = new List<Articulos>();

            // Crea una nueva conexion a la base de datos utilizando la cadena de conexion sqlconString.
            using var conn = new SqlConnection(sqlconString);

            // Crea un nuevo comando SQL para ejecutar el procedimiento almacenado ObtenerArticulos.
            using SqlCommand command = new SqlCommand("ObtenerArticulos", conn)
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
                        // Crea un nuevo objeto Marca y asigna el ID leido.
                        Marca = new Marca()
                        {
                            Id = reader.GetInt32(4)
                        },
                        // Crea un nuevo objeto Categoria y asigna el ID leido.
                        Categoria = new Categoria()
                        {
                            Id = reader.GetInt32(5)
                        },
                        // Asigna el precio.
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
