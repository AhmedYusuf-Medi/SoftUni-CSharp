using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
    {
        public T Text { get; private set; }


        public Box(T input )
        {
            this.Text = input;
        }
        public override string ToString()
        {
            return $"{this.Text.GetType()}: {this.Text}";
        }
    }
}
