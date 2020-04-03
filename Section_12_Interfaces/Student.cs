using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_Interfaces
{
    // lesson 142 Implemeting Interfaces

    class Student : Person
    {

        private string major;
        private string studentId;

        public Student(string id, string lName, string fName, int anAge, string maj, string sId, DateTime dob)
            : base(id, lName, fName, anAge, dob)   // we use :base() to passs in the members to the base class 
        {
            major = maj;
            studentId = sId;
        }


        public override string ExerciseHabits()
        {
            return "5 miles a day";
        }

        public DateTime GetDob()
        {
            // in order to access protected members (variables in the base class of type protected we use the keyword base
            return base.dateOfBirth;
        }
    }
}
