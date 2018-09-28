using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHierarchyAndCollections;

namespace HierarchyAndCollectionsTests
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void CreateMember()
        {
            Member member1 = new Member()
            {
                MemberID= 12345,
                MembershipLength= 2
            };
            Assert.AreEqual(member1.MemberID, 12345);
            Assert.AreEqual(member1.MembershipLength, 2);
        }
        [TestMethod]
        public void CreateMemberPerson()
        {
            Member member2 = new Member()
            {
                MemberID= 59063,
                MembershipLength= 1,
                FirstName = "Jim",
                LastName = "Putter",
                Age = 56,
                Latitude = 73.09,
                Longitude = 729.10

            };
            Assert.AreEqual(member2.MemberID, 59063);
            Assert.AreEqual(member2.MembershipLength, 1);
            Assert.AreEqual(member2.FirstName, "Jim");
            Assert.AreEqual(member2.LastName, "Putter");
            Assert.AreEqual(member2.Age, 56);
            Assert.AreEqual(member2.Latitude, 73.09);
            Assert.AreEqual(member2.Longitude, 729.10);
        }
        [TestMethod]
        public void CreateMemberContact()
        {
            Member member3 = new Member()
            {
                MemberID= 28301,
                MembershipLength=4,
                PhoneNumber="395-094-9832",
                City="Davenport"
            };
            Assert.AreEqual(member3.MemberID, 28301);
            Assert.AreEqual(member3.MembershipLength, 4);
            Assert.AreEqual(member3.PhoneNumber, "395-094-9832");
            Assert.AreEqual(member3.City, "Davenport");
        }
    }
}
