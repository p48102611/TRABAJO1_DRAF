using System.Collections.Generic;

namespace TRABAJO1_DRAF.common
{
    public interface IBuyItem
    {
        public void BuyItemMethod(List<Player> listP, List<Item> listI, int idPlayer, int idItem, int posI);
    }
}