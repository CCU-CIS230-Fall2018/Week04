using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Member : Individual
    {
        // Member properties.
        public DateTime MemberSince { get; set; }
        public string MembershipType { get; set; }
        // Individual parent class constructor.
        public Member(string phoneNumber, string displayName, string firstName, string lastName, DateTime memberSince, string membershipType)
            : base(phoneNumber, displayName, firstName, lastName)
        {
            MemberSince = memberSince;
            MembershipType = membershipType;
        }
    }
}
