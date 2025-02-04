namespace TextRPG
{
    internal class Gambler : ICharacter
    {
        public string Name { get; set; }        //이름
        public string Job { get; set; }         //직업
        public int Level { get; set; }          //레벨
        public int MaxHealth { get; set; }      //최대체력
        public int Health { get; set; }         //체력
        public int Attack { get; set; }         //공격력
        public int Defense { get; set; }        //방어력
        public int Gold { get; set; }           //골드
        public bool IsDead { get; set; }        //사망여부

        //장비 인벤토리
        List<Equipment> equipments = new List<Equipment>();

        //아이템 인벤토리
        List<Item> items = new List<Item>();

        public Gambler()
        {
            Name = "NULL";
            Job = "도박사";
            Level = 1;
            MaxHealth = 0;
            Health = 0;
            Attack = 0;
            Defense = 0;
            Gold = 0;
            IsDead = false;
        }


        public Gambler(string name, int Maxhealth, int attack, int defense, int gold)
        {
            Name = name;
            Job = "도박사";
            Level = 1;
            MaxHealth = Maxhealth;
            Health = Maxhealth;
            Attack = attack;
            Defense = defense;
            Gold = gold;
            IsDead = false;
        }


        //피해 입기
        public void TakeDamage(int damage)
        {
            this.Health -= damage;
            if (this.Health <= 0)
            {
                IsDead = true;
            }
        }

        //골드 얻기
        public void GetGold(int gold)
        {
            this.Gold += gold;
        }

        //골드 잃기
        public void LostGold(int gold)
        {
            this.Gold -= gold;
            if (this.Gold < 0)
            {
                this.Gold = 0;
            }
        }

        //장비 획득
        public void GetEquipment(Equipment eq)
        {
            equipments.Add(eq);
            eq.IsOwned = true;
        }

        //장비 획득 (돈으로)
        public void GetEquipment(Equipment eq, int gold)
        {
            if (isGoldExist(gold))
            {
                equipments.Add(eq);
                this.Gold -= gold;
                eq.IsOwned = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("골드가 부족합니다!");
                Console.ResetColor();
            }
        }

        public void DisplayEquipmentInventory()
        {
            bool isChooseFinished = false;
            while (!isChooseFinished)
            {
                Console.Clear();
                int index = 1;
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++장비 인벤토리++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                foreach (var eq in equipments)
                {
                    Console.Write("{0}.", index);
                    if (eq.IsEquipped)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[E]\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    Console.WriteLine("{0, -15}\t{1,-30}\t{2,-10}", eq.Name, eq.EffectDescription, eq.Description);
                    index++;
                }
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("원하는 번호를 누르면 그에 해당하는 번호의 장비를 착용 또는 해제 가능합니다.");
                Console.WriteLine("0. 나가기");
                //원하는 번호를 누르면 그에 해당하는 번호의 장비를 착용 또는 해제 가능합니다.
                int number = ChooseNumber();
                if (number <= equipments.Count && number > 0)
                {
                    Equipment eq = equipments[number - 1];
                    eq.IsEquipped = !eq.IsEquipped;
                    if (eq.IsEquipped)
                    {
                        ApplyEQEffect(eq);
                    }
                    else
                    {
                        LoseEQEffect(eq);
                    }

                }
                //0. 나가기
                else if (number == 0)
                {
                    break;
                }
                else
                {
                    PrintWaringForSelect();
                }
            }

        }


        //장비 효과 켜기
        public void ApplyEQEffect(Equipment eq)
        {
            this.Attack += eq.AttackPoint;
            this.Defense += eq.DefensePoint;
        }

        //장비 효과 끄기
        public void LoseEQEffect(Equipment eq)
        {
            this.Attack -= eq.AttackPoint;
            this.Defense -= eq.DefensePoint;
        }

        //아이템 획득
        public void GetItem(Item item)
        {
            items.Add(item);
            item.IsOwned = true;
            ApplyItemEffect(item);
        }

        //아이템 버리기
        public void DumpItem(Item item)
        {
            items.Remove(item);
            item.IsOwned = false;
            LoseItemEffect(item);
        }


        //아이템 인벤토리 보여주기
        public void DisplayItemInventory()
        {
            bool isChooseFinished = false;
            while (!isChooseFinished)
            {
                Console.Clear();
                int index = 1;
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++아이템 인벤토리++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                foreach (var item in items)
                {
                    Console.Write("{0}.", index);

                    Console.Write("\t");

                    Console.WriteLine("{0, -15}\t{1,-30}\t{2,-10}", item.Name, item.EffectDescription, item.Description);
                    index++;
                }
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("0. 나가기");
                int number = ChooseNumber();
                //0. 나가기
                if (number == 0)
                {
                    break;
                }
            }
        }

        //아이템 효과 켜기
        public void ApplyItemEffect(Item item)
        {
            this.Attack += item.AttackPoint;
            this.Defense += item.DefensePoint;
        }

        //아이템 효과 끄기
        public void LoseItemEffect(Item item)
        {
            this.Attack -= item.AttackPoint;
            this.Defense -= item.DefensePoint;
        }


        //돈 부족 체크
        public bool isGoldExist(int amount)
        {
            if (this.Gold - amount >= 0)
            {
                return true;
            }
            return false;
        }

        //숫자 고르기
        public int ChooseNumber()
        {
            int chooseNumber = -1;
            try
            {
                chooseNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                PrintWaringForSelect();
                return -1;
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
    }
}
