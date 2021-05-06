using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassTestApp
{
    abstract class AbstractBase // 추상 클래스
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("AbstractBase.ProtectedMthod() 실행");
        }
        public void publicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMthod() 실행");
        }

        public abstract void AbstractMethod();//인터페이스 선언과 동일
    }
}
