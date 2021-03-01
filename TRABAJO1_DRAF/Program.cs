using System;
using System.Collections.Generic;
using System.Text;
using TRABAJO1_DRAF.common;

namespace TRABAJO1_DRAF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var e = new Execute();
            e.ExeBanHero<Banned>(1);
            e.ExeBanHeroExt<Banned>(2);
            e.ExeBanHeroExt<Banned>(3);
            e.ExeBuyItem<BuyItem>(1, 9, 4);
            //e.ExePrintPlayers();
            e.ExePrintAll();
        }
    }
}
