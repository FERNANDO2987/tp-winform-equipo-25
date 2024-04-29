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

        Task<Articulos> AgregarArticulos(Articulos obj);
        Task<Articulos> ModificarArticulos(Articulos obj);
        Task<bool> EliminarArticulos(int id);
        Task<List<Articulos>> BuscarArticuloPorCriterio(string valorBusqueda);

        Task<List<Articulos>> ListarArticulos();

        Task<List<Detalle>> BuscarDetallePorArticulo(string criterio);

        Task<List<Detalle>> ObtenerDatosModificar(string criterio);

    }
}
