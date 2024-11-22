using EventureApp.Models;

namespace EventureApp.UI
{
    public partial class SignUpPage : Form
    {
        public SignUpPage(MyDbContext dbContext)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void to_login_page_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
