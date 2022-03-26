using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._04_분기문._02_Switch문
{
    class _03_Switch문
    {
        static void Main()
        {
            // switch/case문에서 when 구문을 사용하여
            // 추가적인 조건 검사를 수행할 수 있음

            string name = "레넥톤";
            int level = 18;

            switch (name)
            {
                // 이름이 레넥톤이며, 레벨이 10을 초과하는지
                case "레넥톤" when level > 10:
                    Console.WriteLine("레넥톤의 레벨은 10을 넘습니다.");
                    break;
                // 이름이 레넥톤이며, 레벨이 10이하인지
                case "레넥톤" when level <= 10:
                    Console.WriteLine("레넥톤의 레벨은 10을 넘지 않습니다.");
                    break;
            }
        }
    }
}

