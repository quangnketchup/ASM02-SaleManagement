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
    public partial class frmCreateOrder : Form
    {
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfor { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public frmCreateOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProduct.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = DateTime.Parse(mtbOrderDate.Text),
                    RequireDate = DateTime.Parse(mtbRequiredDate.Text),
                    ShippedDate = DateTime.Parse(mtbShippedDate.Text),
                    Status = 1
                };
                if(InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(order);
                }
                else
                {
                    OrderRepository.UpdateOrder(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new order" : "update a order");
            }
        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true) //update mode
            {
                //Show member to perform updating
                txtOrderID.Text = OrderInfor.OrderId.ToString();
                txtMemberId.Text = OrderInfor.MemberId.ToString();
                txtFreight.Text = OrderInfor.Freight.ToString();
                mtbRequiredDate.Text = OrderInfor.RequireDate.ToString();
                mtbOrderDate.Text = OrderInfor.OrderDate.ToString();
                mtbShippedDate.Text = OrderInfor.ShippedDate.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
