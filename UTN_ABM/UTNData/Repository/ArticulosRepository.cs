using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNData.Interfaces;
using UTNData.Models;

namespace UTNData.Repository
{
    public class ArticulosRepository : IArticulosRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _sqlString;
        public ArticulosRepository(IConfiguration configuration) 
        { 
           _configuration = configuration;
            _sqlString = _configuration[""];

        }

        public async Task<List<Articulos>> ObtenerArticulos(int id)
        {
            var articulos = new List<Articulos>();

            using (SqlConnection connection = new SqlConnection(_sqlString))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand("ObtenerArticulos",connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@idArticulos", id);


                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while(reader.Read())
                            {
                                Articulos art = new Articulos();
                                art.Id = reader.GetInt32(0);


                                articulos.Add(art);

                            }
                        
                        
                      
                        
                        }

                        return articulos;

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }       


            }
        }
    }
}
