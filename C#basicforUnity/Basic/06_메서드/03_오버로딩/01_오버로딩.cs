using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._03_오버로딩
{
    class _01_오버로딩
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Plus(double a, double b)
        {
            return (int)(a + b);
        }

        static void Main()
        {
            // 오버로딩이란?
            // 하나의 클래스에 같은 이름의 메서드를 매개변수를 다르게하여
            // 여러개 정의하는 것을 의미합니다.
            // 매개변수의 개수, 데이터 타입을 이미 정의된 메서드와 다르게 하여 사용
            //  -> 메서드를 호출할 때, 컴파일러가 전달하는 인자에 알맞는 메서드를 추론하여 호출

            // 오버로딩의 조건
            // 1. 메서드의 이름 같아야함
            // 2. 매개변수의 개수 또는 데이터타입이 달라야함
            // 3. 매개변수는 같으며, 반환타입이 다른 경우는 오버로딩이 성립되지 않습니다.
            //     -> 컴파일러는 호출할 메서드를 추론할 떄, 매개변수 목록을 기준으로 추론하므로

            Console.WriteLine(Plus(10, 20));
            // static int Plus(int a, int b) 호출

            Console.WriteLine(Plus(10, 20, 30));
            // static int Plus(int a, int b, int c) 호출

            Console.WriteLine(Plus(10.235, 345.2345));
            // static int Plus(double a, double b) 호출

            // 이러한 메서드를 컴파일러는 어떻게 처리하는지?
            // 컴파일 시점에 같은 이름을 가진 메서드를 서로 다른 이름의 메서드로 컴파일
            // 따라서, 사용자가 사용한 메서드는 매개변수 및 데이터 타입에 맞는 메서드를 호출
        }
    }
}
