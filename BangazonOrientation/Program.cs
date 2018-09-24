using BangazonOrientation.Departments;
using System;
using System.Collections.Generic;
using BangazonOrientation.Employees;

namespace BangazonOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<DepartmentBase>();

            var hr = new HumanResources("Human Resources", "Amy Shumer", 42);
            var sales = new Sales("Sales", "Frank Ocean", 42);

            hr.AddPolicy("Attendance", "You better come to work!");
            hr.AddTraining("How to Sell Stuff & Things", "Do it...Do it.");
            departments.Add(hr);
            sales.Travel("Santa Monica", "get a tan");
            departments.Add(sales);


            foreach(var d in departments)
            Console.WriteLine($"{d.ToString()}");

            
            Console.ReadLine();
        }

    }
}
