using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._01_While문
{
    class _03_While문
    {
        static void Main()
        {
            // while문을 이용해서 1부터 100까지의 합계를 출력
            //  -> 5050

            // 1부터 100까지 증가시킬 변수
            int count = 1;

            // 합계를 저장할 변수
            int sum = 0;

            // count가 100이하라면 반복
            while (count <= 100)
            {
                sum += count++;
            }

            Console.WriteLine("1부터 100까지의 합계는 " + sum);
        }
    }
}
