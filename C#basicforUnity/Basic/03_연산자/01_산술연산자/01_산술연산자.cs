using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._01_산술연산자
{
    class _01_산술연산자
    {
        static void Main()
        {
            // 연산자란?
            // 연산을 수행하는 기호를 말합니다
            // 연산자는 항상 연산에 대한 결과를 반환합니다

            // 산술연산자란?
            // 수치 형식의 데이터를 다루는 연산자
            // 수치형식 : 정수, 부동소수점 방식

            // + 덧셈
            // - 뺄셈
            // * 곱셈
            // / 나눗셈
            // % 나머지

            int a = 3;
            int b = 2;

            double sum = a + b;
            double sub = a - b;
            double mul = a * b;
            double div = a / b;
            double rem = a % b;

            Console.WriteLine("sum : " + sum);
            Console.WriteLine("sub : " + sub);
            Console.WriteLine("mul : " + mul);
            Console.WriteLine("div : " + div);
            Console.WriteLine("rem : " + rem);

            div = a / (double)b;
            Console.WriteLine("div : " + div);
        }
    }
}
