using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    // Ilocatable interface that can be used to determine longitude and latitude coordinates.
    public interface ILocatable
    {
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
    public class Individual : Contact, ILocatable
    {
        // Individual properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Contact parent class constructor.
        public Individual(string phoneNumber, string displayName, string firstName, string lastName)
            : base(phoneNumber, displayName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
