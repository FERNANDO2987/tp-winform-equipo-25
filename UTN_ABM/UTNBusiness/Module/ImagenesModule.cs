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
    public class ImagenesModule : IImagenesModule
    {
        private readonly string sqlconString;

        public ImagenesModule(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("El connection string no puede ser nulo o vacío.", nameof(connectionString));
            }

            sqlconString = connectionString;
        }

        public async Task<Imagenes> AgregarImagen(Imagenes obj)
        {

            var conn = new SqlConnection(sqlconString);

            SqlCommand command = new SqlCommand("AgregarImagen", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            conn.Open();


            try
            {
                command.Parameters.Add(new SqlParameter("@Id", obj.Id));
                command.Parameters.Add(new SqlParameter("@IdArticulo", obj.IdArticulo));
                command.Parameters.Add(new SqlParameter("@ImagenURL", obj.ImagenURL));
               

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

        public async Task<Imagenes> ObtenerImagen(int idImagen)
        {          
            var imagen = new Imagenes();          
            
            var conn = new SqlConnection(sqlconString);
          
            SqlCommand command = new SqlCommand("ObtenerImagen", conn)
            {
              
                CommandType = System.Data.CommandType.StoredProcedure
            };         
            conn.Open();

            
            command.Parameters.Add(new SqlParameter("@idImagen", idImagen));

            var reader = command.ExecuteReader();

            try
            {
                if (await reader.ReadAsync())
                {
                    imagen = new Imagenes
                    {
                        Id = reader.GetInt32(0),
                        IdArticulo = reader.GetInt32(1),
                        ImagenURL = reader.GetString(2)
                    };
                }
            }
            catch (Exception ex)
            {
                
                var error = "Error parseando datos de SQL: " + ex.Message;

   
                return new Imagenes();
            }
            finally
            {
              
                reader.Close();
               
                command.Dispose();
             
                conn.Close();
            }

          
            return imagen;
        }
    }
}
