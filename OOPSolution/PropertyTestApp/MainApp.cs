using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지 객체 생성");
            Dog beakgoo = new Dog();
            beakgoo.Name = "백구";


            /*            beakgoo.SetAge(5);

                        Console.WriteLine($"백구의 나이는 {beakgoo.GetAge()} 입니다");*/

            beakgoo.Age = 2500;
            Console.WriteLine($"{beakgoo.Name}의 나이는 {beakgoo.Age}세"); // Get, Set 구분할 필요가 없다.

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}의 나이는 {streetDog.Coloar}세"); // Get, Set 구분할 필요가 없다.

            Dog dog1 = new Dog(); // 기본적인 초기화
            dog1.Name = "황구";
            dog1.Coloar = "노랑";
            dog1.Age = 10;

            Dog dog2 = new Dog()
            {
                Name = "깜깜이",
                Age = 5,
                Coloar = "검정"
            };
            Dog dog3 = new() // 더 줄일 수 있다.
            {
                Name = "깜깜이",
                Age = 5,
                Coloar = "검정"
            };

            var MyInstance = new { Name = "강현업", Age = 3 }; // 무명 형식, 큐플과 비슷, 여기서 쓰고 버림
            Console.WriteLine(MyInstance);
            Console.WriteLine(MyInstance.Age);

        }
    }
}
