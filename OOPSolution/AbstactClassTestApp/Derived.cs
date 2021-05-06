using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod() // virtual - overrid와 abstract - override는 거의 비슷. 
        {
            Console.WriteLine("Derived.AbstractMethod() 실행");
            base.ProtectedMethod(); // base는 부모를 지칭하는 것
        }
    }
}
