using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            // int배열을 int배열로 복사

            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5개 짜리 int 배열, {0, 0, 0, 0, 0}
            Console.WriteLine("복사전 targetInt값 ===> ");

            //복사전
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetInt값 ===> ");
            CopyArray(sourceInt, targetInt);
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion
            // float배열을 float배열로 복사
            #region
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            Console.WriteLine("복사전 targetFloat ===> ");

            //복사전
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetFloat ===> ");
            CopyArray(sourceFloat, targetFloat);
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // string배열을 string배열로 복사

            string[] sourcestring = {"하나", "둘", "셋", "넷", "다섯" };
            string[] targetstring = new string[sourcestring.Length];

            Console.WriteLine("복사전 targetstring ===> ");

            //복사전
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetstring ===> ");
            CopyArray(sourcestring, targetstring);
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion*/


            //------- 일반화 메서드로 통일 --------//

            //      int
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5개 짜리 int 배열, {0, 0, 0, 0, 0}
            Console.WriteLine("복사전 targetInt값 ===> ");

            //복사전
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetInt값 ===> ");
            CopyArray<int>(sourceInt, targetInt);
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //          float
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            Console.WriteLine("복사전 targetFloat ===> ");

            //복사전
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetFloat ===> ");
            CopyArray<float>(sourceFloat, targetFloat);
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //          string
            string[] sourcestring = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetstring = new string[sourcestring.Length];

            Console.WriteLine("복사전 targetstring ===> ");

            //복사전
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine("복사후 targetstring ===> ");
            CopyArray<string>(sourcestring, targetstring);
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        private static void CopyArray<T>(T[] source, T[] target)// 일반화 메서드로 통일
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
