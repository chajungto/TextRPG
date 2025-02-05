namespace TextRPG
{
    internal class Equipment
    {
        public int Id { get; set; }                     //식별 아이디
        public string Name { get; set; }                //장비 이름
        public string Description { get; set; }         //장비 설명
        public string EffectDescription { get; set; }   //장비 효과 설명

        public int AttackPoint;                         //공격력
        public int DefensePoint;                        //방어력

        public int Price { get; set; }                  //가격 
        public bool IsEquipped { get; set; }            //착용 여부
        public bool IsOwned { get; set; }               //소유 여부

        public Equipment()
        {
            Id = 0;
            Name = "장비";
            Description = "장비 설명";
            EffectDescription = "장비 효과 설명";
            AttackPoint = 0;
            DefensePoint = 0;
            Price = 1;
            IsEquipped = false;
            IsOwned = false;
        }

        public Equipment(int _id, string _name, string _description, string _effectDescription, int _attackPoint,
            int _defensePoint, int _price, bool _isEquipped, bool _isOwned)
        {
            Id = _id;
            Name = _name;
            Description = _description;
            EffectDescription = _effectDescription;
            AttackPoint = _attackPoint;
            DefensePoint = _defensePoint;
            Price = _price;
            IsEquipped = _isEquipped;
            IsOwned = _isOwned;
        }
    }

}
