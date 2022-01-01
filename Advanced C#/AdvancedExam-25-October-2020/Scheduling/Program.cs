using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> tasks = new Stack<int>(Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int taskToDo = int.Parse(Console.ReadLine());

            int threadThatFailed = 0;

            while (true)
            {
                //if (threads.Count < 0)
                //{
                //    break;
                //}
                int thread = threads.Peek();
                int task = tasks.Peek();

                if (task == taskToDo)
                {
                    threadThatFailed = thread;
                    break;
                }
                else if (thread >= task)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (thread < task)
                {
                    threads.Dequeue();
                }
            }

            if (threadThatFailed != 0)
            {
                Console.WriteLine($"Thread with value {threadThatFailed} killed task {taskToDo}");
            }

            if (threads.Count != 0)
            {
                Console.WriteLine(string.Join(' ', threads));
            }


        }
    }
}
