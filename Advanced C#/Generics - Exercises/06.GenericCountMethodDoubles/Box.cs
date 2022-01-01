using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDoubles
{
    class Box<T>
        where T: IComparable
    {
        public T Number { get; private set; }

        public Box(T value)
        {
            this.Number = value;
        }


    }
}
