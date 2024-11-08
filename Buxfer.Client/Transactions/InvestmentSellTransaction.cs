namespace Buxfer.Client.Transactions
{
    public class InvestmentSellTransaction : Transaction
    {
        public InvestmentSellTransaction()
        {
            Type = TransactionType.InvestmentSell;
        }
    }
}