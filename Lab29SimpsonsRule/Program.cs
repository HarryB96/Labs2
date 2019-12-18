using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab29SimpsonsRule
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class SimpsonsRule
    {
        /*
         Graph of y = x^2
         points n = 0,1,2,,3,4,5,6 (value of x)
         Goal Approximate area under graph
         Simpson's Rule:

        Area = ((max x - min x)/3n) * (first y + last y + 4(sum of odd index items) + 2(sum of even index items))
         */
        public double GetAreaUnderGraphSquared(int n, int min, int max)
        {
            // n=6, min=0, max=6, difference =(max-min/n)

            //sums of odd and even indexes
            double sumOdd = 0;
            double sumEven = 0;
            int deltaX = max - min;

            //list of y values
            List<double> yValues = new List<double>();

            //Numbers in x range
            IEnumerable<int> xValues = Enumerable.Range(min, n + 1);

            //calculating y values foreach x
            foreach (var x in xValues)
            {
                double y = Math.Pow(x, 2);
                yValues.Add(y);
            }

            //finding the sum of odd and even indexes
            for (int i =1; i<n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += yValues[i];
                }
                else
                {
                    sumOdd += yValues[i];
                }
            }

            //Clacluating area
            double Area = ((deltaX / n) * (yValues[0] + yValues[n] + 4 * (sumOdd) + 2 * (sumEven))) / 3;

            return Area;
        }

        public double GetAreaUnderGraphCubed(int n, int min, int max)
        {
            // n=6, min=0, max=6, difference =(max-min/n)

            //sums of odd and even indexes
            double sumOdd = 0;
            double sumEven = 0;
            int deltaX = max - min;

            //list of y values
            List<double> yValues = new List<double>();

            //Numbers in x range
            IEnumerable<int> xValues = Enumerable.Range(min, n + 1);

            //calculating y values foreach x
            foreach (var x in xValues)
            {
                double y = Math.Pow(x, 3);
                yValues.Add(y);
            }

            //finding the sum of odd and even indexes
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += yValues[i];
                }
                else
                {
                    sumOdd += yValues[i];
                }
            }

            //Clacluating area
            double Area = ((deltaX / n) * (yValues[0] + yValues[n] + 4 * (sumOdd) + 2 * (sumEven))) / 3;

            return Area;
        }
    }
}
