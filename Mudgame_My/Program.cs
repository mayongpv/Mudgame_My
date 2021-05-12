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
            Console.WriteLine("당신은 " + playerName + " 피자가 되었습니다.");


            //플레이어 능력치를 입력받자. power, hp
            string powerString = Console.ReadLine(); //power
            string hpString = Console.ReadLine(); //hp

            int power = int.Parse(powerString);




        }
    }
}
