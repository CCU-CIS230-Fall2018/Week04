using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Association:Organization
    {
        public int AssociationEIN { get; set; }
        public double AssociationDues { get; set; }
    }
}
