using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger// Ver 1.0
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러 : {error}");// debug는 디버깅할때만 출력보기에 출력
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now} : {message}");
        }
    }
}