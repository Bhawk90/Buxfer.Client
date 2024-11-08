namespace Buxfer.Client.Transactions
{
    public class PaymentTransaction : Transaction
    {
        public PaymentTransaction()
        {
            Type = TransactionType.Payment;
        }
    }
}