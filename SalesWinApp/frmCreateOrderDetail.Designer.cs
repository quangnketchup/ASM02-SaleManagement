namespace SalesWinApp
{
    partial class frmCreateOrderDetail
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.mtbShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1224, 869);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 63);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(726, 869);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 63);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 643);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 41);
            this.label5.TabIndex = 24;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 506);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 41);
            this.label3.TabIndex = 22;
            this.label3.Text = "Unit Price";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(186, 233);
            this.product.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(159, 41);
            this.product.TabIndex = 21;
            this.product.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(1274, 99);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(495, 47);
            this.txtMemberId.TabIndex = 88;
            // 
            // mtbShippedDate
            // 
            this.mtbShippedDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbShippedDate.Location = new System.Drawing.Point(1274, 479);
            this.mtbShippedDate.Mask = "00/00/0000";
            this.mtbShippedDate.Name = "mtbShippedDate";
            this.mtbShippedDate.Size = new System.Drawing.Size(495, 47);
            this.mtbShippedDate.TabIndex = 87;
            this.mtbShippedDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbRequiredDate
            // 
            this.mtbRequiredDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbRequiredDate.Location = new System.Drawing.Point(1274, 356);
            this.mtbRequiredDate.Mask = "00/00/0000";
            this.mtbRequiredDate.Name = "mtbRequiredDate";
            this.mtbRequiredDate.Size = new System.Drawing.Size(495, 47);
            this.mtbRequiredDate.TabIndex = 86;
            this.mtbRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbOrderDate
            // 
            this.mtbOrderDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbOrderDate.Location = new System.Drawing.Point(1274, 227);
            this.mtbOrderDate.Mask = "00/00/0000";
            this.mtbOrderDate.Name = "mtbOrderDate";
            this.mtbOrderDate.Size = new System.Drawing.Size(495, 47);
            this.mtbOrderDate.TabIndex = 85;
            this.mtbOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(1274, 594);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(495, 47);
            this.txtFreight.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(960, 602);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 41);
            this.label10.TabIndex = 83;
            this.label10.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(960, 479);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 41);
            this.label9.TabIndex = 82;
            this.label9.Text = "Shipped Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(960, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 41);
            this.label8.TabIndex = 81;
            this.label8.Text = "Required Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(960, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 41);
            this.label7.TabIndex = 80;
            this.label7.Text = "Order Date";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(960, 99);
            this.lbMember.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(168, 41);
            this.lbMember.TabIndex = 79;
            this.lbMember.Text = "Member ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(422, 99);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(439, 47);
            this.txtOrderId.TabIndex = 89;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(422, 227);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(439, 47);
            this.txtProductID.TabIndex = 90;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(422, 356);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(439, 47);
            this.txtUnitPrice.TabIndex = 91;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(422, 506);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(439, 47);
            this.txtQuantity.TabIndex = 92;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(422, 640);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(439, 47);
            this.txtDiscount.TabIndex = 93;
            // 
            // frmCreateOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1993, 1551);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.mtbShippedDate);
            this.Controls.Add(this.mtbRequiredDate);
            this.Controls.Add(this.mtbOrderDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateOrderDetail";
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.frmCreateOrderDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label product;
        private Label label1;
        private TextBox txtMemberId;
        private MaskedTextBox mtbShippedDate;
        private MaskedTextBox mtbRequiredDate;
        private MaskedTextBox mtbOrderDate;
        private TextBox txtFreight;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lbMember;
        private TextBox txtOrderId;
        private TextBox txtProductID;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
    }
}