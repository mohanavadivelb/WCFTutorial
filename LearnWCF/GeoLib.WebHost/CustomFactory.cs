using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace GeoLib.WebHost
{
    public class CustomFactory :ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ServiceHost host = new ServiceHost(typeof(GeoLib.Service.GeoManager));

            host.Open();
            return host;
        }
       
    }
}