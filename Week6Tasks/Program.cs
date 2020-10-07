using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };
            Random rnd = new Random();
            int randomHero = rnd.Next(0, superHeroes.Length);
            int randomVillain = rnd.Next(0, superVillains.Length);
            int randomWeapon = rnd.Next(0, weapon.Length);

            Console.WriteLine($"{superHeroes[randomHero]} will fight {superVillains[randomVillain]} with a {weapon[randomWeapon]}");
        }
    }
}
