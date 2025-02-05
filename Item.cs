using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Item
    {
        public int Id { get; set; }                     //식별 아이디
        public string Name { get; set; }                //아이템 이름
        public string Description { get; set; }         //아이템 설명
        public string EffectDescription { get; set; }   //아이템 효과 설명

        public int AttackPoint;                         //공격력
        public int DefensePoint;                        //방어력

        public int Price { get; set; }                  //가격 
        public bool IsOwned { get; set; }               //소유 여부

        public Item()
        {
            Id = 100;
            Name = "아이템";
            Description = "아이템 설명";
            EffectDescription = "아이템 효과 설명";
            AttackPoint = 0;
            DefensePoint = 0;
            Price = 1;
            IsOwned = false;
        }

        public Item(int _id, string _name, string _description, string _effectDescription, int _attackPoint,
            int _defensePoint, int _price, bool _isOwned)
        {
            Id = _id;
            Name = _name;
            Description = _description;
            EffectDescription = _effectDescription;
            AttackPoint = _attackPoint;
            DefensePoint = _defensePoint;
            Price = _price;
            IsOwned = _isOwned;
        }
    }
}
