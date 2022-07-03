using DataAccess.Repository;
using DataAccess.DataAccess;
namespace SalesWinApp
{
    public partial class frmCreateOrderDetail : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public OrderDetail OrderDetailInfor { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public Order OrderInfor { get; set; }
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
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Status = 1,
                };
                
                var order = new Order
                {
                    OrderId =int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(mtbOrderDate.Text),
                    RequireDate = DateTime.Parse(mtbShippedDate.Text),
                    ShippedDate = DateTime.Parse(mtbShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    Status = 1,
                };
                if (order != null)
                {
                    OrderRepository.InsertOrder(order);
                }
                if (orderDetail != null)
                {
                    OrderDetailRepository.InsertOrderDetail(orderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new order detail");
            }
        }

        private void frmCreateOrderDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
