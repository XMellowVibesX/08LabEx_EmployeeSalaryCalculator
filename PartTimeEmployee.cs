using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string firstName, lastName, department, jobTitle;
        private double basicSalary;

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.jobTitle = jobTitle;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            this.basicSalary = hoursWorked * ratePerHour;
        }

        public double getBasicSalary()
        {
            return this.basicSalary;
        }

        // getters for the name
        public string getFirstName() { return this.firstName; }
        public string getLastName() { return this.lastName; }

    }
}
