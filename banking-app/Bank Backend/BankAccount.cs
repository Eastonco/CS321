using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankAccount
    {
        public BankAccount()
        {
            OpenNewSavings();
            DemoChecking();
            DemoLoan();
        }

        public string UserName { get; }
        private int NextID = 0000001;
        public List<Checking> CheckingAccounts = new List<Checking>();
        public List<Savings> SavingsAccounts = new List<Savings>();
        public List<Loan> Loans = new List<Loan>();
        private int undoCount = 0;

        public void OpenNewChecking()
        {
            this.CheckingAccounts.Add(new Checking(this.NextID));
            this.NextID += 1;
        }

        public void OpenNewSavings()
        {
            this.SavingsAccounts.Add(new Savings(this.NextID, .01, 25));
            this.NextID += 1;
        }

        public void OpenNewLoan()
        {
            this.Loans.Add(new Loan(this.NextID, 100, .05, 24));
            this.NextID += 1;
        }

        private void DemoLoan()
        {
            OpenNewLoan();
            this.Loans[0].AddPayment(32.22);
            this.Loans[0].AddPayment(23.22);
            this.Loans[0].AddPayment(15.22);
        }

        private void DemoChecking()
        {
            OpenNewChecking();
            this.CheckingAccounts[0].AddTransaction(new Transaction(32.4, "Deposit", DateTime.Now));
            this.CheckingAccounts[0].AddTransaction(new Transaction(543.4, "Something", DateTime.Now.AddDays(1)));
            this.CheckingAccounts[0].AddTransaction(new Transaction(36.4, "More Money", DateTime.Now.AddDays(1)));

        }

        public void Transfer()
        {
            if(this.CheckingAccounts[0].Balance - 5 > 0)
            {
                this.undoCount++;
                this.CheckingAccounts[0].AddTransaction(new Transaction(-5, "Transfer to savings", DateTime.Now));
                this.SavingsAccounts[0].AddTransaction(new Transaction(5, "Transfer from checking", DateTime.Now));
            }
        }

        public void undoTransfer()
        {
            if(this.undoCount > 0)
            {
                this.undoCount--;
                this.CheckingAccounts[0].AddTransaction(new Transaction(5, "Undo Transfer to savings", DateTime.Now));
                this.SavingsAccounts[0].AddTransaction(new Transaction(-5, "Undo Transfer from checking", DateTime.Now));
            }
        }
    }
}
