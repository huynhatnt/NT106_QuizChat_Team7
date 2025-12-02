using ClientForm.Services;
using System;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<string, string> res =
                    await _auth.LoginAsync(txtEmail.Text.Trim(), txtPass.Text.Trim());

                string uid = res.Item1;
                string email = res.Item2;

                RoomListForm f = new RoomListForm(uid, email);
                this.Hide();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }
    }
}
