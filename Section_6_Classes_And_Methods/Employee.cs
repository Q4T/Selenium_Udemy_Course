using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Classes_And_Methods
{
    class Employee
    {
        // vars
        private int employeeNum;
        private string firstName;
        private string lastName;
        private string dateOfHire;
        private string jobDescription;
        private string department;
        private decimal monthlySalary;

        // constructor
        public Employee(int empNum, string firName, string lasName, string DOFHire, string JobDesc, string dept, decimal MonthSalary)
        {
            EmployeeNum = empNum;
            FirstName = firName;
            LastName = lasName;
            DateOfHire = DOFHire;
            JobDescription = JobDesc;
            Department = dept;
            MonthlySalary = MonthSalary;
        }

        public Employee (string firName, string lasName)
        {
            FirstName = firName;
            LastName = lasName;
        }

        public int EmployeeNum
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string DateOfHire
        {
            get; set;
        }
        public string JobDescription
        {
            get; set;
        }
        public string Department
        {
            get; set;
        }
        public decimal MonthlySalary
        {
            get; set;
        }

        public string FirstName_LastName()
        {
            string fName = FirstName;
            string lName = LastName;
            return fName + " " + lName;
        }
        public string SortingName()
        {
            string fName = FirstName;
            string lName = LastName;
            return lName + ", " + fName;
        }
    }
}
