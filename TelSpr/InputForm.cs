using System;
using System.Windows.Forms;

namespace TelSpr
{
    public partial class InputForm : Form
    {
        public string DeptName = "";
        public long BossID = 0;
        public string BossFIO = "";
        
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
            DeptName = tbDepartment.Text;
            BossID = (long)tbBoss.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SelectBoss()
        {
            if (!tbBoss.Modified)
                return;

            var bsf = new BossSelectForm {Filter = tbBoss.Text};
            if (bsf.ShowDialog() == DialogResult.OK)
            {
                tbBoss.Text = bsf.Fio;
                tbBoss.Tag = bsf.Id;
            }
            else
            {
                tbBoss.Text = "";
                tbBoss.Tag = null;
                tbBoss.Focus();
            }
        }

        private void tbBoss_Leave(object sender, EventArgs e)
        {
            SelectBoss();
        }

        private void tbBoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectBoss();
            }
        }

        private void InputForm_Shown(object sender, EventArgs e)
        {
            if (DeptName != "")
            {
                tbDepartment.Text = DeptName;
            }

            if (BossID != 0)
            {
                tbBoss.Text = BossFIO;
                tbBoss.Tag = BossID;
            }

            
            
        }


    }
}
