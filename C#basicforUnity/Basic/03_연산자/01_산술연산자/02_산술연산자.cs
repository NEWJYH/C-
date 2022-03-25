using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._01_산술연산자
{
    class _02_산술연산자
    {
        static void Main()
        {
            // int형 변수 n과 m을 선언한 후
            // Console.ReadLine()을 통해 n과 m을 입력받고
            // 산순연산을 이용하여 연산 후 결과를 출력

            // ex
            // input
            // N을 입력해주세요
            // 7
            // M을 입력해주세요
            // 7 

            // output
            // sum : 14
            // sub : 0
            // mul : 49
            // div : 1.000... (실수 형태로 출력)
            // rem : 0

            Console.WriteLine("N을 입력해주세요.");
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine("M을 입력해주세요.");
            uint m = uint.Parse(Console.ReadLine());

            Console.WriteLine("sum : " + (n + m));
            Console.WriteLine("sub : " + (n - m));
            Console.WriteLine("mul : " + (n * m));
            Console.WriteLine("div : " + ((double)n / m));
            Console.WriteLine("rem : " + (n % m));
        }
    }
}
