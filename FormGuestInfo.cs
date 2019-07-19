using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HM.Guest
{
    public partial class FormGuestInfo : Form
    {
        Connection con = new Connection();
        public FormGuestInfo()
        {
            InitializeComponent();
        }

        private void FormGuestInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearData()
        {
            txtFoodPrice.Clear();
            txtFoodQuantity.Clear();
            txtGAddress.Clear();
            txtGContact.Clear();
            txtGEmail.Clear();
            txtGID.Clear();
            txtGName.Clear();
            txtGPassport.Clear();
            txtRoomFare.Clear();
            txtServiceCost.Clear();
            txtServiceQuantity.Clear();
            dateGBirth.Value = DateTime.Now;
            dateGEntry.Value = DateTime.Now;
            dateGLeave.Value = DateTime.Now;
            comboBoxFoodMenu.SelectedIndex = -1;
            comboBoxHotelService.SelectedIndex = -1;
            comboBoxRoomNumber.SelectedIndex = -1;
            comboBoxRoomType.SelectedIndex = -1;
        }

        public bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtGName.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGName, "Name Required.");
            }
            else if (string.IsNullOrEmpty(txtGContact.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGContact, "Contact Required.");
            }
            else if (string.IsNullOrEmpty(txtGPassport.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGPassport, "Email Required.");
            }
            else if (string.IsNullOrEmpty(dateGBirth.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(dateGBirth, "Date of Birth Required.");
            }
            else if (comboBoxRoomType.SelectedIndex == -1)
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(comboBoxRoomType, "Room Required.");
            }
            else if (comboBoxRoomNumber.SelectedIndex == -1)
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(comboBoxRoomNumber, "Room Number Needed");
            }
            else if (string.IsNullOrEmpty(txtRoomFare.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtRoomFare, "Room Fare Need.");
            }
            else if (string.IsNullOrEmpty(dateGEntry.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(dateGEntry, "Entry Date Needed.");
            }
            else if (string.IsNullOrEmpty(dateGLeave.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(dateGLeave, "Departure Date Needed.");
            }
            else
            {
                errorProviderGuest.Clear();
                result = true;
            }
            return result;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                con.DataSend("INSERT INTO DBGuest (gstName, gstContact, gstEmail, gstPass,gstType, gstAddress, gstDOB, RoomType, RoomNum, RoomFare, entryDate, leaveDate, FoodMenu, FoodPrice, FoodNum, HotelService, ServiceNum, ServiceCost) VALUES('" + txtGName.Text + "','" + txtGContact.Text + "','" + txtGEmail.Text + "','" + txtGPassport.Text + "','" + comboBoxGType.Text + "','" + txtGAddress.Text + "','" + dateGBirth.Value.ToString("dd/MM/yyyy") + "','" + comboBoxRoomType.Text + "','" + comboBoxRoomNumber.Text + "','" + txtRoomFare.Text + "','" + dateGEntry.Value.ToString("dd/MM/yyyy") + "','" + dateGLeave.Value.ToString("dd/MM/yyyy") + "','" + comboBoxFoodMenu.Text + "','" + txtFoodPrice.Text + "','" + txtFoodQuantity.Text + "','" + comboBoxHotelService.Text + "','" + txtServiceQuantity.Text + "','" + txtServiceCost.Text + "')");
                MessageBox.Show("Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearData();
                LoadData();
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBGuest");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewGuest.Rows.Clear();

            foreach (DataRow DR in DT.Rows)
            {
                int n = dataGridViewGuest.Rows.Add();
                dataGridViewGuest.Rows[n].Cells["dgGID"].Value = DR["GID"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgName"].Value = DR["gstName"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgContact"].Value = DR["gstContact"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgAddress"].Value = DR["gstAddress"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgEmail"].Value = DR["gstEmail"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgDOB"].Value = DR["gstDOB"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgPassport"].Value = DR["gstPass"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgGType"].Value = DR["gstType"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgRoomType"].Value = DR["RoomType"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgRoomNum"].Value = DR["RoomNum"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgRoomFare"].Value = DR["RoomFare"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgEntry"].Value = DR["entryDate"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgLeave"].Value = DR["leaveDate"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgFoodMenu"].Value = DR["FoodMenu"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgFoodQuantity"].Value = DR["Foodnum"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgFoodPrice"].Value = DR["FoodPrice"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgHotelService"].Value = DR["HotelService"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgServiceQuantity"].Value = DR["ServiceNum"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgServicePrice"].Value = DR["ServiceCost"].ToString();
            }
        }

        private void txtRoomFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtFoodQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtFoodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtServiceQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtServiceCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridViewGuest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGID.Text = dataGridViewGuest.SelectedRows[0].Cells["dgGID"].Value.ToString();
            txtGName.Text = dataGridViewGuest.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtGContact.Text = dataGridViewGuest.SelectedRows[0].Cells["dgContact"].Value.ToString();
            txtGEmail.Text = dataGridViewGuest.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtGPassport.Text = dataGridViewGuest.SelectedRows[0].Cells["dgPassport"].Value.ToString();
            dateGBirth.Text = dataGridViewGuest.SelectedRows[0].Cells["dgDOB"].Value.ToString();
            txtGAddress.Text = dataGridViewGuest.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            comboBoxRoomType.Text = dataGridViewGuest.SelectedRows[0].Cells["dgRoomType"].Value.ToString();
            comboBoxRoomNumber.Text = dataGridViewGuest.SelectedRows[0].Cells["dgRoomNum"].Value.ToString();
            txtRoomFare.Text = dataGridViewGuest.SelectedRows[0].Cells["dgRoomFare"].Value.ToString();
            dateGEntry.Text = dataGridViewGuest.SelectedRows[0].Cells["dgEntry"].Value.ToString();
            dateGLeave.Text = dataGridViewGuest.SelectedRows[0].Cells["dgLeave"].Value.ToString();
            comboBoxFoodMenu.Text = dataGridViewGuest.SelectedRows[0].Cells["dgFoodMenu"].Value.ToString();
            txtFoodPrice.Text = dataGridViewGuest.SelectedRows[0].Cells["dgFoodPrice"].Value.ToString();
            txtFoodQuantity.Text = dataGridViewGuest.SelectedRows[0].Cells["dgFoodQuantity"].Value.ToString();
            comboBoxHotelService.Text = dataGridViewGuest.SelectedRows[0].Cells["dgHotelService"].Value.ToString();
            txtServiceQuantity.Text = dataGridViewGuest.SelectedRows[0].Cells["dgServiceQuantity"].Value.ToString();
            txtServiceCost.Text = dataGridViewGuest.SelectedRows[0].Cells["dgServicePrice"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend(@"UPDATE DBGuest SET gstName ='" + txtGName.Text + "', gstContact ='" + txtGContact.Text + "', gstEmail ='" + txtGEmail.Text + "', gstPass ='" + txtGPassport.Text + "',gstType='" + comboBoxGType.Text + "', gstAddress ='" + txtGAddress.Text + "', gstDOB ='" + dateGBirth.Value.ToString("dd/MM/yyyy") + "', RoomType ='" + comboBoxRoomType.Text + "', RoomNum ='" + comboBoxRoomNumber.Text + "', RoomFare ='" + txtRoomFare.Text + "', entryDate ='" + dateGEntry.Value.ToString("dd/MM/yyyy") + "', leaveDate ='" + dateGLeave.Value.ToString("dd/MM/yyyy") + "', FoodMenu ='" + comboBoxFoodMenu.Text + "', FoodPrice ='" + txtFoodPrice.Text + "', FoodNum ='" + txtFoodQuantity.Text + "', HotelService ='" + comboBoxHotelService.Text + "', ServiceNum ='" + txtServiceQuantity.Text + "', ServiceCost ='" + txtServiceCost.Text + "' Where GID ='" + txtGID.Text + "' ");
                MessageBox.Show("Updated Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("Delete from DBGuest Where GID ='" + txtGID.Text + "'");
                MessageBox.Show("Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        public static string result;
        public static string item;
        public static string price;
        public static string qty;
        public static string roomType;
        public static string roomFare;
        public static string roomRent;
        public static string hotelServices;
        public static string serviceQty;
        public static string hotelserviceCost;
        public static string totalServiceCost;
        public static string subTotal;
        public static string vat;




        double payment;
        double servicePayment;
        double totalBills;
       double roomCost;

        private void btnBill_Click(object sender, EventArgs e)
        {
            roomCost = double.Parse(txtRoomFare.Text);
            roomType = comboBoxRoomType.Text;
            roomFare = txtRoomFare.Text;




            double x = double.Parse(txtServiceCost.Text);
            double y = double.Parse(txtServiceQuantity.Text);
            servicePayment = x * y;
            hotelServices = comboBoxHotelService.Text;
            hotelserviceCost = txtServiceCost.Text;
            totalServiceCost = servicePayment.ToString();
            serviceQty = txtServiceQuantity.Text;



            item = comboBoxFoodMenu.Text;
            price = txtFoodPrice.Text;
            qty = txtFoodQuantity.Text;
            double a = double.Parse(txtFoodPrice.Text);
            double b = double.Parse(txtFoodQuantity.Text);
            payment = a * b;
            result = payment.ToString();




            totalBills = payment + servicePayment+roomCost;
            subTotal = totalBills.ToString();
            vat = (totalBills * .15).ToString();
                
           
            Form1BillNew bs = new Form1BillNew();
            bs.Show();
        }


        ///int count = 0;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {





        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch sh = new FormSearch();
            sh.Show();

        }


     /*   public void dispaly()
        {
            count = 0;
            con.DataGet("select * from DBGuest where gstName='" + txtSearch.Text + "'");
            //  da = new SqlDataAdapter(cmd);
            // dt = new DataTable();
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewGuest.DataSource = DT;
            count = Convert.ToInt32(DT.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("data not found");
            }

        } */
    }
}
