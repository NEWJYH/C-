using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._02_Switch문
{
    class _01_Switch문
    {
        static void Main()
        {
            // Switch문이란?
            // 조건식의 결과가 가질 수 있는 다양한 경우를 한 번에 평가하고
            // 프로그램의 흐름을 가를 때 사용합니다

            // switch (검사할 값)
            // case를 이용해서 경우의 수를 추가합니다.
            // 하나의 case문이 끝나면 break 또는 return으로 꼭 마무리해야 합니다.
            // "나열된 모든 case가 아니라면"의 경우를 처리할 때는 default
            // case문은 정수, 문자열형식의 리터럴 데이터 등을 지원

            int number = 30;

            switch (number)
            {
                case 10: // number의 값이 10이라면
                    Console.WriteLine("number는 10");
                    break;
                case 20: // number의 값이 20이라면
                    Console.WriteLine("number는 20");
                    break;
                default: // 위의 모든 case가 아니라면
                    Console.WriteLine("number는 10, 20이 아님");
                    break;
            }
        }
    }
}
