using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoLib.Data;
using GeoLib.Service;
using GeoLib.Contracts;
using Moq;

namespace Geo.Lib.Tests
{
    [TestClass]
    public class GeoManagerTests
    {
        [TestMethod]
        public void GetZipInfo_Test()
        {
            Mock<IZipCodeRepository> mockZipCodeRepository = new Mock<IZipCodeRepository>();

            ZipCode zipCodeData = new ZipCode()
            {
                City = "LINCOLN PARK",
                State = new State() { Abbreviation = "NJ" },
                Zip = "07035"

            };
            mockZipCodeRepository.Setup(obj => obj.GetByZip("07035")).Returns(zipCodeData);

            IGeoService geoService = new GeoManager(mockZipCodeRepository.Object);
            ZipCodeData zipData = geoService.GetZipInfo("07035");

            Assert.IsTrue(zipData.City.ToUpper() == "LINCOLN PARK");
            Assert.IsTrue(zipData.State.ToUpper() == "NJ");



        }
    }
}
