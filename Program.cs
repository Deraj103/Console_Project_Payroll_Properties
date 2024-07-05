using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Payroll_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Console Project Payroll with Properties\n");
            // array initialization
            Employee[] empArray = new Employee[4];
            empArray[0] = new Salaried("Jared", "Tims", 963, (decimal)69000);
            empArray[1] = new Hourly("Harold", "Henderson", 852, (decimal)18.75, (decimal)40.0);
            empArray[2] = new Hourly("Matthew", "Matterdome", 741, (decimal)20.50, (decimal)45.0);
            empArray[3] = new Salaried("Daril", "Druffs", 654, (decimal)100000);
            // foreach loop to cycle through the employee array
            foreach (Employee emp in empArray)
            {
                WriteLine(emp.ToString());
            }

            WriteLine($"\nTotal Pay: {Employee.totalPay:C}");

            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
