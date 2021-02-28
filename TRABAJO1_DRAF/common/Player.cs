using System;
using System.Collections.Generic;
using System.Text;
using static TRABAJO1_DRAF.Program;

namespace TRABAJO1_DRAF.common
{
    public class Player : IPrint, IExcute//, IPlayer
    {
        private int id;
        private string name;
        private int gold;
        private int behaviorScore;
        //private Hero heroPicked = new Hero();
        private int heroPicked;
        //public MyGenericArray<Item> items = new MyGenericArray<Item>(9);
        public int[] items;
        public Player() { gold = 600; behaviorScore = 10000; items = new int[9]; }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int BehaviorScore { get { return behaviorScore; } set { behaviorScore = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        //public Hero HeroPicked { get { return heroPicked; } set { heroPicked = value; } }
        public int HeroPicked { get { return heroPicked; } set { heroPicked = value; } }
        //public MyGenericArray<Item> Items { get { return items; } set { items = value; } }
        public int[] Items { get { return items; } set { items = value; } }
        public void ShowInfo()
        {
            Console.WriteLine($"Player: {Name} | BehaviorScore: {BehaviorScore} | Gold: {Gold} | Hero: {HeroPicked} | Items: {ShowItemsPlayer()}");
        }
        public string ShowItemsPlayer()
        {
            string tmp = "Items: ";
            for (int c = 0; c < 9; c++)
            {
                tmp += $"|{Items[c]}";
            }
            return tmp;
        }
    }
}
