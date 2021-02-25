using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    class Banned : IBannable
    {
        public void BanHero(List<Hero> list, int id)
        {
            var h = list.SingleOrDefault(e => e.Id == id);
            h.ChangeState();
            //Console.WriteLine(h.State);
        }

        public Action<List<Hero>, int> BanHero1 = (list, id) =>
        {
            var h = list.SingleOrDefault(e => e.Id == id);
            h.ChangeState();
            Console.WriteLine(h.State);
        };
    }
}
