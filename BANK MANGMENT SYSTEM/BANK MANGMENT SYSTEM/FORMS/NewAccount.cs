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
            throw new NotImplementedException();
        }
        private void loadaccount()
        {
            BSE = new Bank_Mangment_SystemEntities1();
            

        }

        private void loaddate()
        {
            throw new NotImplementedException();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
