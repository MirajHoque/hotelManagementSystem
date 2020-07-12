namespace HM.Guest
{
    partial class FormBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHotelService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServiceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.comboBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(171, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 170);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Guest ID",
            "Guest Name"});
            this.comboBoxSearch.Location = new System.Drawing.Point(184, 32);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(212, 24);
            this.comboBoxSearch.TabIndex = 1;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(184, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(235, 110);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 39);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgGID,
            this.dgName,
            this.dgRoomFare,
            this.dgFoodMenu,
            this.dgFoodQuantity,
            this.dgFoodPrice,
            this.dgHotelService,
            this.dgServiceQuantity,
            this.dgServiceCost});
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgGID
            // 
            this.dgGID.HeaderText = "Guest ID";
            this.dgGID.Name = "dgGID";
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            // 
            // dgRoomFare
            // 
            this.dgRoomFare.HeaderText = "Room Fare";
            this.dgRoomFare.Name = "dgRoomFare";
            // 
            // dgFoodMenu
            // 
            this.dgFoodMenu.HeaderText = "Food Menu";
            this.dgFoodMenu.Name = "dgFoodMenu";
            // 
            // dgFoodQuantity
            // 
            this.dgFoodQuantity.HeaderText = "Food Quantity";
            this.dgFoodQuantity.Name = "dgFoodQuantity";
            // 
            // dgFoodPrice
            // 
            this.dgFoodPrice.HeaderText = "Food Price";
            this.dgFoodPrice.Name = "dgFoodPrice";
            // 
            // dgHotelService
            // 
            this.dgHotelService.HeaderText = "Hotel Service";
            this.dgHotelService.Name = "dgHotelService";
            // 
            // dgServiceQuantity
            // 
            this.dgServiceQuantity.HeaderText = "Service Quantity";
            this.dgServiceQuantity.Name = "dgServiceQuantity";
            // 
            // dgServiceCost
            // 
            this.dgServiceCost.HeaderText = "Service Cost";
            this.dgServiceCost.Name = "dgServiceCost";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHotelService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgServiceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgServiceCost;
    }
}