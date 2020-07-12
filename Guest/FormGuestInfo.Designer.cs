namespace HM.Guest
{
    partial class FormGuestInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxGType = new System.Windows.Forms.ComboBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateGBirth = new System.Windows.Forms.DateTimePicker();
            this.txtGAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateGLeave = new System.Windows.Forms.DateTimePicker();
            this.dateGEntry = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoomFare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtServiceQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxHotelService = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFoodQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxFoodMenu = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewGuest = new System.Windows.Forms.DataGridView();
            this.dgGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHotelService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServiceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderGuest = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBill = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGuest)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.comboBoxGType);
            this.panel1.Controls.Add(this.txtGID);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dateGBirth);
            this.panel1.Controls.Add(this.txtGAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGPassport);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGContact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 335);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxGType
            // 
            this.comboBoxGType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGType.FormattingEnabled = true;
            this.comboBoxGType.Items.AddRange(new object[] {
            "Passport",
            "NID",
            "Driving License"});
            this.comboBoxGType.Location = new System.Drawing.Point(214, 178);
            this.comboBoxGType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGType.Name = "comboBoxGType";
            this.comboBoxGType.Size = new System.Drawing.Size(79, 21);
            this.comboBoxGType.TabIndex = 16;
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(94, 13);
            this.txtGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGID.Name = "txtGID";
            this.txtGID.ReadOnly = true;
            this.txtGID.Size = new System.Drawing.Size(200, 20);
            this.txtGID.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 17);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Guest ID";
            // 
            // dateGBirth
            // 
            this.dateGBirth.CustomFormat = "dd/MM/yyyy";
            this.dateGBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGBirth.Location = new System.Drawing.Point(94, 214);
            this.dateGBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateGBirth.Name = "dateGBirth";
            this.dateGBirth.Size = new System.Drawing.Size(200, 20);
            this.dateGBirth.TabIndex = 8;
            // 
            // txtGAddress
            // 
            this.txtGAddress.Location = new System.Drawing.Point(94, 254);
            this.txtGAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGAddress.Multiline = true;
            this.txtGAddress.Name = "txtGAddress";
            this.txtGAddress.Size = new System.Drawing.Size(200, 62);
            this.txtGAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Of Birth";
            // 
            // txtGPassport
            // 
            this.txtGPassport.Location = new System.Drawing.Point(94, 178);
            this.txtGPassport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGPassport.Name = "txtGPassport";
            this.txtGPassport.Size = new System.Drawing.Size(117, 20);
            this.txtGPassport.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passport";
            // 
            // txtGEmail
            // 
            this.txtGEmail.Location = new System.Drawing.Point(94, 134);
            this.txtGEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGEmail.Name = "txtGEmail";
            this.txtGEmail.Size = new System.Drawing.Size(200, 20);
            this.txtGEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtGContact
            // 
            this.txtGContact.Location = new System.Drawing.Point(94, 92);
            this.txtGContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGContact.Name = "txtGContact";
            this.txtGContact.Size = new System.Drawing.Size(200, 20);
            this.txtGContact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(94, 51);
            this.txtGName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(200, 20);
            this.txtGName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dateGLeave);
            this.panel2.Controls.Add(this.dateGEntry);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtRoomFare);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBoxRoomNumber);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxRoomType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(346, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 257);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Departure Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Entry Date";
            // 
            // dateGLeave
            // 
            this.dateGLeave.CustomFormat = "dd/MM/yyyy";
            this.dateGLeave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGLeave.Location = new System.Drawing.Point(22, 202);
            this.dateGLeave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateGLeave.Name = "dateGLeave";
            this.dateGLeave.Size = new System.Drawing.Size(171, 20);
            this.dateGLeave.TabIndex = 14;
            // 
            // dateGEntry
            // 
            this.dateGEntry.CustomFormat = "dd/MM/yyyy";
            this.dateGEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGEntry.Location = new System.Drawing.Point(22, 159);
            this.dateGEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateGEntry.Name = "dateGEntry";
            this.dateGEntry.Size = new System.Drawing.Size(171, 20);
            this.dateGEntry.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Room Fare";
            // 
            // txtRoomFare
            // 
            this.txtRoomFare.Location = new System.Drawing.Point(22, 118);
            this.txtRoomFare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoomFare.Name = "txtRoomFare";
            this.txtRoomFare.Size = new System.Drawing.Size(171, 20);
            this.txtRoomFare.TabIndex = 9;
            this.txtRoomFare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomFare_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Room Number";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Items.AddRange(new object[] {
            "1-A",
            "1-B",
            "1-C",
            "1-D",
            "1-E",
            "2-A",
            "2-B",
            "2-C",
            "2-D",
            "2-E",
            "3-A",
            "3-B",
            "3-C",
            "3-D",
            "3-E"});
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(22, 76);
            this.comboBoxRoomNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRoomNumber.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Room Type";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Executive Suite",
            "Mini Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(22, 41);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRoomType.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Room Selection";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtServiceCost);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtServiceQuantity);
            this.panel3.Controls.Add(this.comboBoxHotelService);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtFoodPrice);
            this.panel3.Controls.Add(this.txtFoodQuantity);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.comboBoxFoodMenu);
            this.panel3.Location = new System.Drawing.Point(671, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 257);
            this.panel3.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(328, 136);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Hotel Services";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(328, 175);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Cost";
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(209, 172);
            this.txtServiceCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(103, 20);
            this.txtServiceCost.TabIndex = 22;
            this.txtServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceCost_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 176);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Quantity";
            // 
            // txtServiceQuantity
            // 
            this.txtServiceQuantity.Location = new System.Drawing.Point(16, 172);
            this.txtServiceQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceQuantity.Name = "txtServiceQuantity";
            this.txtServiceQuantity.Size = new System.Drawing.Size(124, 20);
            this.txtServiceQuantity.TabIndex = 20;
            this.txtServiceQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceQuantity_KeyPress);
            // 
            // comboBoxHotelService
            // 
            this.comboBoxHotelService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotelService.FormattingEnabled = true;
            this.comboBoxHotelService.Items.AddRange(new object[] {
            "Cleaning (10$)",
            "Iron (5$)",
            "Spa (15$)",
            "Babysitting (10$)",
            "Security services (25$)",
            "Car hire (10$)"});
            this.comboBoxHotelService.Location = new System.Drawing.Point(16, 130);
            this.comboBoxHotelService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHotelService.Name = "comboBoxHotelService";
            this.comboBoxHotelService.Size = new System.Drawing.Size(296, 21);
            this.comboBoxHotelService.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(328, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Quantity";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(209, 82);
            this.txtFoodPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(103, 20);
            this.txtFoodPrice.TabIndex = 17;
            this.txtFoodPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodPrice_KeyPress);
            // 
            // txtFoodQuantity
            // 
            this.txtFoodQuantity.Location = new System.Drawing.Point(16, 82);
            this.txtFoodQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFoodQuantity.Name = "txtFoodQuantity";
            this.txtFoodQuantity.Size = new System.Drawing.Size(124, 20);
            this.txtFoodQuantity.TabIndex = 9;
            this.txtFoodQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodQuantity_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Food Menu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Food And Services";
            // 
            // comboBoxFoodMenu
            // 
            this.comboBoxFoodMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFoodMenu.FormattingEnabled = true;
            this.comboBoxFoodMenu.Items.AddRange(new object[] {
            "Chicken (10$)",
            "Salad (5$)",
            "Squash Ravioli (10$)",
            "Lobster Ravioli (5$)",
            "Seared lamb medallions (15$)",
            "Beef Tenderlion (10$)",
            "Fried Salmon (10$)",
            "Salmon (10$)",
            ""});
            this.comboBoxFoodMenu.Location = new System.Drawing.Point(16, 41);
            this.comboBoxFoodMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFoodMenu.Name = "comboBoxFoodMenu";
            this.comboBoxFoodMenu.Size = new System.Drawing.Size(296, 21);
            this.comboBoxFoodMenu.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 303);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 41);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 303);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 41);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 303);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 41);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewGuest
            // 
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.AllowUserToDeleteRows = false;
            this.dataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgGID,
            this.dgName,
            this.dgContact,
            this.dgEmail,
            this.dgPassport,
            this.dgGType,
            this.dgDOB,
            this.dgAddress,
            this.dgRoomType,
            this.dgRoomNum,
            this.dgRoomFare,
            this.dgEntry,
            this.dgLeave,
            this.dgFoodMenu,
            this.dgFoodQuantity,
            this.dgFoodPrice,
            this.dgHotelService,
            this.dgServiceQuantity,
            this.dgServicePrice});
            this.dataGridViewGuest.Location = new System.Drawing.Point(9, 466);
            this.dataGridViewGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewGuest.Name = "dataGridViewGuest";
            this.dataGridViewGuest.ReadOnly = true;
            this.dataGridViewGuest.RowTemplate.Height = 24;
            this.dataGridViewGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuest.Size = new System.Drawing.Size(1101, 188);
            this.dataGridViewGuest.TabIndex = 28;
            this.dataGridViewGuest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewGuest_MouseDoubleClick);
            // 
            // dgGID
            // 
            this.dgGID.HeaderText = "ID";
            this.dgGID.Name = "dgGID";
            this.dgGID.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgContact
            // 
            this.dgContact.HeaderText = "Contact";
            this.dgContact.Name = "dgContact";
            this.dgContact.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgPassport
            // 
            this.dgPassport.HeaderText = "Identity";
            this.dgPassport.Name = "dgPassport";
            this.dgPassport.ReadOnly = true;
            // 
            // dgGType
            // 
            this.dgGType.HeaderText = "Identity Type";
            this.dgGType.Name = "dgGType";
            this.dgGType.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.HeaderText = "Date of Birth";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // dgRoomType
            // 
            this.dgRoomType.HeaderText = "Room Type";
            this.dgRoomType.Name = "dgRoomType";
            this.dgRoomType.ReadOnly = true;
            // 
            // dgRoomNum
            // 
            this.dgRoomNum.HeaderText = "Room Number";
            this.dgRoomNum.Name = "dgRoomNum";
            this.dgRoomNum.ReadOnly = true;
            // 
            // dgRoomFare
            // 
            this.dgRoomFare.HeaderText = "Room Fare";
            this.dgRoomFare.Name = "dgRoomFare";
            this.dgRoomFare.ReadOnly = true;
            // 
            // dgEntry
            // 
            this.dgEntry.HeaderText = "Entry Date";
            this.dgEntry.Name = "dgEntry";
            this.dgEntry.ReadOnly = true;
            // 
            // dgLeave
            // 
            this.dgLeave.HeaderText = "Departure Date";
            this.dgLeave.Name = "dgLeave";
            this.dgLeave.ReadOnly = true;
            // 
            // dgFoodMenu
            // 
            this.dgFoodMenu.HeaderText = "Food Menu";
            this.dgFoodMenu.Name = "dgFoodMenu";
            this.dgFoodMenu.ReadOnly = true;
            // 
            // dgFoodQuantity
            // 
            this.dgFoodQuantity.HeaderText = "Food Quantity";
            this.dgFoodQuantity.Name = "dgFoodQuantity";
            this.dgFoodQuantity.ReadOnly = true;
            // 
            // dgFoodPrice
            // 
            this.dgFoodPrice.HeaderText = "Food Price";
            this.dgFoodPrice.Name = "dgFoodPrice";
            this.dgFoodPrice.ReadOnly = true;
            // 
            // dgHotelService
            // 
            this.dgHotelService.HeaderText = "Hotel Service";
            this.dgHotelService.Name = "dgHotelService";
            this.dgHotelService.ReadOnly = true;
            // 
            // dgServiceQuantity
            // 
            this.dgServiceQuantity.HeaderText = "Hotel Service Quantity";
            this.dgServiceQuantity.Name = "dgServiceQuantity";
            this.dgServiceQuantity.ReadOnly = true;
            // 
            // dgServicePrice
            // 
            this.dgServicePrice.HeaderText = "Hotel Service Cost";
            this.dgServicePrice.Name = "dgServicePrice";
            this.dgServicePrice.ReadOnly = true;
            // 
            // errorProviderGuest
            // 
            this.errorProviderGuest.ContainerControl = this;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(741, 303);
            this.btnBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(98, 41);
            this.btnBill.TabIndex = 29;
            this.btnBill.Text = "Total Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Location = new System.Drawing.Point(322, 367);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 81);
            this.panel4.TabIndex = 31;
            // 
            // FormGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.dataGridViewGuest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGuestInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Info";
            this.Load += new System.EventHandler(this.FormGuestInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGuest)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateGBirth;
        private System.Windows.Forms.TextBox txtGAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGPassport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateGLeave;
        private System.Windows.Forms.DateTimePicker dateGEntry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRoomFare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtServiceQuantity;
        private System.Windows.Forms.ComboBox comboBoxHotelService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFoodQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxFoodMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewGuest;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ErrorProvider errorProviderGuest;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.ComboBox comboBoxGType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHotelService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgServiceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgServicePrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
    }
}