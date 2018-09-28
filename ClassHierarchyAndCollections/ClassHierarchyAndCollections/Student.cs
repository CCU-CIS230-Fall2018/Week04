using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Student : Individual , ILocatable
    {
        public int Grade { get; set; }
        public double GPA { get; set; }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Student(int grade, double gpa, int age, string gender, string name, string number)
            : base(age, gender, name, number)
        {
            Grade = grade;
            GPA = gpa;
            Age = age;
            Gender = gender;
            Name = name;
            Number = number;
        }
    }
}
