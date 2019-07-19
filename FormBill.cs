using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM.Guest
{
    public partial class FormBill : Form
    {

        Connection con = new Connection();
        public FormBill()
        {
            InitializeComponent();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedIndex ==0)
            {
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length !=0)
            {
                if(comboBoxSearch.SelectedIndex ==1)
                {
                   

                }

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
