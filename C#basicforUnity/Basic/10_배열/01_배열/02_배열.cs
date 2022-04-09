using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._01_배열
{
    class _02_배열
    {
        static void Main()
        {
            // 보통 배열은 반복문과 함께 사용
            // for, foreach 문

            // foreach 문을 사용
            // foreach문이란?
            // 배열 또는 컬렉션을 순회하며 각 데이터 요소에 차례때로 접근하도록 하는 반복문
            // 배열 또는 컬렉션을 반복하는 단순하고 깔끔한 방법을 제공
            // 명시적인 반복구간을 작성하지 않으므로, 마지막 엘리먼트에 도달하면 자동으로 반복이 종료

            float[] myArray = { 160.0f, 120.23f, 23523.2f };

            // foreach (원소타입 변수명 in 배열변수명)
            foreach (float f in myArray)
            {
                Console.WriteLine("배열의 원소의 값은 " + f);
            }
        }
    }
}
