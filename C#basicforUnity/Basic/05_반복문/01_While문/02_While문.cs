using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._01_While문
{
    class _02_While문
    {


        static void Main()
        {
            // while문을 중첩시켜서 사용

            int a = 0;

            // a가 3 미만이라면 반복
            while (a < 3)
            {
                Console.WriteLine("a의 값은 " + (a++));

                int b = 0;

                // b의 값이 3미만이라면 반복
                while (b < 3)
                {
                    Console.WriteLine("b의 값은 " + (b++));
                }
            }
        }
    }
}
