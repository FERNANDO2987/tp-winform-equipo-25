using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Models;

namespace UTNBusiness.Interfaces
{
     public interface IMarcasModule
    {
        Task <List<Marca>> ObtenerMarcas();
        Task<Marca> AgregarMarca(Marca obj);

    }
}
