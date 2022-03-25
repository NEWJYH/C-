using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._05_조건연산자
{
    class _01_조건연산자
    {
        static void Main()
        {
            // 조건연산자란?
            // 삼항연산자라고도 합니다.
            // 조건식을 검사하여 참일 때와 거짓일 떄의 값을
            // 다르게 반환시켜주는 연산자입니다.
            
            // 조건연산자 기호 ?
            // (조건식) ? 참일떄 반환할 값 : 거짓일 때 반환할 값;

            int a = 20;

            // a의 값이 10인지 검사하여,
            // 10이라면 "a는 10 입니다." 반환
            // 아니라면 "a는 10이 아닙니다." 반환

            Console.WriteLine((a == 10) ? "a는 10 입니다." : "a는 10이 아닙니다.");

            int b = 30;
            Console.WriteLine("a와 b 중에 더 큰 값은 " + (a > b ? "a" : "b") + " 입니다.");

            // null 조건부 연산자란?
            // 접근하려는 데이터가 null인지 검사하여, 결과가 null이라면 null을 반환하고
            // null이 아니라면 접근하려는 데이터를 반환하는 연산자
            // (Null 체크 -> null은 비어있다는 의미, 비어있는 데이터에 접근하여 특정 연산 등을
            //  하려고하면 데이터가 존재하지 않으므로 연산이 불가능 -> 오류 )

            // null 조건부 연산자 사용 -> 변수이름?
            
            object nullObject = 30;
            object myObject = nullObject?.ToString();

            Console.WriteLine("myObject의 값은 " + myObject);
        }
    }
}
