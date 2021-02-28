using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public class Execute<T> where T : IExcute
    {
        //IBanned ban = new Banned();
        public void ExeBanHero<T>(int i) where T : IBanned
        {
            Banned a;
           
        }
        

        //public Action<int,int> ExeSellItem = (idPlayer, idItem) =>
        //{
        //    var P = ItemsList.SingleOrDefault(e => e.Id == idPlayer);
        //    //Console.WriteLine(h.State);            
        //};
        //public void 
        
    }
}