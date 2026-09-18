using System;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

                using (var homePage = new HomePage())
                {
                    homePage.ShowDialog();
                }

                Close();

                using (var homePage = new HomePage())
                {
                    homePage.ShowDialog();
                }

                Close();
            }

            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
