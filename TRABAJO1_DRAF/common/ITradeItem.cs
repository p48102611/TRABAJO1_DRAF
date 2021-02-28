namespace TRABAJO1_DRAF.common
{
    public interface ITradeItem
    {
        public void BuyItem(int idPlayer, int idItem);
        public void SellItem(int idPlayer, int idItem);
    }
}