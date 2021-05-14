using System;

namespace LamdaTestApp
{
    class Program
    {
        delegate void DoSomething();

        static void Main(string[] args)
        {
            DoSomething Doit = () =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine("John Doe~! ");
            };
            Doit();
        }
    }
}