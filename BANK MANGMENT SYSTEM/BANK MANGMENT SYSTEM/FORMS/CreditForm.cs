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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
            //throw new NotImplementedException();
        }

        private void loaddate()
        {
            datalbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
            //throw new NotImplementedException();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 context = new Bank_Mangment_SystemEntities1();
            decimal b = Convert.ToDecimal(acctext.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();

            nametext.Text = item.Name;
            oldbaltext.Text = Convert.ToString(item.balance);

        }

        private void detailbutton_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 context = new Bank_Mangment_SystemEntities1();
            NewAccount acc = new NewAccount();
            Deposit dp = new Deposit();
            dp.Date = datalbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctext.Text);
            dp.Name = nametext.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltext.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(amounttext.Text);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctext.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
            item.balance = item.balance + Convert.ToDecimal(amounttext.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Money Succesfully :)");


        }
    }
}
