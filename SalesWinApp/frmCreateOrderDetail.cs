using DataAccess.Repository;
using DataAccess.DataAccess;
namespace SalesWinApp
{
    public partial class frmCreateOrderDetail : Form
    {
        public bool isAdmin { get; set; }
        //  public IOrderRepository OrderRepository { get; set; }
        IOrderRepository OrderRepository = new OrderRepository();
        public OrderDetail OrderDetailInfor { get; set; }
        //  public IOrderDetailRepository OrderDetailRepository { get; set; }
        IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
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
                AssignmentContext db = new AssignmentContext();
                var mem = db.Members.SingleOrDefault(pro => pro.CompanyName.Equals(txtMemberId.SelectedItem.ToString()));
                int id = mem.MemberId;

                var order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = id,
                    OrderDate = DateTime.Parse(mtbOrderDate.Text),
                    RequireDate = DateTime.Parse(mtbRequiredDate.Text),
                    ShippedDate = DateTime.Parse(mtbShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    Status = 1,
                };
                if (order != null)
                {
                    OrderRepository.InsertOrder(order);
                }

                var product = db.Products.SingleOrDefault(pro => pro.ProductName.Equals(txtProductID.SelectedItem.ToString()));
                int pro = product.ProductId;
                var orderDetail = new OrderDetail
                {
                    OrderDetailId = int.Parse(txtOrderDetailId.Text),
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = pro,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Status = 1,

                };

                if (orderDetail != null)
                {
                    OrderDetailRepository.InsertOrderDetail(orderDetail);
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new order detail");
            }
        }

        private void frmCreateOrderDetail_Load(object sender, EventArgs e)
        {
            AssignmentContext db = new AssignmentContext();
            var member = from m in db.Members
                         select m.CompanyName.ToString();
            foreach (var x in member)
            {
                txtMemberId.Items.Add(x);
            }
            var product = from c in db.Products
                          select c.ProductName.ToString();
            foreach (var i in product)
            {
                txtProductID.Items.Add(i);
            }
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
