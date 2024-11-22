

namespace EventureApp.UI
{
    public partial class HomePage : Form
    {
        public HomePage(Models.MyDbContext dbContext)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
