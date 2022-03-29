using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._02_생성자소멸자
{
    class Human
    {
        public enum Gender { Man, Woman }

        public string name;
        public int age;
        public Gender gender;

        // 기본 모양의 생성자를 정의
        public Human()
        {
            Console.WriteLine("Human의 생성자 호출");
        }

        // 생성자를 오버로딩 시킵니다.
        public Human(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

            Console.WriteLine("이름 : " + this.name);
            Console.WriteLine("나이 : " + this.age);
            Console.WriteLine("성별 : " + this.gender);
        }

        // 소멸자
        ~Human()
        {
            Console.WriteLine("휴먼 객체 소멸");
        }
    }

    class _01_생성자소멸자
    {
        static void Main()
        {
            // 생성자란?
            // 객체를 생성하기 위해 호출하는 메서드를 의미
            // 객체를 생성하는 시점에 필드를 원하는 값으로 초기화하고 싶을 때
            // 사용할 수 있는 특별한 메서드입니다.
            // 호출했을 경우 지정한 형태의 객체를 생성하여 반환

            // 생성자의 기본적인 언어적 규칙
            // 생성자는 클래스의 이름과 동일
            // 생성자에는 반환타입을 정의하지 않으며, 반환 값도 설정하지 않습니다
            // 생성자의 매개변수를 달리하여, 오버로딩을 가능합니다
            // 생성자를 정의하지 않아도, 기본 생성자가 자동으로 추가됩니다.
            // 생성자는 상속되지 않습니다.

            // 기본생성자란?
            // 클래스를 선언할 때, 명시적으로 생성자를 구현하지 않아도
            // 컴파일러가 만들어주는 기본 형태의 생성자를 말합니다.

            // 기본 생성자는 매개변수가 없으며, 객체를 생성하는 일 외에는
            // 아무 일도 하지 않습니다.
            // 만약, 기본 생성자의 내용을 변경하고 싶다면 기본생성자를
            // 명시적으로 선언하여 내용을 변경하여 정의하면 됩니다.

            // 생성자를 하나라도 정의하게 된다면, 컴파일러는 기본 생성자를 제공하지 않습니다

            Human human = new Human();

            // 매개변수가 있는 오버로딩된 생성자를 호출
            Human human2 = new Human("가렌", 30, Human.Gender.Man);

            // 소멸자란?
            // 객체가 소멸될 때 마지막으로 호출되는 메서드
            // 가비지 컬렉터가 객체의 소멸시점을 판단하여 호출
            // 가비지 컬렉터는 가비지가 일정양에 이르러야 동작하며
            // 가비지가 차오르는 시간을 정확하게 알 수 없고, 순서대로 호출되지 않기 때문에
            // 소멸자는 특별한 경우가 아니라면, 사용하지 않는 것이 좋습니다.

            // 소멸자는 명시적으로 구현한다면, object로 상속받은 소멸자를 타고 올라가며
            // 호출되기 때문에 보통 성능저하를 일으킬 수 있다.

            // 이름 앞에 ~를 붙여 명시적으로 선언
            // 반환 타입을 지정할 수 없습니다
            // 매개변수를 추가할 수 없습니다
            // 오버로딩이 불가능합니다
            // 명시적으로 호출할 수 없습니다
        }
    }
}
