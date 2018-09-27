using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class School : Organization, IAnnualProfit
    {
        public bool Accreditation { get; set; }

        public string EducationLevel { get; set; }
        
    }
}
