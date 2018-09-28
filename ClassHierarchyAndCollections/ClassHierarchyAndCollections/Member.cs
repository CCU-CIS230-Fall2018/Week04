using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Member : Individual , ILocatable
    {
        public int MemberSince { get; set; }
        public bool DangerOfTermination { get; set; }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Member(int memberSince, bool dangerOfTermination, int age, string gender, string name, string number)
            : base(age, gender, name, number)
        {
            MemberSince = memberSince;
            DangerOfTermination = dangerOfTermination;
            Age = age;
            Gender = gender;
            Name = name;
            Number = number;
        }
    }
}
