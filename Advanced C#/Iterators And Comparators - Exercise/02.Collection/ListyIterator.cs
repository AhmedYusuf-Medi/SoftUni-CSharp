using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
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

        public string PrintAll()
        {
            IsArrayEmptyInPrint();

            return string.Join(" ", this.Items);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var i in Items)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
       
    }
}
