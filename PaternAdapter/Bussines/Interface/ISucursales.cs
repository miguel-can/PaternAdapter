﻿using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter.Bussines.Interface
{
    public interface ISucursales
    {
        List<SucursalesDTO> ObtenerLista();
    }
}
