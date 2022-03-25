using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._03_관계연산자
{
    class _01_관계연산자
    {
        static void Main()
        {
            // 관계연산자란?
            // 두 피연산자 사이의 관계를 확인하는 연산자입니다.
            // 두 피연산자가 같은지? 다른지? 큰지? 작은지? 등을 비교할 떄 사용

            // A == B : A와 B가 같은지를 비교, 같을 경우 결과는 참, 아니라면 거짓
            // A != B : A와 B가 다른지를 비교, 다를 경우 결과는 참, 아니라면 거짓
            // A > B, A < B : A와 B의 크기를 비교하며, 초과와 미만을 나타냅니다.
            // A >= B, A <= B : A와 B의 크기를 비교하며, 이상과 이하를 나타냅니다.

            int a = 10;
            int b = 10;
            int c = 20;

            // a와 b가 가진 값이 서로 같은 비교
            Console.WriteLine("a와 b가 서로 같은지? " + (a == b));

            // a와 c가 가진 값이 서로 다른지 비교
            Console.WriteLine("a와 c가 서로 다른지? " + (a != c));

            // a의 값이 c의 값을 초과하는지
            Console.WriteLine("a가 c 초과인지? " + (a > c));

            // a의 값이 c 이하인지
            Console.WriteLine("a가 c 이하인지? " + (a <= c));
        }
    }
}
