using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._03_For문
{
    class _02_For문
    {

        static void Main()
        {
            // for문을 이용해서 아래와 같이 출력
            // for문을 2중으로 사용해서 출력

            // *
            // **
            // ***
            // ****
            // *****

            // y축
            for (int i = 0; i < 5; ++i)
            {
                // x축
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                // 한 줄 띄우기
                Console.WriteLine();
            }
        }
    }
}
