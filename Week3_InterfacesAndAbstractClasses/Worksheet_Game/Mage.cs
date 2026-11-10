using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_Game
{
    
    public class Mage: Character
    {
        public Mage():base(300, 75, 100)
        { }
        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= (Damage * 2);
        }
    }
}
