using System;
using System.Collections.Generic;

namespace Mudgame_My
{
    class Program

    {
        //먼저 실행하고 싶은 것들을 적어보자

        private static string GetAllowedAnswer(params string[] alllowsAnserStringArray)
        {
            string retryOrQuit;
            List<string> allowedAnswer = new List<string>(alllowsAnserStringArray);
            do
            {
                retryOrQuit = Console.ReadLine().ToUpper();
            } while (allowedAnswer.Contains(retryOrQuit) == false);
            return retryOrQuit;
        }

        static void Main(string[] args)
        {
            //피자 나라에 오신걸 환영합니다.
            Console.WriteLine("피자 나라에 오신 걸 환영합니다.Press any key.");
            Console.ReadKey();  // 키 입력 받기
            Console.WriteLine("피자 나라에서는 피자가 아닌 모든 생명체는 공격을 받습니다. Press any key.");
            Console.ReadKey();  // 키 입력 받기
            Console.WriteLine("피자로 변신합니다. 종류는 랜덤으로 설정됩니다. Press any key. ");
            Console.ReadKey();  // 키 입력 받기
                                //플레이어 이름 랜덤 설정
                                //숫자 랜덤만 배웠다 -> 지정된 문자 내에서 랜덤으로 생성
                                //문자열 여러개를 미리 설정해놓고
                                // 거기서 랜덤으로 지정

            int tryCount = 0;
            bool reTry = true;
            //반복.
            while (reTry)
            {



                List<string> names = new List<string>();
                names.Add("고르곤졸라");
                names.Add("치즈");
                names.Add("불고기");
                names.Add("슈퍼슈프림");
                names.Add("파인애플");

                //0부터 시작
                Random random = new Random();

                int index = random.Next(names.Count);
                var playerName = names[index];


                // 나온 값에 따라 빨리 죽는 캐릭터를 만들자
                // 파인애플 피자 나올 시 -> 당신은 인기 없는 피자라 사망했습니다. - 게임 오버

                if (playerName == names[4])
                {
                    Console.WriteLine("당신은 " + playerName + " 피자가 되었습니다.");
                    Console.WriteLine("당신은 인기 없는 피자라 사망했습니다. Game Over");
                    Console.ReadKey();  // 키 입력 받기
                    Console.WriteLine("뻥입니다.");
                }
                else
                {
                    Console.WriteLine("당신은 " + playerName + " 피자가 되었습니다.");
                }

                Console.WriteLine("다시 하시겠습니까? (Y)es/(N)o");
                reTry = Console.ReadLine().ToUpper() == "Y";

                if (tryCount > 5)
                {
                    Console.WriteLine("그냥 하지마");
                }
            }


                Console.WriteLine("모험을 할 준비가 되었습니다. Press any key.");
                Console.ReadKey();  // 키 입력 받기


                Console.WriteLine("불현듯 등 뒤가 쌔하다. Press any key.");
                Console.ReadKey();  // 키 입력 받기           
                Console.WriteLine("뒤를 돌아보니 패퍼로니 피자가 있다.");
                Console.WriteLine("야 너 피자 아니지. Press any key");
                Console.ReadKey();




   
            {

                Console.WriteLine("1.도망친다. 2.싸운다. 3.햄을 뗀다. 4.사실대로 말한다. ");

                char userInput = GetAllowedAnswer("1", "2", "3", "4")[0];
                switch (userInput)
                {
                    case '1':// 도망
                        Console.WriteLine("도망칩니다.");
                        Console.WriteLine("도망치다 넘어졌습니다. 당신의 정체가 들통났습니다. \n사형. Game Over ");
                        Console.ReadKey();  // 키 입력 받기 
                        break;
                    case '2': // 공격
                        Console.WriteLine("싸움을 시작합니다. Press any key");
                        Console.ReadKey();
                        Console.WriteLine("막상 공격적인 태도를 취하니 패퍼로니가 달아났습니다.");
                        break;
                    case '3': // 회복
                        Console.WriteLine("패퍼로니의 햄을 뗍니다. Press any key.");
                        Console.ReadKey();
                        Console.WriteLine("패퍼로니가 부끄러워하며 도망갔습니다.");
                        break;
                    case '4': // 도망.
                        Console.WriteLine("패퍼로니에게 사실대로 이야기 합니다. Press any key");
                        Console.ReadKey();
                        Console.WriteLine("패퍼로니가 당신을 신고했습니다. 사형. Game Over");
                        break;
                    default:
                        Console.WriteLine("없는 명령어 입니다" + userInput);
                        break;
                }
                //game over에서 다시 고르는거 나오게 하기

            }


            Console.WriteLine("휴 한고비 넘겼다. 여기서 빠져나갈 방법을 찾아보자.");
            Console.WriteLine("이제 뭘하지?");

            {
                Console.WriteLine("1.마을을 둘러본다. 2.무기를 찾는다. 3.친구를 만든다 ");

                char userInput = GetAllowedAnswer("1", "2", "3")[0];
                switch (userInput)
                {
                    case '1':// 마을을 둘러본다
                        Console.WriteLine($"마을을 둘러본다. 이제야 피자 나라의 풍경이 눈에 들어온다. ");
                        break;
                    case '2':// 무기를 찾는다
                        Console.WriteLine($"만약에 대비해 무기가 될 만한 것들을 찾아본다.");
                        break;
                    case '3':// 친구를 만든다
                        Console.WriteLine($"가장 착해보이는 피자가 있나 살펴본다.");
                        break;
                }

            }


        }
    }
}




   
        //피클을 만났습니다.
        //안녕 나는 스파이 피클이야. 위험할 땐 나를 불러
        //ok

        //




        //목표 : 피자나라에서 살아남기



    


