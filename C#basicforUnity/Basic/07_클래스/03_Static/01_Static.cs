using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._03_Static
{
    class Sample
    {
        // 정적 필드를 정의
        public static int variable;

        // 인스턴스 필드를 정의
        public int a;

        // 정적 메서드를 정의
        public static void PrintVariable()
        {
            Console.WriteLine("variable의 값은 " + variable);
        }
    }

    class _01_Static
    {
        static void Main()
        {
            // Static 이란?
            // 키워드 뒤에 오는 필드나 메서드를 인스턴스에 소속시키는 것이 아닌
            // 클래스 자체에 소속시키도록 하는 한정자입니다.
            // 필드는 정적 필드가 되고, 메서드는 정적 메서드가 됩니다.
            // 프로그램 시작 시 메모리에 올라가고, 끝날 때까지 유지됌

            // static이 붙지 않은 필드나 메서드는 인스턴스에 소속되므로
            // 인스턴스 필드, 인스턴스 메서드라고 합니다

            // 차이점
            // 인스턴스 필드, 메서드
            // 무조건 특정한 클래스 형태로 인스턴스(객체)를 만들고
            // 메서드를 호출하거나, 필드를 사용해야 합니다
            // 각각의 인스턴스마다 다른 값을 가질 수 있습니다.

            // 정적 필드,메서드
            // 클래스에 소속되어있기 때문에 인스턴스를 만들지 않아도 사용할 수 있습니다.

            Sample.variable = 10;
            Sample.PrintVariable();
        }
    }
}
