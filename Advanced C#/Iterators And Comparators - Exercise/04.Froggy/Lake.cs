using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
       
    {
        public List<int> stones { get; set; }


        private int Count => this.stones.Count;
        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return stones[i];
            }

            int startOddIndex = this.Count - 1;
            if (startOddIndex % 2 == 0)
            {
                startOddIndex--; ;
            }
           
            for (int i = startOddIndex; i > 0; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
       
    }
}
