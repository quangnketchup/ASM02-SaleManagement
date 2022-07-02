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
    }
}
