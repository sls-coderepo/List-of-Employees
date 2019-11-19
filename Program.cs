using System;
using System.Collections.Generic;

namespace ListOfEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee()
            {
                FirstName = "Shirish",
                LastName = "Shrestha",
                Title = "CTO",
                StartDate = new DateTime(2015, 01, 02)

            };

            Employee employee2 = new Employee()
            {
                FirstName = "Shrijan",
                LastName = "Shrestha",
                Title = "Sales Manager",
                StartDate = new DateTime(2016, 01, 02)

            };

            Employee employee3 = new Employee()
            {
                FirstName = "Mrinav",
                LastName = "Shrestha",
                Title = "Hiring Manager",
                StartDate = new DateTime(2017, 08, 04)

            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            Company company = new Company("Ultra Tech Center", new DateTime(2015, 01, 02));
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);

            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.CompanyName} as a {employee.Title} since {employee.StartDate}");
            }

        }
    }
}