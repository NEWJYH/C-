using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._10_배열._01_배열
{
    class _03_배열
    {
        static void Main()
        {
            // 만약 배열의 범위를 초과하여 사용할 경우?
            // IndexOutOfRangeException 이 발생
            // 배열 또는 컬렉션의 범위를 벗어난 멤버에 접근하려 할 때
            // 발생하는 예외
            // 이러한 예외에 대하여 프로그래머 항상 생각하며 최대한 대비해야합니다.

            // 예외 (Exception)
            // 프로그래머의 실수 또는 외부시스템이나 조건들에 의해
            // 더 이상 작업을 수행하지 못하는 것을 말합니다.

            // 예외 처리
            // 이러한 예외가 프로그램의 오류나 다운으로 이루어지지 않도록
            // 적절하게 처리하는 것을 의미

            // 버그 (Bug)
            // 프로그램의 논리 처리상에서 컴파일러가 감지하지 못하는 범위의
            // 구문에러가 프로그램에 존재함을 의미합니다.
            // 이는 논리 처리 상의 정확한 구문을 사용함으로써 해결


            // 배열 선언
            int[] myArray = { 3, 5, 9 };

            // 반복문을 사용 시 반복문의 조건식을 리터럴 데이터로 명시적으로
            // 작성함으로써 발생하는 문제

            // 배열의 사이즈를 구해서 해당 사이즈만큼 반복되게
            //  -> 배열의 사이즈만큼 반복되기 때문에 잘못된 인덱스의 접근을 방지

            for (int i = 0; i < myArray.Length; ++i)
            {
                myArray[i] = i;
                Console.WriteLine(myArray[i]);
            }

            // try / catch 
            // try문을 통해 특정 작업을 시도하고 시도 중에 예외가 발생했을 때
            // catch문을 통해 어떤 예외가 발생했는지 확인 및 예외 처리를 할 수 있다.

            for (int i = 0; true; ++i)
            {
                try
                {
                    Console.WriteLine($"myArray{i} = {myArray[i]}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("예외가 발생했습니다.");
                    Console.WriteLine("내용 : " + e);
                    break;
                }
            }

        }
    }
}
