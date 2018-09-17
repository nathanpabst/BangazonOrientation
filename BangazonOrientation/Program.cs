using BangazonOrientation.Departments;
using System;
using System.Collections.Generic;

namespace BangazonOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department departments = new Department("Human Resources", "Amy Shumer", 42);

            Console.WriteLine(departments.ToString());

            

            Console.ReadLine();
        }

    }
}
