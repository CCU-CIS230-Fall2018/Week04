using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void MemeberTestMethod()
        {
            Member TestMember = new Member("3092363810", "ClassClown", "Keaton", "Helm",DateTime.Today,"Premium");
            Assert.AreEqual(TestMember.PhoneNumber, "3092363810");
            Assert.AreEqual(TestMember.DisplayName, "ClassClown");
            Assert.AreEqual(TestMember.FirstName, "Keaton");
            Assert.AreEqual(TestMember.LastName, "Helm");
            Assert.AreEqual(TestMember.MemberSince, DateTime.Today);
            Assert.AreEqual(TestMember.MembershipType, "Premium");
        }
    }
}
