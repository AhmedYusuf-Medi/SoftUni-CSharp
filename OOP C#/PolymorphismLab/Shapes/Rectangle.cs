using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double height,double width)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width 
        {
            get => this.width; 
            private set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Width parameter cannot be negative or zero!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set 
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Height parameter cannot be negative or zero!");
                }
                this.height = value;
            }
        }
        public override double CalculateArea()
        {
            double result = this.Width * this.Height;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * this.Width + 2 * this.Height;
            return perimeter;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
