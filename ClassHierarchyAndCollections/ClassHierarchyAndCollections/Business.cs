using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassHierarchyAndCollections
{
    public class Business : Organization, IAnnualProfit
    {
        public string Industry { get; set; }

        public List<string> Clients { get; set; }
    }
}
