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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 dbe = new Bank_Mangment_SystemEntities1();
            if (oldpasswordtxt.Text != string.Empty || newpasswordtxt.Text !=string.Empty || retypepasswordtxt.Text != string.Empty)
             
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usertxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(oldpasswordtxt.Text))
                    {
                        user1.Password = newpasswordtxt.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Password Changed Successfully!");
                    }
                    else
                    {

                        MessageBox.Show("Password Incorrect");
                    }
                }



            }
        }
    }
}
