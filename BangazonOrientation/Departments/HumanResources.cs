using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation.Departments
{
    class HumanResources : Department
    {
        public string Name { get; set; } = "Human Resources";
        public string Supervisor { get; set; } = "Bob Lablaw";
        public int Employees { get; set; } = 15;

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {

        }

        
        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);
            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }
        }

        //public string toString()
        //{
            //return ($"{_name} {_supervisor} {_employees}"); 
        
        //}
    }
}
