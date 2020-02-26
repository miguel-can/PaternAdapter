using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines
{
    public class ProcesaSucursales
    {
        private ISucursales svrSucursales;

        public ProcesaSucursales(ISucursales _svrSucursales)
        {
            this.svrSucursales = _svrSucursales;
        }

        public SucursalesDTO Procesar()
        {
            return this.svrSucursales.ObtenerLista().FirstOrDefault();
        }
    }
}
