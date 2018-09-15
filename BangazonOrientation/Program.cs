using BangazonOrientation.Departments;
using System;
using System.Collections.Generic;

namespace BangazonOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            HumanResources hr = new HumanResources("HR", "Amy Shumer", 2);

            departments.Add(hr);
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.ToString()}");
            }

            Console.ReadLine();
        }

    }
}
