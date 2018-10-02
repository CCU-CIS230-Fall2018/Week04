using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void CreateBusiness()
        {
            Business business1= new Business()
            {
                AreaOfBusiness = "Retail",
                BusClasificationType = "Corperation"
            };
            Assert.AreEqual(business1.AreaOfBusiness, "Retail");
            Assert.AreEqual(business1.BusClasificationType, "Corperation");
        }
        [TestMethod]
        public void CreateBusinessWithOrganization()
        {
            Business business2 = new Business()
            {
                BusClasificationType = "S Corp",
                AreaOfBusiness = "Finance",
                OrganizationName = "Investing is US",
                OrganizationStartDate = "08/28/09"
            };
            Assert.AreEqual(business2.AreaOfBusiness, "Finance");
            Assert.AreEqual(business2.BusClasificationType, "S Corp");
            Assert.AreEqual(business2.OrganizationName, "Investing is US");
            Assert.AreEqual(business2.OrganizationStartDate, "08/28/09");
        }
        [TestMethod]
        public void CreateBusinessWithContact()
        {
            Business business3 = new Business()
            {
                BusClasificationType = "Franchise",
                AreaOfBusiness = "Salon",
                PhoneNumber = "938-094-9382",
                City = "Denver"
            };
            Assert.AreEqual(business3.AreaOfBusiness, "Salon");
            Assert.AreEqual(business3.BusClasificationType, "Franchise");
            Assert.AreEqual(business3.PhoneNumber, "938-094-9382");
            Assert.AreEqual(business3.City, "Denver");
        }
    }
}
