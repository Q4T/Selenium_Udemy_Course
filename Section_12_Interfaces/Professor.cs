using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_Interfaces
{
    // lesson 142 Implemeting Interfaces

    class Professor : Person, ITraveler
    {
        private string employeeId;
        private string teachingSubject;

        public Professor(string id, string lName, string fName, int anAge, DateTime dob, string empId, string subject)
    : base(id, lName, fName, anAge, dob)   // we use :base() to passs in the members to the base class 
        {
            EmployeeId = empId;
            TeachingSubject = subject;

        }

        public string EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        public string TeachingSubject
        {
            get
            {
                return teachingSubject;
            }
            set
            {
                teachingSubject = value;
            }
        }

        public override string ExerciseHabits()
        {
            return "25 miles a day";
        }

        public double DetermineMiles()
        {
            return 15.0;
        }

        public string GetDestination()
        {
            return "Work";
        }

        public string getStartLocation()
        {
            return "proffessor Home";
        }


    }
}
