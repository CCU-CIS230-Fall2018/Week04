using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class OrganizationTest
    {
        [TestMethod]
        public void OrganizationTestMethod()
        {
            Organization TestOrganization = new Organization("3092363810", "CCU", DateTime.Today, "Colorado Christian University");

            Assert.AreEqual(TestOrganization.PhoneNumber, "3092363810");
            Assert.AreEqual(TestOrganization.DisplayName, "CCU");
            Assert.AreEqual(TestOrganization.EstablishedDate, DateTime.Today);
            Assert.AreEqual(TestOrganization.EntityName, "Colorado Christian University");
        }
    }
}
