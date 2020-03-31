using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_11_Advanced_OO_Topics
{

    /* Lesson 126 inheritence example p2
     * Often we don't want users to be able to instantiate the base class but just the inheriting class
     * Lesson 127 Abstract classes
     * Lesson 128 Abstract methods
     * Lesson 129 composition
     * Lesson 130 Protected keyword
     * 
     */
    [TestClass]
    public class InheritenceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           // Person p = new Person("1234", "Wilfington", "Wilfer", 16);
          //   Student stu = new Student("1264", "suoking", "changMai", 16, "Politics", "69");   // added a DateTime object to the constructor so this won't work any more
            string exercise = stu.ExerciseHabits();
        }

        [TestMethod]
        public void Composition_Test()
        {
            // in order to use an object in a class we have to instantiate the object and pass in that instantiation.
            DateTime dob = new DateTime(2002, 01, 22);
            Student stu = new Student("1264", "suoking", "changMai", 16, "Politics", "69", dob)
        }

        [TestMethod]
        public void Protected_Keyword_Test()
        {
            // in order to use an object in a class we have to instantiate the object and pass in that instantiation.
            DateTime dob = new DateTime(2002, 01, 22);
            Student stu = new Student("1264", "suoking", "changMai", 16, "Politics", "69", dob)
        }


    }
}
