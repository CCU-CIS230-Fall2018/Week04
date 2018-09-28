using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class IndividualTest
    {
        [TestMethod]
        public void IndividualTestMethod()
        {
            Individual TestIndividual = new Individual("3092363810", "CCU","Keaton","Helm");

            Assert.AreEqual(TestIndividual.PhoneNumber, "3092363810");
            Assert.AreEqual(TestIndividual.DisplayName, "CCU");
            Assert.AreEqual(TestIndividual.FirstName, "Keaton");
            Assert.AreEqual(TestIndividual.LastName, "Helm");
        }
    }
}
