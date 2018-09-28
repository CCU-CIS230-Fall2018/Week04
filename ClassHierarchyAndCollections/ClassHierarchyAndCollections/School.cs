using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class School:Organization
    {
        public int SchoolSize { get; set; }
        public string SchoolLevel { get; set; }
        public List<string> Students { get; set; }
    }
}
