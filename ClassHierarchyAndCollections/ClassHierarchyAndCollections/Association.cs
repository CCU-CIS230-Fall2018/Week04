using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Association : Organization
    {
        // Association properties.
        public string SizeDescription { get; set; }
        public int MeetingsToDate { get; set; }
        // Organization parent class constructor.
        public Association(string phoneNumber, string displayName, DateTime establishedDate, string entityName, string sizeDescription, int meetingstoDate)
            : base(phoneNumber, displayName, establishedDate, entityName)
        {
            SizeDescription = sizeDescription;
            MeetingsToDate = meetingstoDate;
        }
    }
}
