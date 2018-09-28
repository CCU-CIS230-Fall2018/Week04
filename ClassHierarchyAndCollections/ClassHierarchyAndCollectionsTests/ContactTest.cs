using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class ContactUnitTest
    {
        [TestMethod]
        public void ContactTestMethod()
        {
            Contact TestContact = new Contact("3092363810", "BigSkeet");

            Assert.AreEqual(TestContact.DisplayName, "BigSkeet");
            Assert.AreEqual(TestContact.PhoneNumber, "3092363810");
        }
    }
}
