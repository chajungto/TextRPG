namespace TextRPG
{
    internal class Slime : IMonster
    {
        public string Name { get; set; }        //이름
        public int MaxHealth { get; set; }      //최대 체력
        public int Health { get; set; }         //체력
        public int Attack { get; set; }         //공격력
        public int Defense { get; set; }        //방어력
        public int Gold { get; set; }           //골드
        public bool IsDead { get; set; }        //사망 여부

        public Slime()
        {
            Name = "슬라임";
            MaxHealth = 110;
            Health = 110;
            Attack = 18;
            Defense = 12;
            Gold = 18;
            IsDead = false;
        }


        //스테이지 올라갈수록 스탯 증가
        public void IncreaseStat(int stage)
        {
            MaxHealth += stage * 3;
            Health += stage * 3;
            Attack += stage * 3;
            Defense += stage * 3;
            Gold += stage * 3;
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
    }
}
