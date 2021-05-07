using System;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            int[] array = new int[5];

            for (int i= 0; i <= 5; i++)
            {
                try
                {
                    array[i] = (i + 1);
                }
                catch (Exception ex)// Exception 클래스
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("다른 로직 수행");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] list = { 107, 108, 109 };
            try
            {
                string message = null;
                Console.WriteLine(message.Length);
                var result = list[1] / 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                //indexOutOfRange예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!!");


            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("입력좀 제대로 해라!!");
            }

            Console.WriteLine("프로그램 종료");
        }
    }
}
