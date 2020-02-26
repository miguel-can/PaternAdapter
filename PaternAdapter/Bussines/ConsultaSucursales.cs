using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines
{
    public class ConsultaSucursales : ISucursales
    {
        public List<SucursalesDTO> ObtenerLista()
        {
            List<SucursalesDTO> lstSucursales = new List<SucursalesDTO>();
            lstSucursales.Add(new SucursalesDTO() { iIdentificador = 1, cNombre = "Sucursal1", dTotal = 100 });
            lstSucursales.Add(new SucursalesDTO() { iIdentificador = 2, cNombre = "Sucursal2", dTotal = 200 });
            lstSucursales.Add(new SucursalesDTO() { iIdentificador = 3, cNombre = "Sucursal3", dTotal = 300 });
            return lstSucursales;
        }
    }
}
