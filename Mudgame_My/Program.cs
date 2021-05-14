using System;
using System.Collections.Generic;

namespace Mudgame_My
{
    class Program

    {
        private static Random random = new Random();

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

            {
                Console.WriteLine("모험을 할 준비가 되었습니다. Press any key.");
                Console.ReadKey();  // 키 입력 받기


                Console.WriteLine("불현듯 등 뒤가 쌔하다. Press any key.");
                Console.ReadKey();  // 키 입력 받기           
                Console.WriteLine("뒤를 돌아보니 패퍼로니 피자가 있다.");
                Console.WriteLine("야 너 피자 아니지. Press any key");
                Console.ReadKey();
            }
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
                        Console.WriteLine("다시 하시겠습니까? (Y)es/(N)o");



                }



                Console.ReadKey();  // 키 입력 받기
                //Console.WriteLine("휴 한고비 넘겼다. 여기서 빠져나갈 방법을 찾아보자.");
                Console.WriteLine("다시 고르게 하고 싶은데 안됩니다. 그냥 넘어갑니다.");

                Console.ReadKey();  // 키 입력 받기
                Console.WriteLine("이제 뭘하지?");




                Console.WriteLine("1.마을을 둘러본다. 2.무기를 찾는다. 3.친구를 만든다 ");

                char userInput2 = GetAllowedAnswer("1", "2", "3")[0];
                switch (userInput)
                {
                    case '0':// 마을을 둘러본다
                        Console.WriteLine("마을을 둘러본다. 이제야 피자 나라의 풍경이 눈에 들어온다. ");
                        break;
                    case '1':// 무기를 찾는다
                        Console.WriteLine("만약에 대비해 무기가 될 만한 것들을 찾아본다.");
                        break;
                    case '2':// 친구를 만든다
                        Console.WriteLine("가장 착해보이는 피자가 있나 살펴본다.");
                        break;



                }


                Console.ReadKey();
                Console.WriteLine("인기척이 느껴집니다.");
                Console.WriteLine("뒤돌아보니 피클이 있습니다.  Press any key.");
                Console.ReadKey();
                Console.WriteLine("안녕 나는 피클이야. 스파이지. ");
                Console.WriteLine("너 혹시 피자 나라에서 탈출할 방법을 찾고 있니?");
                Console.WriteLine("내가 알려줄게.");
                Console.WriteLine("너를 제외한 피자 7조각을 모아.그럼 여길 탈출할 수 있어.");

                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.WriteLine("미션이 주어졌습니다. 당신은 피자 7조각을 모아야합니다.");
                Console.ReadKey();

                //전투 모드
                //주인공에게 HP와 power를 부여한다. 랜덤
                static Player MakePlayer()
                {
                    Console.WriteLine("전투 모드에 진입합니다");

                    bool isReset = true;
                    int power = 0, hp = 0;

                    while (isReset)
                    {
                        power = random.Next(4, 9);// 4는 포함하고 10은 포함하지 않는 -> 4 ~ 9
                        hp = random.Next(3, 10);
                        //당신의 능력은 입니다. 공격력 3, 체력 5 입니다.
                        Console.WriteLine($"당신은 공격력:{power}, 체력:{hp} 입니다. 다시 생성 하시겠습니까?(Y/N)");
                        string resetAnswer = Console.ReadLine(); //  y, n
                        isReset = resetAnswer.ToLower() == "y";
                    };

                    Player player = new Player(power, hp);

                    Console.WriteLine(player + " : logTest");
                    return player;
                }


                //몬스터 출현 
                //몬스터가 공격한다. 나도 공격한다. HP 가감
                //몬스터를 7마리 잡아야 이긴다.


                Console.WriteLine("몬스터 잡는건 미완성입니다. 시간이 없으니 싸운 셈 칩니다.");
                Console.ReadKey();
                Console.WriteLine("몬스터 잡고 싶으면 다른 게임 하셈.");
                Console.ReadKey();
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("축하합니다 피자 7조각을 모았습니다!");
                Console.ReadKey();

                Console.WriteLine("하지만 당신은 감옥에 갇혔습니다.");
                Console.WriteLine("Lose");
                Console.WriteLine("Press any key");
                Console.ReadKey();


                Console.WriteLine("다시 하시겠습니까? (Y)es/(N)o");
                {
                    char userInput3 = GetAllowedAnswer("Y", "N")[0];
                    switch (userInput)
                    {
                        case '0': //다시하기
                            Console.WriteLine("다시 한다고요?" +
                                "다시 해도 당신은 탈출할 수 없습니다." +
                                "Press any key.");
                            Console.WriteLine("왜냐면 개발자가 그렇게 설정 했음.");
                            Console.ReadKey();  // 키 입력 받기 
                            break;
                        case '1': //안하기
                            Console.WriteLine("게임을 다시 시도하지 않습니다. ");
                            Console.WriteLine("당신은 피자나라에 영원히 갇혔습니다.");
                             
                            Console.ReadKey();
                            Console.WriteLine("당신은 벌로 평생 피자를 먹을 수 없는 저주에 걸렸습니다.");
                            Console.ReadKey();
                            Console.WriteLine("GAME OVER :-)");
                            break;
                    }
                }



                ////몬스터를 7마리 잡았다-> 하지만 lose. 피클이 신고함. 
                //Console.WriteLine("축하합니다! 피자 7조각을 모았습니다!");

                //    //당신은 감옥에 갔습니다. 

                //다시 하시겠습니까? (이 게임은 lose 밖에 없습니다)
                //y->계속해도 탈출할 수 없습니다. 왜냐면 개발자가 그렇게 설정했음. 
                //n->당신은 피자나라에 갇힌 벌로 평생 피자를 먹을 수 없습니다. 






            }



        }
    }
}








//목표 : 피자나라에서 살아남기






