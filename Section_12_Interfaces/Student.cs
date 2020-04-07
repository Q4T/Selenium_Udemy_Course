using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_Interfaces
{
    // lesson 142 Implemeting Interfaces

    class Student : Person, ITraveler
    {

        private string major;
        private string studentId;

        public Student(string id, string lName, string fName, int anAge, string maj, string sId, DateTime dob)
            : base(id, lName, fName, anAge, dob)   // we use :base() to passs in the members to the base class 
        {
            major = maj;    // should be setting to public properties accossors but was lazy.
            studentId = sId;   // should be setting to public properties accossors but was lazy.
        }


        public override string ExerciseHabits()
        {
            return "5 miles a day";
        }

        public double DetermineMiles()
        {
            return 75.0;
        }

        public string GetDestination()
        {
            return "School";
        }

        public string GetStartLocation()
        {
            return "Home";
        }

        public DateTime GetDob()
        {
            // in order to access protected members (variables in the base class of type protected we use the keyword base
            return base.dateOfBirth;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nMiles: " + DetermineMiles() +
                "\nDestination: " + GetDestination() +
                "\nStarting from: " + GetStartLocation()+
                "\n";
        }

    }
}
