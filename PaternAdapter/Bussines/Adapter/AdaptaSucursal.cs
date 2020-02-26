using Newtonsoft.Json;
using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines.Adapter
{
    public class AdaptaSucursal 
    {
        private IGeneradorJSON svrGeneradorJSON;

        public AdaptaSucursal(IGeneradorJSON _svrGeneradorJSON)
        {
            this.svrGeneradorJSON = _svrGeneradorJSON;
        }

        public List<SucursalesDTO> ConvierteJsonListaDTO()
        {
            return JsonConvert.DeserializeObject<List<SucursalesDTO>>(this.svrGeneradorJSON.Generar());
        }
    }
}
