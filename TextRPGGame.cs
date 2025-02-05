namespace TextRPG
{
    internal class TextRPGGame
    {
        ICharacter character = new Knight();          //캐릭터
        string name = "";               //이름
        int jobNumber = 0;              //직업
        int stage = 0;                   //단계
        int nameCountLimit = 8;         //이름 글자수 제한


        //게임 내에서 볼 수 있는 장비 리스트
        List<Equipment> equipmentList = new List<Equipment>();

        //장비 초기화
        public void InitialEquipment()
        {
            equipmentList.Add(new Equipment(1,"나무 검","나무로 만든 검이다.","공격력 + 2", 2, 0,20, false,false));
            
            equipmentList.Add(new Equipment(2, "나무 방패", "나무로 만든 방패다.", "방어력 + 2", 0, 2, 20, false, false));

            equipmentList.Add(new Equipment(3, "돌 검", "돌로 만든 검이다.", "공격력 + 4", 4, 0, 40, false, false));
            
            equipmentList.Add(new Equipment(4, "돌 방패", "돌로 만든 방패다.", "방어력 + 4", 0, 4, 40, false, false));

            equipmentList.Add(new Equipment(5, "팔 토시", "팔에 감싸는 느낌이 괜찮다.", "방어력 + 3", 0, 3, 30, false, false));
            
            equipmentList.Add(new Equipment(6, "하이 힐", "신지 않고 흉기로 쓰인다.", "공격력 + 3", 3, 0, 30, false, false));

            equipmentList.Add(new Equipment(7, "금 검", "금으로 만든 검이다.", "공격력 + 6", 6, 0, 60, false, false));
            
            equipmentList.Add(new Equipment(8, "은 방패", "은으로 만든 방패다.", "방어력 + 6", 0, 6, 60, false, false));

            equipmentList.Add(new Equipment(9, "총", "총 앞에서 만인이 평등해진다.", "공격력 + 12", 12, 0, 120, false, false));
           
            equipmentList.Add(new Equipment(10, "머리 보호대", "일단 헤드샷은 막아주는 든든한 보호대", "방어력 + 12", 0, 12, 120, false, false));

            equipmentList.Add(new Equipment(11, "짱돌", "위급시에는 던져도 된다.", "공격력 + 3, 방어력 + 1", 3, 1, 40, false, false));
          
            equipmentList.Add(new Equipment(12, "팬던트", "총알이 팬던트에 맞아서 내 목숨을 구할 수 있었어...", "공격력 + 1,방어력 + 3", 1, 3, 40, false, false));

            equipmentList.Add(new Equipment(13, "도끼", "제이슨이 보증하는 성능의 돌 도끼", "공격력 + 5, 방어력 + 3", 5, 3, 80, false, false));
         
            equipmentList.Add(new Equipment(14, "안전제일", "술 먹은 다음날 내방에 있던 표지판", "공격력 + 3,방어력 + 5", 3, 5, 80, false, false));

            equipmentList.Add(new Equipment(15, "고양이 머리띠", "원래 고인물 륵이 가장 무서운 법", "공격력 + 6, 방어력 + 6", 6, 6, 120, false, false));
           
            equipmentList.Add(new Equipment(16, "호루스의 방패", "누가 쓰던건지는 몰라도 매우 튼튼해 보이는 방패", "공격력 + 2,방어력 + 10", 2, 10, 120, false, false));

            equipmentList.Add(new Equipment(17, "키보드", "단단하지만 짧다. ", "공격력 + 2, 방어력 + 2", 2, 2, 40, false, false));
          
            equipmentList.Add(new Equipment(18, "콜라 캔", "누가 다 마시고 버린듯 한 캔", "방어력 + 1", 0, 1, 10, false, false));

            equipmentList.Add(new Equipment(19, "족집게", "정교한 공격을 원하는건가? ", "공격력 + 1,", 1, 0, 10, false, false));
          
            equipmentList.Add(new Equipment(20, "자경단의 도전장", "도전장을 받으세요!", "공격력 + 7 방어력 + 2", 7, 2, 90, false, false));

            equipmentList.Add(new Equipment(21, "마법서", "마법은 안적혀있고 단단하기만 하다. ", "방어력 + 10,", 0, 10, 100, false, false));
           
            equipmentList.Add(new Equipment(22, "화합의 모자", "이 모자에는 꿈이 담겨져 있다.", "방어력 + 9", 0, 9, 90, false, false));

            equipmentList.Add(new Equipment(23, "야구방망이", "규칙은 깨라고 있는거라 들었다.", "공격력 + 7,", 7, 0, 70, false, false));
          
            equipmentList.Add(new Equipment(24, "석궁", "조금 낡아보이지만 쓸만해보인다.", "공격력 + 3", 3, 0, 30, false, false));

            equipmentList.Add(new Equipment(25, "태평성대", "이 검으로 세상을 베면 태평성대가 찾아올 것이다.", "공격력 + 15,", 15, 0, 150, false, false));
          
            equipmentList.Add(new Equipment(26, "기사의 검", "어느 기사가 취임식때 하사받았던 검이다.", "공격력 + 5", 5, 0, 50, false, false));

            equipmentList.Add(new Equipment(27, "검투사의 투구", "한때의 영광이 여기에 담겨져 있다.", "방어력 + 10,", 0, 10, 100, false, false));
          
            equipmentList.Add(new Equipment(28, "방탄헬멧", "군인이라면 이 헬멧을 챙기도록 하자.", "방어력 + 7", 0, 7, 70, false, false));

            equipmentList.Add(new Equipment(29, "쌍절권", "공격과 방어에 용이해 보이는 도구이다.", "공격력 + 3, 방어력 + 2", 3, 2, 50, false, false));
          
            equipmentList.Add(new Equipment(30, "모순", "방패와 창이 동시에 있는 세트 도구이다.", "공격력 + 4, 방어력 + 4", 4, 4, 80, false, false));
        }

        //게임 내에서 볼 수 있는 아이템 리스트
        List<Item> itemList = new List<Item>();

        //아이템 초기화
        public void InitialItem()
        {
            itemList.Add(new Item(101, "힘의 부적", "보기만 해도 쎄지는 느낌이다.", "공격력 + 1", 1, 0, 8, false));
           
            itemList.Add(new Item(102, "단단한 부적", "부적 주제에 쓸데없이 단단하다.", "방어력 + 1", 0, 1, 8, false));
          
            itemList.Add(new Item(103, "커피", "힘은 쎄지지만 몸이 카페인을 거부하는 느낌이다.", "공격력 + 2, 방어력 -2", 2, -2, 15, false));
           
            itemList.Add(new Item(104, "유리조각", "유리조각에 찔렸다.", "방어력 - 4", 0, -4, 10, false));
          
            itemList.Add(new Item(105, "기사의 중압감", "기사는 고달픈 법이다", "공격력 + 5, 방어력 -5", 5, -5, 40, false));
          
            itemList.Add(new Item(106, "탈세증명서", "국민이라면 세금은 내도록 하자", "다음 구역 진입시 골드 5% 감소", 0, 0, 10, false));/////   ok
          
            itemList.Add(new Item(107, "제육볶음", "몬스터들이 당신의 제육볶음을 탐낸다.", "다음 구역 진입시 체력 5% 감소", 0, 0, 40, false));/////    ok
         
            itemList.Add(new Item(108, "삶은 달걀", "단백질은 몸에 좋다.", "방어력 + 2", 0, 2, 20, false));
         
            itemList.Add(new Item(109, "샐러드", "건강해진 기분은 들지만, 배가 고프다.", "공격력 - 4, 방어력 + 5", -4, 5, 30, false));
         
            itemList.Add(new Item(110, "오예스", "Oh, Yes!.", "공격력 + 3", 3, 0, 20, false));
          
            itemList.Add(new Item(111, "저주의 권갑", "아픈건 싫으니까 공격력에 올인.", "공격력 + 15, 방어력 - 20", 15, -20, 100, false));
         
            itemList.Add(new Item(112, "광대의 룰렛", "결과는 슈뢰딩거의 고양이와 같은 것.", "다음 구역 진입시 랜덤한 확률로 랜덤 아이템 획득", 0, 0, 77, false));///// ok
         
            itemList.Add(new Item(113, "쿠션", "폭신한 쿠션이 공격을 막아줄 수도..?.", "방어력 + 5", 0, 5, 50, false));
         
            itemList.Add(new Item(114, "오류 코드", "아이템 설명과 다를수 있으니 믿지 말자", "공격력 + 1000, 방어력 + 200", 1, -1, 20, false));
          
            itemList.Add(new Item(115, "전공책", "두꺼워서 둔기로 사용이 가능하다", "공격력 + 4", 4, 0, 30, false));
         
            itemList.Add(new Item(116, "전기장판", "따뜻하다. 여기에만 있고 싶게 만든다.", "공격력 + 3, 방어력 + 3", 3, 3, 50, false));
         
            itemList.Add(new Item(117, "참 잘했어요 도장", "백점 만점! 참 잘했어요!", "다음 구역 진입시 체력 + 10", 0, 0, 90, false));///// ok
          
            itemList.Add(new Item(118, "비둘기 인형", "목으로 날것 같다.", "공격력 + 9, 방어력 + 9", 9, 9, 50, false));
          
            itemList.Add(new Item(119, "토끼 인형", "당신같은 어른이 제일 싫습니다.", "다음 구역 진입시 최대체력의 10% 회복", 0, 0, 50, false));////// ok
          
            itemList.Add(new Item(120, "러시안 룰렛", "오늘 둘 중 하나는 뒤지는 거여!", "공격력 + 25, 전투 내에서 방어력 -5로 고정", 30, 0, 90, false));///// ok

            itemList.Add(new Item(121, "함수 계산기", "슬픔과 분노도 인수분해 가능한 계산기다.", "공격력 + 2, 방어력 + 3", 2, 3, 40, false));

            itemList.Add(new Item(122, "음식 모형", "그냥 모형이다. 계속 보고 있으면 배고파진다.", "방어력 - 2", 0, -2, 25, false));

            itemList.Add(new Item(123, "소녀의 카메라", "언뜻 보기에도 차갑고 화련한 카메라이다.", "방어력 + 3", 0, 3, 20, false));

            itemList.Add(new Item(124, "시한 폭탄(프로토타입)", "가지고 있기만 해도 불안감이 쌓인다..", "공격력 -2, 방어력 - 3", -2, -3, 25, false));

            itemList.Add(new Item(125, "시한 폭탄(양산형)", "이 시한폭탄은 가짜래유!!진짜와 가짜는 그림체부터 다르잖슈!", "효과없음 ", 0, 0, 20, false));

            itemList.Add(new Item(126, "화장품", "던전에서도 자기관리는 중요하다. 자신감이 생긴다.", "공격력 + 4, 방어력 + 3 ", 4, 3, 55, false));

            itemList.Add(new Item(127, "완벽한 모순", "이 같이 완벽한 물질이 또 어디에 있겠느냐.", "자신감 + 1234, 매력 + 81, 코딩력 : 8934", 0, 0, 30, false));

            itemList.Add(new Item(128, "가족사진", "항상 보고만 있어도 힘이 솟는다.", "공격력 + 6, 방어력 + 5", 6, 5, 60, false));

            itemList.Add(new Item(129, "화려한 왕관", "몬스터들의 이목이 모두 당신에게 집중되었다.", "받는 피해 10 추가", 0, 0, 30, false));///// ok
        }


        //전체 진행
        public void Run()
        {
            GameStart();

            Thread.Sleep(1000);
            ChooseJob();

            Thread.Sleep(1500);
            Prepare();

            ChooseTown();

            TakeRestInTown();
        }

        //게임 시작 및 이름 정하기
        public void GameStart()
        {
            Console.WriteLine("Text RPG게임에 오신 당신을 환영합니다.");
            Thread.Sleep(2000);
            while(true)
            {
                Console.WriteLine("당신의 이름은 무엇입니까? (8글자 이내로 기입하여 주십시오.)");
                name = Console.ReadLine();
                if(name?.Length > nameCountLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("8글자를 초과하셨거나 이름을 제대로 작성하지 않았습니다!");
                    Console.ResetColor();
                    Thread.Sleep(500);
                }
                else break;
            }
            Thread.Sleep(1000);
            Console.WriteLine("당신의 이름은 {0}(이)군요!", name);
            Thread.Sleep(2000);
            Console.Clear();
        }

        //직업 선택
        public void ChooseJob()
        {
            Console.WriteLine("");
            Console.WriteLine("\t이제 당신의 직업을 선택해주세요.");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. 기사 \t\t 공격력을 획득하고 시작합니다. 하지만..");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. 부자 \t\t 많은 골드를 획득하고 시작합니다. 하지만..");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. 도박사 \t\t 자신의 스탯을 운에 맡깁니다.");
            Console.ResetColor();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            bool ChoosedJob = false;
            while (!ChoosedJob)
            {
                try
                {
                    Console.Write("당신이 선택한 직업의 번호는 : ");
                    jobNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("번호에 맞게 입력하여 주십시오!");
                    Console.ResetColor();
                }

                switch (jobNumber)
                {
                    case 1:
                        ChoosedJob = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("당신이 선택한 직업은 기사입니다!");
                        break;
                    case 2:
                        ChoosedJob = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("당신이 선택한 직업은 부자입니다!");
                        break;
                    case 3:
                        ChoosedJob = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("당신이 선택한 직업은 도박사입니다!");
                        break;
                    case 0:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("번호에 맞게 입력하여 주십시오!");
                        Console.ResetColor();
                        jobNumber = 0;
                        break;
                }
                Console.ResetColor();
            }

        }

        //직업 선택 후 준비 시간
        public void Prepare()
        {
            Thread.Sleep(1500);
            Console.Clear();
            switch (jobNumber)
            {
                case 1:
                    character = new Knight(name);
                    Console.WriteLine("기사의 능력에 따라...\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("공격력이 증가하는 아이템을 획득하고 시작합니다!\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("다만.. \n");
                    Thread.Sleep(1500);
                    Console.WriteLine("너무 공격력에만 올인했군요. 방어력은 감소합니다!\n");
                    AttainItem(itemList[4]);
                    Thread.Sleep(1500);
                    Console.WriteLine("이제 마을로 이동합니다!");
                    break;
                case 2:
                    character = new Rich(name);
                    Console.WriteLine("부자의 능력에 따라...\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("보유 골드가 증가한 상태로 시작합니다!\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("다만.. \n");
                    Thread.Sleep(1500);
                    Console.WriteLine("세금이 많이 밀렸네요.. 다음 구역으로 넘어갈 시 세금 10%가 떼입니다!\n");
                    AttainItem(itemList[5]);
                    Thread.Sleep(1500);
                    Console.WriteLine("이제 마을로 이동합니다!");
                    break;
                case 3:
                    Console.WriteLine("도박사의 능력에 따라...\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("지금 당신의 운명을 결정하겠습니다!\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("선택의 기회가 주어지면 후회할 짓은 하지 않는것이 좋습니다.\n");
                    Thread.Sleep(1000);

                    PrintStatDeciding();

                    character = RollStat();

                    Thread.Sleep(1500);
                    CheckStat();
                    break;
                default:
                    break;
            }
            Thread.Sleep(1500);
        }

        //스택 정하기 글자 출력
        public void PrintStatDeciding()
        {
            Console.Write("스 ");
            Thread.Sleep(1000);
            Console.Write("탯 ");
            Thread.Sleep(1000);
            Console.Write("결 ");
            Thread.Sleep(1000);
            Console.Write("정 ");
            Thread.Sleep(1000);
            Console.WriteLine("중 ...");
            Thread.Sleep(1000);
        }

        //번호 선택시 경고 창
        public void PrintWaringForSelect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("번호에 맞게 입력하여 주십시오!");
            Console.ResetColor();
        }

        //갬블러 스탯 정하기 
        public Gambler RollStat()
        {
            Random random = new Random();
            int health = random.Next(140, 251);
            int attack = random.Next(15, 51);
            int defense = random.Next(10, 21);
            int gold = random.Next(10, 300);
            Gambler g = new Gambler(name, health, attack, defense, gold);
            return g;
        }

        //스탯 체크 
        public void CheckStat()
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("LV :\t\t {0}", character?.Level);
            Console.WriteLine("이름 :\t\t {0}", character?.Name);
            Console.WriteLine("직업 :\t\t {0}", character?.Job);
            Console.WriteLine("체력 :\t\t {0}", character?.Health);
            Console.WriteLine("공격력 :\t {0}", character?.Attack);
            Console.WriteLine("방어력 :\t {0}", character?.Defense);
            Console.WriteLine("골드 :\t\t {0}", character?.Gold);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n1. 돌아가기");
            Console.ResetColor();
            while (true)
            {
                int index = ChooseNumber();
                if (index == 1 )
                {
                    break;
                }
                else if (index != 0)
                {
                    PrintWaringForSelect();
                }
            }
        }

        //마을 선택지
        public void ChooseTown()
        {
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n==============================Stage{0}==============================\n", stage);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================마을===============================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1500);
            Console.WriteLine("?? : 마을에 온걸 환영해! 마을에 온 기념으로 탐험시에 필요할 것 같은 선물을 줄게!");
            Thread.Sleep(1500);
            Console.WriteLine("?? : 자! 이 중에서 원하는 것을 골라봐!");
            Thread.Sleep(1500);
            Console.ResetColor();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. 효과를 모르는 아이템을 하나 받는다.\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. 돈이 최고다. 소량의 돈을 받는다.\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("3. 지금 스탯이 맘에 들지 않는다. 스탯을 재분배한다. (도박사만 선택 가능)");
            Console.ResetColor();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            bool isChooseFinished = false;

            while(!isChooseFinished)
            {
                switch(ChooseNumber())
                {
                    //1. 아이템 하나 랜덤 지급
                    case 1:
                        isChooseFinished = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("?? : 자 여기있어! 행운을 빌게!\n");
                        Thread.Sleep(1500);
                        Console.ResetColor();

                        Item rItem = RandomItem();
                        AttainItem(rItem);

                        Console.WriteLine("{0} 아이템을 획득하였습니다!", rItem.Name);
                        Thread.Sleep(2000);
                        break;
                    //2. 추가 25골드 지급
                    case 2:
                        isChooseFinished = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("?? : 자 여기있어! 행운을 빌게!\n");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        Console.WriteLine("25골드를 획득하였습니다.");
                        AttainGold(25);
                        break;
                    //3. 도박사 한정 스탯 재분배
                    case 3:
                        if(character?.Job == "도박사")
                        {
                            isChooseFinished = true;

                            PrintStatDeciding();

                            character = RollStat();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("선택 할 수 없는 기능입니다.");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        PrintWaringForSelect();
                        break;
                }
            }
            Console.ResetColor();
        }

        //정비 시간 (마을)
        public void TakeRestInTown()
        {
            bool isChooseFinished = false;
            while (!isChooseFinished)
            {
                Console.Clear();
                Console.WriteLine("\n이제 무엇을 할까?");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. 던전(전투)으로 진입하기");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. 던전(선택)으로 진입하기 - 10 스테이지 이후로는 진입이 불가합니다.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3. 현재 본인의 스탯 보기");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("4. 현재 장비 인벤토리 보기");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("5. 현재 아이템 인벤토리 보기");
                Console.ResetColor();
                Console.WriteLine("상점은 5턴과 10턴에 열립니다!!! 기대해주세요!");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                switch (ChooseNumber())
                {
                    //다음 전투로 이동
                    case 1:
                        stage++;
                        isChooseFinished = true;
                        MoveToFight();
                        
                        break;
                    //다음 선택으로 이동
                    case 2:
                        stage++;
                        isChooseFinished = true;
                        MoveToSelect();
                        
                        break;
                    //현재 본인의 스탯 열기
                    case 3:
                        CheckStat();
                        break;
                    //현재 본인의 장비 인벤토리 보기
                    case 4:
                        character?.DisplayEquipmentInventory();
                        break;
                    //현재 본인의 아이템 인벤토리 보기
                    case 5:
                        character?.DisplayItemInventory();
                        break;
                    default:
                        PrintWaringForSelect();
                        break;
                }
            }
        }

        //정비 시간 (마을 이외의 던전 내에서)
        public void TakeRest()
        {
            //회복 + 아이템 효과
            HaveNextTurn();

            //게임 클리어했는지
            if(stage == 15)
            {
                GameClear();
            }

            bool isChooseFinished = false;
            while (!isChooseFinished)
            {
                Console.Clear();
                Console.WriteLine("\n{0}스테이지 클리어! 이제 무엇을 할까?", stage);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. 던전(전투)으로 진입하기");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. 던전(선택)으로 진입하기 - 10 스테이지 이후로는 진입이 불가합니다.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3. 현재 본인의 스탯 보기");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("4. 현재 장비 인벤토리 보기");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("5. 현재 아이템 인벤토리 보기");
                Console.ResetColor();
                if (stage % 5 == 4 && stage != 14)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("6. 상점으로 진입하기 (오픈했습니다!)");
                    Console.ResetColor();
                }
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                switch (ChooseNumber())
                {
                    //다음 전투로 이동
                    case 1:
                        stage++;
                        isChooseFinished = true;
                        MoveToFight();

                        break;
                    //다음 선택으로 이동
                    case 2:
                        if (stage > 11) break;         //스테이지 제한

                        stage++;
                        isChooseFinished = true;
                        MoveToSelect();

                        break;
                    //현재 본인의 스탯 열기
                    case 3:
                        CheckStat();
                        break;
                    //현재 본인의 장비 인벤토리 보기
                    case 4:
                        character?.DisplayEquipmentInventory();
                        break;
                    //현재 본인의 아이템 인벤토리 보기
                    case 5:
                        character?.DisplayItemInventory();
                        break;
                    case 6:
                        if(stage % 5 == 4 && stage != 14)
                        {
                            stage++;
                            MoveToStore();
                        }

                        break;

                    default:
                        PrintWaringForSelect();
                        break;
                }
            }
        }

        //전투
        public void MoveToFight()
        {
            Thread.Sleep(1500);
            IMonster monster = RandomMoster();
            monster.IncreaseStat(stage);

            int originDefense = character.Defense;

            //120. 러시안 룰렛 효과
            if (itemList[19].IsOwned)
            {
                character.Defense = -5;
            }

            bool isBuffed = false;
            //본격 전투
            while (!(monster.IsDead || character.IsDead))
            {
                Console.Clear();
                Console.WriteLine("\n==============================Stage{0}==============================\n", stage);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===============================전투===============================");
                Console.ResetColor();
                
                Console.WriteLine("야생의 {0}과 마주쳤다!\n", monster.Name);
                Console.WriteLine("{0} \t ---체력:{1} \t 공격력:{2} \t 방어력:{3} ---\n", monster.Name, monster.Health, monster.Attack, monster.Defense);

                Console.WriteLine("무엇을 할까?");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 방어");
                Console.WriteLine("3. 현재 본인의 스탯 보기");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                switch (ChooseNumber())
                {
                    //공격 (그냥 공격)
                    case 1:
                        //버프가 있을 경우
                        if(isBuffed)
                        {
                            //공격력의 30프로만큼 더해서 공격
                            int ThirtyPercentOfAttack = character.Attack * 3 / 10;
                            character.Attack += ThirtyPercentOfAttack;
                            monster.TakeDamage(TotalDamageToMonster(character, monster));
                            Console.WriteLine(TotalDamageToMonster(character, monster)+"만큼의 피해를 주었다!\n");
                            Thread.Sleep(2000);

                            //몬스터가 숨졌는지 확인
                            if (monster.IsDead) break;

                            character.TakeDamage(TotalDamageToCharacter(character, monster));
                            Console.WriteLine(TotalDamageToCharacter(character, monster) + "만큼의 피해를 입었다!");
                            Thread.Sleep(2000);

                            //캐릭터가 숨졌는지 확인
                            if (character.IsDead)
                            {
                                GameOver();
                            }

                            character.Attack -= ThirtyPercentOfAttack;
                            isBuffed = false;
                            
                        }
                        //버프가 없을 경우
                        else
                        {
                            monster.TakeDamage(TotalDamageToMonster(character, monster));
                            Console.WriteLine(TotalDamageToMonster(character, monster) + "만큼의 피해를 주었다!\n");
                            Thread.Sleep(2000);

                            //몬스터가 숨졌는지 확인
                            if (monster.IsDead) break;

                            character.TakeDamage(TotalDamageToCharacter(character, monster));
                            Console.WriteLine(TotalDamageToCharacter(character, monster) + "만큼의 피해를 입었다!");
                            Thread.Sleep(2000);

                            //캐릭터가 숨졌는지 확인
                            if (character.IsDead)
                            {
                                GameOver();
                            }
                        }
                        break;
                    //방어 (방어력을 한턴에 한하여 잠시 증가, 다음 턴 공격력 증가)
                    case 2:
                        //방어력의 30프로를 더해서 방어
                        int ThirtPercentOfDefense = character.Defense * 3 / 10;
                        character.Defense += ThirtPercentOfDefense;
                        Console.WriteLine("방어 자세를 취했다! 일시적으로 방어력이 올라가고 다음번 턴에 공격력이 증가합니다!\n");
                        Thread.Sleep(2000);
                        character.TakeDamage(TotalDamageToCharacter(character, monster));
                        Console.WriteLine(TotalDamageToCharacter(character, monster) + "만큼의 피해를 입었다!");
                        Thread.Sleep(2000);

                        //캐릭터가 숨졌는지 확인
                        if (character.IsDead) break;

                        character.Defense -= ThirtPercentOfDefense;
                        isBuffed = true;
                        break;
                    //현재 본인의 스탯 열기
                    case 3:
                        CheckStat();
                        break;

                    default:
                        PrintWaringForSelect();
                        break;
                }
            }
            character.Defense = originDefense;
            Console.WriteLine("전투 종료");
            Thread.Sleep(1000);
            //보상 : 랜덤 장비 / 골드 
            Equipment eq = RandomEquipment();
            AttainGold(monster.Gold);
            character.GetEquipment(eq);
            Console.WriteLine("다음과 같은 보상을 획득하였습니다! \n");
            Console.WriteLine("골드 + {0}  || 장비 : {1}", monster.Gold, eq.Name);
            Console.WriteLine("휴식으로 넘어갑니다... \n");
            Thread.Sleep(5000);
            TakeRest();
        }

        //선택
        public void MoveToSelect()
        {
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n==============================Stage{0}==============================\n", stage);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================선택===============================");
            Console.ResetColor();

            //선택 사건들 집어넣기
            Random randomEvent = new Random();
            int eventNumber = randomEvent.Next(1,10);
            Selection selection = new Selection(eventNumber, character, itemList);
            selection.StartEvent();

            Console.WriteLine("휴식으로 넘어갑니다... \n");
            Thread.Sleep(5000);
            TakeRest();
        }

        //상점
        public void MoveToStore()
        {
            Thread.Sleep(1500);
            Console.Clear();

            Store store = new Store(character, equipmentList, itemList,stage);
            store.DisplayGoods();

            Console.WriteLine("휴식으로 넘어갑니다... \n");
            Thread.Sleep(5000);
            TakeRest();
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
                PrintWaringForSelect();
                return 0;
            }
            return chooseNumber;
        }

        //장비 얻기
        public void AttainEquipment(Equipment eq)
        {
            character?.GetEquipment(eq);
        }

        //아이템 얻기
        public void AttainItem(Item item)
        {
            character?.GetItem(item);
        }

        //아이템 버리기
        public void DumpItem(Item item)
        {
            character?.DumpItem(item);
        }

        //랜덤 아이템 얻기
        public Item RandomItem()
        {
            Item item = new Item();
            while (true)
            {
                Random random = new Random();
                item = itemList[random.Next(1, itemList.Count)];
                if (!item.IsOwned)
                {
                    return item;
                }
            }
        }

        //랜덤 장비 얻기
        public Equipment RandomEquipment()
        {
            Equipment eq = new Equipment();
            while (true)
            {
                Random random = new Random();
                eq = equipmentList[random.Next(1, equipmentList.Count)];
                if (!eq.IsOwned)
                {
                    return eq;
                }
            }
        }

        //골드 얻기
        public void AttainGold(int gold)
        {
            character?.GetGold(gold);
        }

        //골드 잃기
        public void LostGold(int gold)
        {
            character?.LostGold(gold);
        }

        //랜덤 몬스터 
        public IMonster RandomMoster()
        {
            Random random = new Random();
            int index = random.Next(1, 5);
            if (index == 1)
            {
                Goblin goblin = new Goblin();
                return goblin;
            }
            else if (index == 2)
            {
                Dragon dragon = new Dragon();
                return dragon;
            }
            else if(index == 3) 
            {
                Slime slime = new Slime();
                return slime;
            }
            else
            {
                Devil devil = new Devil();
                return devil;
            }
        }

        //캐릭터가 몬스터에게 주는 최종 피해량      캐릭터 -> 몬스터
        public int TotalDamageToMonster(ICharacter c, IMonster m)
        {
            return (c.Attack - m.Defense) > 0 ? (c.Attack - m.Defense) : 0;
        }

        //몬스터가 캐릭터에게 주는 최종 피해량      몬스터 -> 캐릭터
        public int TotalDamageToCharacter(ICharacter c, IMonster m)
        {
            //128. 화련한 왕관의 효과
            if (itemList[28].IsOwned)
            {
                return (m.Attack - c.Defense + 10) > 0 ? (m.Attack - c.Defense) : 0;
            }
            else
            {
                return (m.Attack - c.Defense) > 0 ? (m.Attack - c.Defense) : 0;
            }
        }

        // 다음 턴으로 왔을 때 -> 캐릭터 최대체력의 20% 힐 + 턴 시작 아이템 효과 발동
        public void HaveNextTurn()
        {
            character.Health += (character.MaxHealth / 5);
            //117. 참 잘했어요 도장 효과
            if (itemList[16].IsOwned)
            {
                character.Health += 10;
            }

            //106. 탈세증명서 효과
            if (itemList[5].IsOwned)
            {
                LostGold(character.Gold / 10);
            }

            //107. 제육볶음 효과
            if (itemList[6].IsOwned)
            {
                character.Health -= (character.Health / 10);
            }

            //119. 토끼 인형 효과
            if (itemList[18].IsOwned)
            {
                character.Health += (character.MaxHealth / 10);
            }

            //112. 광대의 룰렛 효과
            if (itemList[11].IsOwned)
            {
                Random r = new Random();
                int index = r.Next(1, 4);
                if(index == 1)
                {
                    character.GetItem(RandomItem());  
                }
            }

            if (character.Health > character.MaxHealth)
            {
                character.Health = character.MaxHealth;
            }
        }

        public void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("게임 오버!!");
            Console.ResetColor();
            Thread.Sleep(1000);
            Environment.Exit(0);    
        }

        public void GameClear()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("게임 클리어!!");
            Thread.Sleep(1000);
            Console.WriteLine("플레이 해주셔서 감사합니다!!!");
            Console.ResetColor();
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
