namespace SalesWinApp
{
    partial class frmOrderManagements
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.mtbOrderDate = new System.Windows.Forms.TextBox();
            this.mtbRequiredDate = new System.Windows.Forms.TextBox();
            this.mtbShippedDate = new System.Windows.Forms.TextBox();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.mtbFilterStartDate = new System.Windows.Forms.DateTimePicker();
            this.mtbFilterEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(29, 624);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(1913, 344);
            this.dgvOrderList.TabIndex = 61;
            this.dgvOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(878, 980);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 59);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(369, 390);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 59);
            this.btnLoad.TabIndex = 58;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(896, 390);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 59);
            this.btnNew.TabIndex = 57;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1430, 390);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 59);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrderID.Location = new System.Drawing.Point(494, 42);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(480, 47);
            this.txtOrderID.TabIndex = 52;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(1010, 42);
            this.lbRequiredDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(207, 41);
            this.lbRequiredDate.TabIndex = 50;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(253, 143);
            this.lbOrderDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(165, 41);
            this.lbOrderDate.TabIndex = 47;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(253, 235);
            this.lbMemberID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(168, 41);
            this.lbMemberID.TabIndex = 46;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(253, 42);
            this.lbOrderId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(132, 41);
            this.lbOrderId.TabIndex = 45;
            this.lbOrderId.Text = "Order ID";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(1010, 146);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(198, 41);
            this.lbShippedDate.TabIndex = 74;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMemberID.Location = new System.Drawing.Point(494, 237);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(480, 47);
            this.txtMemberID.TabIndex = 75;
            // 
            // txtFreight
            // 
            this.txtFreight.BackColor = System.Drawing.SystemColors.Control;
            this.txtFreight.Location = new System.Drawing.Point(1226, 237);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(501, 47);
            this.txtFreight.TabIndex = 76;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(1010, 243);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(111, 41);
            this.lbFreight.TabIndex = 77;
            this.lbFreight.Text = "Freight";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(1010, 315);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(98, 41);
            this.lbStatus.TabIndex = 80;
            this.lbStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Location = new System.Drawing.Point(1226, 315);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(501, 47);
            this.txtStatus.TabIndex = 81;
            // 
            // mtbOrderDate
            // 
            this.mtbOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.mtbOrderDate.Location = new System.Drawing.Point(494, 146);
            this.mtbOrderDate.Name = "mtbOrderDate";
            this.mtbOrderDate.Size = new System.Drawing.Size(480, 47);
            this.mtbOrderDate.TabIndex = 82;
            // 
            // mtbRequiredDate
            // 
            this.mtbRequiredDate.BackColor = System.Drawing.SystemColors.Control;
            this.mtbRequiredDate.Location = new System.Drawing.Point(1226, 42);
            this.mtbRequiredDate.Name = "mtbRequiredDate";
            this.mtbRequiredDate.Size = new System.Drawing.Size(501, 47);
            this.mtbRequiredDate.TabIndex = 83;
            // 
            // mtbShippedDate
            // 
            this.mtbShippedDate.BackColor = System.Drawing.SystemColors.Control;
            this.mtbShippedDate.Location = new System.Drawing.Point(1226, 146);
            this.mtbShippedDate.Name = "mtbShippedDate";
            this.mtbShippedDate.Size = new System.Drawing.Size(501, 47);
            this.mtbShippedDate.TabIndex = 84;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(178, 496);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(148, 41);
            this.lbStartDate.TabIndex = 87;
            this.lbStartDate.Text = "Start Date";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(915, 502);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(138, 41);
            this.lbEndDate.TabIndex = 88;
            this.lbEndDate.Text = "End Date";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1622, 497);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(188, 58);
            this.btnFind.TabIndex = 89;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // mtbFilterStartDate
            // 
            this.mtbFilterStartDate.Location = new System.Drawing.Point(335, 496);
            this.mtbFilterStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.mtbFilterStartDate.Name = "mtbFilterStartDate";
            this.mtbFilterStartDate.Size = new System.Drawing.Size(527, 47);
            this.mtbFilterStartDate.TabIndex = 90;
            // 
            // mtbFilterEndDate
            // 
            this.mtbFilterEndDate.Location = new System.Drawing.Point(1062, 501);
            this.mtbFilterEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.mtbFilterEndDate.Name = "mtbFilterEndDate";
            this.mtbFilterEndDate.Size = new System.Drawing.Size(527, 47);
            this.mtbFilterEndDate.TabIndex = 91;
            // 
            // frmOrderManagements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1957, 1054);
            this.Controls.Add(this.mtbFilterEndDate);
            this.Controls.Add(this.mtbFilterStartDate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.mtbShippedDate);
            this.Controls.Add(this.mtbRequiredDate);
            this.Controls.Add(this.mtbOrderDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderId);
            this.Name = "frmOrderManagements";
            this.Text = "frmOrderManagements";
            this.Load += new System.EventHandler(this.frmOrderManagements_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvOrderList;
        private Button btnClose;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private TextBox txtOrderID;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbMemberID;
        private Label lbOrderId;
        private Label lbShippedDate;
        private TextBox txtMemberID;
        private TextBox txtFreight;
        private Label lbFreight;
        private EventHandler frmOrderManagements_Load;
        private Label lbStatus;
        private TextBox txtStatus;
        private TextBox mtbOrderDate;
        private TextBox mtbRequiredDate;
        private TextBox mtbShippedDate;
        private Label lbStartDate;
        private Label lbEndDate;
        private Button btnFind;
        private DateTimePicker mtbFilterStartDate;
        private DateTimePicker mtbFilterEndDate;
    }
}