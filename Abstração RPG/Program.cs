using System;
using AbstraçãoRPG;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Knight Arus = new Knight ("Arus", 23, "Knight", "Fatal blow", 150, 150);
        Wizard Jenica = new Wizard ("Jenica", 23, "White Wizard", "Big air ball", 150, 150);
        Wizard Topapa = new Wizard ("Topapa", 25, "Black Wizard","Big fireball", 150, 150);
        Ninja Wedge = new Ninja ("Wedge", 30, "Ninja","Super fast blow", 150, 150);

            Console.WriteLine(Arus);
            Console.WriteLine(Jenica);
            Console.WriteLine(Topapa.attack(7));
            Console.WriteLine(Wedge.attack(4));


            
        }
    }
}

