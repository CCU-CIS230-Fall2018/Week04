using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;


namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class AssociationTest
    {
        [TestMethod]
        public void AssociationTestMethod()
        {
            Association TestAssociation = new Association("3092363810", "NBA",DateTime.Today,"National Basketball Association","Large",50);

            Assert.AreEqual(TestAssociation.PhoneNumber, "3092363810");
            Assert.AreEqual(TestAssociation.DisplayName, "NBA");
            Assert.AreEqual(TestAssociation.EstablishedDate, DateTime.Today);
            Assert.AreEqual(TestAssociation.EntityName, "National Basketball Association");
            Assert.AreEqual(TestAssociation.SizeDescription, "Large");
            Assert.AreEqual(TestAssociation.MeetingsToDate, 50);
        }
    }
}
