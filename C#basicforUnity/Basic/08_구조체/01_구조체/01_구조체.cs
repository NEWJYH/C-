using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._08_구조체._01_구조체
{
    public struct Point
    {
        // 구조체는 내부에서 필드를 정의할 수 없음
        // public double x = 30;
        public double x;
        public double y;

        // 구조체는 기본생성자 사용 불가
        // public Point()
        // { 
        // }

        public Point(double x, double y)
        {
            // 생성자는 무조건 매개변수가 있어야하며,
            // 모든 필드를 초기화시켜야 한다.
            this.x = x;
            this.y = y;
        }

        public void SetPoint(Point point)
        {
            this = point;
        }

        // 메서드 오버로딩 가능
        public void SetPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class _01_구조체
    {
        static void Main()
        {
            // 구조체란?
            // 클래스처럼 복합 데이터 형식이라는 점에서는 비슷하지만
            // 참조 타입이 아닌 값 타입입니다.

            // struct 키워드로 구조체를 선언
            // 기본 접근제한자가 클래스와 동일하게 private으로 적용
            // 대입 연산자로 복사를 진행할 때 얕은 복사가 아닌, 깊은 복사가 일어납니다
            // 생성자를 호출하는 것이 아니라면 new 연산자를 사용하지 않아도 됩니다.
            // 클래스와 다르게 내부에서 직접적으로 필드를 정의할 수 없습니다.
            // 클래스처럼 매개변수가 없는 생성자(기본생성자)를 사용할 수 없으며
            // 생성자를 사용한다면 생성자 내부에서 모든 필드에 대한 초기화가 진행되어야 합니다

            // 구조체는 어느 상황에 사용?
            // 클래스는 객체를 추상화하는데 사용되지만
            // 구조체는 클래스보다 더 간단한 데이터를 다루기 위한 자료구조로 사용됩니다.
            // 그러므로 구조체의 멤버를 편의를 위해 public 선언

            // 구조체의 기본생성자를 호출한다면 모든 필드는
            // 기본값 (0, null)로 초기화됩니다.
            Point myLocation = new Point();

            myLocation.SetPoint(3.3, 2.7);

            Console.WriteLine("x : " + myLocation.x);
            Console.WriteLine("y : " + myLocation.y);

            Point newLocation = new Point(30.5, 23.2);

            Console.WriteLine("newX : " + newLocation.x);
            Console.WriteLine("newY : " + newLocation.y);

            // myLocation을 newLocation에 대입
            newLocation.SetPoint(myLocation);

            // 실제로 깊은복사가 되는지 확인을 위해 값을 변경
            myLocation.SetPoint(23.32, 745.54);

            Console.WriteLine("x : " + myLocation.x);
            Console.WriteLine("y : " + myLocation.y);
            Console.WriteLine("newX : " + newLocation.x);
            Console.WriteLine("newY : " + newLocation.y);
        }
    }
}
