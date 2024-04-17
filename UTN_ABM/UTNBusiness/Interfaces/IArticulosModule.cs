using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNData.Models;

namespace UTNBusiness.Interfaces
{
     public interface IArticulosModule
    {
        Task<List<Articulos>> ObtenerArticulos(int id);

    }
}
