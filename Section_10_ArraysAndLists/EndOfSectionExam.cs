using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Section_10_ArraysAndLists
{
    [TestClass]
    public class EndOfSectionExam
    {
        [TestMethod]
        public void TestMethod1()
        {
            // create the list
            ArrayList dataList = new ArrayList();
            dataList.Add("someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Vegan soup");
            dataList.Add(18M);
            dataList.Add("woof woof");
            dataList.Add(14);
;
            // pass thie list into a method
            RemoveNonValidNumericData(dataList);


        }
        [TestMethod]
        public void RemoveNonValidNumericData(ArrayList dataList)
        {
           

            
            // test to see if it can be converted to an int
          //  foreach(int data in dataList)
          for(int i = 0; i<12;i++)
            {
                // create an array to hold the integers then add them to an arrayList
                int[] intArray = new int[12];
                ArrayList intList = new ArrayList();

                // populate the array from the list
              

            

/*              //  int number;
                if (typeof(int) == intArray[i].GetType)
                {
                    // if its an int create a new arrayList
                    intList.Add(data);
                    Console.Write("intList: {0}", data);
                }
                */


            //    bool intSuccess = int.TryParse(data, out number);

            }


            // test to see if it can be converted to a float

            // test to see if it can be converted to a double

            // test to see if it can be converted to a decimal

        }
    }
}
