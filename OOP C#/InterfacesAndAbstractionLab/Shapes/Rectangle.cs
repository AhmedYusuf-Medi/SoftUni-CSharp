using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int height,int width)
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            for (int row = 0; row < height; row++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
