using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class Stack
    {
        private const int InitialCapacity = 4;
        private int count;
        private int[] Array;

        public int Count { get { return this.count; } }
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.Array[index];
            }
            set
            {
                ValidateIndex(index);
                this.Array[index] = value;
            }

        }
        public Stack()
        {
            this.count = 0;
            this.Array = new int[InitialCapacity];
        }
        private void ValidateIndex(int index)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid input index!");
            }

        }
        private void ValidateLength(int length)
        {
            if (this.Array.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty");
            }
        }
        private void ReSize()
        {
            //creating Array with twice longer length
            int[] newArray = new int[this.Array.Length * 2];

            //filling newArray with the currOne
            for (int i = 0; i < this.Array.Length; i++)
            {
                newArray[i] = this.Array[i];
            }

            this.Array = newArray;
        }
        public void Push(int number)
        {
            if (this.Array.Length == this.count)
            {
                this.ReSize();
            }
            this.Array[this.count] = number;
            count++;
        }

        public int Pop()
        {
            ValidateLength(this.Array.Length);

            int lastIndex = this.count - 1;
            int last = this.Array[lastIndex];
            this.count--;

            return last;
        }

        public int Peek()
        {
            ValidateIndex(this.Array.Length);
            int lastIndex = this.count - 1;

            return this.Array[lastIndex];
        }

        public void ForEach(Action<Object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.Array[i]);
            }
        }

    }
}
