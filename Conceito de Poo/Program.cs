using System;

namespace poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 530);
            Wizard magicMan = new Wizard("Alaf", 45, "Magic", 340);

            Console.WriteLine(arus.ToString());
            Console.WriteLine(magicMan.Attack());
            Console.WriteLine(arus.Attack());
            System.Console.WriteLine(magicMan.Attack(3, "Machadada"));



        }

    }
}
