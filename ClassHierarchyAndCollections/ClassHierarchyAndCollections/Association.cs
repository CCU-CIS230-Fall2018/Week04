using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Association : Organization
    {
        public string Purpose { get; set; }
        public string AnnualDues { get; set; }

        public Association(string purpose, string annualDues, string nasdaq, string size, string name, string number)
            : base(nasdaq, size, name, number)
        {
            Purpose = purpose;
            AnnualDues = annualDues;
            NASDAQ = nasdaq;
            Size = size;
            Name = name;
            Number = number;
        }
    }
}
