using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public class Hero : IPrint, IExecute//, IHero
    {

        private int id;
        private string name;
        private string characters;
        private bool state;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Characters { get { return characters; } set { characters = value; } }
        public bool State { get { return state; } set { state = value; } }
        public bool ChangeState(){ state = !state; return state; }

        public void ShowInfo()
        {
            Console.WriteLine($"IdHero: {Id} | Name: {Name} | Enable: {State} ");
        }
    }
}
