using System;
using Banking;
using NUnit.Framework;

namespace BankingTests
{
    [TestFixture]
    public class BankingTests
    {
        [Test]
        public void OpenNewAccounts()
        {
            BankAccount account = new BankAccount();
            account.OpenNewChecking();
            account.OpenNewSavings();
            account.OpenNewLoan();
            Assert.AreEqual(2, account.CheckingAccounts.Count);
            Assert.AreEqual(2, account.Loans.Count);
            Assert.AreEqual(2, account.SavingsAccounts.Count);
        }

        [Test]
        public void Transfer()
        {
            BankAccount account = new BankAccount();
            var size = account.CheckingAccounts[0].History.Count;
            account.Transfer();
            Assert.AreEqual(size + 1, account.CheckingAccounts[0].History.Count);
        }

        [Test]
        public void undoTransfer()
        {
            BankAccount account = new BankAccount();
            var size = account.CheckingAccounts[0].History.Count;
            account.Transfer();
            account.undoTransfer();
            Assert.AreEqual(size + 2, account.CheckingAccounts[0].History.Count);

        }
    }
}
