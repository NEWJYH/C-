using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._01_출력
{
    class _01_출력
    {
        static void Main()
        {
            // using - 사용중
            // namespace - 이름 공간 (특정한 이름으로 여러 기능들을 묶을 수 있는 기능)

            // 클래스는 기본적으로 데이터와 메서드(기능)으로 이루어졌습니다.
            // C# 프로그램을 구성하는 기본 단위 -> 클래스

            // Main : 프로그램 시작점 (엔트리 포인트)
            // 프로그램에 하나만 존재 해야함

            // 콘솔에 출력
            // Console.Write, Console.WriteLine 사용

            // Write :  개행 없이 문자열 출력

            Console.Write("Hello World\n");
            // \n : 개행문자
            // ; : 해당 라인이 끝났다는 것을 의미하는 문법적 요소

            // WriteLine : 문자열 출력 후 한 줄 개행
            Console.WriteLine("안녕");

            // 코드를 프로그램으로 변환하는 작업 -> 빌드(Build)
            // 빌드 단축키 : Ctrl + F5
        }
    }
}
