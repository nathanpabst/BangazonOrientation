using System;
using System.Collections.Generic;
using System.Text;

namespace BangazonOrientation
{
    class Department
    {
        private string _name;
        private string _supervisor;
        private int _employee_Count;

        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_Count = employees;

        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Hire()
        {
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }
    }
   
}
