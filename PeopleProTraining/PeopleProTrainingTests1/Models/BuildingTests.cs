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
        public void AutoSet_Department_IDTest()
        {
            PeopleProTrainingContext db = new PeopleProTrainingContext();
            Building building = new Building() { Department_Name = "SomeName" };
            building.AutoSet_Department_ID("SomeName");
            Assert.IsTrue(building.Department_ID==0);

        }
    }
}