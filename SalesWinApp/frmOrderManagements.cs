using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DataAccess;
using System.Globalization;
namespace SalesWinApp
{
    public partial class frmOrderManagements : Form
    {
        public bool isAdmin { get; set; }
        public Member loginMember { get; set; }
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public Member loginMember { get; set; }
        //Create a data source
        BindingSource source;
        public frmOrderManagements()
        {
            InitializeComponent();
        }

        
        //----------------------------------------
        public void LoadOrderList()
        {
            var orderList = orderRepository.GetOrders();
            try
            {
                source = new BindingSource();
                if (isAdmin == false)
                {
                    Order order = orderList.SingleOrDefault(o => o.MemberId == loginMember.MemberId);
                    source.DataSource = order;
                }
                else
                {
                    source.DataSource = orderList.OrderByDescending(orderList => orderList.OrderId);
                } 
                if(source.DataSource != null)
                {
                    txtOrderID.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    mtbOrderDate.DataBindings.Clear();
                    mtbRequiredDate.DataBindings.Clear();
                    mtbShippedDate.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();

                    txtOrderID.DataBindings.Add("Text", source, "OrderId");
                    txtMemberID.DataBindings.Add("Text", source, "MemberId");
                    mtbOrderDate.DataBindings.Add("Text", source, "OrderDate");
                    mtbRequiredDate.DataBindings.Add("Text", source, "RequireDate");
                    mtbShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                    txtFreight.DataBindings.Add("Text", source, "Freight");
                    txtStatus.DataBindings.Add("Text", source, "Status");

                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = source;
                    if (isAdmin == false)
                    {

                        if (orderList.Count() == 0)
                        {
                            ClearText();
                            //Set focus order Updated
                            source.Position = source.Count - 1;
                        }
                    }
                }
                else {
                    ClearText();
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order!");
            }
        }
        //Clear text on TextBoxes
        private void ClearText()
        {
            txtFreight.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            mtbOrderDate.Text = string.Empty;
            mtbRequiredDate.Text = string.Empty;
            mtbShippedDate.Text = string.Empty;
        }
        //-----------------------------------------------


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }
        
        private void frmOrderManagements_Load_1(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                btnFind.Enabled = true;

                txtFreight.Enabled = false;
                txtMemberID.Enabled = false;
                txtOrderID.Enabled = false;

                mtbOrderDate.Enabled = false;
                mtbRequiredDate.Enabled = false;
                mtbShippedDate.Enabled = false;
                txtStatus.Enabled = false;
            }
            else
            {
                btnFind.Enabled = true;
                btnDelete.Enabled = true;
                //Register this even to open the frmOrder form that performs updating
                dgvOrderList.CellDoubleClick += DgvOrderList_CellDoubleClick;
            }
        }
        //----------------------------------
        
        private void DgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCreateOrder frmCreateOrder = new frmCreateOrder
            {
                Text = "Update order",
                OrderInfor = GetOrderObject(),
                OrderRepository = orderRepository,
            };
            if(frmCreateOrder.ShowDialog() == DialogResult.OK)
            {
                isAdmin = this.isAdmin;
                LoadOrderList();
                //Set focus order update
                source.Position = source.Count - 1;
            }
        }

        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(mtbOrderDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    RequireDate = DateTime.Parse(mtbRequiredDate.Text),
                    ShippedDate = DateTime.Parse(mtbShippedDate.Text),
                    Status = int.Parse(txtStatus.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreateOrderDetail frmCreateOrder = new frmCreateOrderDetail
            {
                Text = "Add Order",
            }; 
            if (frmCreateOrder.ShowDialog()==DialogResult.OK)
            {
                //Set focus order inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOrder(order.OrderId);
                LoadOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FilterByOrderDayShippedDate();
        }

        //Filter startDate and EndDate
        private void FilterByOrderDayShippedDate()
        {
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCreateOrder frmCreateOrder = new frmCreateOrder
            {
                Text = "Update order",
                isAdmin = this.isAdmin,
                OrderInfor = GetOrderObject(),
                OrderRepository = orderRepository,
            };
            if (frmCreateOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                //Set focus order update
                source.Position = source.Count - 1;
            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            try
            {
                var StartDate = mtbFilterStartDate.Value;
                var EndDate = mtbFilterEndDate.Value;
                var list = orderRepository.GetOrderTime(StartDate, EndDate);
                LoadOrderListTime(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //--------------------------------

        private void LoadOrderListTime(IEnumerable<Order> list)
        {
            var list0 = orderRepository.GetOrders();
            var listOrder = list;
            try
            {
                source = new BindingSource();
                source.DataSource = listOrder.OrderByDescending(listOrder => listOrder.OrderId);
                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                mtbOrderDate.DataBindings.Clear();
                mtbRequiredDate.DataBindings.Clear();
                mtbShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                mtbOrderDate.DataBindings.Add("Text", source, "OrderDate");
                mtbRequiredDate.DataBindings.Add("Text", source, "RequireDate");
                mtbShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (isAdmin == false)
                {
                    {
                        ClearText();
                        //Set focus order Updated
                        source.Position = source.Count - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order!");
            }
        }
    }
}
