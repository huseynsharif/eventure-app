using EventureApp.Models;
using Microsoft.IdentityModel.Tokens;


namespace EventureApp.UI
{
    public partial class LoginPage : Form
    {
        private readonly MyDbContext _dbContext;
        public LoginPage(MyDbContext dbContext)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _dbContext = dbContext;
        }

        private void to_sign_up_page_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SignUpPage signUpPage = new SignUpPage(_dbContext);
            signUpPage.ShowDialog(); 
            this.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                checkInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkInputs()
        {
            if (
                    tb_username.Text.IsNullOrEmpty() ||
                    tb_password.Text.IsNullOrEmpty()
               )
            {

                throw new Exception("Please, fill all fields.");
            }

        }

        private void NavigateToHome()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
