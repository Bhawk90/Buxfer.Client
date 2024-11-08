namespace Buxfer.Client
{
    /// <summary>
    ///     Transaction types.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        ///     An expense.
        /// </summary>
        Expense,

        /// <summary>
        ///     An income.
        /// </summary>
        Income,

        /// <summary>
        ///     A transfer.
        /// </summary>
        Transfer,

        /// <summary>
        ///     A refund.
        /// </summary>
        Refund,

        /// <summary>
        ///     A paid for friend.
        /// </summary>
        PaidForFriend,

        /// <summary>
        ///     A shared bill.
        /// </summary>
        SharedBill,

        /// <summary>
        ///     A loan.
        /// </summary>
        Loan,

        /// <summary>
        ///     A settlement.
        /// </summary>
        Settlement,
        
        /// <summary>
        /// A payment.
        /// </summary>
        Payment,
        
        /// <summary>
        /// An investment buy.
        /// </summary>
        InvestmentBuy,
        
        /// <summary>
        /// An investment sell.
        /// </summary>
        InvestmentSell,
        
        /// <summary>
        /// An investment dividend.
        /// </summary>
        InvestmentDividend,
        
        /// <summary>
        /// A capital gain.
        /// </summary>
        CapitalGain,
        
        /// <summary>
        /// A capital loss.
        /// </summary>
        CapitalLoss
    }
}