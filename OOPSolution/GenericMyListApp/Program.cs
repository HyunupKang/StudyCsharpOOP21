using System;
using System.Net.Http.Headers;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1; // 객체를 MyList list = new MyList(); 로 생성하면 list[i] = "string" 안된다. string Class를 써야한다 ==> 일반화를 쓰면 한방에 해결, MyList<T>로 해서 일반화 한다.
            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}  ");
            }
            Console.WriteLine();

            MyList<string> strlist = new MyList<string>();
            for (int i = 0; i < strlist.Length; i++)
            {
                strlist[i] = "취업" +  (i + 1);
            }
            for (int i = 0; i < strlist.Length; i++)
            {
                Console.Write($"{strlist[i]}  ");
            }
            Console.WriteLine();

            MyList<object> objList = new MyList<object>();
            objList[0] = 111;
            objList[1] = 3.123;
            objList[2] = "Hello,";

            for (int i = 0; i < objList.Length; i++)
            {
                Console.Write($"{objList[i]}  ");
            }
        }
    }
}
