using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._05_반복문._02_DoWhile문
{
    class _01_DoWhile문
    {
        static void Main()
        {
            // Do While문이란?
            // 조건식을 평가하기 전에, 무조건 처음 한 번 do 구문을
            // 실행시킨 후에 while 조건을 평가함.

            int a = 10;

            do
            {
                Console.WriteLine("a의 값은 " + a);
                --a;
            }
            // a가 10 이 아니고, a가 0 보다 크다면 반복하게
            while (a > 10 && a > 0);
        }
    }
}
