using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        public List<T> Items { get; private set; }
        public int Index { get; set; }
        public ListyIterator(List<T> items)
        {
            this.Items = items;
            this.Index = 0;
        }

        public ListyIterator()
        {
        }

        public bool HasNext()
        {
            if (ValidateIndex(this.Index, this.Items))
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (ValidateIndex(this.Index,this.Items))
            {
                this.Index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            IsArrayEmptyInPrint();
            Console.WriteLine(this.Items[Index]);
        }

        private void IsArrayEmptyInPrint()
        {
            if (this.Items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public static bool ValidateIndex(int index,List<T> items)
        {
            if (index <= items.Count)
            {
                return true;
            }

            return false;
        }
        


    }
}
