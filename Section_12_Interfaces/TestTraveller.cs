using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_12_Interfaces
{
    [TestClass]
    public class TestTraveller
    {
        [TestMethod]
        public void Test_Traveller()
        {                                  // (string id, string lName, string fName, int anAge, DateTime dob, string empId, string subject
            DateTime DateOfBirth = new DateTime(1962, 07, 07);
            DateTime DateOfBirth1 = new DateTime(1983, 02, 07);
            DateTime DateOfBirthstu1 = new DateTime(2010, 12, 07);
            DateTime DateOfBirthstu2 = new DateTime(2003, 06, 07);

            Professor prof1 = new Professor("001", "Peterson", "Jordan", 58, DateOfBirth, "0001", "Pyschology");
            Professor prof2 = new Professor("002", "Duder", "Miss", 28, DateOfBirth1, "0014", "Media Studies");
            Student stu1 = new Student("005", "stoner", "Lazy", 18, "Dog Studies", "555", DateOfBirthstu1);
            Student stu2 = new Student("079", "NameSpacer", "Woofy", 18, "Media Studies", "385", DateOfBirthstu2);

            // create an array of objects
            Person[] ListOfPeople = new Person[4];
            // add each of the 4 objects created 
            ListOfPeople[0] = prof1;
            ListOfPeople[1] = prof2;
            ListOfPeople[2] = stu1;
            ListOfPeople[3] = stu2;
             
            foreach(Person aPerson in ListOfPeople)
            {
                Console.WriteLine(aPerson);
            }
        }
    }
}
