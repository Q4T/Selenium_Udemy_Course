using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_13_Exception_Handeling
{
    class BodyMassIndexCalculator
    {
        private int weight;
        private int heightInFeet;
        private int heightinInches;

        public BodyMassIndexCalculator()
        {

        }

        public  BodyMassIndexCalculator(int lbs, int ft, int inches)
        {
            weight = lbs;
            heightInFeet = ft;
            heightinInches = inches;
        }

        public double CalculateBMI()
        {
            return (weight * 703) / Math.Pow((heightInFeet * 12 + heightinInches), 2);
        }

        public override string ToString()
        {
            return "BMI: " + CalculateBMI().ToString("F2");
        }
    }
}
