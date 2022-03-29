using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._04_객체복사
{
    class Test
    {
        public int c;
        public Test DeepCopy()
        {
            return (Test)this.MemberwiseClone();
        }
    }

    class Sample
    {
        public int a;
        public Test b;

        public Sample DeepCopy()
        {
            // object.MemberwiseClone() 해당 메서드를 이용하여 깊은복사
            var clone = (Sample)this.MemberwiseClone();
            clone.b = this.b.DeepCopy();

            return clone;
        }
    }

    class _01_객체복사
    {
        static void Main()
        {
            // Sample 타입의 객체를 힙에 동적할당하여 스택의 s1이 참조하도록 합니다.
            Sample s1 = new Sample();

            Sample s2 = s1;

            // s1이 참조하는 객체의 a값을 10으로 변경
            s1.a = 10;

            // s2가 참조하는 객체의 a값을 100으로 변경
            s2.a = 100;

            Console.WriteLine("s1.a = " + s1.a);
            Console.WriteLine("s2.a = " + s2.a);

            // 둘 다 100이라는 결과가 나오는 이유?
            // 클래스는 참조타입이기 때문에 = 대입 연산자로 대입하였을 경우
            // 힙에 있는 데이터가 복사되는 것이 아닌, 스택에 있는 데이터가 복사되므로
            // 값 복사가 일어나지않고, 객체 참조가 일어납니다

            // 그러므로 s1이 가리키는 객체를 s2도 가리키게 되므로
            // s1과 s2는 동일한 객체를 가리키게 됩니다.

            // 이렇게 값 복사가 아닌 참조만 복사하는 것을
            // Shallow Copy (얕은 복사)라고 합니다.
            // 반대로 값까지 복사하는 것을 Deep Copy(깊은 복사)라고 합니다.

            // 깊은 복사를 하려면?

            s1.b = new Test();
            Sample s3 = s1.DeepCopy();

            s1.a = 30;
            s3.a = 80;

            s1.b.c = 100;

            Console.WriteLine("s1.a = " + s1.a);
            Console.WriteLine("s3.a = " + s3.a);

            Console.WriteLine("s1.b = " + s1.b.c);
            Console.WriteLine("s3.b = " + s3.b.c);
        }
    }
}
