using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class CustomTuple<T1,T2>
    {
        public T1 item1 { get; set; }
        public T2 item2 { get; set; }

        public CustomTuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2}"; 
        }
    }
}
