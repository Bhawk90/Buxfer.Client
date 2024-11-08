namespace Buxfer.Client.Transactions
{
    public class InvestmentDividendTransaction : Transaction
    {
        public InvestmentDividendTransaction()
        {
            Type = TransactionType.InvestmentDividend;
        }
    }
}