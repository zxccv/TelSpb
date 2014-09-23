using System;
using System.Data;
using System.Windows.Forms;

namespace TelSpr
{
    public partial class BossSelectForm : Form
    {
        public long Id;
        public string Fio;
        public string Filter;

        public BossSelectForm()
        {
            InitializeComponent();
        }

        private void BossSelectForm_Load(object sender, EventArgs e)
        {
            
            var dtWorkers = DBFunctions.ReadFromDB(@"SELECT id,CONCAT(workers.second_name,' ',workers.name, 
            CASE WHEN NOT ISNULL(workers.third_name) AND workers.third_name <> '' THEN CONCAT(' ',workers.third_name) ELSE '' END) AS FIO,
            IFNULL(workers.position,'') AS Position 
            FROM workers");

            dtWorkers.DefaultView.RowFilter = "`FIO` LIKE '%" + Filter + "%'";

            //TODO Ограничения на количество

            var column = new DataGridViewTextBoxColumn
            {
                Name = "FIO",
                HeaderText = "ФИО",
                DataPropertyName = "FIO",
                FillWeight = 120
            };

            dgvWorkers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                Name = "Position",
                HeaderText = "Должность",
                DataPropertyName = "Position",
                FillWeight = 60
            };

            dgvWorkers.Columns.Add(column);

            dgvWorkers.AutoGenerateColumns = false;
            dgvWorkers.DataSource = dtWorkers;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var currRow = FindCurrentRow(dgvWorkers);

            if (currRow == null)
                return;

            Id = (long)currRow["id"];
            Fio = (string)currRow["fio"];

            DialogResult = DialogResult.OK;
            Close();
        }

        private DataRow FindCurrentRow(DataGridView dgv)
        {
            var cManager =
                dgv.BindingContext[dgv.DataSource, dgv.DataMember]
                     as CurrencyManager;
            if (cManager == null || cManager.Count == 0)
                return null;

            var drv = cManager.Current as DataRowView;
            return drv.Row;
        }

        private void dgvWorkers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect_Click(sender, (EventArgs)e);
        }
    }
}
