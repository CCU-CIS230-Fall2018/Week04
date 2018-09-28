using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Individual : Contact 
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        

        public Individual (int age, string gender, string name, string number)
            : base(name, number)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Number = number;
        }
    }
}
