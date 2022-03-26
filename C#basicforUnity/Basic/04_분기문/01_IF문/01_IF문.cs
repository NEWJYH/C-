using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._01_IF문
{
    class _01_IF문
    {
        static void Main()
        {
            // 분기문이란?
            // 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름 제어 구문입니다.
            // C#에서는 한 번에 단 하나의 조건만 평가할 수 있는 if문과
            // 한 번에 여러 개의 조건을 평가할 수 있는 switch문을 제공

            // if문 사용
            // if (조건식) 조건식이 참이라면 실행할 구문;

            // if문은 조건식 다음에 오는 단 하나의 구문만을 실행
            if (false) Console.WriteLine("실행!");
            Console.WriteLine("if문 끝!");

            // 한 번에 여러개의 구문을 제어할 때
            // 제어할 여러구문을 코드 블록으로 묶습니다.
            if (3 % 2 == 1)
            {
                Console.WriteLine("3은 홀수입니다.");
                Console.WriteLine("3은 홀수입니다.");
                Console.WriteLine("3은 홀수입니다.");
            }

            // if문 조건식의 결과가 거짓일 때, 특정 구문을 실행하는 방법
            // else문을 추가로 사용

            // else문 사용조건
            // esle는 단독으로 존재할 수 없음
            // if문이 선행되어야만 esle를 사용 가능
            // else는 if문에 맨 마지막에 와야함

            int a = 5;

            // a의 값이 10 이상인지 검사
            if (a >= 10)
            {
                Console.WriteLine("a는 10 이상입니다.");
            }
            // 위의 조건이 아닐 경우
            else
            {
                Console.WriteLine("a는 10 이상이 아닙니다.");
            }
        }
    }
}
