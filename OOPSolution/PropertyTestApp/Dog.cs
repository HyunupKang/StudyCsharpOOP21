using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
/*        private int age;
        private string name;
        //값을 사용
        public int GetAge()
        {
            return this.age;
        }
        //값을 설정
        public void SetAge(int age)
        {
            if (age < 0) { this.age = 1; } // 잘못된 값이 안들어가게 막는것 = 속성
            else if (age > 15) { this.age = 15; }
            else { this.age = age; }
        }*/  // 특성이 많아지만 골치 아파짐. 모든걸 일일이 Get, Set 메서드를 작성해야 함
        private int age;
        private string name;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)  // value : 자기 자신에 값을 넣는것
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
                
            }
        }
        /*        public string Name
                {
                    get
                    {
                        return this.name;
                    }
                    set
                    {
                        this.name = value;
                    }
                }*/
        // 위 stirng Name에서 보면 Age와 다르게 하는거라곤 값 입력 받고 값 출력 뿐, 그래서 get; set으로 축약함 // 그리고 위 private string name;를 선언할 필요 없음
        public string Name { get; set; } = "멍멍이"; // 초기화
        public string Coloar { get; set; } = "누런색";
    }
}
