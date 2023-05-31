using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Model
{
    public class Staff
    {
        private bool active1;
        private bool active2;

        public Staff(string iD, string name, int age, bool active)
        {
            ID = iD;
            Name = name;
            Age = age;
            Active = active;
        }

        public string ID { get; set; } = default;
        public string Name { get; set; } = default;
        public int Age { get; set; } = default;
        public bool Active { get; set; } = default;


        public void Update(Staff staff)
        {
            Name = staff.Name;
            Age = staff.Age;
            Active = staff.Active;
        }
    }
}
