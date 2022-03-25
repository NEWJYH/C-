using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._02_형식변환
{
    class _02_형식변환
    {
        static void Main(string[] args)
        {
            // 형식변환(Type Conversion)을 사용해서
            // 특정 데이터를 다른 데이터형 변수로 옮겨 담을 수 있습니다.

            // 이전의 박싱, 언박싱도 값 형식과 참조 형식간의 형식변환이라고 할 수 있습니다.
            // 사소한 부주의 때문에 데이터에 손상을 입힐 수도 있는 작업

            // 형식 변환에는 크게 2가지
            // 암시적 변환 :
            //   작은 데이터 타입에서 큰 데이터 타입으로 변환하는 것처럼
            //   변환에 대한 안정성과 데이터 손실에 대한 리스크 없이 데이터형이 변환되는 것을 의미
            //   -> 변환에 대한 것을 개발자가 직접 작성할 필요없이 컴파일러가 알아서 추론하여 변환하므로
            //      암시적 변환이라고 한다.

            // 명시적 변환 : 
            //   큰 데이터 타입에서 작은 데이터 타입으로 변환하는 것 처럼  변환 시에
            //   값의 손실이 발생할 수 있거나, 변환이 실패할 수 있는 경우 -> 명시적 변환 사용
            //   캐스팅이라고 합니다.

            // 값의 손실이란?
            // 변경하고자 하는 목표가 되는 데이터 타입이 허용할 수 있는 범위가 작은 경우에
            // 허용할 수 없는 범위가 버려지게 되는 현상
            //  - 실수에서 정수형으로 변환 시에 소수점 값이 버려짐
            //  - 부동소수점 형식 간의 변환에서는 정밀도에 손상을 입게 됩니다. ( double -> float)

            // 암시적 변환 ex
            // 값의 손실이 없습니다.
            float myFloat = 10;
            Console.WriteLine("myFloat의 값은 " + myFloat);

            // 명시적 변환
            // 값의 손실이 발생할 수 있으며,
            // (변경하고자하는 데이터타입)을 앞에 붙여 캐스팅
            int myInt = (int)3.14f;
            Console.WriteLine("myInt의 값은 " + myInt);

            double pi = 3.14d;

            // string piStr = (string)pi;
            // string으로 명시적 변환이 불가능함
            // 이러한 경우를 위해서 object는 ToString()이라는 메서드를 제공
            // 해당 메서드를 이용하여 문자열로 변환 후 데이터를 반환함
            string piStr = pi.ToString();
            Console.WriteLine("piStr의 값은 " + piStr);

            // 그럼 반대로 string형을 다른 숫자 자료형으로 변환
            // 이 때 변환하고자 하는 숫자타입.Parse() 메서드를 사용
            //  -> 변환하는 문자열 데이터에 숫자만 존재해야함
            piStr = "123.456";
            pi = double.Parse(piStr);
            Console.WriteLine("pi의 값은 " + pi);
        }
    }
}

