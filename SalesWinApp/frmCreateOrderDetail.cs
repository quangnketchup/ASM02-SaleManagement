using DataAccess.Repository;
using DataAccess.DataAccess;
namespace SalesWinApp
{
    public partial class frmCreateOrderDetail : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public OrderDetail OrderDetailInfor { get; set; }
        public frmCreateOrderDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProduct.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Status = 1,
                };
                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrderDetail(orderDetail);
                }
                else
                {
                    OrderDetailRepository.UpdateOrderDetail(orderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new order detail" : "update a order detail");
            }
        }

        private void frmCreateOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderDetailInfor.OrderId.ToString();
                txtDiscount.Text = OrderDetailInfor.Discount.ToString();
                txtProduct.Text = OrderDetailInfor.ProductId.ToString();
                txtQuantity.Text = OrderDetailInfor.Quantity.ToString();
                txtUnitPrice.Text = OrderDetailInfor.UnitPrice.ToString();
            }
        }
    }
}
