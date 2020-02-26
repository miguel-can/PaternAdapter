using PaternAdapter.Bussines;
using PaternAdapter.Bussines.Adapter;
using PaternAdapter.Bussines.Interface;
using PaternAdapter.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOpcion = 0;
            ISucursales svrSucursales;
            IGeneradorJSON svrGeneradorJSON;
            IImpresorSucursales svrImpresor;
            
            List<SucursalesDTO> lstSucursalesDTO = new List<SucursalesDTO>();
            string cJson = string.Empty;
            SucursalesDTO entSucursal = new SucursalesDTO();

            Console.WriteLine("Indique el NÚMERO de servicio que corresponda de la lista siguiente:");
            Console.WriteLine("Servicio: 1");
            Console.WriteLine("Servicio: 2");
            Console.WriteLine("Servicio: 3");            

            int.TryParse(Console.ReadLine(), out iOpcion);

            switch (iOpcion)
            {
                case 1:
                    //En este case se implementa el adaptador, el adaptador se ajusta a la interfaz ISucursales
                    svrGeneradorJSON = new GeneraJson();
                    AdaptaSucursal svrAdaptaSucursal = new AdaptaSucursal(svrGeneradorJSON);
                    svrSucursales = new AdaptadorSucursales(svrAdaptaSucursal);
                    lstSucursalesDTO = svrSucursales.ObtenerLista();

                    svrImpresor = new ImpresorSucursales();
                    svrImpresor.ImprimirSucursales(lstSucursalesDTO);
                    break;
                case 2:
                    svrGeneradorJSON = new GeneraJson();
                    cJson = svrGeneradorJSON.Generar();
                    Console.WriteLine(cJson);
                    break;
                case 3:
                    svrSucursales = new ConsultaSucursales();
                    entSucursal = new ProcesaSucursales(svrSucursales).Procesar();
                    lstSucursalesDTO.Add(entSucursal);

                    svrImpresor = new ImpresorSucursales();
                    svrImpresor.ImprimirSucursales(lstSucursalesDTO);
                    break;
                default:
                    Console.WriteLine("Indique unda opción correcta");
                    break;
            }

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
