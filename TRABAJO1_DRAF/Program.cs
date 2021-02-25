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
            List<Hero> list2 = new List<Hero>();
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
            static List<Item> ItemsList()
            {
                var result = new List<Item>();
                result.Add(new Item() { Id = 1, Name = "Observer Ward", Price = 0, Description = "Plants an Observer Ward, an invisible watcher that gives ground vision in a 1400 radius to your team. Lasts 6 minutes." });
                result.Add(new Item() { Id = 2, Name = "Tango", Price = 90, Description = "Consumes a target tree to gain 7 health regeneration for 16 seconds. Consuming an Ironwood Tree doubles the heal amount." });
                result.Add(new Item() { Id = 3, Name = "Enchanted Mango", Price = 70, Description = "Instantly restores 100 mana." });
                //result.Add(new Item() { Id = 7, Name = "Faerie Fire", Price = "Core, Hero safe lane", State = true });
                //result.Add(new Item() { Id = 5, Name = "Clarity", Price = "Core, Hero safe lane", State = true });
                //result.Add(new Item() { Id = 4, Name = "Iron Branch", Price = "Core, Hero off lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 9, Name = "Magic Stick", Price = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 6, Name = "Quelling Blade", Price = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 10, Name = "Shadow Field", Price = "Core, Hero mid lanner", State = true });
                //result.Add(new Item() { Id = 8, Name = "Nigth Stalker", Price = "Core and Tank, Hero off lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 11, Name = "Manus", Price = "Core, Support and Tank, Hero off lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 12, Name = "Invoker", Price = "Core, Hero mid lanner", State = true });
                //result.Add(new Item() { Id = 13, Name = "Lion", Price = "Support, Hero off lanner or safe lane", State = true });
                //result.Add(new Item() { Id = 14, Name = "Spectre", Price = "Core, Hero safe lane", State = true });
                return result;
            }
        }
    }
}
