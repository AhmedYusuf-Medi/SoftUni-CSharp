using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddFirst(Node currHead)
        {
            if (Head == null)
            {
                Head = currHead;
                Tail = currHead; 
            }
            else
            {
                currHead.Next = Head;
                Head.Previous = currHead;
                Head = currHead;
            }
        }

        public void AddLast(Node currTail)
        {
            if (Tail == null)
            {
                Tail = currTail;
                Head = currTail;
            }
            else
            {
                currTail.Previous = Tail;
                Tail.Next = currTail;
                Tail = currTail;

            }
        }

        public Node RemoveFirst()
        {
            Node oldHead = this.Head;
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            Node oldTail = this.Tail;
            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
            return oldTail;
        }

        public void ForEach(Action<Node> action)
        {
            var currNode = this.Head;
            while (currNode != null)
            {
                action(currNode);
                currNode = currNode.Next;
            }
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(n => list.Add(n));
            return list.ToArray();
        }

        public void ReverseForeach(Action<Node> action)
        {
            var currNode = this.Tail;
            while (currNode != null)
            {
                action(currNode);
                currNode = currNode.Previous;
            }
        }

        public void ReversePrintList()
        {
            this.ReverseForeach(n => Console.WriteLine(n.Value));
        }

        public void PrintList()
        {
            this.ForEach(n => Console.WriteLine(n.Value));
        }
        public void PrintOddNumbers()
        {
            Console.WriteLine("Odd numbers");
            this.ReverseForeach(n =>
            {
                if (n.Value % 2 == 1)
                {
                    Console.WriteLine(n.Value);
                }
            }
            );
        }

        public void PrintEvenNumbers()
        {
            Console.WriteLine("Even numbers");
            this.ForEach(n =>
            {
                if (n.Value % 2 == 0)
                {
                    Console.WriteLine(n.Value);
                }
            }
            );
        }

        public bool Cointains(int value)
        {
            bool isFound = false;
            ForEach(n =>
            {
                if (n.Value == value)
                {
                    isFound = true;
                }
                
            });
            return isFound;
        }

        public bool RemoveInputValue(int value)
        {
            Node currNode = Head;
            while (currNode !=null)
            {
                if (currNode.Value == value)
                {
                    currNode.Previous.Next = currNode.Next;
                    currNode.Next.Previous = currNode.Previous;
                    return true;
                }
            }

            return false;
        }

       
    }
}
