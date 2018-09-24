using System;
using System.Collections.Generic;
using System.Text;
using BangazonOrientation.Employees;

namespace BangazonOrientation.Departments
{
    public class DepartmentBase
    {       
        string _name;
        string _supervisor;
        int _employee_Count;

        public DepartmentBase(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_Count = employees;

        }

        public List<Employee> Employees { get; } = new List<Employee>();

        public override string ToString() => $"{_name} {_supervisor} {_employee_Count}";
        
        public virtual void Hire(Employee employee) => Employees.Add(employee);

        public void Fire(Employee employee) => Employees.Remove(employee);

        public void ShowCurrentEmployees()
        {
            foreach(var emp in Employees)
            Console.WriteLine($"{emp.First} {emp.Last}");
        }

    }
   
}
