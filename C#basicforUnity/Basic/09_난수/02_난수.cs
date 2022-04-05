using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._09_난수
{
    class _02_난수
    {
        static void Main()
        {
            // 난수를 이용하여 확률을 구현
            // 0%는 없다고 가정, 1~100까지의 범위에 속하는 난수를 뽑습니다.
            // 뽑은 난수가 내가 미리 설정한 확률 값 이하인지 검사
            // 만약 이하라면 성공, 아니라면 실패

            // 뽑기 성공 확률
            int successPer;

            // 성공확률을 잘못된 값을 입력했을 경우
            // 성공확률 입력을 다시 반복하도록 하기 위하여, 조건을 true로 설정
            // 정상적인 입력이라면 break문을 통해, 무한루프를 탈출
            while (true)
            {
                // 성공확률 입력
                Console.WriteLine("1부터 100 사이의 값으로 확률을 설정해주세요.");
                successPer = int.Parse(Console.ReadLine());

                // 올바른 값을 입력했을 경우
                if (successPer > 0 && successPer <= 100)
                {
                    // 정상적인 입력이므로 루프 탈출
                    break;
                }
                // 잘못된 값을 입력했을 경우
                else
                {
                    Console.WriteLine("!!! Input Error !!!");
                    Console.WriteLine("1부터 100 사이의 값을 입력해주세요!");
                    Thread.Sleep(1000);
                    Console.Clear(); // 화면 지우기
                }
            }

            Console.WriteLine("확률이 " + successPer + "%로 설정되었습니다.");
            Thread.Sleep(500);
            Console.Clear();

            Console.Write("아이템 뽑는 중");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

            // 1부터 100 사이의 난수를 뽑음
            int pick = new Random().Next(1, 101);

            // 성공인지 (확률 값 이하인지)
            if (pick <= successPer) Console.WriteLine("!!! 성공 !!!");
            else Console.WriteLine("!!! 실패 !!!");
        }
    }
}