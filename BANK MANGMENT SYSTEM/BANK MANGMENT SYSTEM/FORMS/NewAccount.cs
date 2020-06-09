using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_MANGMENT_SYSTEM.FORMS
{
    public partial class NewAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;

        Bank_Mangment_SystemEntities1 BSE;
        MemoryStream ms;
        
        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();



        }

        private void loadstate()
        {
            comboBox1.Items.Add("ISLAMABAD");
            comboBox1.Items.Add("LAHORE");
            comboBox1.Items.Add("KARACHII");
            comboBox1.Items.Add("QUETTA");
            comboBox1.Items.Add("BALOCHISTAN");


        }
        private void loadaccount()
        {
            BSE = new Bank_Mangment_SystemEntities1();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);
            
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("mm/dd/yyyy");
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maleradioButton.Checked)
            {
                gender = "Male";
            }
            else if (femaleradioButton.Checked)
            {
                gender = "Female";
            }
            else if (otherradioButton.Checked)
            {
                gender = "Other";
            }

            if (marriedradioButton.Checked)
            {
                m_status = "Married";
            }
            else if (unmarriedradioButton.Checked)
            {
                m_status = "UnMarried";
            }
            BSE = new Bank_Mangment_SystemEntities1();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametext.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetext.Text;
            acc.District = distext.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.martial_status_ = m_status;
            acc.Mother_Name = mothertext.Text;
            acc.Father_Name = fathertext.Text;
            acc.balance = Convert.ToDecimal(balancetext.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("FILE SAVED");











        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendilg = new OpenFileDialog();
            if (opendilg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendilg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);



            }

        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
