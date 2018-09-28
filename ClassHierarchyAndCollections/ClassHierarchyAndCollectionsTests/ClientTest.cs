using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void ClientTestMethod()
        {
            Client TestClient = new Client("3092363810", "ClassClown", "Keaton", "Helm",true,"Wednesday");
            Assert.AreEqual(TestClient.PhoneNumber, "3092363810");
            Assert.AreEqual(TestClient.DisplayName, "ClassClown");
            Assert.AreEqual(TestClient.FirstName, "Keaton");
            Assert.AreEqual(TestClient.LastName, "Helm");
            Assert.AreEqual(TestClient.ActiveTicker, true);
            Assert.AreEqual(TestClient.MeetingDay, "Wednesday");
        }
    }
}
