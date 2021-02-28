using System;
using System.Collections.Generic;
using System.Text;
using static TRABAJO1_DRAF.Program;

namespace TRABAJO1_DRAF.common
{
    class Player : //IPrint, IExcute, IPlayer
    {
        private int id;
        private string name;
        private int gold;
        private int behaviorScore;
        private Hero pickHero = new Hero();
        public MyGenericArray<Item> items = new MyGenericArray<Item>(9);
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int BehaviorScore { get { return behaviorScore; } set { behaviorScore = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public Hero PickHero { get { return pickHero; } set { pickHero = value; } }
        public MyGenericArray<Item> Items { get { return items; } set { items = value; } }
        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
