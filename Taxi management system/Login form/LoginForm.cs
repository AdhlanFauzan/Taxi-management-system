using System;
using System.Windows.Forms;
using DAL.Concrete.Repositories;
using Entities.Concrete;
using MaterialSkin.Controls;
using System.Configuration;

namespace Taxi_management_system.Login_form
{
    public partial class LoginForm : MaterialForm
    {
        private readonly UserRepository _userRepository = new UserRepository(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            User currentUser = _userRepository.GetUserByLogin(loginTextField.Text, passwordTextField.Text);
            if (currentUser.Login == loginTextField.Text)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
