using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation
{
    class Department
    {       
        public string DepartmentName { get; private set; }

        private string _name;
        private string _supervisor;
        private int _employee_Count;

        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_Count = employees;

        }

        public override string ToString()
        {
            return $"Department Name: {_name} Supervisor: {_supervisor} Number of Employees {_employee_Count}";
        }

        public virtual void CalculatePayroll()
        {
            


        }

    }
   
}
