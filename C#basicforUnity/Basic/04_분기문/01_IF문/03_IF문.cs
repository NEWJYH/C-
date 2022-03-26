using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._01_IF문
{
    class _03_IF문
    {
        static void Main()
        {
            // 일한 시간을 사용자 입력받고 임금을 출력하는 프로그램을 작성
            // 임금 = 일한시간 * 최저시급
            // 일한시간이 8시간을 초과한 경우, 초과한 시간은 최저시급 * 1.5배로 계산
            //  -> 초과한 시간만큼만 1.5배로 계산
            // 최저시급 8720원

            // 최저시급
            const int MinimumWage = 8720;

            // 기본시간
            const int DefaultTime = 8;

            // 일한 시간, 임금
            int workTime, pay;

            // 일한 시간을 입력
            Console.WriteLine("일한 시간을 입력해주세요.");
            workTime = int.Parse(Console.ReadLine());

            // 8시간을 초과한 경우
            if (workTime > DefaultTime)
            {
                pay = (int)(MinimumWage * DefaultTime + (1.5 * MinimumWage * (workTime - DefaultTime)));
            }
            // 8시간을 초과하지 않은 경우
            else
            {
                pay = MinimumWage * workTime;
            }

            Console.WriteLine("지급받을 임금은 " + pay + "원");
        }
    }
}
