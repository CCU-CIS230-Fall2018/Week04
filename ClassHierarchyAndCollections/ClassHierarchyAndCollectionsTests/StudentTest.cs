using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentTestMethod()
        {
            Student TestStudent = new Student("3092363810", "ClassClown", "Keaton", "Helm", 22, "Junior");
            Assert.AreEqual(TestStudent.PhoneNumber, "3092363810");
            Assert.AreEqual(TestStudent.DisplayName, "ClassClown");
            Assert.AreEqual(TestStudent.FirstName, "Keaton");
            Assert.AreEqual(TestStudent.LastName, "Helm");
            Assert.AreEqual(TestStudent.StudentId, 22);
            Assert.AreEqual(TestStudent.Year, "Junior");  
        }
    }
}
