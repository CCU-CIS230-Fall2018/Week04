using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Student : Individual
    {
        // Student properties.
        public int StudentId { get; set; }
        public string Year { get; set; }
        // Individual parent class constructor.
        public Student(string phoneNumber, string displayName, string firstName, string lastName, int studentId, string year)
            : base(phoneNumber, displayName, firstName, lastName)
        {
            StudentId = studentId;
            Year = year;
        }
    }
}
