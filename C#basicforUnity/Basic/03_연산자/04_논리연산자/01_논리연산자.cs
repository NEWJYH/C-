using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._04_논리연산자
{
    class _01_논리연산자
    {
        static void Main()
        {
            // 논리연산자란?
            // 참과 거짓으로 이루어지는 진리값이 피연산자인 연산을 말합니다

            // && : AND 연산자 (논리곱)
            // 피연산자로 오는 2개의 진리값이 모두 TRUE여야, 결과가 TRUE가 됩니다.
            bool check = true && true;
            Console.WriteLine("check의 값은 " + check);

            bool check2 = (10 > 20) && (50 < 60);
            Console.WriteLine(check2);

            // || : OR 연산자 (논리합)
            // 피연산자로 2개의 진리값 중에 하나라도 TRUE라면, 결과가 TRUE가 됩니다
            bool check3 = check || check2;
            Console.WriteLine(check3);

            // ! : NOT 연산자 (논리부정)
            // 피연산자의 진리값을 반대로 뒤집는 연산입니다
            bool check4 = !check3;
            Console.WriteLine(check4);
        }
    }
}
