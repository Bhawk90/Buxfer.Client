using System;

namespace Buxfer.Client
{
    public static class TransactionTypeExtensions
    {
        public static string ToApiString(this TransactionType type)
        {
            switch (type)
            {
                case TransactionType.Expense: return "expense";
                case TransactionType.Income: return "income";
                case TransactionType.Transfer: return "transfer";
                case TransactionType.Refund: return "refund";
                case TransactionType.PaidForFriend: return "paidForFriend";
                case TransactionType.SharedBill: return "sharedBill";
                case TransactionType.Loan: return "loan";
                case TransactionType.Settlement: return "settlement";
                case TransactionType.Payment: return "payment";
                case TransactionType.InvestmentBuy: return "investment_buy";
                case TransactionType.InvestmentSell: return "investment_sell";
                case TransactionType.InvestmentDividend: return "investment_dividend";
                case TransactionType.CapitalGain: return "capital_gain";
                case TransactionType.CapitalLoss: return "capital_loss";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Cannot determine transaction type");
            }
        }
    }
}