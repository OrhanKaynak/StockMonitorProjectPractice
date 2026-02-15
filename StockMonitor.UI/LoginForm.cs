using System;
using System.Windows.Forms;
using StockMonitor.Business;
using StockMonitor.Entities;

namespace StockMonitor.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();

            User user = new User
            {
                UserName = tbxUser.Text,
                Password = tbxPassword.Text
            };

            bool isSuccess = userManager.Login(user);

            if (isSuccess)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
