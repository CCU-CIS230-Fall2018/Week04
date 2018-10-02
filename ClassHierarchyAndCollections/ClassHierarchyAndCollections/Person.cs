using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public interface ILocatable
    {
        double Latitude { get; set; }

        double Longitude { get; set; }
    }
    public class Person :Contact, ILocatable
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }



    }
}
