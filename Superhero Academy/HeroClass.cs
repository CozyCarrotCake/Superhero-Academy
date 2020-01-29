using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class HeroClass
    {
        public string name; 
        

        public List<string> availblePower = new List<string>(); // En lista med alla klassers möjliga krafter, krafterna läggs till genom subklasserna



        protected int hp; // förändras i subklasserna och tänkt krafterna, protected så att enbart det kan förändras i subklasserna (vet att de gjorde så att
        // jag inte kunde förändra de i krafterna, men var något annat problem också)

        protected int dmgPot;

        protected int movement;


    }
}
