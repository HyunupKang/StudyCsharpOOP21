using System;

namespace AbstactClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //AbstractBase obj = new AbstractBase(); // abstract 앞에 new 할 수 없다.
            AbstractBase obj = new Derived(); // 그래서 상속 받은 클래스를 이용
            obj.publicMethod();
            obj.AbstractMethod();

        }
    }
}
