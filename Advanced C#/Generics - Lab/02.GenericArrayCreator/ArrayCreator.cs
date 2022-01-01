using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] itemArray = new T[length];

            for (int i = 0; i < itemArray.Length; i++)
            {
                itemArray[i] = item;
            }

            return itemArray;
        }
    }
}
