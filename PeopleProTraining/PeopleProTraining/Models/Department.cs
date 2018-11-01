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

        public Department()
        {
            ID = 0;
            Name = "\0";
            FacultyMembers = null;
        }

        public void addNewFacultyMember(Faculty faculty)
        {
            FacultyMembers.Add(faculty);
        }
        public void setFacultyMembers(List<Faculty> faculty)
        {
            FacultyMembers=faculty;
        }

    }
}