using System;

namespace NUnitTest
{
    public class BankAccount
    {
        private decimal amount;

        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount
        {
            get => this.amount;

            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Amount cannot be negative");
                }

                this.amount = value;
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount <= 0)
            {
                throw new InvalidOperationException("Deposit amount must be more than 0");
            }

            this.Amount += depositAmount;
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= 0)
            {
                throw new InvalidOperationException("Withdraw amount must be more than 0");
            }

            this.Amount -= withdrawAmount;
        }
    }
}
