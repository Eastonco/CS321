using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Savings : Checking
    {
        public Savings(int id, double interestRate, double minimum) : base(id)
        {
            this.InterestRate = interestRate;
            this.InterestGained = 0;
            this.minimumBalance = minimum;
            this._balance = minimum;
            this.History.Add(new Transaction(minimum, "Minimum Deposit", DateTime.Now));

            StartInterest();
        }

        public double InterestRate;
        public double InterestGained;

        private void InterestAchieved()
        {
            double amount = this.Balance * this.InterestRate;
            amount = Math.Round(amount, 2);
            this.InterestGained += amount;

            Transaction interestPayment = new Transaction(amount, "Interest Payment", DateTime.Now);
            this._balance += amount;
            this.History.Add(interestPayment);
        }

        private void StartInterest()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(3); // time between payments

            var timer = new System.Threading.Timer((e) =>
            {
                InterestAchieved();
            }, null, startTimeSpan, periodTimeSpan);
        }
    }
}
