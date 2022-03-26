using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._01_While문
{
    class _01_While문
    {
        static void Main()
        {
            // 반복문이란?
            // 특정 조건을 만족하는 동안 코드 또는 코드블록을 반복하여
            // 실행하도록 하는 문법입니다.
            // c#은 4가지의 반복문을 제공
            // while, do while, for, foreach

            // while문 사용방법
            // while (조건식) 조건식이 참일 경우 반복시킬 구문;
            //  -> 위와 같이 작성 시 뒤에 오는 단 하나의 구문만 영향을 받음

            // 복수의 구문을 반복시킬 시에 코드블록 사용

            // while (true) Console.WriteLine("반복합니다.");
            // 해당 반복문처럼 조건식이 false를 가지지 못하는 반복문을
            // 무한 루프라고 합니다.
            // 원치않게 무한루프에 빠지는 것을 주의해야합니다.

            // 1부터 10까지의 수를 출력하는 반복문을 작성

            // 1부터 10까지 증가시킬 변수
            int count = 1;

            // count의 값이 10 이하라면 반복
            while (count <= 10)
            {
                Console.WriteLine("count의 값은 " + count);
                ++count;
            }

            // 디버그
            // 코드를 프로그램을 만듬 -> 빌드
            // 빌드 종류 ->  배포용, 디버그용

        }
    }
}
