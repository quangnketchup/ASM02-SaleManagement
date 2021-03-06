using DataAccess.Repository;
using Nancy.Json;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader("appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();

            var obj = jss.Deserialize<dynamic>(json);

            string Email = obj["DefaultAccount"]["Email"];
            string Password = obj["DefaultAccount"]["password"];
            bool isMem = false;

            if (Email.Equals(txtUserName.Text) && Password.Equals(txtPassword.Text))
            {
                frmMain frm = new frmMain()
                {
                    isAdmin = true
                };
                frm.ShowDialog();
                isMem = true;

                this.Close();

            }

            var members = memberRepository.GetMembers();

            foreach (var i in members)
            {
                if (i.Email.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text))
                {
                    frmMain frm = new frmMain()
                    {
                        isAdmin = false,
                        loginMember = i,
                    };
                    frm.ShowDialog();
                    isMem = true;

                    this.Close();
                    break;

                }

            }
            if (isMem == true)
            {
                MessageBox.Show("Login Success", "Right user");
            }
            else
            {
                MessageBox.Show("Wrong username/email or pass word, please try again", "Wrong user");

            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
