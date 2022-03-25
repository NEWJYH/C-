using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._06_할당연산자
{
    class _02_Null병합연산자
    {
        static void Main()
        {
            // Null 병합 연산자란?
            // Null 조건부 연산자처럼 데이터의 null 검사를 간결하게 만들어주는 연산자입니다.
            // 왼쪽 피연산자의 값을 검사하여 null이라면, 오른쪽 피연산자의 값을 반환
            // null이 아니라면, 왼쪽 피연산자의 값을 반환하는 연산자입니다.
            // 기호 ??

            object a = null;

            // a의 값이 null이라면 100을, null 아니라면 a를 반환
            object b = a ?? 100;

            Console.WriteLine(b);
        }
    }
}
