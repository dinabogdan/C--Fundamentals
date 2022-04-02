using System;

namespace MethodsAndFunctions
{
    class FinancialTransaction
    {
        public string Id { get; set; }
        public float Amount { get; set; }
        public string PayerAccount { get; set; }
        public string PayeeAccount { get; set; }
    }

    class FinancialTransactionProcessor
    {
        void ProcessTransaction(FinancialTransaction tx)
        {
            RejectIfTrue(string.IsNullOrEmpty(tx.Id), "Transaction id is null or empty");
            RejectIfTrue(tx.Amount <= 0, "Transaction amount is negative or equal to zero");
            RejectIfTrue(string.IsNullOrEmpty(tx.PayerAccount), "Transaction payer account is null or empty");
            RejectIfTrue(string.IsNullOrEmpty(tx.PayeeAccount), "Transaction payee account is null or empty");

            // above code vs. following one

            // if (string.IsNullOrEmpty(tx.Id))
            //     throw new ArgumentException("Transaction id is null or empty");
            //
            // if (tx.Amount <= 0)
            //     throw new ArgumentException("Transaction amount is negative or equal to zero");
            //
            // if (string.IsNullOrEmpty(tx.PayerAccount))
            //     throw new ArgumentException("Transaction payer account is null or empty");
            //
            // if (string.IsNullOrEmpty(tx.PayeeAccount))
            //     throw new ArgumentException("Transaction payee account is null or empty");

            // more complex validation logic
            // ...

            // local method
            static void RejectIfTrue(bool condition, string message)
            {
                if(condition)
                    throw new ArgumentException(message);
            }
        }
    }
}
