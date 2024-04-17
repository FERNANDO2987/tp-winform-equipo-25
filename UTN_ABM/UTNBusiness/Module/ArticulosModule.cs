using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTNBusiness.Interfaces;
using UTNData.Interfaces;
using UTNData.Models;

namespace UTNBusiness.Module
{
    public class ArticulosModule : IArticulosModule
    {
        private readonly IArticulosRepository _articulosRepository;

        public ArticulosModule(IArticulosRepository articulosRepository)
        {
            _articulosRepository = articulosRepository;
        }
        public Task<List<Articulos>> ObtenerArticulos(int id)
        {
            var result = _articulosRepository.ObtenerArticulos(id);

            throw new NotImplementedException();
        }
    }
}
