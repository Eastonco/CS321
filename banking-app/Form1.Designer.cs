
namespace Banking_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.LoansBtn = new System.Windows.Forms.Label();
            this.SavingsBtn = new System.Windows.Forms.Label();
            this.CheckingBtn = new System.Windows.Forms.Label();
            this.AuthBtn = new System.Windows.Forms.Label();
            this.CheckingViewPanel = new System.Windows.Forms.Panel();
            this.CheckTransList = new System.Windows.Forms.ListView();
            this.chPayee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = new System.Windows.Forms.Label();
            this.BalanceAmount = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.AccountBalanceLabel = new System.Windows.Forms.Label();
            this.SavingsViewPanel = new System.Windows.Forms.Panel();
            this.SavingsYTDGain = new System.Windows.Forms.Label();
            this.YTDGainLabel = new System.Windows.Forms.Label();
            this.SavingsInterest = new System.Windows.Forms.Label();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.SavingsHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SavingsID = new System.Windows.Forms.Label();
            this.SavingsBalance = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoanViewPanel = new System.Windows.Forms.Panel();
            this.LoanInterestGained = new System.Windows.Forms.Label();
            this.Label0 = new System.Windows.Forms.Label();
            this.LoanInterestRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoanHistory = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoanID = new System.Windows.Forms.Label();
            this.LoanTotalBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LoanCurrentBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransferBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.CheckingViewPanel.SuspendLayout();
            this.SavingsViewPanel.SuspendLayout();
            this.LoanViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Menu.Controls.Add(this.LoansBtn);
            this.Menu.Controls.Add(this.SavingsBtn);
            this.Menu.Controls.Add(this.CheckingBtn);
            this.Menu.Controls.Add(this.AuthBtn);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(288, 744);
            this.Menu.TabIndex = 0;
            // 
            // LoansBtn
            // 
            this.LoansBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoansBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoansBtn.ForeColor = System.Drawing.Color.White;
            this.LoansBtn.Location = new System.Drawing.Point(0, 213);
            this.LoansBtn.Name = "LoansBtn";
            this.LoansBtn.Size = new System.Drawing.Size(288, 71);
            this.LoansBtn.TabIndex = 6;
            this.LoansBtn.Text = "Loans";
            this.LoansBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoansBtn.Visible = false;
            this.LoansBtn.Click += new System.EventHandler(this.LoansBtn_Click);
            // 
            // SavingsBtn
            // 
            this.SavingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SavingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsBtn.ForeColor = System.Drawing.Color.White;
            this.SavingsBtn.Location = new System.Drawing.Point(0, 142);
            this.SavingsBtn.Name = "SavingsBtn";
            this.SavingsBtn.Size = new System.Drawing.Size(288, 71);
            this.SavingsBtn.TabIndex = 5;
            this.SavingsBtn.Text = "Savings";
            this.SavingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SavingsBtn.Visible = false;
            this.SavingsBtn.Click += new System.EventHandler(this.SavingsBtn_Click);
            // 
            // CheckingBtn
            // 
            this.CheckingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingBtn.ForeColor = System.Drawing.Color.White;
            this.CheckingBtn.Location = new System.Drawing.Point(0, 71);
            this.CheckingBtn.Name = "CheckingBtn";
            this.CheckingBtn.Size = new System.Drawing.Size(288, 71);
            this.CheckingBtn.TabIndex = 4;
            this.CheckingBtn.Text = "Checking";
            this.CheckingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckingBtn.Visible = false;
            this.CheckingBtn.Click += new System.EventHandler(this.CheckingBtn_Click);
            // 
            // AuthBtn
            // 
            this.AuthBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthBtn.ForeColor = System.Drawing.Color.White;
            this.AuthBtn.Location = new System.Drawing.Point(0, 0);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(288, 71);
            this.AuthBtn.TabIndex = 0;
            this.AuthBtn.Text = "Authenticate";
            this.AuthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_click);
            // 
            // CheckingViewPanel
            // 
            this.CheckingViewPanel.Controls.Add(this.button1);
            this.CheckingViewPanel.Controls.Add(this.TransferBtn);
            this.CheckingViewPanel.Controls.Add(this.CheckTransList);
            this.CheckingViewPanel.Controls.Add(this.ID);
            this.CheckingViewPanel.Controls.Add(this.BalanceAmount);
            this.CheckingViewPanel.Controls.Add(this.AccountNumberLabel);
            this.CheckingViewPanel.Controls.Add(this.AccountBalanceLabel);
            this.CheckingViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckingViewPanel.Location = new System.Drawing.Point(288, 0);
            this.CheckingViewPanel.Name = "CheckingViewPanel";
            this.CheckingViewPanel.Size = new System.Drawing.Size(1050, 744);
            this.CheckingViewPanel.TabIndex = 1;
            this.CheckingViewPanel.Visible = false;
            // 
            // CheckTransList
            // 
            this.CheckTransList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPayee,
            this.chAmount,
            this.chDate});
            this.CheckTransList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckTransList.FullRowSelect = true;
            this.CheckTransList.GridLines = true;
            this.CheckTransList.HideSelection = false;
            this.CheckTransList.Location = new System.Drawing.Point(0, 280);
            this.CheckTransList.Name = "CheckTransList";
            this.CheckTransList.Size = new System.Drawing.Size(1050, 464);
            this.CheckTransList.TabIndex = 4;
            this.CheckTransList.UseCompatibleStateImageBehavior = false;
            this.CheckTransList.View = System.Windows.Forms.View.Details;
            // 
            // chPayee
            // 
            this.chPayee.Text = "Payee";
            this.chPayee.Width = 320;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Amount";
            this.chAmount.Width = 100;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 100;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(733, 142);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(157, 37);
            this.ID.TabIndex = 3;
            this.ID.Text = "11557902";
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.AutoSize = true;
            this.BalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceAmount.ForeColor = System.Drawing.Color.White;
            this.BalanceAmount.Location = new System.Drawing.Point(127, 142);
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.Size = new System.Drawing.Size(98, 37);
            this.BalanceAmount.TabIndex = 2;
            this.BalanceAmount.Text = "$0.00";
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNumberLabel.Location = new System.Drawing.Point(716, 88);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(174, 37);
            this.AccountNumberLabel.TabIndex = 1;
            this.AccountNumberLabel.Text = "Account ID";
            // 
            // AccountBalanceLabel
            // 
            this.AccountBalanceLabel.AutoSize = true;
            this.AccountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.AccountBalanceLabel.Location = new System.Drawing.Point(127, 88);
            this.AccountBalanceLabel.Name = "AccountBalanceLabel";
            this.AccountBalanceLabel.Size = new System.Drawing.Size(132, 37);
            this.AccountBalanceLabel.TabIndex = 0;
            this.AccountBalanceLabel.Text = "Balance";
            // 
            // SavingsViewPanel
            // 
            this.SavingsViewPanel.Controls.Add(this.SavingsYTDGain);
            this.SavingsViewPanel.Controls.Add(this.YTDGainLabel);
            this.SavingsViewPanel.Controls.Add(this.SavingsInterest);
            this.SavingsViewPanel.Controls.Add(this.InterestLabel);
            this.SavingsViewPanel.Controls.Add(this.SavingsHistory);
            this.SavingsViewPanel.Controls.Add(this.SavingsID);
            this.SavingsViewPanel.Controls.Add(this.SavingsBalance);
            this.SavingsViewPanel.Controls.Add(this.label);
            this.SavingsViewPanel.Controls.Add(this.label4);
            this.SavingsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavingsViewPanel.Location = new System.Drawing.Point(288, 0);
            this.SavingsViewPanel.Name = "SavingsViewPanel";
            this.SavingsViewPanel.Size = new System.Drawing.Size(1050, 744);
            this.SavingsViewPanel.TabIndex = 5;
            this.SavingsViewPanel.Visible = false;
            // 
            // SavingsYTDGain
            // 
            this.SavingsYTDGain.AutoSize = true;
            this.SavingsYTDGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsYTDGain.ForeColor = System.Drawing.Color.White;
            this.SavingsYTDGain.Location = new System.Drawing.Point(595, 142);
            this.SavingsYTDGain.Name = "SavingsYTDGain";
            this.SavingsYTDGain.Size = new System.Drawing.Size(81, 37);
            this.SavingsYTDGain.TabIndex = 13;
            this.SavingsYTDGain.Text = "43%";
            // 
            // YTDGainLabel
            // 
            this.YTDGainLabel.AutoSize = true;
            this.YTDGainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YTDGainLabel.ForeColor = System.Drawing.Color.White;
            this.YTDGainLabel.Location = new System.Drawing.Point(499, 88);
            this.YTDGainLabel.Name = "YTDGainLabel";
            this.YTDGainLabel.Size = new System.Drawing.Size(308, 37);
            this.YTDGainLabel.TabIndex = 12;
            this.YTDGainLabel.Text = "YTD Interest Gained";
            // 
            // SavingsInterest
            // 
            this.SavingsInterest.AutoSize = true;
            this.SavingsInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsInterest.ForeColor = System.Drawing.Color.White;
            this.SavingsInterest.Location = new System.Drawing.Point(311, 142);
            this.SavingsInterest.Name = "SavingsInterest";
            this.SavingsInterest.Size = new System.Drawing.Size(81, 37);
            this.SavingsInterest.TabIndex = 11;
            this.SavingsInterest.Text = "43%";
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestLabel.ForeColor = System.Drawing.Color.White;
            this.InterestLabel.Location = new System.Drawing.Point(265, 88);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(197, 37);
            this.InterestLabel.TabIndex = 10;
            this.InterestLabel.Text = "Interest Rate";
            // 
            // SavingsHistory
            // 
            this.SavingsHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.SavingsHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SavingsHistory.FullRowSelect = true;
            this.SavingsHistory.GridLines = true;
            this.SavingsHistory.HideSelection = false;
            this.SavingsHistory.Location = new System.Drawing.Point(0, 280);
            this.SavingsHistory.Name = "SavingsHistory";
            this.SavingsHistory.Size = new System.Drawing.Size(1050, 464);
            this.SavingsHistory.TabIndex = 9;
            this.SavingsHistory.UseCompatibleStateImageBehavior = false;
            this.SavingsHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Payee";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 100;
            // 
            // SavingsID
            // 
            this.SavingsID.AutoSize = true;
            this.SavingsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsID.ForeColor = System.Drawing.Color.White;
            this.SavingsID.Location = new System.Drawing.Point(844, 142);
            this.SavingsID.Name = "SavingsID";
            this.SavingsID.Size = new System.Drawing.Size(157, 37);
            this.SavingsID.TabIndex = 8;
            this.SavingsID.Text = "11557902";
            // 
            // SavingsBalance
            // 
            this.SavingsBalance.AutoSize = true;
            this.SavingsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsBalance.ForeColor = System.Drawing.Color.White;
            this.SavingsBalance.Location = new System.Drawing.Point(50, 142);
            this.SavingsBalance.Name = "SavingsBalance";
            this.SavingsBalance.Size = new System.Drawing.Size(98, 37);
            this.SavingsBalance.TabIndex = 7;
            this.SavingsBalance.Text = "$0.00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(827, 88);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 37);
            this.label.TabIndex = 6;
            this.label.Text = "Account ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance";
            // 
            // LoanViewPanel
            // 
            this.LoanViewPanel.Controls.Add(this.LoanCurrentBalance);
            this.LoanViewPanel.Controls.Add(this.label9);
            this.LoanViewPanel.Controls.Add(this.LoanInterestGained);
            this.LoanViewPanel.Controls.Add(this.Label0);
            this.LoanViewPanel.Controls.Add(this.LoanInterestRate);
            this.LoanViewPanel.Controls.Add(this.label2);
            this.LoanViewPanel.Controls.Add(this.LoanHistory);
            this.LoanViewPanel.Controls.Add(this.LoanID);
            this.LoanViewPanel.Controls.Add(this.LoanTotalBalance);
            this.LoanViewPanel.Controls.Add(this.label6);
            this.LoanViewPanel.Controls.Add(this.label7);
            this.LoanViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoanViewPanel.Location = new System.Drawing.Point(288, 0);
            this.LoanViewPanel.Name = "LoanViewPanel";
            this.LoanViewPanel.Size = new System.Drawing.Size(1050, 744);
            this.LoanViewPanel.TabIndex = 14;
            this.LoanViewPanel.Visible = false;
            // 
            // LoanInterestGained
            // 
            this.LoanInterestGained.AutoSize = true;
            this.LoanInterestGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanInterestGained.ForeColor = System.Drawing.Color.White;
            this.LoanInterestGained.Location = new System.Drawing.Point(581, 88);
            this.LoanInterestGained.Name = "LoanInterestGained";
            this.LoanInterestGained.Size = new System.Drawing.Size(81, 37);
            this.LoanInterestGained.TabIndex = 20;
            this.LoanInterestGained.Text = "43%";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.ForeColor = System.Drawing.Color.White;
            this.Label0.Location = new System.Drawing.Point(527, 34);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(234, 37);
            this.Label0.TabIndex = 19;
            this.Label0.Text = "Interest Gained";
            // 
            // LoanInterestRate
            // 
            this.LoanInterestRate.AutoSize = true;
            this.LoanInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanInterestRate.ForeColor = System.Drawing.Color.White;
            this.LoanInterestRate.Location = new System.Drawing.Point(311, 88);
            this.LoanInterestRate.Name = "LoanInterestRate";
            this.LoanInterestRate.Size = new System.Drawing.Size(81, 37);
            this.LoanInterestRate.TabIndex = 18;
            this.LoanInterestRate.Text = "43%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interest Rate";
            // 
            // LoanHistory
            // 
            this.LoanHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LoanHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoanHistory.FullRowSelect = true;
            this.LoanHistory.GridLines = true;
            this.LoanHistory.HideSelection = false;
            this.LoanHistory.Location = new System.Drawing.Point(0, 280);
            this.LoanHistory.Name = "LoanHistory";
            this.LoanHistory.Size = new System.Drawing.Size(1050, 464);
            this.LoanHistory.TabIndex = 16;
            this.LoanHistory.UseCompatibleStateImageBehavior = false;
            this.LoanHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "To Capital";
            this.columnHeader6.Width = 100;
            // 
            // LoanID
            // 
            this.LoanID.AutoSize = true;
            this.LoanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanID.ForeColor = System.Drawing.Color.White;
            this.LoanID.Location = new System.Drawing.Point(844, 88);
            this.LoanID.Name = "LoanID";
            this.LoanID.Size = new System.Drawing.Size(157, 37);
            this.LoanID.TabIndex = 15;
            this.LoanID.Text = "11557902";
            // 
            // LoanTotalBalance
            // 
            this.LoanTotalBalance.AutoSize = true;
            this.LoanTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanTotalBalance.ForeColor = System.Drawing.Color.White;
            this.LoanTotalBalance.Location = new System.Drawing.Point(50, 88);
            this.LoanTotalBalance.Name = "LoanTotalBalance";
            this.LoanTotalBalance.Size = new System.Drawing.Size(98, 37);
            this.LoanTotalBalance.TabIndex = 14;
            this.LoanTotalBalance.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(827, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Account ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Balance";
            // 
            // LoanCurrentBalance
            // 
            this.LoanCurrentBalance.AutoSize = true;
            this.LoanCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanCurrentBalance.ForeColor = System.Drawing.Color.White;
            this.LoanCurrentBalance.Location = new System.Drawing.Point(433, 201);
            this.LoanCurrentBalance.Name = "LoanCurrentBalance";
            this.LoanCurrentBalance.Size = new System.Drawing.Size(98, 37);
            this.LoanCurrentBalance.TabIndex = 22;
            this.LoanCurrentBalance.Text = "$0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(179, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "Current Balance";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "To Interest";
            this.columnHeader7.Width = 100;
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(379, 40);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(244, 45);
            this.TransferBtn.TabIndex = 5;
            this.TransferBtn.Text = "Transfer $5 to Savings";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Undo Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1338, 744);
            this.Controls.Add(this.CheckingViewPanel);
            this.Controls.Add(this.LoanViewPanel);
            this.Controls.Add(this.SavingsViewPanel);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.CheckingViewPanel.ResumeLayout(false);
            this.CheckingViewPanel.PerformLayout();
            this.SavingsViewPanel.ResumeLayout(false);
            this.SavingsViewPanel.PerformLayout();
            this.LoanViewPanel.ResumeLayout(false);
            this.LoanViewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label AuthBtn;
        private System.Windows.Forms.Label LoansBtn;
        private System.Windows.Forms.Label SavingsBtn;
        private System.Windows.Forms.Label CheckingBtn;
        private System.Windows.Forms.Panel CheckingViewPanel;
        private System.Windows.Forms.Label AccountBalanceLabel;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.ListView CheckTransList;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label BalanceAmount;
        private System.Windows.Forms.ColumnHeader chPayee;
        private System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Panel SavingsViewPanel;
        private System.Windows.Forms.ListView SavingsHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label SavingsID;
        private System.Windows.Forms.Label SavingsBalance;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.Label SavingsYTDGain;
        private System.Windows.Forms.Label YTDGainLabel;
        private System.Windows.Forms.Label SavingsInterest;
        private System.Windows.Forms.Panel LoanViewPanel;
        private System.Windows.Forms.Label LoanInterestGained;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label LoanInterestRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LoanHistory;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label LoanID;
        private System.Windows.Forms.Label LoanTotalBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LoanCurrentBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Button button1;
    }
}

