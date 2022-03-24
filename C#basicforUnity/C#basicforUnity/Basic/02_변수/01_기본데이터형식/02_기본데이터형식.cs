using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._01_기본데이터형식
{
    class _02_기본데이터형식
    {
        static void Main(string[] args)
        {
            // 2진수, 16진수를 표현하는 방식
            // 각 자리수의 가중치를 곱하는 방식으로 모두 계산할수 있습니다.
            // 가중치는 x^n을 뜻합니다.
            // 2진수형식은 0b 접두어를, 16진수 0x 접두어를 사용

            // 2진수 데이터를 표현할 때, 각 자리를 확인하기 편하게
            // 4자리마다 _(언더바)로 나눠서 표현
            int number = 0b1111_0000;
            Console.WriteLine(number);//240

            int number2 = 0b1011_1010;
            Console.WriteLine(number2);//186

            // 16진수 0~9, A~F(10~15)
            int number3 = 0xf0;
            Console.WriteLine(number3);//240

            int number4 = 0xba;
            Console.WriteLine(number4);//186
        }
    }
}
