using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ContactTest()
        {
            Contact contact = new Contact();
            contact.PhoneNumber = "719-395-8281";
            contact.Address = "1800 Testing Lane";
            Assert.AreEqual(contact.PhoneNumber, "719-395-8281");
            Assert.AreEqual(contact.Address, "1800 Testing Lane");
        }
        [TestMethod]
        public void OrganizationTest()
        {
            Organization organization = new Organization();
            organization.PhoneNumber = "719-395-8281";
            organization.Address = "1800 Testing Lane";
            organization.ForProfit = true;
            organization.OrganizationName = "Test Corp";
            Assert.AreEqual(organization.PhoneNumber, "719-395-8281");
            Assert.AreEqual(organization.Address, "1800 Testing Lane");
            Assert.IsTrue(organization.ForProfit);
            Assert.AreEqual(organization.OrganizationName, "Test Corp");
        }
        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person();
            person.PhoneNumber = "719-395-8281";
            person.Address = "1800 Testing Lane";
            person.FirstName = "Bob";
            person.LastName = "Smith";
            Assert.AreEqual(person.PhoneNumber, "719-395-8281");
            Assert.AreEqual(person.Address, "1800 Testing Lane");
            Assert.AreEqual(person.FirstName, "Bob");
            Assert.AreEqual(person.LastName, "Smith");
        }
        [TestMethod]
        public void AssociationTest()
        {
            Association association = new Association();
            association.PhoneNumber = "719-395-8281";
            association.Address = "1800 Testing Lane";
            association.ForProfit = false;
            association.OrganizationName = "Test Corp";
            association.AnnualGoal = "Save all the animals!";
            association.Description = "We save animals";
            Assert.AreEqual(association.PhoneNumber, "719-395-8281");
            Assert.AreEqual(association.Address, "1800 Testing Lane");
            Assert.IsFalse(association.ForProfit);
            Assert.AreEqual(association.OrganizationName, "Test Corp");
            Assert.AreEqual(association.AnnualGoal, "Save all the animals!");
            Assert.AreEqual(association.Description, "We save animals");
        }
        [TestMethod]
        public void BusinessTest()
        {
            Business business = new Business();
            business.PhoneNumber = "719-395-8281";
            business.Address = "1800 Testing Lane";
            business.ForProfit = true;
            business.OrganizationName = "Test Corp";
            business.Clients = new List<string>();
            business.Clients.Add("Will");
            business.Industry = "Coal Power";
            Assert.AreEqual(business.PhoneNumber, "719-395-8281");
            Assert.AreEqual(business.Address, "1800 Testing Lane");
            Assert.IsTrue(business.ForProfit);
            Assert.AreEqual(business.OrganizationName, "Test Corp");
            Assert.AreEqual(business.Clients[0], "Will");
            Assert.AreEqual(business.Industry, "Coal Power");
        }
        [TestMethod]
        public void SchoolTest()
        {
            School school = new School();
            school.PhoneNumber = "719-395-8281";
            school.Address = "1800 Testing Lane";
            school.ForProfit = true;
            school.OrganizationName = "Test Corp";
            school.Accreditation = true;
            school.EducationLevel = "Highschool";
            Assert.AreEqual(school.PhoneNumber, "719-395-8281");
            Assert.AreEqual(school.Address, "1800 Testing Lane");
            Assert.IsTrue(school.ForProfit);
            Assert.AreEqual(school.OrganizationName, "Test Corp");
            Assert.IsTrue(school.ForProfit);
            Assert.AreEqual(school.EducationLevel, "Highschool");            
        }
        [TestMethod]
        public void StudentTest()
        {
            Student student = new Student();
            student.PhoneNumber = "719-395-8281";
            student.Address = "1800 Testing Lane";
            student.FirstName = "Bob";
            student.LastName = "Smith";
            student.GradeAverage = 3.6F;
            student.Working = true;
            Assert.AreEqual(student.PhoneNumber, "719-395-8281");
            Assert.AreEqual(student.Address, "1800 Testing Lane");
            Assert.AreEqual(student.FirstName, "Bob");
            Assert.AreEqual(student.LastName, "Smith");
            Assert.AreEqual(student.GradeAverage, 3.6F);
            Assert.IsTrue(student.Working);
        }
        [TestMethod]
        public void WorkerTest()
        {
            Worker worker = new Worker();
            worker.PhoneNumber = "719-395-8281";
            worker.Address = "1800 Testing Lane";
            worker.FirstName = "Bob";
            worker.LastName = "Smith";
            worker.Salary = "$100,000";
            worker.YearsOfEmployment = 4;            
            Assert.AreEqual(worker.PhoneNumber, "719-395-8281");
            Assert.AreEqual(worker.Address, "1800 Testing Lane");
            Assert.AreEqual(worker.FirstName, "Bob");
            Assert.AreEqual(worker.LastName, "Smith");
            Assert.AreEqual(worker.Salary, "$100,000");
            Assert.AreEqual(worker.YearsOfEmployment, 4);            
        }
        [TestMethod]
        public void ClientTest()
        {
            Client client = new Client();
            client.PhoneNumber = "719-395-8281";
            client.Address = "1800 Testing Lane";
            client.FirstName = "Bob";
            client.LastName = "Smith";
            
            Assert.AreEqual(client.PhoneNumber, "719-395-8281");
            Assert.AreEqual(client.Address, "1800 Testing Lane");
            Assert.AreEqual(client.FirstName, "Bob");
            Assert.AreEqual(client.LastName, "Smith");            
        }


    }
}
