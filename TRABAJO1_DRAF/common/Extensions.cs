using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public static class Extensions
    {
        public static Action<List<Hero>, int> BanHero1 = (list, id) =>
        {
            var h = list.SingleOrDefault(e => e.Id == id);
            h.ChangeState();
            Console.WriteLine(h.State);
        };
        public static void BanHeroExt(this IBanned b, List<Hero> list, int i) 
        {
            BanHero1(list,i);
        }
    }
}
