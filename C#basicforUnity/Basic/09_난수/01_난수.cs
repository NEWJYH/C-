using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._09_난수
{
    class _01_난수
    {
        static void Main()
        {
            // 난수란?
            // 특정한 배열 순서나, 규칙을 가지지 않는 연속적인 임의의 수를 의미

            // C#에서는 Random 클래스 제공
            Random rand = new Random();

            // 반복문을 통해 10개의 난수를 생성하고 출력
            for (int i = 0; i < 10; ++i)
            {
                // 랜덤객체.Next(min, max) : min부터 max -1 까지의 난수를 반환
                Console.WriteLine(rand.Next(0, 10));
            }
        }
    }
}
