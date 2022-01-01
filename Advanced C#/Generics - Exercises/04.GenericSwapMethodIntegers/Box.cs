using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {

        public T Number { get; set; }

        public Box(T value)
        {
            this.Number = value;
        }

        public override string ToString()
        {
            return $"{this.Number.GetType()}: {Number}";
        }
    }
}
