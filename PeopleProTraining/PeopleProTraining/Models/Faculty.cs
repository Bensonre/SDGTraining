using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PeopleProTraining.Models
{
    public class Faculty
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Department_Name { get; set; }

        public int Department_ID { get; set; }

        private PeopleProTrainingContext db = new PeopleProTrainingContext();

        public void Set_Department_Name(string D_Name)
        {
            this.Department_Name = D_Name;
            AutoSet_Department_ID(D_Name);
            return;
        }

        private void AutoSet_Department_ID(string D_Name)
        {
            List<Department> departments = db.Departments.ToList();

            for (int i = 0; i < departments.Count(); i++)
            {
                if (departments[i].Name == D_Name)
                {
                    this.Department_ID = departments[i].ID;
                }
            }
            return;
        }


    }
        
        
}