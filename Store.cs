using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Store
    {
        ICharacter Character;
        List<Equipment> EqList;
        List<Item> ItemList;
        int stage;

        public Store()
        {
            Character = new Knight();
            EqList = new List<Equipment>();
            ItemList = new List<Item>();
            stage = 1;
        }

        public Store(ICharacter _character, List<Equipment> _eqList, List<Item> _itemList, int _stage)
        {
            Character = _character;
            EqList = _eqList;
            ItemList = _itemList;
            stage = _stage;
        }

        //상품 전시
        public void DisplayGoods()
        {
            List<Equipment> threeRandomEquipment = new List<Equipment>();
            List<Item> threeRandomItem = new List<Item>();
            bool isBuyFinished = false;

            //장비 중복 피하며 3개 추출
            while (true)
            {
                threeRandomEquipment.Add(RandomEquipment());
                threeRandomEquipment.Add(RandomEquipment());
                threeRandomEquipment.Add(RandomEquipment());
                if (threeRandomEquipment.Count() == threeRandomEquipment.Distinct().Count())
                {
                    break;
                }
            }

            //아이템 중복 피하며 3개 추출
            while (true)
            {
                threeRandomItem.Add(RandomItem());
                threeRandomItem.Add(RandomItem());
                threeRandomItem.Add(RandomItem());
                if (threeRandomItem.Count() == threeRandomItem.Distinct().Count())
                {
                    break;
                }
            }
            while (!isBuyFinished)
            {
                Console.Clear();
                Console.WriteLine("\n==============================Stage{0}==============================\n", stage);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===============================상점===============================");
                Console.ResetColor();
                Console.WriteLine("");

                Console.WriteLine("===============================장비===============================");
                for (int order = 1; order <= threeRandomEquipment.Count(); order++)
                {
                    Console.Write("{0}.{1,-35}{2,-35} 가격: {3,-10}", order, threeRandomEquipment[order - 1].Name,
                        threeRandomEquipment[order - 1].EffectDescription, threeRandomEquipment[order - 1].Price);
                    if (threeRandomEquipment[order - 1].IsOwned)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[보유중]");
                        Console.ResetColor();
                    }
                    else Console.WriteLine("");
                }

                Console.WriteLine("");

                Console.WriteLine("===============================아이템===============================");
                for (int order = 4; order <= threeRandomItem.Count() + 3; order++)
                {
                    Console.Write("{0}.{1,-40} 가격:{2,-10}", order, threeRandomItem[order - 4].Name, threeRandomItem[order - 4].Price);
                    if (threeRandomItem[order - 4].IsOwned)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[보유중]");
                        Console.ResetColor();
                    }
                    else Console.WriteLine("");
                }
                Console.WriteLine("==================================================================");
                Console.WriteLine("구매하고 싶으신 상품의 번호를 선택하여 주십시오. ");
                Console.WriteLine("다음 구역으로 이동하고 싶다면 해당 번호 외 다른 버튼을 눌러주세요.");


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("보유 골드 : {0}\n", Character.Gold);
                Console.ResetColor();
                switch (ChooseNumber())
                {
                    case 1:
                        BuyEq(threeRandomEquipment[0]);

                        break;
                    case 2:
                        BuyEq(threeRandomEquipment[1]);
                        break;
                    case 3:
                        BuyEq(threeRandomEquipment[2]);
                        break;
                    case 4:
                        BuyItem(threeRandomItem[0]);
                        break;
                    case 5:
                        BuyItem(threeRandomItem[1]);
                        break;
                    case 6:
                        BuyItem(threeRandomItem[2]);
                        break;
                    default:
                        isBuyFinished = true;
                        break;
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
                eq = EqList[random.Next(1, EqList.Count)];
                if (!eq.IsOwned)
                {
                    return eq;
                }
            }
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

        //해당 물품을 살수 있는가?
        public bool IsAbleToBuy(int price)
        {
            if (Character.Gold - price >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //장비 구매
        public void BuyEq(Equipment eq)
        {
            if (eq.IsOwned)
            {
                Console.WriteLine("당신의 이미 해당 물품을 가지고 있습니다.");
            }
            else if (IsAbleToBuy(eq.Price))
            {
                Character.Gold -= eq.Price;
                Console.WriteLine("{0} 장비를 구매하였습니다", eq.Name);
                Character.GetEquipment(eq);
            }
            else
            {
                Console.WriteLine("당신의 돈이 부족합니다!");
            }
            Thread.Sleep(1000);
        }

        //아이템 구매
        public void BuyItem(Item item)
        {
            if (item.IsOwned)
            {
                Console.WriteLine("당신의 이미 해당 물품을 가지고 있습니다.");
            }
            else if (IsAbleToBuy(item.Price))
            {
                Character.Gold -= item.Price;
                Console.WriteLine("{0} 아이템을 구매하였습니다", item.Name);
                Character.GetItem(item);
            }
            else
            {
                Console.WriteLine("당신의 돈이 부족합니다!");
            }
            Thread.Sleep(1000);
        }
    }
}
