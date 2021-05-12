using System;
using System.Collections.Generic;

namespace Mudgame_My
{
    class Program
    {
        //먼저 실행하고 싶은 것들을 적어보자


        static void Main(string[] args)
        {
            //피자 나라에 오신걸 환영합니다.
            Console.WriteLine("피자 나라에 오신 걸 환영합니다.");
            Console.WriteLine("피자 나라에서는 피자가 아닌 모든 생명체는 공격을 받습니다 .");

            Console.WriteLine("피자로 변신합니다. 종류는 랜덤으로 설정됩니다. ");

            //플레이어 이름 랜덤 설정
            //숫자 랜덤만 배웠다 -> 지정된 문자 내에서 랜덤으로 생성
            //문자열 여러개를 미리 설정해놓고
            // 거기서 랜덤으로 지정
            List<string> names = new List<string>();
            names.Add("패퍼로니");
            names.Add("치즈");
            names.Add("불고기");
            names.Add("슈퍼슈프림");
            names.Add("파인애플");

            //0부터 시작
            Random random = new Random();
            
            int index  = random.Next(names.Count);
            var playerName = names[index];



            ////플레이어 능력치를 입력받자. power, hp
            //string powerString = Console.ReadLine(); //power
            //string hpString = Console.ReadLine(); //hp

            //int power = int.Parse(powerString);


            // 나온 값에 따라 빨리 죽는 캐릭터를 만들자
            // 파인애플 피자 나올 시 -> 당신은 인기 없는 피자라 사망했습니다. - 게임 오버

            if (playerName == names[4])
            {
                Console.WriteLine("당신은 " + playerName + " 피자가 되었습니다.");
                Console.WriteLine("당신은 인기 없는 피자라 사망했습니다.");
            }
            else
            {
                Console.WriteLine("당신은 " + playerName + " 피자가 되었습니다.");
            }
            // 다른 종류 나올 시 진행

            //갑자기 등장한 그림자
            //야 너 피자 아니지
            //뒤를 보니 패퍼로니 피자가 있다. 

            //1. 도망친다. 2. 햄을 뗀다. 3. 사실대로 말한다.

            //도망친다-> 도망치다 넘어졌습니다. 당신의 정체가 들통났습니다. 사형
            // 햄을 뗀다 패퍼로니 피자는 부끄러워 도망감 
            //사실대로 말한다 -> 경찰에게 붙잡혀 사형

            //휴 한고비를 넘겼다. 
            //이 나라를 빠져나갈 방법을 찾아보자.

            //피클을 만났습니다.
            //안녕 나는 스파이 피클이야. 위험할 땐 나를 불러
            //ok

            //




            //목표 : 피자나라에서 살아남기



        }
    }
}
