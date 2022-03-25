using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._03_상수와열거형
{
    class _01_상수
    {
        // 상수란?
        // 변수와 달리 저장된 값을 바꿀수 없는 메모리 공간
        // 변수처럼 선언하되, 타입 앞에 const 키워드를 붙여 사용합니다.

        // 상수 선언시, 선언과 동시에 초기화가 강제됨
        //  -> 선언 시에 무조건 사용할 값을 대입

        const float pi = 3.14f;

        // 상수이기 때문에 초기 할당된 데이터 변경 불가능
        // pi = 123.456f;

        // 데이터의 기본 값
        // 값 타입 -> 기본값 0
        // 참조타입 -> 기본값 null
        // 따라서, 상수를 선언 시에 초기화를 꼭 해줘야함
    }
}
