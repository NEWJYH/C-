using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._01_While문
{
    class _04_While문
    {
        static void Main()
        {
            // while문을 이용해서 구구단을 출력하는 프로그램을 작성

            // input
            // 구구단 몇 단을 출력할까요?
            // 6

            // output
            // 6 x 1 = 6
            // 6 x 2 = 12
            // ...
            // 6 x 9 = 54

            Console.WriteLine("구구단 몇 단을 출력할까요?");
            int number = int.Parse(Console.ReadLine());

            // 1부터 10까지 증가할 변수
            int count = 1;

            while (count < 10)
            {
                //Console.WriteLine(number + " x " + count + " = " + (number * count));
                Console.WriteLine($"{number} x {count} = {number * count}");
                ++count;
            }
        }
    }
}
