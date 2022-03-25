using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._03_상수와열거형
{
    class _02_열거형
    {
        // 상수 Slime, Goblin, Ork를 갖는 열거형 데이터
        // MonsterType을 만듬

        // 열거형 정의
        // 열거형을 정의해서 새로운 데이터 타입을 만든 것 뿐이고,
        // 실제 사용시에는 열거형 타입으로 변수를 만들거나, 열거형타입.요소이름 사용

        enum MonsterType
        {
            // 열거형은 정수를 문자열로 표현하기 위해 주로 사용
            // 정수를 문자열로 표현함으로써 코드의 가독성 향상
            //  -> 프로그래머의 편의 향상을 위해 사용 

            Slime = 10,
            Goblin = 20,
            Ork,
        }

        static void Main()
        {
            // 열거형이란?
            // 서로 연관된 상수들의 집합이다.
            // 쓰이는 곳이 비슷한 상수들을 하나의 카테고리로
            // 묶어서 표현할 떄 사용
            // enum 키워드를 사용

            MonsterType type = MonsterType.Slime;
            Console.WriteLine(type); // Slime
            Console.WriteLine((int)type); // 10

        }

    }
}
    