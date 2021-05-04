using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //~~~~~3000라인 

            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now)); //ExtendedMonitor는 가져다 쓴다고 가정
            monitor1.PrintLog("콘솔로그내용입니다");
            var monitor = new ExtendedMonitor(new FileLogger("210504.log")); //ExtendedMonitor는 가져다 쓴다고 가정
            monitor.PrintLog("로그내용입니다");

            Thread.Sleep(1000);
            //이하 생략 1400라인
            monitor.PrintLog("이해 오류가 발생했습니다");

            Console.WriteLine("프로그램 종료");
        }
    }
}
