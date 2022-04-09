using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._01_배열
{
    class _01_배열
    {
        static void Main()
        {
            // 배열이란?
            // 동일한 타입의 데이터를 모아놓은 데이터 집합입니다.
            // 여러 개의 동일한 타입의 변수가 필요한 경우 유용하게 사용할 수 있습니다.
            // 만약 10개의 int형 변수가 필요하다면, 1개의 int형 배열을 선언하여 해결 가능

            // 배열 선언방법
            // 데이터타입[] 식별자(변수이름) = new 데이터타입[사이즈];

            int[] myArray = new int[5];
            // 배열의 요소들을 엘리먼트(Element)라고 하며
            // 각각의 원소들을 구분하기 위한 번호를 인덱스(Index)라고 합니다.
            // 배열의 인덱스는 0번부터 시작 (Zero-base-index)
            // 각각의 엘리먼트에 "배열이름[index]"로 접근
            // new int[5] : 20 byte의 메모리를 힙에 동적할당

            // 첫번째 원소에 10을 할당
            //myArray[0] = 10;
            // 두번째 원소에 20을 할당
            //myArray[1] = 20;
            // 세번째 원소에 30을 할당
            //myArray[2] = 30;
            // 네번째 원소에 40을 할당
            //myArray[3] = 40;
            // 다섯번째 원소에 50을 할당
            //myArray[4] = 50;

            // 배열은 인덱스 및 사용되는 데이터의 규칙을 이용하여
            // 주로 반복문과 함께 사용
            for (int i = 0; i < 5; ++i)
            {
                myArray[i] = (i + 1) * 10;
            }

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("myArray " + (i + 1) + "번째의 값은 " + myArray[i]);
            }

            // 배열을 선언하며, 원소들의 값을 초기화
            //  -> 선언과 동시에 값을 대입하는 경우(초기화 시에만) 가능
            string[] myArray2 = new string[2] { "철수", "영희" };
            Console.WriteLine("myArray2[0] = " + myArray2[0]);
            Console.WriteLine("myArray2[1] = " + myArray2[1]);

            // 배열의 사이즈를 명시적으로 작성하지 않고
            // 뒤에 초기화를 통해 초기화한 원소의 개수만큼 배열 사이즈가 자동적으로 지정됌
            int[] myArray3 = new int[] { 1, 2, 3 };
            int[] myArray4 = { 4, 5, 6, 7 };


        }
    }
}
