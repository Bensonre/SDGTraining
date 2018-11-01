using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleProTraining.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Faculty> FacultyMembers { get; set; }

        public List<Building> Buildings { get; set; }

     
        public void setFacultyMembers(List<Faculty> faculty)
        {
            FacultyMembers=faculty;
        }
        public void setBuildings(List<Building> buildings)
        {
            Buildings = buildings;
        }
    }
}