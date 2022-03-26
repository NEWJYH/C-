using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._01_메서드
{
    class _04_메서드
    {

        static void Main()
        {
            // 학생 성적평가 프로그램
            // int형 변수 kor, eng, math에 각각 국,영,수 점수를 사용자 입력받고
            // [과목의 총점], [과목의 평균], [최고점수]를 출력하는 메서드를 정의하여
            // 아래와 같이 동작하는 프로그램 작성

            // input
            // 국어 : 90
            // 영어 : 80
            // 수학 : 85

            // output
            // 총점 : 255
            // 평균 : 85
            // 최고점수 : 90

            Console.Write("국어 : ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("영어 : ");
            int eng = int.Parse(Console.ReadLine());

            Console.Write("수학 : ");
            int math = int.Parse(Console.ReadLine());

            PrintSum(kor, eng, math);
            PrintAvg(kor, eng, math);
            PrintMax(kor, eng, math);
        }

        static void PrintSum(int kor, int eng, int math)
        {
            Console.WriteLine("총점 : " + (kor + eng + math));
        }

        static void PrintAvg(int kor, int eng, int math)
        {
            Console.WriteLine("평균 : " + ((kor + eng + math) / 3));
        }

        static void PrintMax(int kor, int eng, int math)
        {
            int max = kor > eng ? kor : eng;
            max = max > math ? max : math;

            Console.WriteLine("최고점수 : " + max);
        }

       
    }
}
