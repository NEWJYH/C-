using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._04_Nullable
{
    class _01_Nullable
    {
        static void Main()
        {
            // C# 에서 변수를 선언할때, 컴파일러는 초기화를 강제합니다.
            // 하지만, 필요에 따라서 메모리를 비워놓을 수도 있습니다.

            // null이란?
            // 비어있다는 것을 의미

            // null 값을 가질 수 있는 건 참조형식의 데이터만 null값을 가질 수 있음
            //  -> 값 형식 비어있는 상태를 나타낼 수 없다는 것

            // 프로그래밍을 하다보면 값 타입의 데이터에 null을 넣어 표현했을 때
            // 로직을 좀 더 수월하게 짤수 있는 상황이 있음..

            // Nullable Type (값 타입도 null을 표현할 수 있음)

            // 데이터 타입 뒤에 ? 붙여서 사용
            // 참조타입은 사용 불가 (참조 타입은 이미 null을 표현할 수 있으므로)

            int? a = null;
            // 값 타입의 데이터를 널러블로 만들었을 때
            // 사용할수 있는 맴버가 2개 -> hasValue, Value

            Console.WriteLine(a.HasValue);
            a = 30;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.Value);

        }

    }
}
