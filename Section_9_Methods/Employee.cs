using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Classes_And_Methods
{
    /* Lesson 100 Overloading
     * 
     * 
     */

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

        // constructor 1
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

        // constructor 2
        public Employee (string firName, string lasName)
        {
            FirstName = firName;
            LastName = lasName;
        }

        public int EmployeeNum
        {
            get
            {
                return employeeNum;
            }

            set
            {
                employeeNum = value;
            }   
                
              
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
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

        // methods
        public string FirstName_LastName()
        {
           /*
            string fName = FirstName;
            string lName = LastName;
            return fName + " " + lName;
            */

            // teacher did this
            return FirstName + " " + LastName;  // calling the getters directly which is more efficient!!

        }
        public string SortingName()
        {
            string fName = FirstName;
            string lName = LastName;
            return lName + ", " + fName;
        }
        public string JobLocation()
        {
            if (JobDescription == "manager")
            {
                return "Boston";
            }
            else if (JobDescription == "staff")
            {
                return "Chicago";
            }
            return "New York";
        }
        // because we are overriding the ToString method (from base class Object) when we call Console.WriteLine(<instantiationName>) 
        // it will use this format below
        public override string ToString()
        {
            return EmployeeNum + " " + FirstName + " " + " Job Description: " + JobDescription;
        }

        // *****************************************  overloaded methods    ******************************************************

        public String PayType(string title)
        {
            if(JobDescription == "Manager")
            {
                return "Salary";
            }
            else if(JobDescription == "staff")
            {
                return "Hourly";
            }
            return "Hourly";
        }

        public String PayType(int id)
        {
            if(EmployeeNum == 1234)
            {
                return "Salary";
            }
            else if(EmployeeNum == 123)
            {
                return "Hourly";
            }
            return "Hourly";
        }

    }
}
