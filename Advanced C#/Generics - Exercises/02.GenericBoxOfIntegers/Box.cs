using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfIntegers
{
    public class Box<T>
    {
        public T Number { get; set; }

        public Box(T number)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{Number.GetType()}: {this.Number}";
        }
    }
}
