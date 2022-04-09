using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._02_가변인자매개변수
{
    class _01_가변인자매개변수
    {
        // 가변인자 매개변수를 이용하여 배열을 생성하는 메서드를 작성
        private int[] MakeIntArray(params int[] values)
        {
            return (int[])values.Clone();
        }

        static void Main()
        {
            // 가변 인자 매개변수란?
            // 개수가 유연하게 변할 수 있는 매개변수를 말합니다.
            // 매개변수의 개수에 따라 오버로딩 처리하지 않아도 됌
            // params 키워드와 배열을 사용
            // 가변인자 매개변수는 항상 필수 매개변수 뒤에 선언할 수 있음

            var myClass = new _01_가변인자매개변수();

            int[] array = myClass.MakeIntArray(1, 3, 65, 23, 5332);

            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
