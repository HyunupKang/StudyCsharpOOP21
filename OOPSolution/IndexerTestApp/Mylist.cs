using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class Mylist
    {
        private int[] array;
        public int this[int index] // == MyList[i] == array[i] // private인 array이름을 Mylist란 이름으로 쓰겠다. // 인덱서 : private 배열을 Class 배열로 매핑
        {
            get
            {
                return array[index]; 
            }
            set
            {
                if (index >= array.Length) // 하나씩 증가
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public Mylist()
        {
            array = new int[3]; //array가 private라 main에서 접근 못함
        }
    }
}
