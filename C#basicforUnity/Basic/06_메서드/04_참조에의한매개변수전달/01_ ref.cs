using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._06_메서드._04_참조에의한매개변수전달
{
    class _01_ref
    {
        // 값에 의한 호출
        static void AddTen(int value)
        {
            value += 10;
        }

        // 참조에 의한 호출
        static void AddTen2(ref int value)
        {
            // 매개변수에 사용되는 ref란?
            // 해당 매개변수에 전달되는 인자는 값이 아닌, 참조로 전달됌을 의미
            // 또, ref로 참조 전달되는 값 형식은 boxing 현상이 일어나지 않습니다.

            value += 10;
        }

        static void Main()
        {
            int a = 30;

            AddTen(a);

            Console.WriteLine("a의 값은 " + a);
            // a의 값이 그대로인 이유?
            // AddTen()의 매개변수 value에는 a가 아닌
            // a가 가진 값 10이 복사되어서 전달되었기 때문에
            // 이러한 현상을 값 복사라고 합니다.
            // 또, 매개변수에 위와 같은 방식으로 전달하는 것을
            // Call/Pass By Value (값에 의한 호출/전달) 이라고 합니다.

            // 그렇다면, 원래 의도했던 변수 a를 전달시키는 방법
            // 참조에 의한 호출을 위한 ref, out 한정자를 사용해야합니다.

            // ref 한정자를 사용한 매개변수에 인자를 전달할 때에도 ref 한정자를 사용
            AddTen2(ref a);

            Console.WriteLine("a의 값은 " + a);
        }
    }
}
