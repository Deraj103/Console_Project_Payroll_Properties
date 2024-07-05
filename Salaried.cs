using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Payroll_Properties
{
    internal class Salaried : Employee
    {
        //auto-implemented property
        private decimal AnnualSalary { get; set; }
        // constructor
        public Salaried(string fName, string lName, int empID, decimal aSalary)
            : base(fName, lName, empID)
        {
            AnnualSalary = aSalary;
        }
        // inherited abstract method
        public override decimal Earnings()
        {
            totalPay += AnnualSalary / 52;
            return AnnualSalary / 52;
        }
        // tostring method
        public override string ToString()
        {
            return $"{base.ToString()} salaried, {AnnualSalary:C} annual" + $"\n\tweekly earnings: {Earnings():C}";
        }
    }
}
