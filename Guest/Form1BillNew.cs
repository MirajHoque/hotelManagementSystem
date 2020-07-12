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
    public partial class Form1BillNew : Form
    {
        public Form1BillNew()
        {
            InitializeComponent();
        }

        private void Form1BillNew_Load(object sender, EventArgs e)
        {
            lblRoomType.Text = Guest.FormGuestInfo.roomType;
            lblRoomFare.Text = Guest.FormGuestInfo.roomFare;

            lblHotelServices.Text = Guest.FormGuestInfo.hotelServices;
            lblsqtyd.Text = Guest.FormGuestInfo.serviceQty;
            lblPerserviceCost.Text = Guest.FormGuestInfo.hotelserviceCost;
            lblHotelCost.Text = Guest.FormGuestInfo.totalServiceCost;

            lblFoodItem.Text = Guest.FormGuestInfo.item;
            lblFoodPrice.Text = Guest.FormGuestInfo.price;
            lblFoodQuantity.Text = Guest.FormGuestInfo.qty;
            lblFoodCost.Text = Guest.FormGuestInfo.result;

            lblStotal.Text = Guest.FormGuestInfo.subTotal;
            lblVat.Text = Guest.FormGuestInfo.vat;

        }

        private void btnNetPayable_Click(object sender, EventArgs e)
        {
            double s = double.Parse(lblStotal.Text);
            double v = double.Parse(lblVat.Text);
            double dis = double.Parse(txtDiscount.Text);

          double   totalAmountToPay = (s + v) - dis;
            totalAmountToPay = double.Parse(lblNetpayable.Text);



        }
    }
}
