using System;
using static System.Console;
using RPG_ABSTRACAO.src.entities;

namespace RPG_ABSTRACAO
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight hero = new Knight("Arus", 23, "Knight" , 100 , 70);
           Wizard maga = new Wizard("Jenica", 66, "White Wizard", 70, 100 );
           
           WriteLine(hero.ToString());
           WriteLine(hero.Attack());
           WriteLine(maga.Attack(2));
        }
    }
}
