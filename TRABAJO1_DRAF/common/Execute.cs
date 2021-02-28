using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TRABAJO1_DRAF;
namespace TRABAJO1_DRAF.common
{
    public class Execute<T> where T : IExcute
    {
        public List<Hero> HeroesList = HeroesListDefault();
        public List<Item> ItemsList = ItemsListDefault();
        public List<Player> PlayersList = PlayersListDefault();
        
        public void ExeBanHero<T>(int i) where T : IBanned, new()
        {
            T ban = new T();
            ban.BanHero(HeroesList, i);
        }
        public void ExeBanHeroExt<T>(int i) where T : IBanned, new()
        {
            T ban = new T();
            ban.BanHeroExt(HeroesList, i);
        }

        //public Action<int,int> ExeSellItem = (idPlayer, idItem) =>
        //{
        //    var P = ItemsList.SingleOrDefault(e => e.Id == idPlayer);
        //    //Console.WriteLine(h.State);            
        //};
        //public void 

        public static List<Hero> HeroesListDefault()
        {
            var result = new List<Hero>
                {
                    new Hero() { Id = 1, Name = "Abadon", Characters = "Core, Support and Tank, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 2, Name = "Tinker", Characters = "Core, Hero mid lanner", State = true },
                    new Hero() { Id = 3, Name = "Shadow Shaman", Characters = "Support, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 7, Name = "Antimage", Characters = "Core, Hero safe lane", State = true },
                    new Hero() { Id = 5, Name = "Juggernaut", Characters = "Core, Hero safe lane", State = true },
                    new Hero() { Id = 4, Name = "Faceless Void", Characters = "Core, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 9, Name = "Lina", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true },
                    new Hero() { Id = 6, Name = "Mirana", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane", State = true },
                    new Hero() { Id = 10, Name = "Shadow Field", Characters = "Core, Hero mid lanner", State = true },
                    new Hero() { Id = 8, Name = "Nigth Stalker", Characters = "Core and Tank, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 11, Name = "Manus", Characters = "Core, Support and Tank, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 12, Name = "Invoker", Characters = "Core, Hero mid lanner", State = true },
                    new Hero() { Id = 13, Name = "Lion", Characters = "Support, Hero off lanner or safe lane", State = true },
                    new Hero() { Id = 14, Name = "Spectre", Characters = "Core, Hero safe lane", State = true }
                };
            return result;
        }
        public static List<Item> ItemsListDefault()
        {
            var result = new List<Item>
                {
                    new Item() { Id = 1, Name = "Observer Ward", Price = 0, Description = "Plants an Observer Ward, an invisible watcher that gives ground vision in a 1400 radius to your team. Lasts 6 minutes." },
                    new Item() { Id = 2, Name = "Tango", Price = 90, Description = "Consumes a target tree to gain 7 health regeneration for 16 seconds. Consuming an Ironwood Tree doubles the heal amount." },
                    new Item() { Id = 3, Name = "Enchanted Mango", Price = 70, Description = "Instantly restores 100 mana." },
                    new Item() { Id = 7, Name = "Faerie Fire", Price = 70, Description = "Instantly restores 85 health." },
                    new Item() { Id = 5, Name = "Clarity", Price = 50, Description = "Grants 6 mana regeneration to the target for 30 seconds.." },
                    new Item() { Id = 4, Name = "Iron Branch", Price = 50, Description = "Targets the ground to plant a happy little tree that lasts for 20 seconds." },
                    new Item() { Id = 8, Name = "Magic Stick", Price = 200, Description = "Instantly restores 15 health and mana per charge stored." },
                    new Item() { Id = 6, Name = "Quelling Blade", Price = 130, Description = "Destroy a target tree." }
                };
            return result;
        }
        public static List<Player> PlayersListDefault()
        {
            var result = new List<Player>
                {
                    new Player() { Id = 1, Name = "Puppey", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 2, Name = "Arteezy", BehaviorScore = 1, Gold = 600},
                    new Player() { Id = 3, Name = "RAMZESS666", BehaviorScore = 10, Gold = 600 },
                    new Player() { Id = 7, Name = "N0tail", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 5, Name = "Kuroky", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 4, Name = "Dendi", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 9, Name = "Fear", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 8, Name = "Abed", BehaviorScore = 10000, Gold = 600 },
                    new Player() { Id = 10, Name = "N0tail", BehaviorScore = 1000, Gold = 600 },
                    new Player() { Id = 6, Name = "Miracle-", BehaviorScore = 10000, Gold = 600 }
                };
            return result;
        }

    }
}