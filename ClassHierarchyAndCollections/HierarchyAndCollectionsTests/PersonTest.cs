using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CreatePersonTest()
        {
            Person person1 = new Person()
            {
                FirstName = "John",
                LastName ="Smith",
                Age = 35,
            };

            Assert.AreEqual(person1.FirstName, "John");
            Assert.AreEqual(person1.LastName, "Smith");
            Assert.AreEqual(person1.Age, 35);

        }
        [TestMethod]
        public void CreatePersonWithILocatable()
        {
            Person person2 = new Person()
            {
                FirstName = "Dana",
                LastName ="Johnson",
                Age = 29,
                Latitude = 39.73,
                Longitude= 104.99
            };

            Assert.AreEqual(person2.FirstName, "Dana");
            Assert.AreEqual(person2.LastName, "Johnson");
            Assert.AreEqual(person2.Age, 29);
            Assert.AreEqual(person2.Latitude, 39.73);
            Assert.AreEqual(person2.Longitude, 104.99);

        }
        [TestMethod]
        public void CreatePersonWithContact()
        {
            Person person3 = new Person()
            {
                FirstName ="Chad",
                LastName = "Jones",
                Age = 21,
                PhoneNumber = "345-290-0273",
                City = "Denver"
            };

            Assert.AreEqual(person3.FirstName, "Chad");
            Assert.AreEqual(person3.LastName, "Jones");
            Assert.AreEqual(person3.Age, 21);
            Assert.AreEqual(person3.PhoneNumber, "345-290-0273");
            Assert.AreEqual(person3.City, "Denver");

        }
    }
}
