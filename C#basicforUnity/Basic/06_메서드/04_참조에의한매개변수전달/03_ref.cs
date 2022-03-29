using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._04_참조에의한매개변수전달
{
    class _03_ref
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            // ref 한정자를 이용하여 2개의 매개변수에 전달된 변수의 값을 변경하는
            // Swap 메서드를 작성

            // ex
            // int a = 10;
            // int b = 20;
            // Swap 실행 (a,b전달)

            // output
            // a = 20
            // b = 10

            int a = 10;
            int b = 20;

            Swap(ref a, ref b);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
