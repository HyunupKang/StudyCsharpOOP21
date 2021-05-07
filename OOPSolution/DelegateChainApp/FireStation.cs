using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChainApp
{
    delegate void ThereIsAFire(string location);

    class FireStation
    {
        public void Call119(string loaction) { Console.WriteLine($"소방서죠, 불났어요. 주소는 {loaction} 입니다."); }
        public void ShotOut(string location) { Console.WriteLine($"피하세요!! {location}에 불났어요!!"); }
        public void Escape(string loacation) { Console.WriteLine($"{loacation}에서 나갑시다!!"); }
    }
}
