using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class Technological : HeroClass
    {
        public Technological()
        {
            availblePower.Add("Suit"); //Lägger till krafterna i listan med möjliga kraftr
            availblePower.Add("Weapon");
            availblePower.Add("Gadgets");

            hp = 75;
            dmgPot = 105;
            movement = 80;
        }
        



    }
}
