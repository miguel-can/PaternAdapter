using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines
{
    public class ImpresorSucursales : IImpresorSucursales
    {
        public void ImprimirSucursales(List<SucursalesDTO> lstSucursales)
        {
            foreach (SucursalesDTO entSucursal in lstSucursales)
            {
                Console.WriteLine("Identificador:{0}, Nombre:{1}, Total:{2}", entSucursal.iIdentificador, entSucursal.cNombre, entSucursal.dTotal);
            }
        }
    }
}
