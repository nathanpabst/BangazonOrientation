using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation.Employees
{
    public class Employee
    {
        public string First { get; }
        public string Last { get; }

        public Employee(string first, string last)
        {
            First = first; 
            Last = last;
        }
    }

}
