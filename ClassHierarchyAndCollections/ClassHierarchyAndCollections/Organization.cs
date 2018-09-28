using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Organization : Contact
    {
        public string NASDAQ { get; set; }
        public string Size { get; set; }

        public Organization(string nasdaq, string size, string name, string number)
            : base(name, number)
        {
            NASDAQ = nasdaq;
            Size = size;
            Name = name;
            Number = number;
        }
    }
}
