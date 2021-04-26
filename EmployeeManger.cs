using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_T02_HOL_005
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeManger
    {
        private readonly List<Employee> employees;
        public int HeadCount { get; set; }

        public EmployeeManger()
        {
            employees = new List<Employee>();
            HeadCount = employees.Count();
        }
        public void AddEmployee(Employee empObj)
        {
            employees.Add(empObj);
            HeadCount++;
        }
    }
}
