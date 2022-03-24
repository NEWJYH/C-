﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._01_기본데이터형식
{
    class _01_기본데이터형식
    {
        static void Main(string[] args)
        {
            // 변수(Variable) 란?
            // 변하는 수

            // 우리가이전까지 사용했던 리터럴 데이터는 사용이 끝나면 사라지는 데이터
            // 하지만 프로그래밍을 하게 되면, 계속해서 유지해야되는 데이터가 생기는데
            // 이 때 변수를 사용

            // 메모리 측면에서 보자면 데이터를 담는 "일정한크기"의 공간

            // 데이터 형식의 종류
            // 1. 기본 데이터 형식과 복합 데이터 형식
            // 2. 값 형식과 참조 형식

            // 기본 데이터 형식
            // 총 15가지를 C#에서 지원하며,
            // 크게 숫자, 논리, 문자열, 오브젝트 형식으로 나눌수 있습니다.

            // 복합 데이터 형식
            // 기본 데이터 형식을 조합하여 만들어낸 데이터 형식
            // 클래스, 구조체, 배열 등이 있습니다.

            // 값 형식
            // 변수가 값을 담는 데이터 형식 (주로 숫자형 데이터)

            // 참조 형식
            // 변수가 값 대신, 값이 있는 위치를 갖는 데이터 형식
            // -> 위치란? 메모리 상에서 값이 저장되어 있는 주소

            // Stack, Heap Memory
            // Stack : 프로그램이 자동으로 사용하는 임시 영역
            // 값 형식의 데이터들이 이 곳에 할당됩니다.
            // 지역변수, 매개변수, 리턴 값 처럼 잠시 사용되었다가
            // 사라지는 데이터를 저장하는 영역
            // 메서드를 호출할 때 할당되고, 호출이 끝나면 시스템에 반환

            // Heap : 프로그래머가 필요에 의해 동적으로 메모리를 할당할 때 사용되는 메모리 영역
            // 참조 형식의 데이터들이 이곳에 할당되며, 이 데이터가 있는 메모리 위치를 가리키는 변수
            // 스택에 할당됩니다.

            // C, C++ 기준
            // 스택과 다르게 메모리 할당이 이루어지면서 사용이 끝났을 때 알아서 해제되지 않습니다.
            // 개발자가 직접 사용한 메모리를 해제해야했음

            // C# 기준
            // GC(Garbege Collection) 이라는 청소부가 힙 메모리에 존재하며, 사용되지 않는 메모리를
            // 메모리 해제합니다.

            // 숫자형 데이터 형식(Numeric Type)
            // 프로그래밍을 하며 제일 많이 다루게 될 데이터 형식, 값 형식
            // C#은 15가지 기본 데이터 형식 중 12가지를 숫자 데이터 형식으로 제공하며
            // 12가지를 나눠 9가지는 정수, 3가지는 실수 자료형으로 사용

            // 정수는 음수, 0, 양수 <- 이것만 표현하면 되는데 굳이 9가지로 나눈이유?
            // 각각 타입마다 크기와 범위가 다름
            // 그러므로 코드에 사용될 데이터가 어느 정도 범위에 있는지 가늠한 뒤
            // 적절한 데이터 형식을 선택함으로써 메모리를 효율적으로 사용하기 위해서

            // [데이터 타입]   [크기(byte)]    [담을 수 있는 값의 범위]
            // 부호 있는 정수 (signed)
            //    sbyte         1 (8비트)           -128 ~ 127
            //    short         2 (16비트)        -32768 ~ 32767
            //     int          4 (32비트)       약 -21억 ~ 21억
            //     long         8 (64비트)       약 -922경 ~ 922경

            // 부호 없는 정수 (unsigned)
            //     byte         1                     0 ~ 255
            //     ushort       2                     0 ~ 65535
            //     uint         4                     0 ~ 약 42억
            //     ulong        8                     0 ~ 약 1844경

            // 변수를 선언
            // 데이터 타입 변수이름(식별자);
            int myNumber;
            uint myNuber2;
            // 이렇게 선언하면 컴파일러는 int형식을 위해 메모리 공간을 할당하며
            // 이 공간을 myNumber 변수가 사용할 수 있도록 준비

            // 선언한 변수에 최초로 값을 할당합니다. (변수 초기화)
            // 데이터를 넣는 행위 -> 대입
            // 대입연산자 =
            myNumber = 1000;

            Console.WriteLine("myNumber의 값은 " + myNumber);

            Console.WriteLine("long의 최소값은 " + long.MinValue);
            Console.WriteLine("long의 최대값은 " + long.MaxValue);

        }
    }
}
