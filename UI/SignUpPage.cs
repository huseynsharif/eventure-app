using EventureApp.Models;
using Microsoft.IdentityModel.Tokens;

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

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                checkInputs();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkInputs()
        {
            if (
                    tb_username.Text.IsNullOrEmpty() ||
                    tb_password.Text.IsNullOrEmpty() ||
                    tb_cpassword.Text.IsNullOrEmpty()
                    )
            {

                throw new Exception("Please, fill all fields.");
            }

            if (tb_username.Text.Length < 3)
            {

                throw new Exception("Username length must be more than 2.");
            }

            if (!tb_password.Text.Equals(tb_cpassword.Text))
            {

                throw new Exception("Passwords must be same.");
            }

            if (tb_password.Text.Length < 6)
            {

                throw new Exception("Passwords length must be more than 5.");
            }
        }
    }
}
