using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T first;
        private T sec;

        public EqualityScale(T first, T sec)
        {
            this.first = first;
            this.sec = sec;
        }

        public bool AreEquals()
        {
            return first.Equals(sec);
        }
    }
}
