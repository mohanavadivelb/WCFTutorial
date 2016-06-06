using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.Contracts
{
    [ServiceContract]
    public interface IGeoService 
    {
        [OperationContract]
        ZipCodeData GetZipInfo(string Zip);

        [OperationContract]
        IEnumerable<string> GetStates(bool PrimaryOnly);

        [OperationContract(Name ="GetZipsByState")]
        IEnumerable<ZipCodeData> GetZips(string state);

        [OperationContract (Name ="GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
