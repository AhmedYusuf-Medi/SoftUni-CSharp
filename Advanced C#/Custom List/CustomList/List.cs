using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class List
    {
        private const int InitialCapacity = 2;

        private int[] Array;

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
        public List()
        {
            this.Array = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        private void ValidateIndex(int index)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid input index!");
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
        private void Shrink()
        {
            //creating Array twice smaller
            int[] newArray = new int[this.Array.Length / 2];

            //filing newArray with currone
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.Array[i];
            }

            Array = newArray;

        }

        private void ShiftToLeft(int index)
        {
            //delete the index we wanted and shiffting Array to left
            for (int i = index; i < this.Count - 1; i++)
            {
                this.Array[i] = this.Array[i + 1];
            }
        }
        private void ShiftToRight(int index)
        {
            //adding the number we wanted and shiffting Array to right

            for (int i = Count; i > index; i--)
            {
                this.Array[i] = this.Array[i - 1];
            }
        }
        public void Add(int number)
        {
            if (this.Count == this.Array.Length)
            {
                this.ReSize();
            }
            this.Array[this.Count] = number;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);

            int numberToRemove = this.Array[index];
            this.Array[index] = default(int);
            this.ShiftToLeft(index);

            this.Array[Count - 1] = default;
            this.Count--;

            if (this.Count <= this.Array.Length / 4)
            {
                this.Shrink();
            }

            return numberToRemove;
        }

        public void Insert(int index, int number)
        {
            this.ValidateIndex(index);

            if (this.Count == this.Array.Length)
            {
                this.ReSize();
            }

            this.ShiftToRight(index);
            this.Array[index] = number;
            this.Count++;
        }

        public void Swap(int firstIndex, int secIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secIndex);

            //Bitwise
            this.Array[firstIndex] = this.Array[firstIndex] ^ this.Array[secIndex];
            this.Array[secIndex] = this.Array[firstIndex] ^ this.Array[secIndex];
            this.Array[firstIndex] = this.Array[firstIndex] ^ this.Array[secIndex];
        }

        public bool Contains(int inputedNumber)
        {
            for (int i = 0; i < this.Array.Length; i++)
            {
                int currNum = this.Array[i];
                if (currNum == inputedNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currNum = this.Array[i];
                action(currNum);
            }
        }

        public void PrintListInNewLine(List list)
        {
            list.ForEach(n => Console.WriteLine(n));
        }
        public void PrintListInOneLine(List list)
        {
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        }
        public void MySelect(Func<int,int> func)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currNum = this.Array[i];
                int a = func(currNum);
                this.Array[i] = a;
            }
        }
        public void Reverse()
        {
            for (int i = 0; i < Count / 2; i++)
            {
                int temp = this.Array[i];
                Array[i] = Array[Count - i - 1];
                Array[Count - i - 1] = temp;
            }
        }

        public int ReturnCount()
        {
            return Count;
        }

    }
}
