using GeoLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoLib.Data;
using System.Threading;

namespace GeoLib.Service
{
    public class GeoManager : IGeoService
    {
        IZipCodeRepository _zipCodeRepository = null;
        IStateRepository _stateRepository = null;

        public GeoManager()
        {

        }
        public GeoManager (IZipCodeRepository zipCodeRepository)
        {
            _zipCodeRepository = zipCodeRepository;
        }

        public GeoManager(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public GeoManager(IZipCodeRepository zipCodeRepository,IStateRepository sateRepository)
        {
            _zipCodeRepository = zipCodeRepository;
            _stateRepository = sateRepository;
        }

        public IEnumerable<string> GetStates(bool PrimaryOnly)
        {
            List<string> statesData = new List<string>();

            IStateRepository stateRepository =  _stateRepository ?? new StateRepository();

            IEnumerable<State> states = stateRepository.Get(PrimaryOnly);
            if(states!=null)
            {
                foreach(State state in states)
                {
                    statesData.Add(state.Abbreviation);
                }
            }


            return statesData;
        }

        public ZipCodeData GetZipInfo(string Zip)
        {
            ZipCodeData zipCodeData = null;

            
            IZipCodeRepository zipCodeRepository = _zipCodeRepository ?? new ZipCodeRepository();
            ZipCode zipCodeEntity = zipCodeRepository.GetByZip(Zip);
            if (zipCodeEntity != null)
            {
                zipCodeData = new ZipCodeData()
                {

                    City = zipCodeEntity.City,
                    State = zipCodeEntity.State.Abbreviation,
                    ZipCode = zipCodeEntity.Zip
                };
            }

            return zipCodeData;
        }

        public IEnumerable<ZipCodeData> GetZips(string state)
        {
            List<ZipCodeData> zipCodesData = new List<ZipCodeData>();
            IZipCodeRepository zipCodeRepository = _zipCodeRepository ?? new ZipCodeRepository();

            IEnumerable<ZipCode> zipCodes = zipCodeRepository.GetByState(state);
            if(zipCodes!=null)
            {
                foreach (ZipCode zip in zipCodes)
                {
                    zipCodesData.Add(new ZipCodeData()
                    {

                        City = zip.City,
                        State = zip.State.Abbreviation,
                        ZipCode = zip.Zip                   
                        
                    });
                }
            }

            return zipCodesData;
        }

        public IEnumerable<ZipCodeData> GetZips(string zip, int range)
        {
            List<ZipCodeData> zipCodesData = new List<ZipCodeData>();
            IZipCodeRepository zipCodeRepository = _zipCodeRepository ?? new ZipCodeRepository();

            ZipCode zipCodeEntity = zipCodeRepository.GetByZip(zip);
            IEnumerable<ZipCode> zipCodes = zipCodeRepository.GetZipsForRange(zipCodeEntity,range);
            if (zipCodes != null)
            {
                foreach (ZipCode zipCode in zipCodes)
                {
                    zipCodesData.Add(new ZipCodeData()
                    {

                        City = zipCode.City,
                        State = zipCode.State.Abbreviation,
                        ZipCode = zipCode.Zip

                    });
                }
            }

            return zipCodesData;
        }
    }
} 
