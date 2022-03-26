using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._02_Switch문
{
    class _02_Switch문
    {
        static void Main()
        {
            // switch/case문을 이용하여 데이터 타입에 따라 분기를 나눌 수 있습니다.
            //  -> 이 때 case문에 꼭 식별자(변수이름)을 붙여줘야 됩니다.

            object obj = 10;

            switch (obj)
            {
                case int i: // obj의 타입이 int라면 현재 case에서 i라는 임시변수로 사용
                    Console.WriteLine("obj는 int! " + i);
                    break;
                case double d: // obj의 타입이 double이라면 현재 case에서 d라는 임시변수로 사용
                    Console.WriteLine("obj는 double! " + d);
                    break;
                case float f:
                    Console.WriteLine("obj는 float! " + f);
                    break;
            }
        }
    }
}
