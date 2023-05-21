using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class CheckEquality
    {
       public void CheckEqualit()
        {
            Console.WriteLine("Enter the coordinates of the endpoints for Line 1:");
            double x1Line1 = Convert.ToDouble(Console.ReadLine());
            double y1Line1 = Convert.ToDouble(Console.ReadLine());
            double x2Line1 = Convert.ToDouble(Console.ReadLine());
            double y2Line1 = Convert.ToDouble(Console.ReadLine());

            // Input the coordinates of the endpoints for the second line
            Console.WriteLine("Enter the coordinates of the endpoints for Line 2:");
            double x1Line2 = Convert.ToDouble(Console.ReadLine());
            double y1Line2 = Convert.ToDouble(Console.ReadLine());
            double x2Line2 = Convert.ToDouble(Console.ReadLine());
            double y2Line2 = Convert.ToDouble(Console.ReadLine());

            // Check equality of the two lines based on their endpoints
            bool areEqual = x1Line1 == x1Line2 && y1Line1 == y1Line2 && x2Line1 == x2Line2 && y2Line1 == y2Line2;

            Console.WriteLine("Lines are" + (areEqual ? " " : " not ") + "equal.");
        }

    }
}


using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckEquality equalityChecker = new CheckEquality();


            equalityChecker.CheckEqualit();






        }
    }
}
