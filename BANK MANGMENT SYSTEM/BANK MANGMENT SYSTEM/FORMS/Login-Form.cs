﻿using System;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank_Mangment_SystemEntities1 dbe = new Bank_Mangment_SystemEntities1();
            if (usertextBox.Text!= String.Empty || passwordtextBox.Text!= String.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usertextBox.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passwordtextBox.Text))
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Null values")
                }
            }
            else
            {
                MessageBox.Show("Please enter username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }
    }
}
