using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._01_배열
{
    class _05_배열
    {
        static void Main()
        {
            // int형 배열 myArray는 30개의 원소를 가지고 있습니다.
            // 각 원소에 61~90 까지의 데이터를 넣은 후 출력

            // output
            // myArray index 0, value 61
            // ...
            // myArray index 29, value 90

            int[] myArray = new int[30];

            for (int i = 0; i < myArray.Length; ++i)
            {
                myArray[i] = 61 + i;
                Console.WriteLine($"myArray index {i}, value {myArray[i]}");
            }
        }
    }
}
