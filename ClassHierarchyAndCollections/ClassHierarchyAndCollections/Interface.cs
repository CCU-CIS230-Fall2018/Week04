using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public interface ILocatable
    { 
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
}
