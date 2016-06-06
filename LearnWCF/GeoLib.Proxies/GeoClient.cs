using GeoLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.Proxies
{
    public class GeoClient : ClientBase<IGeoService>, IGeoService
    {
        public GeoClient(string endPointName) : base(endPointName)
        {

        }

        public GeoClient (Binding binding, EndpointAddress endPointAddress) : base(binding,endPointAddress)
        {

        }
        public IEnumerable<string> GetStates(bool PrimaryOnly)
        {
            return Channel.GetStates(PrimaryOnly);
        }

        public ZipCodeData GetZipInfo(string Zip)
        {
            return Channel.GetZipInfo(Zip);
        }

        public IEnumerable<ZipCodeData> GetZips(string state)
        {
            return Channel.GetZips(state);
        }

        public IEnumerable<ZipCodeData> GetZips(string zip, int range)
        {
            return Channel.GetZips(zip, range);
        }
    }
}
