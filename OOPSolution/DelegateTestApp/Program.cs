using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 일반적인 호출
            Calculator calc = new Calculator();
            Console.WriteLine($"3+5 = {calc.Plus(3,5)}");   // 결과를 돌려받음
            Console.WriteLine($"3+5 = {calc.Divide(3,5)}");

            //대리자 호출
            CalcDele callBack;
            callBack = new CalcDele(calc.Plus);
            Console.WriteLine($"3+5 = {callBack(3, 5)}");  // 소스 코드를 전부 돌려 받음
            callBack = new CalcDele(calc.MultiPle);
            Console.WriteLine($"3*5 = {callBack(3, 5)}");
        }
    }
}
