using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._05_접근제한자
{
    class Student
    {
        // 아래의 두 필드는 모두 private으로 선언했기 때문에
        // 외부에서 선언한 필드로의 직접적인 접근이 불가능

        // 이름
        private string name;
        // 나이
        private int age;

        // 생성자의 접근제한자를 public으로 선언했기 때문에
        // 외부에서 생성자를 자유롭게 이용할 수 있음.
        //  -> 생성자를 이용하여 private 필드의 간접적인 데이터 쓰기 작업
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 학생의 정보를 출력하는 메서드
        //  -> 해당 메서드를 통해 private 필드의 간접적인 데이터 읽기 작업
        public void PrintInfo()
        {
            Console.WriteLine("학생 : " + name);
            Console.WriteLine("나이 : " + age);
        }
    }

    class _01_접근제한자
    {
        // 접근제한자란?
        // 접근제한자는 외부로부터 멤버들로의 접근을 제한할 때 사용하는 한정자

        // 접근제한자 종류
        // public
        // 클래스의 내부/외부 모든 곳에서 접근이 가능

        // protected (클래스가 상속관계에 있을 경우에 사용)
        // 클래스의 외부에서는 접근하지 못하지만, 내부와 파생된 클래스에서 접근이 가능

        // private
        // 클래스 내부에서만 접근이 가능, 파생클래스나 외부에서 접근이 불가능
        // 클래스와 구조체에서 접근제한자를 명시적으로 지정하지 않았을 경우 -> 기본값

        // 객체 지향 프로그래밍 3대 특성
        // 은닉성(캡슐화), 상속성, 다형성

        // 은닉성
        // 데이터의 보호를 위하여 객체의 필드, 메서드를 필요에 의해 
        // 감추거나 공개하는 것을 의미
        // 객체 지향 프로그래밍에서는 클래스의 사용자에게 필요한 최소의
        // 기능만을 노출시키고 내부를 감추도록 요구합니다. 이 때 접근제한자 사용
        //  -> 필드는 숨기고, 기능만을 노출하게 되는데, 이 때 클래스를 캡슐화했다고 표현

        // 상속성
        // 부모가 가지고 있는 것을 자식 클래스가 물려받아 같이 공유하며 나아가 확장하는 개념
        // 기존의 코드를 재사용하여 보다 쉽게 코드를 작성하는 기법을 말합니다.
        // 비슷한 개념을 발견하여 이를 공통화 시켜 개발 생산성을 향상시킬 수 있습니다.

        // 다형성
        // 같은 타입이지만 실행 결과가 다양한 객체를 이용할 수 있는 성질을 의미합니다.
        // 하나의 이름으로 많은 상황에 대처하는 기법

        static void Main()
        {
            Student student = new Student("아크샨", 20);
            student.PrintInfo();

            // 접근제한자가 private이기 때문에 접근 불가
            // student.name = "안녕";

        }
    }
}
