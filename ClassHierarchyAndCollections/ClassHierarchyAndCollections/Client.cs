using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchyAndCollections
{
    public class Client : Individual
    {
        public int ClientSince { get; set; }
        public string Tier { get; set; }

        public Client(int clientSince, string tier, int age, string gender, string name, string number)
            : base(age, gender, name, number)
        {
            ClientSince = clientSince;
            Tier = tier;
            Age = age;
            Gender = gender;
            Name = name;
            Number = number;
        }
    }
}
