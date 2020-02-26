using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines.Adapter
{
    public class AdaptadorSucursales : ISucursales
    {
        private readonly AdaptaSucursal svrAdaptaSucursal;

        public AdaptadorSucursales(AdaptaSucursal _svrAdaptaSucursal)
        {
            this.svrAdaptaSucursal = _svrAdaptaSucursal;
        }

        public List<SucursalesDTO> ObtenerLista()
        {
            return this.svrAdaptaSucursal.ConvierteJsonListaDTO();
        }

    }
}
