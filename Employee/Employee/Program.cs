using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Rodrigo", "Alvarez", 80000, "Software Engineer");

            Console.WriteLine("Here is the employee object: " + employee.getFirstName() + " " + employee.getLastName() + " " + employee.getSalary().ToString("C", CultureInfo.CurrentCulture) + " " + employee.getPosition());
            Console.ReadLine();
        }
    }
}
