using System;

namespace LineComparison
{
    internal class Line : IComparable<Line>

    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double CalculateLength()
        {
            double length = Math.Sqrt(
                Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2)
            );

            return length;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Line other = (Line)obj;

            return this.x1 == other.x1 &&
                   this.y1 == other.y1 &&
                   this.x2 == other.x2 &&
                   this.y2 == other.y2;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x1, y1, x2, y2);
        }

        public int CompareTo(Line other)
        {
            if (other == null)
                return 1;

            double thisLength = this.CalculateLength();
            double otherLength = other.CalculateLength();

            return thisLength.CompareTo(otherLength);
        }


    }
}
