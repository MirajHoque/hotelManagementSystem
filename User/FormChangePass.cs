using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM.User
{
    public partial class FormChangePass : Form
    {
       
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Change the Password?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Connection con = new Connection();
                con.DataGet("Select 1 from DBUser where UserName ='" + txtCPUserName.Text + "' and Password = '"+txtOldPass.Text+"'");
                DataTable DT = new DataTable();
                con.sda.Fill(DT);
                if(DT.Rows.Count>0)
                {
                    if(txtNewPass.Text == txtConfirmPss.Text)
                    {
                        if (txtNewPass.Text.Length>3)
                        {
                            con.DataSend("UPDATE DBUser SET Password ='" +txtNewPass.Text + "' where UserName='" + txtCPUserName.Text + "' and Password ='"+txtOldPass.Text+"' ");
                            MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            errorProviderChangePass.SetError(txtNewPass,"Minimum 4 Characte Required.");
                        }

                    }
                    else
                    {
                        errorProviderChangePass.SetError(txtNewPass, "Password Doesn't Match");
                        errorProviderChangePass.SetError(txtConfirmPss, "Password Doesn't Match");
                    }

                }
                else
                {
                    errorProviderChangePass.SetError(txtCPUserName, "please Check User Name.");
                    errorProviderChangePass.SetError(txtOldPass, "please Check Password.");
                }
            }
        }
    }
}
