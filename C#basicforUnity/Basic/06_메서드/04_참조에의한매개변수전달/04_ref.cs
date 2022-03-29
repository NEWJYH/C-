using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._04_참조에의한매개변수전달
{
    class _04_ref
    {
        static void DivideOut(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main()
        {
            // 출력전용 매개변수 out
            // out은 ref처럼 참조 전달을 한다는 것은 동일
            // out 매개변수에 전달되는 인자가 메서드 내부에서 할당됨을 보장받습니다.
            //  -> out으로 전달한 인자는 메서드 내부에서 무조건 데이터 할당을 해야함

            int q;
            int r;

            DivideOut(3, 5, out q, out r);

            Console.WriteLine("몫 : " + q);
            Console.WriteLine("나머지 : " + r);
        }
    }
}
