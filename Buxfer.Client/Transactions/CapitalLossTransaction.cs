namespace Buxfer.Client.Transactions
{
    public class CapitalLossTransaction : Transaction
    {
        public CapitalLossTransaction()
        {
            Type = TransactionType.CapitalLoss;
        }
    }
}