using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using DataAccess.DataAccess;
namespace SalesWinApp
{
    //test connect git
    public partial class frmOrderDetails : Form
    {
        public bool isAdmin { get; set; }
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        //Create a data source
        BindingSource source;

        //-------------------------

        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if(isAdmin == true)
            {
                btnDelete.Enabled = false;
                btnCreate.Enabled = false;
                
                txtDiscount.Enabled = false;
                txtOrderID.Enabled = false;
                txtProduct.Enabled = false;
                txtQuantity.Enabled = false;
                txtUnitPrice.Enabled = false;
                dgvOrderDetail.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = true;
                //Register this event to open the frmOrderDetail form that performs updating
                dgvOrderDetail.CellDoubleClick += dgvOrderDetail_CellContentClick;
            }
        }
        //--------------------------------
        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCreateOrderDetail frmCreateOrderDetail = new frmCreateOrderDetail
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderDetailInfor = GetOrderDetailObject(),
                OrderDetailRepository = orderDetailRepository,
            };
            if (frmCreateOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetailList();
                //Set focus order updated
                source.Position = source.Count - 1;
            }
        }

        //Clear text on Textboxes
        private void ClearText()
        {
            txtOrderID.Text = String.Empty;
            txtProductID.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
        }
        //-------------------------------------

        public void LoadOrderDetailList()
        {
            var orders = orderDetailRepository.GetOrderDetails();

            try
            {
                //The BindingSource oponent is designed to simplify
                //The process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = orders.OrderByDescending(order => order.OrderId);
                txtDiscount.DataBindings.Clear();
                txtOrderID.DataBindings.Clear();
                txtProduct.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtDiscount.DataBindings.Add("Text", source, "Discount");
                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtProduct.DataBindings.Add("Text", source, "ProductId");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = source;
                if (isAdmin == false)
                {
                    if (orders.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    if(orders.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }
        //----------------------------------------------
        private OrderDetail GetOrderDetailObject()
        {
            OrderDetail orderDetail=null;
            try
            {
                orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProduct.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtDiscount.Text),
                    Status = int.Parse(txtStatus.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order Detail");
            }
            return orderDetail;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateOrderDetail frmCreateOrderDetails = new frmCreateOrderDetail
            {
                Text = "Add Order Detail",
                InsertOrUpdate = false,
                OrderDetailRepository = orderDetailRepository
            };
            if (frmCreateOrderDetails.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetailList();
                //Set focus order detail Update
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = GetOrderDetailObject();
                orderDetailRepository.DeleteOrderDetail(orderDetail.OrderId, orderDetail.ProductId);
                LoadOrderDetailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a orderDetail");
            }
        }
    }
}
