using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._03_For문
{
    class _01_For문
    {
        static void Main()
        {
            // for문이란?
            // 초기식, 조건식, 증감식으로 이루어진 반복문
            // while문보다 반복을 더 정교하게 제어할 수 있습니다.

            // 초기식 : 
            // 반복을 실행하기 전에 가장 먼저 실행되는 코드 (1번 실행)
            // for문에서 사용할 변수를 이 곳에서 선언 및 초기화
            // ex) while문에 조건을 제어하기 위해 count 변수를 선언

            // 조건식 :
            // 반복을 계속 수행할 것인지 결정하는 식
            // 당연히 조건식이 false가 된다면 반복을 중단

            // 증감식 :
            // 반복이 끝날 때마다 실행됩니다.
            // 이 곳에서 조건식에 사용되는 변수의 값을 조정합니다.
            // ex) while문에서 언젠가 반복을 끝내기 위해 count 변수의 값을
            //     매 반복마다 ++, -- 했음

            // for (초기식; 조건식; 증감식)
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(i + "번 반복했습니다.");
            }

            // for문 초기식에서 변수 선언 시 네이밍(이름짓기)
            //  -> 프로그래머들끼리의 관습..
            // i, j, k 

            // 10!의 값을 for문을 이용해서 출력
            // 10! = 1 * 2 * 3 ... 10;

            int fac = 1;
            for (int i = 1; i <= 10; ++i)
            {
                fac *= i;
            }
            Console.WriteLine("10!의 값은 " + fac);
        }
    }
}
