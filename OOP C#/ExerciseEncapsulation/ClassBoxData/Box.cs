using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;


        public Box(double length, double width, double height)
        {
            this.Lenght = length;
            this.Width = width;
            this.Height = height;
        }
        private double Lenght
        {
            get => this.length;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        private double Width
        {
            get => this.width;

             set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        private double Height 
        {
            get => this.height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double Volume()
        {
            return this.Lenght * this.Width * this.Height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        }

        public double SurfaceArea()
        {
            return 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        }
    }
}
