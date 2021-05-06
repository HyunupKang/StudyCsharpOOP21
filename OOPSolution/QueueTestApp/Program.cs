using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 스택큐 로직 영역
            /*            Console.WriteLine("Queue Test");

                        Queue queue = new Queue();
                        queue.Enqueue(1);
                        queue.Enqueue(2);
                        queue.Enqueue(3);
                        queue.Enqueue(4);
                        queue.Enqueue(5);

                        Console.WriteLine("DeQueue");

                        while (queue.Count > 0)
                        {
                            Console.Write(queue.Dequeue() + "\t");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Stack Test");
                        Stack stack = new Stack();

                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        Console.WriteLine("Pop");

                        while (stack.Count > 0)
                        {
                            Console.Write($"{stack.Pop()}\t");
                        }
                        Console.WriteLine();*/
            #endregion

            Hashtable dictionary = new Hashtable();
            dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";

            Console.WriteLine(dictionary["tweet"]);

            
        }
    }
}
