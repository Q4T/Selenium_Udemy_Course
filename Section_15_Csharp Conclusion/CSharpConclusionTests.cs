using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Section_15_Csharp_Conclusion
{
    [TestClass]
    public class CSharpConclusionTests

    {
        [TestMethod]
        public void SingleFamilyTest()
        {
            // string theAddress, string typeOfConstr, string yrBuilt, decimal rentAmnt, int sqrtFt, string bedNum, string bathNum, bool porch, bool garage)

            SingleFamily sFam1 = new SingleFamily("1 woofington Cresent", "2 Story Brick", "1950",100.00M, 500, "3", "1", true,true);
            SingleFamily sFam2 = new SingleFamily("2 woofington Cresent", "3 Story Brick", "1952", 300.00M, 500, "5", "1", true, false);
            SingleFamily sFam3 = new SingleFamily("3 woofington Cresent", "2 Story Brick", "1950", 100.50M, 500, "3", "1", false, true);
            SingleFamily sFam4 = new SingleFamily("4 woofington Cresent", "2 Story Brick", "1950", 200.00M, 600, "3", "1", true, false);
            SingleFamily sFam5 = new SingleFamily("5 woofington Cresent", "3 Story Brick", "2000", 900.00M, 500, "5", "4", true, true);

            // put the objects into a list and loop trhough then print out each one using ToString
            ArrayList sFam = new ArrayList();
            sFam.Add(sFam1);
            sFam.Add(sFam2);
            sFam.Add(sFam3);
            sFam.Add(sFam4);
            sFam.Add(sFam5);

            foreach(var item in sFam)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(" ");
                
            }
        }

        [TestMethod]
        public void MultiUnitTests()
        {
            // same as above
            // string theAddress, string typeOfConstr, string yrBuilt, string cmplxName, int numUnits, decimal rentPerUnit
            MultiUnit mUnit1 = new MultiUnit("1 Barkington Towers", "DogHouse", "2020","Barkersville",20,500);
            MultiUnit mUnit2 = new MultiUnit("2 Barkington Towers", "DogHouse", "2020", "Barkersville", 22, 500);
            MultiUnit mUnit3 = new MultiUnit("3 Barkington Towers", "DogHouse", "2020", "Barkersville", 43, 68);
            MultiUnit mUnit4 = new MultiUnit("4 Barkington Towers", "DogHouse", "2020", "Barkersville", 66, 444);
            MultiUnit mUnit5 = new MultiUnit("5 Barkington Towers", "DogHouse", "2020", "Barkersville", 44, 666);

            ArrayList mUnitLst = new ArrayList();
            mUnitLst.Add(mUnit1);
            mUnitLst.Add(mUnit2);
            mUnitLst.Add(mUnit3);
            mUnitLst.Add(mUnit4);
            mUnitLst.Add(mUnit5);

            foreach(var item in mUnitLst)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(" ");
            }
        }

        [TestMethod]
        public void CombinedTest()
        {
            //take the 5 objects of each type from above and create a list <Housing> 
            SingleFamily sFam1 = new SingleFamily("1 woofington Cresent", "2 Story Brick", "1950", 100.00M, 500, "3", "1", true, true);
            SingleFamily sFam2 = new SingleFamily("2 woofington Cresent", "3 Story Brick", "1952", 300.00M, 500, "5", "1", true, false);
            SingleFamily sFam3 = new SingleFamily("3 woofington Cresent", "2 Story Brick", "1950", 100.50M, 500, "3", "1", false, true);
            SingleFamily sFam4 = new SingleFamily("4 woofington Cresent", "2 Story Brick", "1950", 200.00M, 600, "3", "1", true, false);
            SingleFamily sFam5 = new SingleFamily("5 woofington Cresent", "3 Story Brick", "2000", 900.00M, 500, "5", "4", true, true);
            MultiUnit mUnit1 = new MultiUnit("1 Barkington Towers", "DogHouse", "2020", "Barkersville", 20, 500);
            MultiUnit mUnit2 = new MultiUnit("2 Barkington Towers", "DogHouse", "2020", "Barkersville", 22, 500);
            MultiUnit mUnit3 = new MultiUnit("3 Barkington Towers", "DogHouse", "2020", "Barkersville", 43, 68);
            MultiUnit mUnit4 = new MultiUnit("4 Barkington Towers", "DogHouse", "2020", "Barkersville", 66, 444);
            MultiUnit mUnit5 = new MultiUnit("5 Barkington Towers", "DogHouse", "2020", "Barkersville", 44, 666);

            ArrayList housing = new ArrayList();
            housing.Add(sFam1);
            housing.Add(sFam2);
            housing.Add(sFam3);
            housing.Add(sFam4);
            housing.Add(sFam5);
            housing.Add(mUnit1);
            housing.Add(mUnit2);
            housing.Add(mUnit3);
            housing.Add(mUnit4);
            housing.Add(mUnit5);
          
            // loop trhough each and print addresses and projected rental amount
            foreach (Housing house in housing)
            {
                Console.WriteLine(house.Address);
                Console.WriteLine(house.ProjectedRentalAmt().ToString("c"));
                Console.WriteLine(" ");
            }   
        }
    }
}
