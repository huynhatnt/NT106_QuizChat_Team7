using ClientForm.Services;
using System;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _auth = new AuthService();
        private readonly UserService _user = new UserService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string pass = txtPass.Text.Trim();

                string uid = await _auth.RegisterAsync(email, pass);
                await _user.SaveUserAsync(uid, email);

                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng ký");
            }
        }
    }
}
