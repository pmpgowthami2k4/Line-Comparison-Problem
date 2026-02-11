using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            // Creating a line with two points
            Line line = new Line(1, 2, 4, 6);

            // Calculating length
            double length = line.CalculateLength();

            Console.WriteLine("Length of the Line is: " + length);
        }
    }
}
