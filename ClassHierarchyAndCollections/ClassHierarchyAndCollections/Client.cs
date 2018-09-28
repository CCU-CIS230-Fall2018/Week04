using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Client : Individual
    {
        // Client properties.
        public bool ActiveTicker { get; set; }
        public string MeetingDay { get; set; }
        // Individual parent class constructor.
        public Client(string phoneNumber, string displayName, string firstName, string lastName, bool activeTicker, string meetingDay)
            : base(phoneNumber, displayName, firstName, lastName)
        {
            ActiveTicker = activeTicker;
            MeetingDay = meetingDay;
        }
    }
}
