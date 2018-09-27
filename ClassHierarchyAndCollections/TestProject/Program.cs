using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using ClassHierarchyAndCollections;
using System.Diagnostics;


namespace TestProject
{
    public class FlowTests
    {
        [TestMethod]
        public void StudentTests ()
        {
            Contact contact = new Contact();
            contact.PhoneNumber = "719-395-8281";
            Assert.AreEqual(contact.PhoneNumber, "719-395-8281" );
        }


    }
}
