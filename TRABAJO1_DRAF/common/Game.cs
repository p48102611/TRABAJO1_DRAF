using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public class Game<T> where T : IHero, IItem, IPlayer
    {


        public List<Hero> HeroesList()
        {
            var result = new List<Hero>();
            result.Add(new Hero() { Id = 1, Name = "Abadon", Characters = "Core, Support and Tank, Hero off lanner or safe lane" });
            result.Add(new Hero() { Id = 2, Name = "Tinker", Characters = "Core, Hero mid lanner" });
            result.Add(new Hero() { Id = 3, Name = "Shadow Shaman", Characters = "Support, Hero off lanner or safe lane" });
            result.Add(new Hero() { Id = 7, Name = "Antimage", Characters = "Core, Hero safe lane" });
            result.Add(new Hero() { Id = 5, Name = "Juggernaut", Characters = "Core, Hero safe lane" });
            result.Add(new Hero() { Id = 4, Name = "Faceless Void", Characters = "Core, Hero off lanner or safe lane" });
            result.Add(new Hero() { Id = 9, Name = "Lina", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane" });
            result.Add(new Hero() { Id = 6, Name = "Mirana", Characters = "Core and Support, Hero off lanner, mid lanner or safe lane" });
            result.Add(new Hero() { Id = 10, Name = "Shadow Field", Characters = "Core, Hero mid lanner" });
            result.Add(new Hero() { Id = 8, Name = "Nigth Stalker", Characters = "Core and Tank, Hero off lanner or safe lane" });
            return result;
        }
    }
}
