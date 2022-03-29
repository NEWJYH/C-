using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._04_참조에의한매개변수전달
{
    class _02_ref
    {
        // 매개변수로 전달된 value를 참조반환하는 메서드
        static ref int GetRefData(ref int value)
        {
            return ref value;
        }

        static void Main()
        {
            // ref 한정자를 이용하면 참조 반환도 가능합니다.
            // 이러한 방식을 이용하면 반환받은 결과를 참조로 다룰 수 있습니다.

            // 사용방법
            // 반환타입 앞에 ref 한정자를 작성하고, return문이 반환하는
            // 변수 앞에도 ref 키워드를 명시해야합니다.

            int a = 10;

            // b에 a를 참조시킵니다.
            ref int b = ref GetRefData(ref a);
            // 참조반환을 사용하려면 반환되는 참조를 받는 변수의 타입에도 ref 작성
            // 메서드를 호출하는 곳 앞에도 ref 작성
            //  -> 메서드를 호출하는 곳 앞에 ref를 작성하지 않을 시, 값 반환으로 사용

            // GetRefData는 참조반환 메서드이지만,
            // 호출하는 곳에서 ref를 붙이지 않을 시 값 반환으로 사용
            int c = GetRefData(ref a);

            a = 1000;

            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
