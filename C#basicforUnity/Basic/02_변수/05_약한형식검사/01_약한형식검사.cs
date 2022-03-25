using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._05_약한형식검사
{
    class _01_약한형식검사
    {
        static void Main()
        {
            // C#은 선언된 타입과 들어간 데이터 타입에 대해
            // 강력한 규제를 하는 언어
            // 프로그래머 실수를 줄여준다는 장점이 있음
            // 대신, 사용시 명시적으로 타입을 작성해야함

            // 이때 약한 형식검사를 이용한다면,
            // 데이터에 맞는 타입을 명시적으로 작성하지 않아도 됨

            // 약한 형식 검사란?
            // 들어간 값에 따라 컴파일러가 알아서 타입을 추론해주는 것을 의미
            // 반드시 선언 시에 초기화를 해야합니다.

            // 약한 형식 검사 키워드 var

            var variable = 10;

            // GetType() -> 해당 변수의 타입을 반환해주는 메서드
            Console.WriteLine(variable.GetType());// int32

            var variable2 = "그래";

            Console.WriteLine(variable2.GetType());// string
        }
    }
}
