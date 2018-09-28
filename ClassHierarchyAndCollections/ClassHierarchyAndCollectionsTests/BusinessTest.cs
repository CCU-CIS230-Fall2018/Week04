using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void BusinessTestMethod()
        {
            Business TestBusiness = new Business("3092363810", "PWC", DateTime.Today, "Price Waterhouse Cooper","C-Corp",false);

            Assert.AreEqual(TestBusiness.PhoneNumber, "3092363810");
            Assert.AreEqual(TestBusiness.DisplayName, "PWC");
            Assert.AreEqual(TestBusiness.EstablishedDate, DateTime.Today);
            Assert.AreEqual(TestBusiness.EntityName, "Price Waterhouse Cooper");
            Assert.AreEqual(TestBusiness.FormationType, "C-Corp");
            Assert.AreEqual(TestBusiness.TaxExemptTicker, false);
        }
    }
}
