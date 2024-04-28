using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Models;

namespace UTNBusiness.Interfaces
{
     public interface ICategoriaModule
    {

        Task<List<Categoria>> ObtenerCategorias();
        Task<Categoria> AgregarCategorias(Categoria obj);


    }
}
