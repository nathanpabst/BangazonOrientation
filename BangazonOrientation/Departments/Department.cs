using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation
{
    class Department
    {
        private float hourlyRate;
        private int hWorked;

        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
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

        //public override string ToString()
        //{
        //    return $"{_name} {_supervisor} {_employee_Count}";
        //}

        public virtual void CalculatePayroll()
        {
            Console.WriteLine("Calculating Payroll...");

            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay * _employee_Count;


        }

    }
   
}
