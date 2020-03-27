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
            dataList.Add("wibble");
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

            ArrayList goodValues = CheckList(dataList);
           
            int sum = SumList(goodValues);

            Assert.AreEqual(147, sum);
        }
        public ArrayList CheckList(ArrayList list)
        {
            ArrayList goodVals = new ArrayList();

            foreach(var item in list) // we use var here becasue we have multiple tpyes, strings and ints.
            {
                int aValue;
                // here we get the item or element and convert it to a string first then see if it can be converted to an int. And if it can be it will return true.
                if(int.TryParse(Convert.ToString(item), out aValue) == true)
                {
                    // it can be converted to an int so add it to a new list.
                    goodVals.Add(aValue);   // pass in aValue which is the integer that has been made from the string
                }
            }
            return goodVals;
        }

        public int SumList(ArrayList list)
        {
            int sum = 0;
            foreach(int item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
