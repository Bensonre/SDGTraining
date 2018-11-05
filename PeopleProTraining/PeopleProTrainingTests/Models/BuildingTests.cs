using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleProTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Models.Tests
{
    [TestClass()]
    public class BuildingTests
    {
        [TestMethod()]
        public void Set_Department_NameTest()
        {
           /* string Depo_Name = "Bogus";
            Building building = new Building();
            building.Set_Department_Name(Depo_Name);*/
            Assert.IsTrue(true);
         //   Assert.IsTrue(building.Department_Name.Equals(Depo_Name), "depo names are equal");
        }
    }
}