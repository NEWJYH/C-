using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._06_확장메서드
{
    public static class MyClass
    {
        // 확장 메서드 규칙
        // 접근 제한자는 public으로 선언, static 키워드를 통해 클래스에 포함되도록
        // 첫번째 매개변수에는 this 키워드와 확장하고자하는 데이터타입을 명시

        // int타입을 확장
        public static int Plus(this int variable, int add)
        {
            return variable + add;
        }
    }

    class _01_확장메서드
    {
        static void Main()
        {
            // 확장 메서드란?
            // 기존 클래스의 기능을 확장하는 기법
            // 이미 만들어진 클래스를 추가적으로 작성하지 못할 경우
            // 해당 클래스를 확장할 때 사용

            // 확장 메서드를 포함할 클래스는 static 한정자로 수식
            // static 클래스를 작성하는 경우, 모든 멤버는 static이 되어야합니다

            int a = 10;

            Console.WriteLine("a Plus = " + a.Plus(50));
            // 이렇게 확장메서드를 이용하여
            // 원래부터 int타입의 메서드였던 것처럼 사용
        }
    }
}
