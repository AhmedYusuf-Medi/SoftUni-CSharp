﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> 
        where T: IComparable
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

    }
}
