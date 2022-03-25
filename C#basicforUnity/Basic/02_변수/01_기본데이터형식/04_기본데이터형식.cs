using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._01_기본데이터형식
{
    class _04_기본데이터형식
    {
        static void Main(string[] args)
        {
            // 문자열 형식에서는 char 타입을 사용합니다.
            // 사실 char는 정수 형식이지만, 문자 데이터를 표현할 떄 사용
            // 앞, 뒤에 작은 따옴표(')를 사용하여 char형 데이터를 다룹니다.

            char myCharacter = '캐';
            char myCharacter1 = '릭';
            char myCharacter2 = '터';

            Console.WriteLine("" + myCharacter + myCharacter1 + myCharacter2);

            // 이러한 문자의 집합을 표현 (문자열)
            // string -> 참조 형식

            string myString = "아크샨";
            Console.WriteLine(myString);
        }
    }
}
