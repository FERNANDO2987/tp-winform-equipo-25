using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Models;



namespace UTNBusiness.Interfaces
{
     public interface IImagenesModule
    {
        Task<Imagenes> ObtenerImagen(int idImagen);
        Task<Imagenes> AgregarImagen(Imagenes obj);

    }
}
