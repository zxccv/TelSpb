using System;
using System.Windows.Forms;

namespace TelSpr
{
    public partial class InputForm : Form
    {
        public string InputString = "";

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InputString = tbPassword.Text;
            Close();
        }
    }
}
