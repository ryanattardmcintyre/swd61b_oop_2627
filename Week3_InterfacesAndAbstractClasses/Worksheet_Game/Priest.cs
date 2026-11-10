using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_Game
{
    /*
      
 150 health points.

     */
    public class Priest: Character, IHeal
    {
        public Priest() : base(200, 100, 125) {}

        public override void Attack(Character target)
        {
            target.Health -= Damage;
            this.Health += 10;

        }

        public void Heal(Character target)
        {
            if (Mana >= 100)
            {
                Mana -= 100;
                target.Health += 150;
            }
        }
    }
}
