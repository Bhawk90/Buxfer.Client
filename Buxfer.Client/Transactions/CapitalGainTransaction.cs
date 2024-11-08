namespace Buxfer.Client.Transactions
{
    public class CapitalGainTransaction : Transaction
    {
        public CapitalGainTransaction()
        {
            Type = TransactionType.CapitalGain;
        }
    }
}