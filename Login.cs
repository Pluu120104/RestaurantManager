using RestaurantManager.DAO;

namespace RestaurantManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            string username = tbxUsername.Text;
            string passWord = tbxPassword.Text;
            if (Loginn(username,passWord))
            {
                TableManager tableManager = new TableManager();
                this.Hide();
                tableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong user name or password");
            }
        }

        bool Loginn(string userName, string passWord)
        {

            return AccountDAO.Instance.Login(userName,passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
