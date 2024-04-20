using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Models;


namespace UTNBusiness.Interfaces
{
     public interface IArticulosModule
    {
        Task<List<Articulos>> ObtenerArticulos(int idArticulo);
        Task<Articulos> AgregarArticulos(Articulos articulos);
        Task<Articulos> ModificarArticulos(Articulos articulos);
        Task<bool> EliminarArticulos(int id);

    }
}
