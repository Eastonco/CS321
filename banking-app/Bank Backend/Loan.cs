using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Loan
    {
        public Loan(int loanId, double initialAmount, double interestRate, int monthCount)
        {
            this.Id = loanId;
            this.InterestRate = interestRate;
            this.TotalBalance = initialAmount;
            this._currentBalance = this.TotalBalance;
            this.LoanLengthInMonths = monthCount;
            this.history = new List<LoanPayment>();
        }

        public double TotalBalance { get; }
        private double _currentBalance;
        public double CurrentBalance
        {
            get
            {
                return this._currentBalance;
            }
        }
        public double InterestRate { get; }
        public int Id { get; }
        public int LoanLengthInMonths { get; }

        public List<LoanPayment> history { get; }

        public class LoanPayment
        {
            public LoanPayment(double amount, double interestRate)
            {
                this.Amount = amount;
                this.ToInterest = this.Amount * interestRate;
                this.ToCapital = this.Amount - this.ToInterest;

                this.Amount = -Amount;
                this.ToInterest = -ToInterest;
                this.ToCapital = -ToCapital;
                this.date = DateTime.Now;
            }

            public double Amount { get; }
            public double ToCapital { get; }
            public double ToInterest { get; }
            public DateTime date { get; }

        }

        public void AddPayment(double amount)
        {
            this.history.Add(new LoanPayment(amount, this.InterestRate));
            this._currentBalance -= amount;
        }

    }
}
