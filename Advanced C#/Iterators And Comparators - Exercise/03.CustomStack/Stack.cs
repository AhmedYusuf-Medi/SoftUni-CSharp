using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {
        public List<T> items { get; set; }

        public Stack()
        {
            this.items = new List<T>();
        }

        public void Push(T item)
        {
            this.items.Add(item);          
        }

        private int Count => this.items.Count;

        public T Pop()
        {
            try
            {
                T lastitems = this.items[^1];
                items.RemoveAt(items.Count - 1);

                return lastitems;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("No element");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count -1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
