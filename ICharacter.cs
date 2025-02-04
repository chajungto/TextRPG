namespace TextRPG
{
    internal interface ICharacter
    {
        public string Name { get; set; }        //이름
        public string Job { get; set; }         //직업
        public int Level { get; set; }          //레벨
        public int MaxHealth { get; set; }      //최대 체력
        public int Health { get; set; }         //체력
        public int Attack { get; set; }         //공격력
        public int Defense { get; set; }        //방어력
        public int Gold { get; set; }           //골드
        public bool IsDead { get; set; }        //사망 여부

        public void TakeDamage(int damage);                 //피해 입기
        public void GetGold(int gold);                      //골드 얻기
        public void LostGold(int gold);                     //골드 잃기

        public void GetEquipment(Equipment eq);             //장비 얻기
        public void GetEquipment(Equipment eq, int gold);   //장비 얻기(구매)
        public void DisplayEquipmentInventory();            //장비 인벤토리

        public void GetItem(Item item);                     //아이템 얻기
        public void DumpItem(Item item);                    //아이템 버리기
        public void DisplayItemInventory();                 //아이템 인벤토리

        public bool isGoldExist(int amount);                //돈 부족 여부

        public int ChooseNumber();                          //숫자 고르기
        public void PrintWaringForSelect();                 //경고문
    }
}
