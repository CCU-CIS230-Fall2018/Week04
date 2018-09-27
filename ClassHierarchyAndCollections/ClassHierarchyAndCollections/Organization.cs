using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Organization : Contact
    {
        public string OrganizationName { get; set; }

        public bool ForProfit { get; set; }
    }
}
