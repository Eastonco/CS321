using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Checking
    {
        public Checking(int id)
        {
            this.Id = id;
            this._balance = 0;
            this.minimumBalance = 0;
            this.History = new List<Transaction>();
        }

        public int Id { get; }
        public double _balance;
        public double Balance
        {
            get { return this._balance; }
        }
        public double minimumBalance { get; set; }

        public List<Transaction> History { get; }

        public void AddTransaction(Transaction transaction)
        {
            if(transaction.amount < 0)
            {
                if(this.Balance + transaction.amount < this.minimumBalance)
                {
                    throw new Exception("Balance less than Minimum");
                }
                
            }
            this.History.Add(transaction);
            this._balance += transaction.amount;

        }

    }
}
