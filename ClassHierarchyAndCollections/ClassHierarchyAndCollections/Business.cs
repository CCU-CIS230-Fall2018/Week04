using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Business : Organization
    {
        // Business properties.
        public string FormationType { get; set; }
        public bool TaxExemptTicker { get; set; }
        // Organization parent class constructor.
        public Business(string phoneNumber, string displayName, DateTime establishedDate, string entityName, string formationType, bool taxexemptTicker)
            : base(phoneNumber, displayName, establishedDate, entityName)
        {
            FormationType = formationType;
            TaxExemptTicker = taxexemptTicker;
        }
    }
}
