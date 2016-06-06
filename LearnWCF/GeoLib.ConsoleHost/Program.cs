using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace GeoLib.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostGeoService = new ServiceHost(typeof(GeoLib.Service.GeoManager));

            //string url = "net.Tcp://localhost/8009/GeoService";
            //NetTcpBinding binding = new NetTcpBinding();
            //Type contract = typeof(GeoLib.Contracts.IGeoService);

            //hostGeoService.AddServiceEndpoint(contract, binding, url);

            hostGeoService.Open();


            Console.WriteLine("Service Started");
            Console.ReadLine();

            hostGeoService.Close();
        }
    }
}
