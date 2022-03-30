using System;
using AbstraçãoRPG;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Knight Arus = new Knight ("Arus", 23, "Knight", "Fatal blow", 150, 150);
        Wizard Jenica = new Wizard ("Jenica", 23, "Knight", "Big air ball", 150, 150);
        Wizard Topapa = new Wizard ("Topapa", 25, "Black Wizard","Big fireball", 150, 150);
        Ninja Wedge = new Ninja ("Wedge", 30, "Black Wizard","Super fast blow", 150, 150);

            Console.WriteLine(Arus.attack(8));
            Console.WriteLine(Jenica.attack(9));
            Console.WriteLine(Topapa.attack(7));
            Console.WriteLine(Wedge.attack(4));


            
        }
    }
}

