﻿using System;
using System.Security;

namespace ArrayTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");

            int[] scores = { 80, 74, 81, 94, 100};
/*            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100;*/

            //학생 수학점수 총합
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += scores[i];
            }
            //평균
            float average = (float)sum / scores.Length;

            Console.WriteLine($"수학 점수 총합 : {sum}, 평균 : {average}");
        }
    }
}
