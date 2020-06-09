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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            bindgrids();
        }

        private void bindgrids()
        {
            dataGridView1.AutoGenerateColumns = false;
            Bank_Mangment_SystemEntities1 bs = new Bank_Mangment_SystemEntities1();
            var item = bs.userAccounts.ToList();
            dataGridView1.DataSource = item;
            //throw new NotImplementedException();
        }
    }
}
