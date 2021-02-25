using System;
using System.Collections.Generic;
using System.Text;
using TRABAJO1_DRAF.common;

namespace TRABAJO1_DRAF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //banear 5 heroes
            var Hlist = HeroesList();
            IBannable ban = new Banned();
            ban.BanHero(Hlist,1);
            //game.BanHero(Hlist, 1);
            //game.BanHero1(Hlist, 1);
            //elegir heroes
            List<Hero> list2 = new List<Hero>(10);
            static List<Hero> HeroesList()
            {
                var result = new List<Hero>();
                result.Add(new Hero() { Id = 1, Name = "Abadon", Characters = "Core, Support and Tank, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 2, Name = "Tinker", Characters = "Core, Hero mid lanner", State = true });
                result.Add(new Hero() { Id = 3, Name = "Shadow Shaman", Characters = "Support, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 7, Name = "Antimage", Characters = "Core, Hero safe lane", State = true });
                result.Add(new Hero() { Id = 5, Name = "Juggernaut", Characters = "Core, Hero safe lane", State = true });
                result.Add(new Hero() { Id = 4, Name = "Faceless Void", Characters = "Core, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 9, Name = "Lina", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 6, Name = "Mirana", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 10, Name = "Shadow Field", Characters = "Core, Hero mid lanner", State = true });
                result.Add(new Hero() { Id = 8, Name = "Nigth Stalker", Characters = "Core and Tank, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 11, Name = "Manus", Characters = "Core, Support and Tank, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 12, Name = "Invoker", Characters = "Core, Hero mid lanner", State = true });
                result.Add(new Hero() { Id = 13, Name = "Lion", Characters = "Support, Hero off lanner or safe lane", State = true });
                result.Add(new Hero() { Id = 14, Name = "Spectre", Characters = "Core, Hero safe lane", State = true });
                return result;
            }
        }
    }
}
