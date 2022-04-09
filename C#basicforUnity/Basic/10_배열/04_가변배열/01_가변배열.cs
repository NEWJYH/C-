using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._04_가변배열
{
    class _01_가변배열
    {
        static void Main()
        {
            // 가변배열이란?
            // 다양한 길이의 배열을 요소로 가지는 다차원 배열을 의미

            // 가변배열은 다음과 같이 선언
            //  -> 최상위 차원의 길이는 고정, 하위차원은 가변적
            int[][] arr = new int[3][];

            // 2차원 배열의 0번째 원소에 1차원 배열을 할당
            arr[0] = new int[2];
            // 2차원 배열의 1번째 원소에 1차원 배열을 할당
            arr[1] = new int[3];
            // 2차원 배열의 2번째 원소에 1차원 배열을 할당
            arr[2] = new int[4];

            int count = 1;
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                // 1차원 배열 순회 시 각 원소의 1차원 배열 길이가 다르므로
                // 2차원 배열의 각 원소에 접근하여 Length를 통해
                // 서로 다른 길이를 구함
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    arr[i][j] = count++;
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
