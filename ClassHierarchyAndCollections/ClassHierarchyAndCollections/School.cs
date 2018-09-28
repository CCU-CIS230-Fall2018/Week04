using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class School : Organization
    {
        // School properties including a collection of student objects.
        public int Enrollment { get; set; }
        public List<Student> Students { get; set; }
        // Organization parent class constructor.
        public School(string phoneNumber, string displayName, DateTime establishedDate, string entityName, int enrollment, List<Student> students)
            : base(phoneNumber, displayName, establishedDate, entityName)
        {
            Enrollment = enrollment;
            Students = students;
        }
    }
}
