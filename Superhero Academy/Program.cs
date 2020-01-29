using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroClass you = new HeroClass(); // Skapar en instans av spelarens klass, som sedan förändras beroende på vad man väljer, skapar den nu så att 
            //man försäkrar koden om att den alltid kommer att ha en klass

            Console.WriteLine("Hello there! Welcome to Superhero Academy!");
            Console.WriteLine("What is your name?");
            string answer0 = Console.ReadLine();

            you.name = answer0; // Lägger till namnet i name-klassen i den nyskapade instansen

            Console.WriteLine("What kind of Superhero are you?");
            Console.WriteLine("1. Biological?");
            Console.WriteLine("2. Magical?");
            Console.WriteLine("3. Technological?");
            string answer1 = Console.ReadLine(); //Put in a list?
            

            
            if (answer1 == "1")
            {
                Console.WriteLine("Which kind of biological?");
                Console.WriteLine("1. Trained?");
                Console.WriteLine("2. Enhanced?");
                string answer2 = Console.ReadLine();

                if (answer2 == "1")
                {
                    you = new Trained(); //Blir en ny subklass
                }
                else if (answer2 == "2")
                {
                    you = new Enhanced();
                }
                
                
            }
            else if (answer1 == "2")
            {
                you = new Magical();
            }

            else if (answer1 == "3")
            {
                you = new Technological();
                
            }
            


            Console.WriteLine("What power do you want?");
            for (int i = 0; i < you.availblePower.Count; i++)
            {
                Console.WriteLine(you.availblePower[i]); //Räknar upp de möjliga krafterna som den klassen kan inneha
            }
            string answer3 = Console.ReadLine();


            if (answer3 == "1")
            {
            } // fuck aja
            Power yourPower = new Power(); // Tänkte förtydliga vilken kraft man valde här men blöh för tid och dålig planering












            Console.ReadLine();
        }
    }
}
