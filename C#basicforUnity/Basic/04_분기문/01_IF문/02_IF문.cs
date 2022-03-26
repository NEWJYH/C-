using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._01_IF문
{
    class _02_IF문
    {
        static void Main()
        {
            // 국어, 영어, 수학 점수를 사용자 입력 받고
            // 3과목의 평균을 구하여 아래와 같은 결과를 출력

            // 평균이 80이상이라면, "평균은 80 이상입니다." 출력
            // 아니라면, "평균은 80이상이 아닙니다." 출력

            // input
            // 국어 : 80
            // 영어 : 70
            // 수학 : 80

            // output
            // 평균은 80이상이 아닙니다.

            Console.Write("국어 : ");
            string a = Console.ReadLine();
            a = (a == "") ? "0" : a;
            int kor = int.Parse(a);


            Console.Write("영어 : ");
            int eng = int.Parse(Console.ReadLine());
     
            Console.Write("수학 : ");
            int math = int.Parse(Console.ReadLine());

            var avg = (kor + eng + math) / 3;

            if (avg >= 80)
            {
                Console.WriteLine("평균의 80 이상입니다.");
            }
            else
            {
                Console.WriteLine("평균은 80 이상이 아닙니다.");
            }
        }
    }
}