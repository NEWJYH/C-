using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._05_접근제한자
{
    class Dog
    {
        // private 필드 선언
        private string name;
        private int age;

        // 필드 name에 대한 접근자를 구성
        public string GetName() { return name; }
        // 필드 name에 대한 설정자를 구성
        public void SetName(string value) { name = value; }

        // 필드 age에 대한 접근자를 구성
        public int GetAge() { return age; }
        // 필드 age에 대한 설정자를 구성
        public void SetAge(int value)
        {
            // age 값이 0 이하일 경우 예외처리
            if (value <= 0)
            {
                Console.WriteLine("나이 값이 잘못되었습니다.");
                return;
            }

            age = value;
        }
    }

    class _02_접근제한자
    {
        static void Main()
        {
            // private으로 선언한 필드에 접근하기 위해서?
            // 접근자와 설정자를 구성하여 간접 접근을 할 수 있습니다.

            // 접근자란? (데이터 읽기)
            // 지정한 필드의 값을 반환하는 메서드
            // 이름 앞에 Get을 붙여서 사용 (관습)
            // 반환타입은 지정한 필드의 데이터 타입과 일치

            // 설정자란? (데이터 쓰기)
            // 지정한 필드의 값을 설정하는 메서드
            // 이름 앞에 Set을 붙여서 사용 (관습)
            // 반환타입은 void
            // 값을 설정하려는 필드의 데이터타입과 일치하는 매개변수를 선언하여 사용

            Dog myDog = new Dog();

            myDog.SetName("피즈");
            myDog.SetAge(15);

            Console.WriteLine("강아지 : " + myDog.GetName());
            Console.WriteLine("나이 : " + myDog.GetAge());
        }
    }
}
