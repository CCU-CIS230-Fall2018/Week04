using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void CreateStudent()
        {
            Student student1 = new Student()
            {
                Grade = 3,
                StudentID= 161026
            };

            Assert.AreEqual(student1.Grade, 3);
            Assert.AreEqual(student1.StudentID, 161026);

        }
        [TestMethod]
        public void CreateStudentWithPerson()
        {
            Student student2 = new Student()
            {
                Grade = 6,
                StudentID = 0442709,
                FirstName = "Cindy",
                LastName = "May",
                Age = 12,
                Latitude= 84.90,
                Longitude = 392.09
            };

            Assert.AreEqual(student2.Grade, 6);
            Assert.AreEqual(student2.StudentID, 0442709);
            Assert.AreEqual(student2.FirstName, "Cindy");
            Assert.AreEqual(student2.LastName, "May");
            Assert.AreEqual(student2.Age, 12);
            Assert.AreEqual(student2.Latitude, 84.90);
            Assert.AreEqual(student2.Longitude, 392.09);


        }
        [TestMethod]
        public void CreateStudentWithContact()
        {
            Student student3 = new Student()
            {
                Grade = 10,
                StudentID = 0484201,
                PhoneNumber = "830-903-8502",
                City = "Lakewood"
            };

            Assert.AreEqual(student3.Grade, 10);
            Assert.AreEqual(student3.StudentID, 0484201);
            Assert.AreEqual(student3.PhoneNumber, "830-903-8502");
            Assert.AreEqual(student3.City, "Lakewood");

        }
    }
}
