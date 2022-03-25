using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._03_연산자._02_단항연산자
{
    class _01_단항연산자
    {
        static void Main()
        {
            // 단항연산자란?
            // 피연산자가 1개인 연산자입니다.
            // 증가연산자와 감소연산자를 사용할 수 있습니다.
            // 단항연산자를 사용 시, 피연산자의 앞에 붙였냐, 뒤에 붙였냐에
            // 따라 전처리 연산, 후처리 연산으로 나눠 사용 할 수 있습니다.
            // 숫자 데이터 형식에 사용 가능

            int count = 0;

            // 증가연산자(++)
            // 피연산자의 값을 1증가
            ++count;// count = count + 1; 과 같음
            Console.WriteLine(count);

            // 감소연산자 (--)
            // 피연산자의 값을 1 감소
            --count; // count = count - 1; 과 같음
            Console.WriteLine(count);

            // 전처리 연산
            // 연산자를 변수 앞에 사용합니다.
            // 변수에 직접적으로 연산을 한 뒤 결과를 돌려줍니다
            Console.WriteLine("++count의 값은 " + (++count));

            // 후처리 연산
            // 연산자를 변수 뒤에 사용합니다
            // 연산 시에 변수를 복사한 뒤, 복사본에 연산을 한 후
            // 결과를 돌려줍니다.
            Console.WriteLine("count++의 값은 " + (count++));
            Console.WriteLine("count : " + count);

            // 후처리 연산이 사용될 때, 임시변수가 하나 생성되기 때문에
            // 전처리 연산자가 후처리 연산자보다 효율이 좋습니다.
            // 전처리, 후처리 성능 차이는 매우 미비하기 때문에..
            // 굳이 신경 쓸 필요는 없다...
        }
    }
}
