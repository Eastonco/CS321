using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Transaction
    {
        public Transaction(double amount, string payee, DateTime date)
        {
            this.amount = amount;
            this.payee = payee;
            this.date = date;
        }

        public double amount { get; set; }
        public string payee { get; set; }
        public DateTime date { get; set; }
    }
}
