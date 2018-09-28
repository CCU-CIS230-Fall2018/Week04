using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Business : Organization
    {
        public bool ForProfit { get; set; }
        public string Industry { get; set; }

        public Business(bool forProfit, string industry, string nasdaq, string size, string name, string number)
            : base( nasdaq, size, name, number)
        {
            ForProfit = forProfit;
            Industry = industry;
            NASDAQ = nasdaq;
            Size = size;
            Name = name;
            Number = number;
        }
    }
}
