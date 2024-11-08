namespace Buxfer.Client.Transactions
{
    public class InvestmentBuyTransaction : Transaction
    {
        public InvestmentBuyTransaction()
        {
            Type = TransactionType.InvestmentBuy;
        }
    }
}