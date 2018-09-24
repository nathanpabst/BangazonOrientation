using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation.Departments
{
    class HumanResources : DepartmentBase
    {
        
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public int Employees { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();
        private Dictionary<string, string> _training = new Dictionary<string, string>();

        public HumanResources(string name, string supervisor, int employees) : base(name, supervisor, employees) { }

        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);
            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"Our new policy: {policy.Value}");
            }

        }

        public void AddTraining(string title, string text)
        {
            _training.Add(title, text);
            foreach (KeyValuePair<string, string> training in _training)
            {
                Console.WriteLine($"Our new training session: {training.Value}");
            }
        }

        
    }
}
