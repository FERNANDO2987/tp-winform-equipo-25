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

        public Task<Imagenes> GuardarImagen(string imagen)
        {
            throw new NotImplementedException();
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
