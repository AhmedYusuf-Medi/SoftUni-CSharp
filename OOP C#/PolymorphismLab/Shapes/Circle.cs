using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get => this.radius;
            private set 
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Radius cannot be negative or zero");
                }
                this.radius = value;
            }
        }
        public override double CalculateArea()
        {
            double result = Math.PI * Math.Pow(this.Radius , 2);

            return result;
        }

        public override double CalculatePerimeter()
        {;
            double perimeter = 2 * this.Radius * Math.PI;

            return perimeter;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
