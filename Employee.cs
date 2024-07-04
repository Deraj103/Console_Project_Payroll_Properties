using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Payroll_Properties
{
    class Employee
    {
        // auto-implemented properties
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int EmployeeID { get; set; }
        // constructor
        public Employee(string fName, string lName, int empID)
        {
            FirstName = fName;
            LastName = lName;
            EmployeeID = empID;
        }
        // tostring method
        public override string ToString()
        {
            return ($"Employee {EmployeeID}: {FirstName} {LastName}, ");
        }
    }
}
