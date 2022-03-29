using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._02_선택적매개변수
{
    class _01_선택적매개변수
    {
        public enum CalculateType { Add, Sub, Mul, Div }

        // 2개의 double 데이터를 받아, 사용자가 선택한 연산을 실행한 후 결과를 double 데이터형식으로 반환하는 메서드
        static double Calculate(double a, double b, CalculateType type = CalculateType.Add)
        {
            // 연산 결과를 저장할 변수
            double result = 0;

            switch (type)
            {
                case CalculateType.Add:
                    result = a + b;
                    break;
                case CalculateType.Sub:
                    result = a - b;
                    break;
                case CalculateType.Mul:
                    result = a * b;
                    break;
                case CalculateType.Div:
                    result = a / b;
                    break;
            }

            return result;
        }


        static void Main()
        {
            // 선택적 매개변수란? (옵셔널 파라미터)
            // 기본값을 가지는 매개변수를 말하며,
            // 필요에 따라 데이터를 할당할 수 있는 매개변수를 의미
            // 선택적 매개변수는 메서드를 호출할 때 데이터 할당을 생략할 수도 있습니다
            //  -> 할당 생략 시 설정해둔 기본값으로 해당 매개변수가 사용됌
            // 물론 필요에 따라 특정 데이터를 할당시킬 수도 있습니다.
            // 꼭, 필수 매개변수 뒤에 선언되어야 합니다.

            Console.WriteLine("a를 입력해주세요.");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b를 입력해주세요.");
            double b = double.Parse(Console.ReadLine());

            double result = Calculate(a, b);

            Console.WriteLine("연산결과 : " + result);
        }
    }
}
