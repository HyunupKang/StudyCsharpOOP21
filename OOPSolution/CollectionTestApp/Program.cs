using System;
using System.Collections;
using System.ComponentModel;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            int a = 123;
            object obj = a;
            int b = (int)obj;

            Console.WriteLine("a의 값 : " + a);
            Console.WriteLine("obj의 값 : " + obj);

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj);*/

            ArrayList list = new ArrayList(); // 배열인데 사이즈 지정 안함
            
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)// 여기서 item 은 Object 타입. 모든 클래스의 조상은 Object
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            list.Sort();

            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();



            list.Reverse();
            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            list.Insert(2, 88);
            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            list.RemoveAt(5); // 인덱스 5번 지워라
            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            int index88 = list.IndexOf(88);
            Console.WriteLine($"88의 위치 : {index88}");

            list.Remove(5); // 5를 지워라
            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{ item }\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14); // 14가 두개인데, 첫번째 인덱스만 받음
            Console.WriteLine($"14의 위치값 : {index14}");

            int listIndex14 = list.LastIndexOf(14);
            Console.WriteLine($"마지막 14의 위치값 : {listIndex14}");

            Console.WriteLine($"총 갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막값{list[list.Count - 1]}");

        }
    }
}
