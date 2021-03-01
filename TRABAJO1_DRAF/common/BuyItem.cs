using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    class BuyItem : IBuyItem, IExecute
    {
        public static Action<List<Player>, List<Item>,int, int, int> buyItem = (listP, listI, p, i, pos) =>
        {
            var tmpP = listP.SingleOrDefault(tmp => tmp.Id == p);
            var tmpI = listI.SingleOrDefault(tmp => tmp.Id == i);
            tmpP.Gold -= tmpI.Price;
            tmpP.items[pos] = tmpI.Id;
        };
        public void BuyItemMethod(List<Player> listP, List<Item> listI, int idPlayer, int idItem, int posI)
        {
            buyItem(listP, listI, idPlayer, idItem, posI);
        }
    }
}
