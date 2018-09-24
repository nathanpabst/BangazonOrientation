using System;
using System.Collections.Generic;
using System.Text;
using BangazonOrientation.Departments;

namespace BangazonOrientation.Departments
{
    public class Sales : DepartmentBase
    {
        public string Name { get; set; } = "Sales";
        public string Supervisors { get; set; } = "Nancy Reagan";
        public int Employees { get; set; } = 42;

        private Dictionary<string, string> _travel = new Dictionary<string, string>();
        private Dictionary<string, double> _sell = new Dictionary<string, double>();

        public Sales(string name, string supervisor, int employees) : base(name, supervisor, employees) { }

        public void Travel(string location, string notes)
        {
            _travel.Add(location, notes);
            foreach (KeyValuePair<string, string> local in _travel)
            {
                Console.WriteLine($"{local.Value}");
            }
        }

        public void Sell(string customer, double amount)
        {
            _sell.Add(customer, amount);
            foreach (KeyValuePair<string, double> cust in _sell)
            {
                Console.WriteLine($"{cust.Value}");
            }
        }
    }
}
