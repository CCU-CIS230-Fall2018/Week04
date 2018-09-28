using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace ClassHierarchyAndCollectionsTests
{
    [TestClass]
    public class ContactTestClass
    {
        [TestMethod]
        public void ContactTest()
        {
            Contact testContact = new Contact("John", "303-444-5555");

            Assert.AreEqual(testContact.Name, "John");
            Assert.AreEqual(testContact.Number, "303-444-5555");
        }
    }

    [TestClass]
    public class IndividualTestClass
    { 
        [TestMethod]

        public void IndividualTest()
        {
            Individual testIndividual = new Individual(12, "Male", "Rick", "303-111-2222");

            Assert.AreEqual(testIndividual.Age, 12);
            Assert.AreEqual(testIndividual.Gender, "Male");
            Assert.AreEqual(testIndividual.Name, "Rick");
            Assert.AreEqual(testIndividual.Number, "303-111-2222");
        }
    }

    [TestClass]
    public class StudentTestClass
    {
        [TestMethod]

        public void StudentTest()
        {
            Student testStudent = new Student(6, 3.0, 12, "Female", "Sarah", "720-888-9999");

            Assert.AreEqual(testStudent.Grade, 6);
            Assert.AreEqual(testStudent.GPA, 3.0);
            Assert.AreEqual(testStudent.Age, 12);
            Assert.AreEqual(testStudent.Gender, "Female");
            Assert.AreEqual(testStudent.Name, "Sarah");
            Assert.AreEqual(testStudent.Number, "720-888-9999");
        }
    }

    [TestClass]
    public class MemberTestClass
    {
        [TestMethod]

        public void MemberTest()
        {
            Member testMember = new Member(2012, true, 43, "Male", "Jacob", "303-111-2222");

            Assert.AreEqual(testMember.MemberSince, 2012);
            Assert.AreEqual(testMember.DangerOfTermination, true);
            Assert.AreEqual(testMember.Age, 43);
            Assert.AreEqual(testMember.Gender, "Male");
            Assert.AreEqual(testMember.Name, "Jacob");
            Assert.AreEqual(testMember.Number, "303-111-2222");
        }
    }

    [TestClass]
    public class ClientTestClass
    {
        [TestMethod]

        public void ClientTest()
        {
            Client testClient = new Client(2015, "Favored", 55, "Female", "Rachel", "303-888-2222");

            Assert.AreEqual(testClient.ClientSince, 2015);
            Assert.AreEqual(testClient.Tier, "Favored");
            Assert.AreEqual(testClient.Age, 55);
            Assert.AreEqual(testClient.Gender, "Female");
            Assert.AreEqual(testClient.Name, "Rachel");
            Assert.AreEqual(testClient.Number, "303-888-2222");
        }
    }

    [TestClass]
    public class OrganizationTestClass
    {
        [TestMethod]

        public void OrganizationTest()
        {
            Organization testOrganization = new Organization("APPL", "Large", "Apple Inc.", "555-232-5566");

            Assert.AreEqual(testOrganization.NASDAQ, "APPL");
            Assert.AreEqual(testOrganization.Size, "Large");
            Assert.AreEqual(testOrganization.Name, "Apple Inc.");
            Assert.AreEqual(testOrganization.Number, "555-232-5566");
        }
    }

    [TestClass]
    public class BusinessTestClass
    {
        [TestMethod]

        public void BusinessTest()
        {
            Business testBusiness = new Business(true, "Technology", "MSFT", "Large", "Microsoft", "403-555-7777");

            Assert.AreEqual(testBusiness.ForProfit, true);
            Assert.AreEqual(testBusiness.Industry, "Technology");
            Assert.AreEqual(testBusiness.NASDAQ, "MSFT");
            Assert.AreEqual(testBusiness.Size, "Large");
            Assert.AreEqual(testBusiness.Name, "Microsoft");
            Assert.AreEqual(testBusiness.Number, "403-555-7777");
        }
    }

    [TestClass]
    public class AssociationTestClass
    {
        [TestMethod]

        public void AssociationTest()
        {
            Association testAssociation = new Association("For Players", "300", "NFL", "Medium", "National Football League", "333-444-5555");

            Assert.AreEqual(testAssociation.Purpose, "For Players");
            Assert.AreEqual(testAssociation.AnnualDues, "300");
            Assert.AreEqual(testAssociation.NASDAQ, "NFL");
            Assert.AreEqual(testAssociation.Size, "Medium");
            Assert.AreEqual(testAssociation.Name, "National Football League");
            Assert.AreEqual(testAssociation.Number, "333-444-5555");
        }
    }

    [TestClass]
    public class SchoolTestClass
    {
        [TestMethod]

        public void SchoolTest()
        {
            Student studentOne = new Student(4, 4.0, 8, "Male", "Carl", "333-444-5555");
            Student studentTwo = new Student(5, 3.4, 9, "Female", "Beth", "555-111-3333");
            Student studentThree = new Student(6, 3.6, 10, "Female", "Hannah", "444-555-6666");
            List<Student> Roster = new List<Student>();
            Roster.Add(studentOne);
            Roster.Add(studentTwo);
            Roster.Add(studentThree);
            School testSchool = new School("K-12", "Private", "SCHL", "Small", "South High", "555-777-8888", Roster);

            Assert.AreEqual(testSchool.GradesTaught, "K-12");
            Assert.AreEqual(testSchool.PublicOrPrivate, "Private");
            Assert.AreEqual(testSchool.NASDAQ, "SCHL");
            Assert.AreEqual(testSchool.Size, "Small");
            Assert.AreEqual(testSchool.Name, "South High");
            Assert.AreEqual(testSchool.Number, "555-777-8888");
            Assert.AreSame(testSchool.Students, Roster);
        }
    }
}


