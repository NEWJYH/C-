using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._01_배열
{
    class _04_배열
    {
        // arr에 전달된 배열의 모든 원소의 값을
        // value 값으로 할당
        public void InitArray(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = value;
        }

        // arr에 전달된 배열의 모든 원소의 값을 출력
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.WriteLine(arr[i]);
        }

        static void Main()
        {
            // 배열은 참조 타입에 속합니다.
            // 매개변수에 ref, out 키워드가 사용하지 않아도 전달했을 경우
            // 참조 전달이 됩니다.
            // = 연사자로 대입하였을 경우, 오른쪽 피연산자가 참조하는 배열을
            // 왼쪽 피연산자도 같이 참조하게 됩니다. (얕은 복사)

            // 배열을 동적할당하여 myArray1에 참조시킵니다.
            int[] myArray1 = new int[20];

            // myArray1이 참조하는 배열을 myArray2도 참조하도록 합니다.
            int[] myArray2 = myArray1;

            var myClass = new _04_배열();

            // myArray2가 참조하는 배열의 모든 원소의 값을 3으로 초기화
            myClass.InitArray(myArray2, 3);

            // myArray1이 참조하는 배열의 원소의 값을 모두 출력
            myClass.PrintArray(myArray1);

            Console.Clear();

            // 만약 배열의 얕은 복사가 아닌, 깊은 복사를 수행하고 싶다면?
            // Array 클래스가 지원해주는 Clone 메서드를 사용
            int[] myArray3 = (int[])myArray1.Clone();
            // array.Clone() : array의 깊은 복사를 수행
            // object 형식을 리턴하기 때문에 사용하고자 하는 형식으로 캐스팅

            myClass.InitArray(myArray3, 1);

            Console.WriteLine("Print MyArray1");
            myClass.PrintArray(myArray1);

            Console.WriteLine();

            Console.WriteLine("Print MyArray3");
            myClass.PrintArray(myArray3);
        }
    }
}
