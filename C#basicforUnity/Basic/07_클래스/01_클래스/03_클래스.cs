using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic._07_클래스._01_클래스
{
    class AirConditioner
    {
        // 전원
        public bool power;

        // 온도
        public int temp = 22;

        // 전원 설정 기능
        public void SetPower(bool power)
        {
            // 현재 동일한 이름(power)를 갖는 필드와 매개변수가 존재함
            // 내가 하고자하는 행위는 power 필드에 매개변수로 받은 power 데이터를 넣는 행위
            // power를 통해 변수에 접근하면 필드와 매개변수 중, 매개변수로 접근이 됌
            //  -> 동일한 이름을 갖는 필드와 매개변수(지역변수)가 있다면, 지역변수가 우선시 됌

            // 이때 this라는 키워드를 사용하여 필드에 접근
            // this?
            // 자기자신의 객체를 가리키는 키워드
            this.power = power;
            Console.WriteLine("전원이 " + (power ? "켜" : "꺼") + "졌습니다.");
        }

        // 온도 설정 기능
        public void SetTemp(int temp)
        {
            this.temp = temp;
            PrintTemp();
        }

        // 온도 1도 증가
        public void UpTemp()
        {
            ++temp;
            PrintTemp();
        }

        // 온도 1도 감소
        public void DownTemp()
        {
            --temp;
            PrintTemp();
        }

        // 온도 출력 기능
        public void PrintTemp()
        {
            Console.WriteLine("온도를 " + temp + "도로 설정했습니다.");
        }
    }

    class _03_클래스
    {
        static void Main()
        {
            // 제시한 클래스를 설계하고, Main에서 객체를 생성한 뒤 기능을 실행해보세요.

            // 클래스 이름 : AirConditioner

            // 필드
            // 전원을 표현할 변수 (On/Off)
            // 온도를 저장할 변수 (정수)

            // 메서드
            // 전원 설정 기능
            // 온도 설정 기능 (원하는 온도로)
            // 온도 1도 증가
            // 온도 1도 감소

            // -> 온도 변경될 때마다 확인할 수 있게, 변경된 온도를 출력

            // 전원 On
            // 온도설정 18도
            // 온도 1도 증가
            // 온도 1도 감소
            // 전원 Off

            // 객체 생성 시 필드 초기값
            //  -> 전원 꺼짐, 온도 22도

            AirConditioner ac = new AirConditioner();

            ac.SetPower(true);
            ac.SetTemp(18);
            ac.UpTemp();
            ac.DownTemp();
            ac.SetPower(false);
        }
    }
}
