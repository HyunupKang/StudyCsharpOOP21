using System;
using System.Data;

namespace DelegateChainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FireStation station = new FireStation();

            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);

            //대리자 실행
            fireHouse("청와대"); // 한꺼번에 여러개의 메서드를 실행할 수 있다.

            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            fireWoorim("우림라이온밸리A");

        }
    }
}
