using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolTestMethod()
        {
            Student FirstStudent = new Student("1234567891", "clown", "Noah", "Jamison", 1, "Junior");
            Student SecondStudent = new Student("3092365828", "nerd", "Keaton", "Helm", 2, "Freshman");
            Student ThirdStudent = new Student("198765321", "TeachersPet", "John", "Smith", 3, "Senior");
            List<Student> ClassRoster = new List<Student>();
            ClassRoster.Add(FirstStudent);
            ClassRoster.Add(SecondStudent);
            ClassRoster.Add(ThirdStudent);

            School TestSchool = new School("3092363810", "SHS", DateTime.Today,"Sherrard High School",300,ClassRoster);

            Assert.AreEqual(TestSchool.PhoneNumber, "3092363810");
            Assert.AreEqual(TestSchool.DisplayName, "SHS");
            Assert.AreEqual(TestSchool.EstablishedDate, DateTime.Today);
            Assert.AreEqual(TestSchool.EntityName, "Sherrard High School");
            Assert.AreEqual(TestSchool.Enrollment, 300);
            Assert.AreSame(TestSchool.Students, ClassRoster);
        }
    }
}
