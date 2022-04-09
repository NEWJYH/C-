using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._03_다차원배열
{
    class _01_다차원배열
    {
        private void PrintArray(int[,] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main()
        {
            // 다차원 배열
            // 배열을 요소로 갖는 배열을 말합니다.
            // 1차원 배열을 요소로 갖는 배열을 2차원 배열
            // 2차원 배열을 요소로 갖는 배열을 3차원 배열

            // 2차원 배열
            // 각각의 원소가 1차원 배열을 하나씩 갖습니다
            // [] 이 아닌 [,] 로 2차원 배열을 선언
            // new 타입[2차원 길이, 1차원 길이]로 메모리 할당

            // 길이가 4인 배열을 원소로 3개 갖는 2차원 배열을 선언
            int[,] myArray = new int[3, 4];
            // [ ㅁ ㅁ ㅁ ㅁ ]
            // [ ㅁ ㅁ ㅁ ㅁ ]
            // [ ㅁ ㅁ ㅁ ㅁ ]

            // 다차원 배열의 길이를 구하는 방법?
            // Length 가 아닌 GetLength(dimension)를 사용
            // Length를 사용한다면 해당 배열의 전체 원소의 수를 반환받습니다.
            // 2차원 배열 길이 -> 배열변수명.GetLength(0) -> 2차원 배열의 길이
            // 1차원 배열 길이 -> 배열변수명.GetLength(1) -> 1차원 배열의 길이

            int length1 = myArray.GetLength(1);
            int length2 = myArray.GetLength(0);

            Console.WriteLine("1차원 배열의 길이 : " + length1);
            Console.WriteLine("2차원 배열의 길이 : " + length2);

            // 배열의 값을 초기화할 때 사용할 변수
            int count = 0;

            // 2차원 배열을 순회할 for문을 작성
            for (int i = 0; i < length2; ++i)
            {
                // 2차원 배열의 각 원소들이 갖는 1차원 배열을 순회할 for문
                for (int j = 0; j < length1; ++j)
                {
                    myArray[i, j] = ++count;
                    Console.Write($"myArray[{i},{j}] = {myArray[i, j]}  ");
                }
                Console.WriteLine();
            }

            // 다차원 배열을 초기화하는 방법들

            var myClass = new _01_다차원배열();

            // 배열의 형식과 길이를 명시
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            myClass.PrintArray(arr1);

            // 배열의 길이를 생략
            int[,] arr2 = new int[,] { { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            myClass.PrintArray(arr2);

            // 형식과 길이를 모두 생략
            int[,] arr3 = { { 16, 17 }, { 18, 19 } };
            myClass.PrintArray(arr3);

        }
    }
}
