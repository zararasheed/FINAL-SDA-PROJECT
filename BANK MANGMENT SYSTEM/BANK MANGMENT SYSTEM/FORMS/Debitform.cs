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
    public partial class Debitform : Form
    {
        public Debitform()
        {
            InitializeComponent();
            loadcombo();
            loaddate();

        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelabel.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        private void loadcombo()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 dbe = new Bank_Mangment_SystemEntities1();
            NewAccount nacc = new NewAccount();
            debit dp = new debit();
            dp.Date = datelabel.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dbe.debits.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);

            var item = (from u in dbe.userAccounts where u.Account_No == b select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(amounttxt.Text);
            dbe.SaveChanges();
            MessageBox.Show("Debit Money");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 dbe = new Bank_Mangment_SystemEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.balance);


        }
    }
}
