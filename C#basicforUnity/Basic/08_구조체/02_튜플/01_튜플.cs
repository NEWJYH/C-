using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._08_구조체._02_튜플
{
    class _01_튜플
    {
        static void Main()
        {
            // 튜플이란?
            // 여러 필드를 담을 수 있는 구조체입니다.
            // 타입의 이름을 가지지 않는 구조체입니다.
            // 보통 튜플은 프로그램 전체에서 사용할 타입을 선언할 때가 아닌
            // 암시적으로 사용할 복합 데이터 형식을 선언할 때 사용합니다.

            // 기본적인 튜플의 선언 방법
            // () 괄호 사이에 2개 이상의 필드를 지정함으로써 만들 수 있습니다.
            // 각각 입력한 튜플의 필드에는 Item1 ~ ItemN 으로 접근할 수 있습니다.
            var unnameType = (123, "그래");
            // 다음과 같은 튜플을 Unnamed Tuple(명명되지 않은 튜플)이라고 합니다.
            // 컴파일러가 튜플의 모양을 보고 직접 타입을 판단할 수 있도록 var 키워드를 사용
            // 튜플은 ValueTuple 구조체 형식 기반으로 만들어집니다.
            // 위와 같은 형식은 Item1에 123, Item2에 "그래"라는 값이 저장

            Console.WriteLine("item1 = " + unnameType.Item1);
            Console.WriteLine("item2 = " + unnameType.Item2);

            // 명명된 튜플(Named Tuple)도 사용 가능
            // 명명된 튜플은 각 필드에 이름을 선언하는 방식이며
            // 아래와 같이 사용
            var namedType = (Name: "카르마", Age: 23, Level: 18);

            Console.WriteLine("Name : " + namedType.Name);
            Console.WriteLine("Age : " + namedType.Age);
            Console.WriteLine("Level : " + namedType.Level);

            // 튜플의 각 요소들을 개별값으로 분해하는 것도 가능
            var (name, age, level) = namedType;
            // 대입하는 tuple 타입에 따라 name, age, level의 타입이 정해지며
            // 차례대로 값이 들어갑니다.

            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("level : " + level);

            // 튜플 분해 시 특정 필드를 무시하고 싶다면 _를 사용
            var (newName, _, newLevel) = namedType;

            Console.WriteLine("newName : " + newName);
            Console.WriteLine("newLevel : " + newLevel);
        }
    }
}
