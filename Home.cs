using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void accountingYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountingYear ay=new AccountingYear();
            ay.Show();
            this.Hide();
        }

        private void accountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountHead ah=new AccountHead();
            ah.Show();
            this.Hide();
        }

        private void openingBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpeningBalance op=new OpeningBalance();
            op.Show();
            this.Hide();
        }

        private void tRANSACTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction t=new Transaction();
            t.Show();
            this.Hide();
        }

        private void monthlyStatementAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyStatement m = new MonthlyStatement();
            m.Show();
            this.Hide();
        }

        private void accountHeadWiseStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountHeadWise m = new AccountHeadWise();
            m.Show();
            this.Hide();
        }

        private void receivingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceivingReport m = new ReceivingReport();
            m.Show();
            this.Hide();
        }

        private void withdrawReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrwalReport m = new WithdrwalReport();
            m.Show();
            this.Hide();
        }

        private void currentBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentBalance m = new CurrentBalance();
            m.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();        }
    }
}
