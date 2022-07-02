namespace SalesWinApp
{
    partial class frmCreateOrder
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.mtbOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(329, 765);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 68);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(661, 642);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(495, 47);
            this.txtFreight.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 650);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 41);
            this.label10.TabIndex = 41;
            this.label10.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 527);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 41);
            this.label9.TabIndex = 40;
            this.label9.Text = "Shipped Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 41);
            this.label8.TabIndex = 39;
            this.label8.Text = "Required Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 41);
            this.label7.TabIndex = 38;
            this.label7.Text = "Order Date";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(347, 147);
            this.lbMember.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(168, 41);
            this.lbMember.TabIndex = 33;
            this.lbMember.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(661, 21);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(495, 47);
            this.txtOrderID.TabIndex = 28;
            // 
            // mtbOrderDate
            // 
            this.mtbOrderDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbOrderDate.Location = new System.Drawing.Point(661, 275);
            this.mtbOrderDate.Mask = "00/00/0000";
            this.mtbOrderDate.Name = "mtbOrderDate";
            this.mtbOrderDate.Size = new System.Drawing.Size(495, 47);
            this.mtbOrderDate.TabIndex = 72;
            this.mtbOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbRequiredDate
            // 
            this.mtbRequiredDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbRequiredDate.Location = new System.Drawing.Point(661, 404);
            this.mtbRequiredDate.Mask = "00/00/0000";
            this.mtbRequiredDate.Name = "mtbRequiredDate";
            this.mtbRequiredDate.Size = new System.Drawing.Size(495, 47);
            this.mtbRequiredDate.TabIndex = 73;
            this.mtbRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbShippedDate
            // 
            this.mtbShippedDate.BackColor = System.Drawing.SystemColors.Window;
            this.mtbShippedDate.Location = new System.Drawing.Point(661, 527);
            this.mtbShippedDate.Mask = "00/00/0000";
            this.mtbShippedDate.Name = "mtbShippedDate";
            this.mtbShippedDate.Size = new System.Drawing.Size(495, 47);
            this.mtbShippedDate.TabIndex = 74;
            this.mtbShippedDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(918, 763);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 58);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(661, 147);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(495, 47);
            this.txtMemberId.TabIndex = 76;
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 950);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mtbShippedDate);
            this.Controls.Add(this.mtbRequiredDate);
            this.Controls.Add(this.mtbOrderDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderID);
            this.Name = "frmCreateOrder";
            this.Text = "frmCreateOrder";
            this.Load += new System.EventHandler(this.frmCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSave;
        private TextBox txtFreight;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lbMember;
        private Label label1;
        private TextBox txtOrderID;
        private MaskedTextBox mtbOrderDate;
        private MaskedTextBox mtbRequiredDate;
        private MaskedTextBox mtbShippedDate;
        private Button btnClose;
        private TextBox txtMemberId;
    }
}