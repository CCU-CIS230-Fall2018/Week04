using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void CreateContact()
        {
            Contact contact1 = new Contact()
            {
                PhoneNumber="203-940-8203",
                City="Golden"
            };
            Assert.AreEqual(contact1.PhoneNumber, "203-940-8203");
            Assert.AreEqual(contact1.City, "Golden");
        }
    }
}
