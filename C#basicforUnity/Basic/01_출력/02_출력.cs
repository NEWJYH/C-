using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._01_출력
{
    class _02_출력
    {
        static void Main(string[] args)
        {
            // 어떠한 복수의 문자열을 이어서 출력할 때
            // + 연산자를 사용할수 있습니다.
            // 문자열에서 사용되는 + 연산자를 문자열 결합 연산자라고 합니다.
            Console.WriteLine("안녕하세요.\n" + "나는 이즈리얼 입니다.");

            // 20 + 30 = 50 입니다.
            Console.WriteLine(20 + "+" + 30 + "=" + (20 + 30) + "입니다.");

            // "" 문자열(복수의 문자) 데이터
            // '' 문자(한글자) 데이터
        }
    }
}
