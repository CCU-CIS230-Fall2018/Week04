using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Organization : Contact, ILocatable
    {
        // Organization properties.
        public DateTime EstablishedDate { get; set; }
        public string EntityName { get; set; }
        double ILocatable.Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double ILocatable.Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Contact parent class constructor.
        public Organization(string phoneNumber, string displayName, DateTime establishedDate, string entityName)
            : base(phoneNumber, displayName)
        {
            EstablishedDate = establishedDate;
            EntityName = entityName;
        }
    }
}
