namespace TextRPG
{
    internal interface IMonster
    {
        public string Name { get; set; }        //이름
        public int MaxHealth { get; set; }      //최대 체력
        public int Health { get; set; }         //체력
        public int Attack { get; set; }         //공격력
        public int Defense { get; set; }        //방어력
        public int Gold { get; set; }           //골드
        public bool IsDead { get; set; }        //사망 여부

        public void IncreaseStat(int stage);                //스테이지 올라갈수록 스탯 증가
        public void TakeDamage(int damage);                 //피해 입기

    }
}
