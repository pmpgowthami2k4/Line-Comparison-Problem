using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Line line1 = new Line(1, 2, 4, 6);   // Length = 5
            Line line2 = new Line(0, 0, 3, 4);   // Length = 5

            int result = line1.CompareTo(line2);

            if (result == 0)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else if (result > 0)
            {
                Console.WriteLine("Line 1 is longer than Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is shorter than Line 2.");
            }
        }


    }
}
