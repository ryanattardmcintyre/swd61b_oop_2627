using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_Game
{
    public abstract class Character : IAttack
    {
        protected Character(int mana, int damage, int health) {
            Mana = mana;
            Damage = damage;
            Health = health;
        }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public abstract void Attack(Character target);
        
    }
}
