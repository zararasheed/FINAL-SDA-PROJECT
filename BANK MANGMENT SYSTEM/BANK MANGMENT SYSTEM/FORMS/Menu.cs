using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_MANGMENT_SYSTEM.FORMS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdationForm upf = new UpdationForm();
            upf.MdiParent = this;
            upf.Show();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAccount newacc = new NewAccount();
            newacc.MdiParent = this;
            newacc.Show();

        }

        private void allStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList newacc = new CustomerList();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditForm cff = new CreditForm();
            cff.MdiParent = this;
            cff.Show();

        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm df = new DepositForm();
            df.MdiParent=this;
            df.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm tf = new TransferForm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceSheet bs = new balanceSheet();
            bs.MdiParent = this;
            bs.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFD vfd = new ViewFD();
            vfd.MdiParent = this;
            vfd.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDForm fd = new FDForm();
            fd.MdiParent = this;
            fd.Show();
        }
    }
}
