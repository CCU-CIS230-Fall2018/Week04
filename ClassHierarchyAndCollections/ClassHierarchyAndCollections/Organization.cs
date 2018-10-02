using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Organization: Contact, ILocatable
    {
        public string OrganizationName { get; set; }
        public string OrganizationStartDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
