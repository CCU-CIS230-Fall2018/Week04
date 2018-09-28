using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void CreateClient()
        {
            Client client1 = new Client()
            {
                YearsAsClient = 3,
                ClientID = 161026
            };
            Assert.AreEqual(client1.YearsAsClient, 3);
            Assert.AreEqual(client1.ClientID, 161026);
        }
        [TestMethod]
        public void CreateClientWithPerson()
        {
            Client client2 = new Client()
            {
                YearsAsClient = 6,
                ClientID = 0442709,
                FirstName = "Kate",
                LastName = "Spade",
                Age = 12,
                Latitude = 84.90,
                Longitude = 392.09
            };
            Assert.AreEqual(client2.YearsAsClient, 6);
            Assert.AreEqual(client2.ClientID, 0442709);
            Assert.AreEqual(client2.FirstName, "Kate");
            Assert.AreEqual(client2.LastName, "Spade");
            Assert.AreEqual(client2.Age, 12);
            Assert.AreEqual(client2.Latitude, 84.90);
            Assert.AreEqual(client2.Longitude, 392.09);
        }
        [TestMethod]
        public void CreateClientWithContact()
        {
            Client client3 = new Client()
            {
                YearsAsClient = 10,
                ClientID = 0484201,
                PhoneNumber = "830-903-8502",
                City = "Moline"
            };
            Assert.AreEqual(client3.YearsAsClient, 10);
            Assert.AreEqual(client3.ClientID, 0484201);
            Assert.AreEqual(client3.PhoneNumber, "830-903-8502");
            Assert.AreEqual(client3.City, "Moline");
        }
    }
}