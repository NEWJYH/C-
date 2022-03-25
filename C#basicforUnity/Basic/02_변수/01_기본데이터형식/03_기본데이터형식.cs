using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._01_기본데이터형식
{
    class _03_기본데이터형식
    {
        static void Main(string[] args)
        {
            // 부동 소수점 방식
            // 소수점이 고정되어 있지 않고, 움직이면서 수를 표현한다는 뜻에서 지어진 이름

            // [데이터 형식]    [크기(byte)]   [표현할 수 있는 자리수]
            //    float         4(32비트)       단일 정밀도 부동 소수점 방식 (유효 자리 : 7자리)
            //    double        8(64비트)       복수 정밀도 부동 소수점 방식 (유효 자리 : 15~16자리)
            //   decimal        16(128비트)     29자리 데이터를 표현할 수 있는 소수 형식
            //                                  float, double 형시과는 다른 방식으로 데이터를 다루며, 정밀도가 훨씬 높음

            // IEEE 에서 실수를 표현하기 위한 표준 방법
            // 정밀도란? 소수점 형식의 특징이자 한계를 의미
            // float 7자리를 넘어가면 나머지 숫자는 대략적으로 표현

            // 값 뒤에 f나 F를 붙여서 flaot형 데이터를 표현
            float myFloat = 3.14f;
            Console.WriteLine("myFloat의 값은 " + myFloat);

            // double은 d 나 D를 붙여서 표현해도 되지만
            // 작성하지 않아도 double로 인식
            double myDouble = 123.4567;
            Console.WriteLine("myDouble의 값은 " + myDouble);

            // decimal은 m이나 M을 붙여서 표현
            decimal myDecimal = 0.123456789m;
            Console.WriteLine("myDecimal의 값은 " + myDecimal);

            // 내가 값을 사용하는 범위가 엄청 크지가 않다면
            // 정수데이터 대신 실수데이터를 사용해도 되는지??
            //  -> 실수를 사용하면 정수도 표현할 수 있으니까..

            // 1. 소수점을 표현하기 위해서 일부 bit를 사용하므로,
            //    실수형으로 같은 메모리 크기를 가지는 타입이라도 표현할 수 있는 범위가 훨씬 적음
            // 2. cpu가 연산을 하는데 정수타입보다 실수타입 연산이 훨씬 느리기 때문에..

        }
    }
}
