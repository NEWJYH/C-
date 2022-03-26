using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._01_메서드
{
    class _01_메서드
    {
        static void Main()
        {
            // 로컬함수란?
            // 메서드 내부에 선언되며, 선언된 메서드 내부에서만 사용가능한 함수입니다.
            // 로컬함수는 자신이 존재하는 지역에 선언되어있는 변수를 사용할 수 있으며,
            // 클래스 멤버변수, 메서드를 모두 사용할 수 있습니다.

            // 로컬 메서드가 아닌 로컬 함수인 이유?
            // 클래스의 멤버가 아니기 때문에 메서드가 아닌 함수라고 합니다.
            //  -> 로컬함수의 영역은 로컬함수를 선언한 메서드의 내부

            // 그래서 어느 경우에 사용?
            //  -> 메서드 내에서 반복되는 코드가 존재하고, 이 코드가 이 메서드에서만 사용될
            //     해당 코드를 로컬함수로 만들어서 사용

            const string endLine = "\n";

            PrintString("Hello");
            PrintString("World");

            // 로컬함수를 메서드 내부에 정의
            void PrintString(string print)
            {
                Console.Write(print + endLine);
            }

        }
    }
}
