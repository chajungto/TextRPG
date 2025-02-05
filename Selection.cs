namespace TextRPG
{
    internal class Selection
    {
        public int EventNumber { get; set; }    //이벤트의 번호
        public ICharacter ch { get; set; }      //플레이어 정보
        public List<Item> ItemList { get; set; }   //아이템 정보

        public Selection()
        {
            EventNumber = 0;
            ch = new Knight();
            ItemList = new List<Item>();
        }

        public Selection(int _eventNumber, ICharacter _character, List<Item> _itemList)
        {
            EventNumber = _eventNumber;
            ch = _character;
            ItemList = _itemList;
        }

        public void StartEvent()
        {
            switch (EventNumber)
            {
                //사건 1. 인형 판매원
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 어이 거기!");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 잠시 인형들 한번 보고가 ~");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 혹시 마음에 들면 하나 사가도 돼! 싸게싸게 해줄게!\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 50원을 지불해 비둘기 인형을 구매한다.");
                    Console.WriteLine("2. 50원을 지불해 토끼 인형을 구매한다.");
                    Console.WriteLine("(그 외의 다른 키). 던전에 왠 인형이지? 그냥 무시한다.");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


                    int ChoosedIndex_01 = ChooseNumber();
                    if (ChoosedIndex_01 == 1)
                    {
                        if (ch.isGoldExist(ch.Gold - 50) && !ItemList[17].IsOwned)
                        {
                            ch.LostGold(50);
                            ch.GetItem(ItemList[17]);
                            Console.WriteLine("저 인형은 목으로 날수가 있구나!");
                            Console.WriteLine("{0} 아이템을 획득하였습니다.", ItemList[17].Name);
                        }
                        else if (ItemList[17].IsOwned)
                        {
                            Console.WriteLine("저 인형은 이미 가지고 있었지..");
                        }
                        else
                        {
                            Console.WriteLine("돈도 없는데 그냥 지나가자...");
                        }
                    }
                    else if (ChoosedIndex_01 == 2)
                    {
                        if (ch.isGoldExist(ch.Gold - 50) && !ItemList[18].IsOwned)
                        {
                            ch.LostGold(50);
                            ch.GetItem(ItemList[18]);
                            Console.WriteLine("인형에 \"Rabbit1 임무 돌입합니다\" 이라고 써져있다.");
                            Console.WriteLine("{0}아이템을 획득하였습니다.", ItemList[18].Name);
                        }
                        else if (ItemList[18].IsOwned)
                        {
                            Console.WriteLine("저 인형은 이미 가지고 있었지..");
                        }
                        else
                        {
                            Console.WriteLine("돈도 없는데 그냥 지나가자...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("그냥 지나가자...");
                    }

                    break;

                //사건2. 상남자
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 거기 잠깐.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 너도 혹시 상남자인가?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 상남자라면 이 아이템을 한번 가져가 보는 건 어떤가!!");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 제하하하!! 이 아이템 위력이 정말 최고라고!\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 러시안 룰렛 아이템을 가져간다.");
                    Console.WriteLine("(그 외의 다른 키). 던전에는 이상한 사람들이 많은가보다. 그냥 무시한다.");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                    int ChoosedIndex_02 = ChooseNumber();
                    if (ChoosedIndex_02 == 1)
                    {
                        if (!ItemList[19].IsOwned)
                        {
                            ch.GetItem(ItemList[19]);
                            Console.WriteLine("난 상남자다. 내놔라.");
                            Console.WriteLine("{0} 아이템을 획득하였습니다.", ItemList[19].Name);

                        }
                        else if (ItemList[19].IsOwned)
                        {
                            Console.WriteLine("나도 이미 가지고 있지. 돈으로 받겠네.");
                            ch.GetGold(45);
                        }
                        else
                        {
                            Console.WriteLine("돈도 없는데 그냥 지나가자...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("거 발 닦고 잠이나 주무슈!!!");
                    }

                    break;

                //사건 3. 도박
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 자자.. 빨리 뽑아 이러다가 날 새겠어..");
                    Thread.Sleep(1500);
                    Console.WriteLine("{0} : 복잡하게 생각하지 말자 ", ch.Name);
                    Thread.Sleep(1500);
                    Console.WriteLine("{0} : 양자택일이야 1이냐 0이냐 있으냐 없으냐 남자냐 여자냐... ", ch.Name);
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 빨리 뽑아! 오른쪽이야 왼쪽이야?");
                    Thread.Sleep(1500);
                    Console.WriteLine("{0} : 그래 결심했어! ", ch.Name);
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 오른쪽을 선택한다.");
                    Console.WriteLine("2. 왼쪽을 선택한다.");
                    Console.WriteLine("(그 외의 다른 키). 이런 판에는 끼는거 아니다. 재빠르게 도망간다.");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                    Random randoom_03 = new Random();
                    int randomIndex_03 = randoom_03.Next(1, 3);
                    int ChoosedIndex_03 = ChooseNumber();

                    //굳이 1을 선택할 때 2를 선택할 때를 나누지 않아도 되었었구나
                    if (ChoosedIndex_03 == 1)
                    {
                        if (ChoosedIndex_03 == randomIndex_03)
                        {
                            Console.WriteLine("난 이 기나긴 싸움에서 이긴거야!!!");
                            ch.GetGold(100);
                            Console.WriteLine("골드 + 100");
                        }
                        else
                        {
                            Console.WriteLine("젠장! 이건 무효야!!");
                            ch.LostGold(100);
                            Console.WriteLine("골드 - 100");
                        }
                    }
                    else if (ChoosedIndex_03 == 2)
                    {
                        if (ChoosedIndex_03 == randomIndex_03)
                        {
                            Console.WriteLine("난 이 기나긴 싸움에서 이긴거야!!!");
                            ch.GetGold(100);
                            Console.WriteLine("골드 + 100");
                        }
                        else
                        {
                            Console.WriteLine("젠장! 이건 무효야!!");
                            ch.LostGold(100);
                            Console.WriteLine("골드 - 100");
                        }
                    }
                    else
                    {
                        Console.WriteLine("도박은 원래 하면 안되는거야..");
                    }

                    break;

                //사건 4. 레스토랑
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 네 손님 주문하시겠습니까?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 저희 음식점 제육볶음은 몬스터들도 탐내하는 음식입니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 아니면 샐러드도 다이어터들에게도 인기만점이죠.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 공짜로 드리는 삶은 달걀도 있습니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 어떤 음식을 주문하시겠습니까?\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 제육볶음 - 40원");
                    Console.WriteLine("2. 샐러드 - 30원");
                    Console.WriteLine("3. 삶은달걀 - 0원");
                    Console.WriteLine("(그 외의 다른 키). 이미 배부른데? 나가야겠다.");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                    int ChoosedIndex_04 = ChooseNumber();
                    if (ChoosedIndex_04 == 1)
                    {
                        if (ch.isGoldExist(ch.Gold - 40) && !ItemList[6].IsOwned)
                        {
                            ch.GetItem(ItemList[6]);
                            Console.WriteLine("감사합니다!");
                            Console.WriteLine("{0} 아이템을 획득하였습니다.", ItemList[6].Name);
                        }
                        else if (ItemList[6].IsOwned)
                        {
                            Console.WriteLine("이미 이걸 먹었지... 거스름돈이나 주세요!");
                            ch.GetGold(20);
                        }
                        else
                        {
                            Console.WriteLine("돈도 없는데 그냥 지나가자...");
                        }
                    }
                    else if (ChoosedIndex_04 == 2)
                    {
                        if (ch.isGoldExist(ch.Gold - 30) && !ItemList[8].IsOwned)
                        {
                            ch.GetItem(ItemList[8]);
                            Console.WriteLine("감사합니다!");
                            Console.WriteLine("{0} 아이템을 획득하였습니다.", ItemList[8].Name);
                        }
                        else if (ItemList[8].IsOwned)
                        {
                            Console.WriteLine("이미 이걸 먹었지... 거스름돈이나 주세요!");
                            ch.GetGold(10);
                        }
                        else
                        {
                            Console.WriteLine("돈도 없는데 그냥 지나가자...");
                        }
                    }
                    else if (ChoosedIndex_04 == 3)
                    {
                        if (!ItemList[7].IsOwned)
                        {
                            ch.GetItem(ItemList[7]);
                            Console.WriteLine("감사합니다!");
                            Console.WriteLine("{0} 아이템을 획득하였습니다.", ItemList[7].Name);
                        }
                        else if (ItemList[7].IsOwned)
                        {
                            Console.WriteLine("이미 이걸 먹었지... 거스름돈이나 주세요!");
                            ch.GetGold(5);
                        }
                        else
                        {
                            Console.WriteLine("그냥 나가자...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("그냥 나가자..");
                    }

                    break;

                //사건 5. 기가체드
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 어이 거기 {0}삣삐", ch.Name);
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 혹시 힘들다고 생각하는건 아니지?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 힘내라고 {0}삣삐, 내가 널 응원하고 있을 테니\n", ch.Name);
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("응원 아이템을 획득합니다!");
                    //상점에서는 구매 불가하고 오직 사건에서만 얻을 수 있는 아이템
                    Item FightingItem = new Item(130, "응원", "난 항상 널 응원하고 있어 (중첩 가능)", "공격력 + 5, 방어력 + 5", 5, 5, 100, false);
                    ch.GetItem(FightingItem);
                    break;

                //사건 6. 설계자
                case 6:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 아 안녕하십니까 이 던전의 설계자입니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 최근 이 던전에 오류코드가 떠돌아다닌다던데...");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 혹시 보신적 있으신가요?\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 아뇨 본적 없어요..");
                    if (ItemList[13].IsOwned)
                    {
                        Console.WriteLine("2. 혹시 이건가요?");
                    }
                    Console.WriteLine("(그 외의 다른 키). 무시하고 지나간다.");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    int ChoosedIndex_06 = ChooseNumber();
                    if (ChoosedIndex_06 == 1)
                    {
                        if (!ItemList[13].IsOwned)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("?? : 제가 보이시다니.. 당신도 오류 코드를 가질 자격이 있군요.");
                            Console.ResetColor();
                            ch.GetItem(ItemList[13]);
                            Console.WriteLine("아이템 {0} 획득하였습니다.", ItemList[13].Name);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("?? : 당신은 저에게 거짓말을 치고 있군요. 이건 제 기분에 대한 벌입니다.");
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine("골드 -20");
                            ch.LostGold(20);
                        }
                    }
                    else if (ChoosedIndex_06 == 2 && ItemList[13].IsOwned)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("?? : 오 이겁니다. 제게 주셔서 감사합니다. 보상으로 골드를 드리도록 하죠.");
                        Console.ResetColor();
                        Console.WriteLine("골드 +77");
                        ch.GetGold(77);
                        ch.DumpItem(ItemList[13]);
                    }
                    else
                    {
                        Console.WriteLine("서늘한 기분이 들지만, 지나치자.");
                    }


                    break;

                //사건 7. 휴식.
                case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 반갑습니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 아 이곳은 어디냐고요?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 그냥 이 곳은 휴식터같은 곳이에요..");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 분명 당신은 무언가를 얻으려고 왔지만,");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 때로는 속세에서 벗어나서 잠시 쉬어가는 건 어떠신가요?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 아무 생각하지말고 잠시 쉬었다 가시죠\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Thread.Sleep(1500);
                    Console.WriteLine("아무런 일도 일어나지 않았습니다.");
                    break;

                //사건 8. 자판기
                case 8:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("당신은 길을 가다가 자판기 하나를 발견하였습니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("하지만 상품은 보이지 않고 빨간 버튼 하나만 놓여져 있네요.");
                    Thread.Sleep(1500);
                    Console.WriteLine("마침 주변에는 아무도 없어 보입니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("당신이 원하는 대로 누를수 있다는 뜻이죠.");
                    Thread.Sleep(1500);
                    Console.WriteLine("자 이제 선택의 시간이 다가온 것 같습니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("버튼을 누르시겠습니까?\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 누른다.");
                    Console.WriteLine("(그 외의 다른 키). 누르지 않는다.");
                    int ChoosedIndex_08 = ChooseNumber();
                    if (ChoosedIndex_08 == 1)
                    {
                        Random randoom_08 = new Random();
                        int randomIndex_08 = randoom_08.Next(1, 4);
                        switch (randomIndex_08)
                        {
                            case 1:
                                Console.WriteLine("띠링!");
                                Thread.Sleep(1500);
                                Console.WriteLine("무작위 아이템을 획득합니다!");
                                Thread.Sleep(1500);
                                ch.GetItem(RandomItem());
                                break;
                            case 2:
                                Console.WriteLine("띠링!");
                                Thread.Sleep(1500);
                                Console.WriteLine("무작위 양의 골드를 획득합니다!");
                                Thread.Sleep(1500);
                                ch.GetGold(randoom_08.Next(30, 101));
                                break;
                            case 3:
                                Console.WriteLine("띠링!");
                                Thread.Sleep(1500);
                                Console.WriteLine("무작위 양의 골드를 빼앗깁니다!");
                                Thread.Sleep(1500);
                                ch.LostGold(randoom_08.Next(30, 101));
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("버튼은 누르는게 아니다. 특히나 빨간 버튼은 더더욱 누르는게 아니다.");
                    }
                    break;

                //사건 9. 빵과 복권
                case 9:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("?? : 혹시 오징어게임2를 보셨나요?");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 해당 영화에는 노숙자에게 빵과 복권을 선택하라고 하는 장면이 나옵니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 저는 저 장면을 보면서 엄청 궁금했어요.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 당신이라면 어떤 선택을 할지 말이죠...");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 자 여기 50 골드와 최대 당첨금이 100골드짜리인 복권이 있습니다.");
                    Thread.Sleep(1500);
                    Console.WriteLine("?? : 당신은 어떤 선택을 하시겠습니까?\n");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1. 안전하게 50골드를 획득한다.");
                    Console.WriteLine("2. 0원이 나오더라도 도파민은 못참지! 복권 가즈아~");
                    Console.WriteLine("(그 외의 다른 키). 근데 누구세요? 저 아세요?");

                    int ChoosedIndex_09 = ChooseNumber();
                    if (ChoosedIndex_09 == 1)
                    {
                        Console.WriteLine("좋은 선택이네요. 때로는 확실함이 보장되는 안정감도 좋으니까요.");
                        Thread.Sleep(1500);
                        Console.WriteLine("골드 + 50");
                        ch.GetGold(50);
                    }
                    else if (ChoosedIndex_09 == 2)
                    {
                        Console.WriteLine("어떤 결과가 나올지도 모르는 불확실성을 선택하는 당신. 과감하군요.");
                        Thread.Sleep(1500);
                        Random random_09 = new Random();
                        int randomIndex_09 = random_09.Next(0, 101);
                        ch.GetGold(randomIndex_09);
                        Console.WriteLine("골드 + " + randomIndex_09);
                    }
                    else
                    {
                        Console.WriteLine("모르는 사람이랑 엮여서 좋을 거 없다. 그냥 지나치자.");
                    }
                    break;
                default:
                    break;
            }
        }

        //숫자 고르기
        public int ChooseNumber()
        {
            int chooseNumber = 0;
            try
            {
                chooseNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                //PrintWaringForSelect();
                return 0;
            }
            return chooseNumber;
        }

        //번호 선택시 경고 창
        public void PrintWaringForSelect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("번호에 맞게 입력하여 주십시오!");
            Console.ResetColor();
        }

        //랜덤 아이템 얻기
        public Item RandomItem()
        {
            Item item = new Item();
            while (true)
            {
                Random random = new Random();
                item = ItemList[random.Next(1, ItemList.Count)];
                if (!item.IsOwned)
                {
                    return item;
                }
            }
        }


    }
}
