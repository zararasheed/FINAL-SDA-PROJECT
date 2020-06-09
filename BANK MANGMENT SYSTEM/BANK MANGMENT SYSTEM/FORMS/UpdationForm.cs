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
    public partial class UpdationForm : Form
    {
        Bank_Mangment_SystemEntities1 dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;


        public UpdationForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Bank_Mangment_SystemEntities1();
            decimal accno = Convert.ToDecimal(accnotext.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Bank_Mangment_SystemEntities1();
            var item = dbe.userAccounts.Where(a => a.Name== nametext.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new Bank_Mangment_SystemEntities1();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            accnotext.Text = item.Account_No.ToString();
            nametext.Text = item.Name;
            mothertext.Text = item.Mother_Name;
            fathertext.Text = item.Father_Name;
            phonetextbox.Text = item.PhoneNo;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            districttext.Text = item.District;
            statetext.Text = item.State;

            if (item.Gender=="Male")
            {
                maleradio.Checked = true;
            }
            if (item.Gender == "Female")
            {
                femaleradio.Checked = true;
            }
            if (item.Gender == "Other")
            {
                otherradio.Checked = true;
            }
            if (item.martial_status_ == "Married")
            {
                marriedradio.Checked = true;
            }

            if (item.martial_status_ == "UnMarried")
            {
                unmarriedradio.Checked = true;
            }
            if (item.Gender == "Male")
            {
                maleradio.Checked = true;
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfdg = new OpenFileDialog();

            if (openfdg.ShowDialog() ==DialogResult.OK)
            {
                Image img = Image.FromFile(openfdg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms,img.RawFormat);
                
            }









        }

        private void button4_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new Bank_Mangment_SystemEntities1();
            decimal a = Convert.ToDecimal(accnotext.Text);
            userAccount acc = dbe.userAccounts.First(s=>s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
            
        }
    }
}
