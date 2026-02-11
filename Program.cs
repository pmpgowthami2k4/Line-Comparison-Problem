using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Line line1 = new Line(1, 2, 4, 6);
            Line line2 = new Line(1, 2, 4, 6);

            if (line1.Equals(line2))
            {
                Console.WriteLine("Both lines are equal.");
            }
            else
            {
                Console.WriteLine("Lines are not equal.");
            }
        }

    }
}
