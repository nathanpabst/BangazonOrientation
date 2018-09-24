using BangazonOrientation.Departments;
using System;
using System.Collections.Generic;

namespace BangazonOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<DepartmentBase>();

            var hr = new HumanResources("Human Resources", "Amy Shumer", 42);

            hr.AddPolicy("Attendance", "You better come to work!");
            hr.AddTraining("How to Sell Stuff & Things", "Do it...Do it.");
            departments.Add(hr);

            foreach(var d in departments)
            Console.WriteLine($"{d.ToString()}");

            
            Console.ReadLine();
        }

    }
}
