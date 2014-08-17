using System;
using System.Windows.Forms;

namespace TelSpr
{
    public partial class PasswordForm : Form
    {
        public bool IsPasswordCorrect = false;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "ht;bvhtlfrnbhjdfybz" || tbPassword.Text == "режимредактирования")
            {
                IsPasswordCorrect = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }

        }
    }
}
