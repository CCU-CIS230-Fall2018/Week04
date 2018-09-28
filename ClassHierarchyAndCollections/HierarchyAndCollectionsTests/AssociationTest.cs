using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class AssociationTest
    {
        [TestMethod]
        public void CreateAssociation()
        {
            Association association1 = new Association()
            {
                AssociationDues = 250.00,
                AssociationEIN= 27402965
            };
            Assert.AreEqual(association1.AssociationDues, 250.00);
            Assert.AreEqual(association1.AssociationEIN, 27402965);
        }
        [TestMethod]
        public void CreateAssociationWithOrganization()
        {
            Association association2 = new Association()
            {
                AssociationDues = 99.00,
                AssociationEIN = 8402740,
                OrganizationName = "Stone Creek Home Owners",
                OrganizationStartDate = "09/28/14"
            };
            Assert.AreEqual(association2.AssociationDues, 99.00);
            Assert.AreEqual(association2.AssociationEIN, 8402740);
            Assert.AreEqual(association2.OrganizationName, "Stone Creek Home Owners");
            Assert.AreEqual(association2.OrganizationStartDate, "09/28/14");
        }
        [TestMethod]
        public void CreateAssociationWithContact()
        {
            Association association3 = new Association()
            {
                AssociationDues = 56.00,
                AssociationEIN = 9753234,
                PhoneNumber = "938-094-9382",
                City = "Eldridge"
            };
            Assert.AreEqual(association3.AssociationDues, 56.00);
            Assert.AreEqual(association3.AssociationEIN, 9753234);
            Assert.AreEqual(association3.PhoneNumber, "938-094-9382");
            Assert.AreEqual(association3.City, "Eldridge");
        }
    }
}
