using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._01_IF문
{
    class _04_IF문
    {
        static void Main()
        {
            // else if문이란?
            // 분기점을 다양하게 만들 때 사용하는 기능
            // else문처럼 단독으로 사용할 수 없습니다.
            // 무조건 if문 다음, 또는 else if 다음에 사용되어야 합니다.

            Console.WriteLine("a에 정수 값을 입력해주세요.");
            int a = int.Parse(Console.ReadLine());

            // a의 값이 0보다 큰 지
            if (a > 0)
            {
                Console.WriteLine("a는 양수");
            }
            // a의 값이 0보다 작은지
            else if (a < 0)
            {
                Console.WriteLine("a는 음수");
            }
            // 위의 조건 모두 아닐 경우
            else
            {
                Console.WriteLine("a는 0");
            }

        }
    }
}
