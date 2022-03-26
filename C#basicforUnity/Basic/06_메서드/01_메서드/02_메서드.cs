using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._01_메서드
{
    class _02_메서드
    {
        // int형 데이터를 반환하는 GetMyNumber() 메서드를 정의
        static int GetMyNumber()
        {
            Console.WriteLine("원하는 번호를 입력해주세요.");
            int number = int.Parse(Console.ReadLine());

            // return문이란?
            // 메서드의 실행을 종료하고, 프로그램의 흐름을 호출자에게 돌려놓습니다.
            // 반환타입이 void가 아닌 메서드에서는 return 반환할 데이터; 으로
            // 데이터를 반환시킵니다.
            // 반환타입이 void인 메서드에서는 return; 을 이용하여 메서드의 실행을 종료

            return number;
        }

        static void Main()
        {

            int myNumber = GetMyNumber();

            Console.WriteLine("반환받은 데이터는 " + myNumber);
        }
    }
}
