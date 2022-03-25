using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._02_형식변환
{
    internal class _01_입력
    {
        static void Main()
        {
            // 사용자 입력을 받아 선언한 변수에 입력받은 데이터를 저장

            // 사용자가 입력 상태를 인지할 수 있게 가이드
            Console.WriteLine("문자열을 입력해주세요.");

            // 콘솔 입력 - Console.ReadLine()
            string input = Console.ReadLine();

            // 저장한 값을 출력
            Console.WriteLine("입력한 값은 " + input);

            // 사용자가 입력하는 데이터는 정수라고 가정
            Console.WriteLine("원하는 숫자를 입력해주세요.");

            // Console.ReadLine()이 반환하는 데이터는 문자열 데이터
            // 문자열 데이터를 정수타입의 변수에 담으려고 해서 오류가 발생함
            // -> 사용자가 정수를 입력하더라도 입력한 정수가 ReadLine에서는
            //    전부 문자열로 처리가 되기 때문에 최종적으로 string이 반환

            // 문자열을 다시 정수로 변환(타입변환)
            int myNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("입력받은 순자는 " + myNumber);

        }
    }
}
