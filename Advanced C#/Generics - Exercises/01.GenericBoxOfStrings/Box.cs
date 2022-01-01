using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercises
{
    class Box <T>
    {
        public T Text { get; set; }

        public Box(T text)
        {
            this.Text = text;
        }

        public override string ToString()
        {
            return $"{Text.GetType()}: {Text}";
        }
    }
}
