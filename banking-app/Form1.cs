using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking;

namespace Banking_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BankAccount MyAccount = new BankAccount();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AuthBtn_click(object sender, EventArgs e) // authbtn
        {
            if (this.Authenticate())
            {
                this.LoansBtn.Visible = true;
                this.SavingsBtn.Visible = true;
                this.CheckingBtn.Visible = true;
            }
            
        }

        private bool Authenticate()
        {
            return true;
        }

        private void LoadCheckingView()
        {
            ID.Text = MyAccount.CheckingAccounts[0].Id.ToString();
            BalanceAmount.Text = "$" + MyAccount.CheckingAccounts[0].Balance.ToString();
            CheckTransList.Items.Clear();
            var trans = MyAccount.CheckingAccounts[0].History;
            foreach(var swype in trans)
            {
                var row = new string[] { swype.payee, swype.amount.ToString(), swype.date.ToString("MM/dd/yyyy") };
                var lvi = new ListViewItem(row);
                CheckTransList.Items.Add(lvi);
            }
            SavingsViewPanel.Visible = false;
            LoanViewPanel.Visible = false;
            CheckingViewPanel.Visible = true;
        }

        private void LoadSavingsView()
        {
            var account = MyAccount.SavingsAccounts[0];
            SavingsID.Text = account.Id.ToString();
            SavingsBalance.Text = "$" + account.Balance.ToString();
            SavingsYTDGain.Text = "$" + account.InterestGained.ToString();
            SavingsInterest.Text = account.InterestRate.ToString() + "%";

            SavingsHistory.Items.Clear();
            foreach (var transaction in account.History)
            {
                var row = new string[] { transaction.payee, transaction.amount.ToString(), transaction.date.ToString("mm/dd/yyy") };
                var lvi = new ListViewItem(row);
                SavingsHistory.Items.Add(lvi);
            }
            CheckingViewPanel.Visible = false;
            LoanViewPanel.Visible = false;
            SavingsViewPanel.Visible = true;
        }

        private void LoadLoanView()
        {
            var acount = MyAccount.Loans[0];
            LoanID.Text = acount.Id.ToString();
            LoanTotalBalance.Text = "$" + acount.TotalBalance.ToString();
            LoanCurrentBalance.Text = "$" + acount.CurrentBalance.ToString();
            LoanInterestGained.Text = "$" + (acount.TotalBalance * acount.InterestRate).ToString();
            LoanInterestRate.Text = acount.InterestRate.ToString() + "%";

            LoanHistory.Items.Clear();

            foreach (var transaction in acount.history)
            {
                var row = new string[] { transaction.date.ToString("mm/dd/yyy"), transaction.Amount.ToString(), transaction.ToCapital.ToString(), transaction.ToInterest.ToString() };
                var lvi = new ListViewItem(row);
                LoanHistory.Items.Add(lvi);
            }

            CheckingViewPanel.Visible = false;
            SavingsViewPanel.Visible = false;
            LoanViewPanel.Visible = true;

        }

        private void CheckingBtn_Click(object sender, EventArgs e)
        {
            LoadCheckingView();
        }

        private void SavingsBtn_Click(object sender, EventArgs e)
        {
            LoadSavingsView();
        }

        private void LoansBtn_Click(object sender, EventArgs e)
        {
            LoadLoanView();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            MyAccount.Transfer();
            LoadCheckingView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyAccount.undoTransfer();
            LoadCheckingView();
        }
    }
}
