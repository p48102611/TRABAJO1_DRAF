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

            //banear 5 heroes
            //var Run = new Execute();
            //ban.BanHero(Hlist,1);
            //game.BanHero(Hlist, 1);
            //game.BanHero1(Hlist, 1);
            //elegir heroes
            //IExcute e = new Execute<Execute>();
            var e = new Execute<IExcute>();
            e.ExeBanHero<Banned>(1);
            e.ExeBanHeroExt<Banned>(2);
            e.ExeBanHeroExt<Banned>(3);
            //e.ExeBanHero();

        }
        public class MyGenericArray<T> where T : new()
        {
            private T[] array;
            public MyGenericArray(int size)
            {
                array = new T[size];
            }
            public T getItem(int index) { return array[index]; }
            public void setItem(int index, T value) { array[index] = value; }
            public void delItem(int index) { array[index] = new T(); }
        }
    }
}
