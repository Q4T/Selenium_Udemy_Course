using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_Advanced_OO_Topics   // public vars can be seen in this namespace
{
    /* Lesson 125 inheritence example
     * Lesson 128 Abstract methods
     * 
     */

    abstract class Person
    {
        private string idNumber;   // private vars can only be seen in this class  // these are known as members - the variables
        private string lastName;        // these are known as members
        private string firstName;       // these are known as members
        private int age;                // these are known as members
        private DateTime dateOfBirth;    // members can also be objects like DateTime

        public Person()  // public vars can be seen in this namespace
        {

        }

        public Person(string id,string lName, string fName, int anAge, DateTime dob)
        {
            // not using accessors here just setting to private varaibles
            idNumber = id;
            lastName = lName;
            firstName = fName;
            age = anAge;
            dateOfBirth = dob;
        }

        public abstract string ExerciseHabits();   // abstract method
    }
}
