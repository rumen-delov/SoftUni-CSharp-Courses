using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        private NUnitTest.BankAccount account;

        [SetUp]
        public void InitializeBankAccount()
        {
            account = new NUnitTest.BankAccount(1000);
        }

        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            Assert.That(account.Amount, Is.EqualTo(1000), "Wrong amount added to account on initialization");
        }

        [Test]
        public void DepositPositiveAmount()
        {
            account.Deposit(200);

            Assert.That(account.Amount, Is.EqualTo(1200));
        }

        [Test]
        public void DepositNegativeAmount()
        {            
            Assert.That(() => account.Deposit(-65), 
                Throws.InvalidOperationException.With.Message
                .EqualTo("Deposit amount must be more than 0"));
        }
    }
}
