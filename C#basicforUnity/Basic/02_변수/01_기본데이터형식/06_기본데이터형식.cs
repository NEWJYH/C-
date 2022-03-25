using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._02_변수._01_기본데이터형식
{
    class _06_기본데이터형식
    {
        // 모든 데이터를 다룰수 있는 object 형식
        // C#에서는 모든 데이터 형식을 자동으로 object를 상속받게 하였습니다.

        // 상속이란?
        // 부모 데이터 형식의 기능을 자식이 물려 받는 것을 의미
        // 상속을 사용할 경우 부모로부터 자식은 데이터와 기능을 물려 받게 되며
        // 자식은 부모와 같은 형태로 동작할 수 있습니다.

        static void Main()
        {
            object obj1 = "C#";
            object obj2 = 'a';
            object obj3 = 111;
            object obj4 = 12.34f;
            object obj5 = false;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);
            Console.WriteLine(obj5);

            // 이렇게 편한데 object 형식을 사용하지 않는 이유
            // object는 참조 형식
            // int, flaot 등등 값 타입의 데이터는 스택에 할당되지만
            // object는 참조형식이므로 힙 메모리도 같이 사용하게 되며,_
            // myNumber에 담긴 값 1000을 stack에 저장합니다.
            int myNumber = 1000;

            // myNumber에 담긴 값 1000을 박싱해서 heap에 저장한 후
            // heap에 저장된 위치(주소)를 myObject가 가리키도록(참조) 합니다.
            object myObject = myNumber;
        }
    }
}
