using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._01_메서드
{
    class _03_메서드
    {
        // 메서드에서 사용할 데이터를 매개변수를 통해 전달받을 수 있습니다.

        // 매개변수란?
        // 메서드에서 사용할 데이터를 전달받는 일을 합니다.
        // 메서드 외부에서 사용될 수 없습니다.
        //  -> 매개변수는 해당 메서드의 지역변수

        // 자신이 태어난 연도를 전달받아 나이를 구하여 출력하는 메서드
        static void PrintAge(int birthYear)
        {
            int age = DateTime.Now.Year - birthYear + 1;

            Console.WriteLine("나이는 " + age + "살 입니다.");
        }

        static void Main()
        {
            Console.WriteLine("태어난 년도를 입력해주세요.");
            int year = int.Parse(Console.ReadLine());

            // year 변수의 데이터를 아규먼트(인자)로 넣어서
            // PrintAge()의 파라미터(매개변수)로 전달
            PrintAge(year);
        }
    }
}
