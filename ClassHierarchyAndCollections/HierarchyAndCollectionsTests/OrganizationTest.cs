using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class OrganizationTest
    {
        [TestMethod]
        public void CreateOrganization()
        {
            Organization organization1 = new Organization()
            {
                OrganizationName = "Ski USA",
                OrganizationStartDate = "5/29/15"
            };

            Assert.AreEqual(organization1.OrganizationName, "Ski USA");
            Assert.AreEqual(organization1.OrganizationStartDate, "5/29/15");
           
        }
        [TestMethod]
        public void CreateOrganizationWithILocatable()
        {
            Organization organization2 = new Organization()
            {
                OrganizationName = "Progressive",
                OrganizationStartDate="7/09/99",
                Latitude = 39.73,
                Longitude = 104.99
            };

            Assert.AreEqual(organization2.OrganizationName, "Progressive");
            Assert.AreEqual(organization2.OrganizationStartDate, "7/09/99");
            Assert.AreEqual(organization2.Latitude, 39.73);
            Assert.AreEqual(organization2.Longitude, 104.99);

        }
        [TestMethod]
        public void CreateOrganizationWithContact()
        {
            Organization organization3 = new Organization()
            {
                OrganizationName = "Nationwide",
                OrganizationStartDate = "9/02/04",
                PhoneNumber = "345-290-0273",
                City = "Denver"
            };
            Assert.AreEqual(organization3.OrganizationName, "Nationwide");
            Assert.AreEqual(organization3.OrganizationStartDate, "9/02/04");
            Assert.AreEqual(organization3.PhoneNumber, "345-290-0273");
            Assert.AreEqual(organization3.City, "Denver");
         }
    }
}