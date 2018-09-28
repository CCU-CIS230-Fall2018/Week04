using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;
using System.Collections.Generic;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void CreateSchool()
        {
            School school1 = new School()
            {
                SchoolSize = 1500,
                SchoolLevel = "Elementary"

            };
            school1.Students = new List<string>
            {
                "Dana"
            };
            Assert.AreEqual(school1.SchoolSize, 1500);
            Assert.AreEqual(school1.SchoolLevel, "Elementary");
            Assert.AreEqual(school1.Students[0], "Dana");
        }
        [TestMethod]
        public void CreateSchoolWithOrganization()
        {
            School school2 = new School()
            {
                SchoolLevel="Senior High",
                SchoolSize= 2421,
                OrganizationName="North Scott Senior High School",
                OrganizationStartDate="08/28/42"
            };
            Assert.AreEqual(school2.SchoolSize, 2421);
            Assert.AreEqual(school2.SchoolLevel, "Senior High");
            Assert.AreEqual(school2.OrganizationName, "North Scott Senior High School");
            Assert.AreEqual(school2.OrganizationStartDate, "08/28/42");
        }
        [TestMethod]
        public void CreateSchoolWithContact()
        {
            School school3 = new School()
            {
                SchoolSize=28348,
                SchoolLevel="University",
                PhoneNumber="938-094-9382",
                City="Iowa City"
            };
            Assert.AreEqual(school3.SchoolSize, 28348);
            Assert.AreEqual(school3.SchoolLevel, "University");
            Assert.AreEqual(school3.PhoneNumber, "938-094-9382");
            Assert.AreEqual(school3.City, "Iowa City");
        }
    }
}
