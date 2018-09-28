using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class School : Organization
    {
        public string GradesTaught { get; set; }
        public string PublicOrPrivate { get; set; }
        public List<Student> Students { get; set; }

        public School(string gradesTaught, string publicOrPrivate, string nasdaq, string size, string name, string number, List<Student> students)
            : base(nasdaq, size, name, number)
        {
            GradesTaught = gradesTaught;
            PublicOrPrivate = publicOrPrivate;
            NASDAQ = nasdaq;
            Size = size;
            Name = name;
            Number = number;
            Students = students;
        }
    }
}
