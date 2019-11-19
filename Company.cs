using System;
using System.Collections.Generic;

namespace ListOfEmployees
{
    class Company
    {
        public DateTime ConpanyStartDate { get; }
        public string CompanyName { get; }
        public List<Employee> Employees { get; }

        public Company(string companyName, DateTime companyStartDate)
        {
            CompanyName = companyName;
            ConpanyStartDate = companyStartDate;
            Employees = new List<Employee>();
        }
    }
}