using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._06_할당연산자
{
    class _01_할당연산자
    {
        static void Main()
        {
            // 할당연산자란?
            // 왼쪽 피연산자에 오른쪽 피연산자의 데이터를 할당하는 기능
            // 산술 연산자에 =을 붙여서 사용

            // 할당 연산자의 종류
            // +=, -=, *=, /= , %=

            int a = 10;
            int b = 20;

            a += b; // a = a + b;
            Console.WriteLine("a : " + a); // 30

            a -= b; // a = a - b;
            Console.WriteLine("a : " + a); // 10

            a *= b; // a = a * b;
            Console.WriteLine("a : " + a); // 200

            a /= b; // a = a / b;
            Console.WriteLine("a : " + a); // 10

            a &= b; // a = a & b;
            Console.WriteLine("a : " + a); // 0

            a %= b;
            Console.WriteLine("a : " + a); // 0

            // 연산자 파트 복습필요 교재 확인하기
        }
    }
}

