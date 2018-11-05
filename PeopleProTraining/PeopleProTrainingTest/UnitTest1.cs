using System;
using PeopleProTraining;
using PeopleProTraining.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeopleProTrainingTest
{
    [TestClass]
    public class BuildingTests
    {
        [TestMethod]
        public void Auto_Set_Department_ID()
        {
            Building building = new Building();
            building.Department_Name = "Bogus";
            building.AutoSet_Department_ID("Bogus");
            Assert.IsTrue(building.Department_ID == 0);
        }
    }
}
