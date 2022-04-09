using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._03_다차원배열
{
    class _02_다차원배열
    {
        static void Main()
        {
            // 다차원 배열을 이용하여 아래와 같은 결과를 출력

            // output (입/출력 한번에 하기 편함)
            //  1  2  3  4  5
            //  6  7  8  9 10
            // 11 12 13 14 15
            // 16 17 18 19 20

            // 2차원 배열 선언
            // 2차원 길이 4, 1차원 길이 5
            int[,] arr = new int[4, 5];

            // 1부터 증가시켜 배열의 원소에 대입할 값
            int count = 1;

            // 2차원 배열 길이만큼 순회
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                // 1차원 배열 길이만큼 순회
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = count++;
                    Console.Write(string.Format("{0, 2}", arr[i, j]) + " ");
                }
                Console.WriteLine();
            }

            // output2 (입력/출력을 나눠서)
            // 16 17 18 19 20
            // 11 12 13 14 15
            //  6  7  8  9 10
            //  1  2  3  4  5

            // 카운트 변수를 재사용하기 위해 1로 변경
            count = 1;

            // 입력
            for (int i = arr.GetLength(0) - 1; i > -1; --i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = count++;
                }
            }

            // 출력
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(string.Format("{0, 2}", arr[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
