using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;
        private string position;

        // Default contructor
        public Employee() { }

        // Contructor that adds values to the class object
        public Employee(string firstName, string lastName, double salary, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.position = position;
        }

        // Grabs the first name of the object of the Employee class
        public string getFirstName()
        {
            return this.firstName;
        }

        // Grabs the last name of the Employee object
        public string getLastName()
        {
            return this.lastName;
        }

        // Grabs the salary of the Employee object
        public double getSalary()
        {
            return this.salary;
        }

        // Grabs the position of the Employee object
        public string getPosition()
        {
            return this.position;
        }
    }
}
