using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._01_클래스
{
    // 고양이 타입의 객체를 생성할 때 사용할 클래스
    class Cat
    {
        public string name;
        public string sound;

        public void PrintInfo()
        {
            Console.WriteLine("고양이의 이름 : " + name);
            Console.WriteLine($"{name}의 울음소리 : {sound}");
        }
    }

    class _02_클래스
    {
        static void Main()
        {
            Cat kitty = new Cat();
            // kitty와 동일한 형태지만, 독립된 데이터를 갖는 새로운 Cat 객체를 생성
            Cat bella = new Cat();

            kitty.name = "키티";
            kitty.sound = "야옹";

            bella.name = "벨라";
            bella.sound = "애옹";

            kitty.PrintInfo();
            bella.PrintInfo();
        }
    }
}
