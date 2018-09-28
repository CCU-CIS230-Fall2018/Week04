using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Contact
    {
        // Contact Properties.
        public string PhoneNumber { get; set; }
        public string DisplayName { get; set; }

        // Constructor with PhoneNumber and DisplayName.
        public Contact(string phoneNumber, string displayName)
        {
            PhoneNumber = phoneNumber;
            DisplayName = displayName;
        }
    }


}
