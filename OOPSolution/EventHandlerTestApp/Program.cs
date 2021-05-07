using System;

namespace EventHandlerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9!");

            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappene += new EventHandler(MyHandler); // 이벤트가 일어났을때 MyHandler에게 일을 던져준다.

            for (int i = 1; i <= 100; i++)
            {
                notifier.DoSomething(i);
            }
        }

        private static void MyHandler(string message)
        {
            Console.Write(message);
        }
    }
}
