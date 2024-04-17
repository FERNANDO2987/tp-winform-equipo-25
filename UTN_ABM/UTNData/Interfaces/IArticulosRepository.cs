using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNData.Models;

namespace UTNData.Interfaces
{
     public interface IArticulosRepository
    {
        Task<List<Articulos>> ObtenerArticulos(int id);
    }
}
