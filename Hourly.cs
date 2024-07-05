using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Payroll_Properties
{
    internal class Hourly : Employee
    {
        // auto-implemented properties
        private decimal HourlyWage { get; set; }
        private decimal HoursWorked { get; set; }
        // constructor
        public Hourly (string fName, string lName, int empID, decimal hWage, decimal hWorked)
            : base (fName, lName, empID)
        {
            HourlyWage = hWage;
            HoursWorked = hWorked;
        }
        // inherited abstract method
        public override decimal Earnings()
        {
            decimal totalEarnings = 0;
            if (HoursWorked > 40)
            {
                decimal standardHours = 40;
                decimal OT = HoursWorked - 40;
                decimal OTRate = (HourlyWage * (decimal)1.5);
                decimal totalOTPay = OTRate * OT;
                totalEarnings = totalOTPay + (decimal)(standardHours * HourlyWage);
                totalPay += totalEarnings;
            }
            else
            {
                totalEarnings = (decimal)HoursWorked * HourlyWage;
                totalPay += totalEarnings;
            }

            return totalEarnings;
        }
        // tostring method
        public override string ToString()
        {
            return $"{base.ToString()} hourly, wage {HourlyWage:C}, hours worked {HoursWorked}" + $"\n\tweekly earnings: {Earnings():C}";
        }
    }
}
