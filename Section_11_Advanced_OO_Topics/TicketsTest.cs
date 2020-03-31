using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_11_Advanced_OO_Topics
{
    [TestClass]
    public class TicketsTest
    {
        [TestMethod]
        public void Musical_Test()
        {
            DateTime theDate = new DateTime(2020, 07, 07);
            Musical music = new Musical("24", "B", theDate, "19:30","Wangmaster Hall", "Les Miserables", 14.50M, "Woofington House Musical Company");            
            Console.WriteLine(music);
        }

        [TestMethod]
        public void PlayTest()
        {
            DateTime theDate = new DateTime(2020, 03, 17);
            Play play = new Play("24", "B", theDate, "19:30", "Wangmaster Hall", "To Woof a Mockingbird", 14.50M,"James Abraham", "Woofington House Theatre Company");
            Console.WriteLine(play);
        }
        [TestMethod]
        public void LectureTest()
        {
            DateTime theDate = new DateTime(2020, 02, 19);
            Lecture lecture = new Lecture("27", "G", theDate, "9:30", "Wangmaster Hall", "Why trans women are not women", 70M, "Proffesor Jorden B Peterson");
            Console.WriteLine(lecture);
        }
    }
}
