using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace TelSpr
{
    public partial class TelSprMainForm : Form
    {       
        private bool _isTreeExpanded;
        private bool _newWorker;
        private DataTable _dtWorkers;
        
        private DataRow _lastRow;
        
        public TelSprMainForm()
        {
            _isTreeExpanded = true;
            _newWorker = false;
            _lastRow = null;
            InitializeComponent();
        }

        #region Работаем над системным меню

// ReSharper disable 
        // Define the Win32 API methods we are going to use
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
 
        private static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);

        [DllImport("user32.dll")]
        private static extern bool ModifyMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);

        /// Define our Constants we will use
// ReSharper disable InconsistentNaming
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 MF_SEPARATOR = 0x800;
        public const Int32 MF_BYPOSITION = 0x400;
        public const Int32 MF_STRING = 0x0;
// ReSharper restore InconsistentNaming

        // The constants we'll use to identify our custom system menu items
        public const Int32 EditModeSysMenuId = 1000;

// ReSharper restore 

        protected override void WndProc(ref Message m)
        {
            // Check if a System Command has been executed
            if (m.Msg == WM_SYSCOMMAND)
            {
                // Execute the appropriate code for the System Menu item that was clicked
                switch (m.WParam.ToInt32())
                {
                    case EditModeSysMenuId:
                        EditModeChange();
                        break;                    
                }
            }

            base.WndProc(ref m);
        }

        private void UpdateSystemMenu()
        {
            var systemMenuHandle = GetSystemMenu(Handle, false);

            InsertMenu(systemMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(systemMenuHandle, 6, MF_BYPOSITION, EditModeSysMenuId, "Включить режим редактирования");
        }

        #endregion

        #region EditMode On/Off

        private bool _editMode;

        private void ControlsAcceptance()
        {
            tbS_Name.ReadOnly = !_editMode;
            tbName.ReadOnly = !_editMode;
            tbT_Name.ReadOnly = !_editMode;
            tbPosition.ReadOnly = !_editMode;
            tbCabinet.ReadOnly = !_editMode;
            tbCellPhone1.ReadOnly = !_editMode;
            tbCellPhone2.ReadOnly = !_editMode;
            tbOfficialPhone.ReadOnly = !_editMode;

            tbPhoneAdd.ReadOnly = !_editMode;
            tbBoss.ReadOnly = !_editMode;
            tbResponsibility.ReadOnly = !_editMode;
            tbComment.ReadOnly = !_editMode;

            tbEmailWork.ReadOnly = !_editMode;
            tbEmailPersonal.ReadOnly = !_editMode;
            tbBirthday.ReadOnly = !_editMode;

            cbDepartment.Enabled = _editMode;

            if (_editMode)
            {
                pbPhoto.Click += pbPhoto_Click;
                pbPhoto.Cursor = Cursors.Hand;
            }
            else
            {
                pbPhoto.Click -= pbPhoto_Click;
                pbPhoto.Cursor = Cursors.Default;
            }

            btnSave.Visible = _editMode;
            btnAdd.Visible = _editMode;
            btnDelete.Visible = _editMode;
        }

        private void EditModeChange()
        {
            if (_editMode)
            {
                var systemMenuHandle = GetSystemMenu(Handle, false);
                ModifyMenu(systemMenuHandle, 6, MF_BYPOSITION, EditModeSysMenuId, "Включить режим редактирования");
                _editMode = false;
                Text = @"Телефонный справочник АК ГРУЗОМОБИЛЬ";
                ControlsAcceptance();
                tvOrganizationStructure.ContextMenuStrip = null;
            }
            else
            {
                var pwdForm = new PasswordForm();
                pwdForm.ShowDialog();
                if (pwdForm.IsPasswordCorrect)
                {
                    var systemMenuHandle = GetSystemMenu(Handle, false);
                    ModifyMenu(systemMenuHandle, 6, MF_BYPOSITION, EditModeSysMenuId, "Отключить режим редактирования");
                    _editMode = true;
                    Text = @"Телефонный справочник АК ГРУЗОМОБИЛЬ (РЕЖИМ РЕДАКТИРОВАНИЯ)";
                    ControlsAcceptance();
                    tvOrganizationStructure.ContextMenuStrip = cmOrganizationTree;
                }
            }
        }

        #endregion

        #region Работа с подразделениями (дерево и комбо-бокс)
        //////////////////////////////
        /// ДЕРЕВО
        //////////////////////////////

        //Поиск в дереве по тегу
        public TreeNode FindTag(TreeNodeCollection tcol, object tag)
        {
            foreach (TreeNode tn in tcol)
            {
                if ((long)tn.Tag == (long)tag)
                    return tn;

                var res = FindTag(tn.Nodes, tag);
                if (res != null)
                    return res;
            }
            return null;
        }

        private void LoadOrganizationTree()
        {
            tvOrganizationStructure.Nodes.Clear();
            TreeNode rootNode = null;
            var dt = DBFunctions.ReadFromDB("SELECT id,parent_id,name FROM org_structure");
            foreach (DataRow row in dt.Rows)
            {
                if ((long)row["parent_id"] == 0)
                {
                    rootNode = tvOrganizationStructure.Nodes.Add((string)row["name"]);
                    rootNode.Tag = row["id"];
                    rootNode.Expand();

                }
                else
                {
                    var parentNode = FindTag(tvOrganizationStructure.Nodes, row["parent_id"]);
                    if (parentNode == null)
                    {
                        parentNode = tvOrganizationStructure.Nodes.Add("");
                        parentNode.Tag = row["parent_id"];
                    }

                    var loadingNode = FindTag(tvOrganizationStructure.Nodes, row["id"]);
                    if (loadingNode == null)
                    {
                        loadingNode = tvOrganizationStructure.Nodes.Add("");
                        loadingNode.Tag = row["id"];
                    }

                    loadingNode.Text = (string)row["name"];
                    parentNode.Nodes.Add((TreeNode)loadingNode.Clone());
                    loadingNode.Remove();
                }

            }

            if (rootNode != null)
            {
                tvOrganizationStructure.SelectedNode = rootNode;
                rootNode.Expand();
            }
        }

        //Получает массив id-ов всех подразделений, подчиненных текущему(включая текущее)
        private List<long> GetDepartmentIds(TreeNode startNode)
        {
            var retList = new List<long>();

            foreach (TreeNode childNode in startNode.Nodes)
            {
                var childList = GetDepartmentIds(childNode);
                retList.AddRange(childList);
            }

            retList.Add((long)startNode.Tag);
            return retList;

        }
        
        //Получает массив id-ы всех подразделений, подчиненных текущему(включая текущее) в виде СТРОКИ <('id','id','id',....)>
        private string GetDepartmentIdsString()
        {
            var depts = GetDepartmentIds(tvOrganizationStructure.SelectedNode);

            var retString = "(";

            var isFirst = true;
            foreach (var deptId in depts)
            {
                if (isFirst)
                    isFirst = false;
                else
                    retString += ",";

                retString += "'" + Convert.ToString(deptId) + "'";
            }

            retString += ")";

            return retString;
        }

        private void btnExpandTree_Click(object sender, EventArgs e)
        {
            if (_isTreeExpanded)
            {
                btnExpandTree.Text = @">";
                verticalSplitContainer.SplitterDistance = 25;
            }
            else
            {
                btnExpandTree.Text = @"<";
                verticalSplitContainer.SplitterDistance = 300;
            }

            _isTreeExpanded = !_isTreeExpanded;

        }

        private void tvOrganizationStructure_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvOrganizationStructure.SelectedNode = e.Node;
            }
        }

        private void cmOrganizationTree_Opening(object sender, CancelEventArgs e)
        {
            if (tvOrganizationStructure.SelectedNode != null)
            {
                menuDeleteOrgUnit.Enabled = true;
                menuEditOrgUnit.Enabled = true;
            }
            else
            {
                menuDeleteOrgUnit.Enabled = false;
                menuEditOrgUnit.Enabled = false;
            }
                
        }

        private void menuAddOrgUnit_Click(object sender, EventArgs e)
        {

            var inputForm = new InputForm();
            inputForm.ShowDialog();
            var deptName = inputForm.DeptName;
            if (deptName != "")
            {
                var newNode = tvOrganizationStructure.SelectedNode.Nodes.Add(deptName);

                var parameters = new Dictionary<string, object>();
                parameters.Add("name", deptName);
                parameters.Add("parent_id", (long)tvOrganizationStructure.SelectedNode.Tag);
                parameters.Add("boss_id", inputForm.BossID);

                DBFunctions.ExecuteCommand("INSERT INTO org_structure VALUES(NULL,@parent_id,@name,@boss_id)", parameters);

                var maxId = (long)DBFunctions.ReadScalarFromDB("SELECT MAX(id) FROM org_structure");

                newNode.Tag = maxId;

                LoadDepartments();
                FillForm();
            }

        }

        private void menuEditOrgUnit_Click(object sender, EventArgs e)
        {
            var currDeptId = (long)tvOrganizationStructure.SelectedNode.Tag;

            var parameters = new Dictionary<string, object> { { "dept_id", currDeptId } };

            DataTable dtDeptInfo = DBFunctions.ReadFromDB(
            @"SELECT 
                org_structure.name,
                org_structure.boss_id,
                IFNULL(CONCAT(boss_table.second_name,' ',boss_table.name,
                CASE WHEN NOT ISNULL(boss_table.third_name) AND boss_table.third_name <> '' THEN CONCAT(' ',boss_table.third_name) ELSE '' END),'') AS boss_fio
                FROM org_structure LEFT JOIN workers AS boss_table ON org_structure.boss_id = boss_table.id WHERE org_structure.id = @dept_id"
                , parameters);

            var inputForm = new InputForm();
            
            inputForm.DeptName = (string)dtDeptInfo.Rows[0]["name"];
            if (dtDeptInfo.Rows[0]["boss_id"] != DBNull.Value && (long) dtDeptInfo.Rows[0]["boss_id"] != 0)
            {
                inputForm.BossID = (long) dtDeptInfo.Rows[0]["boss_id"];
                inputForm.BossFIO = (string) dtDeptInfo.Rows[0]["boss_fio"];
            }
            else
            {
                inputForm.BossID = 0;
            }

            DialogResult inputResult = inputForm.ShowDialog();

            if (inputResult == DialogResult.OK)
            {
                parameters.Add("name",inputForm.DeptName);
                parameters.Add("boss_id", inputForm.BossID);    

                DBFunctions.ExecuteCommand("UPDATE org_structure SET name=@name,boss_id=@boss_id WHERE id=@dept_id",parameters);

                tvOrganizationStructure.SelectedNode.Text = inputForm.DeptName;
            }
        }

        private void menuDeleteOrgUnit_Click(object sender, EventArgs e)
        {
            var currDeptId = (long)tvOrganizationStructure.SelectedNode.Tag;

            var parameters = new Dictionary<string, object> {{"dept_id", currDeptId}};

            var childDeptsCount = (long)DBFunctions.ReadScalarFromDB("SELECT COUNT(id) FROM org_structure WHERE parent_id = @dept_id", parameters);

            if (childDeptsCount > 0)
            {
                MessageBox.Show("Невозможно удалить подразделение. Есть подчиненные подразделения", "Ошибка удаления");
                return;
            }


            var workersCount = (long)DBFunctions.ReadScalarFromDB("SELECT COUNT(id) FROM workers WHERE department = @dept_id", parameters);

            if (workersCount > 0)
            {
                MessageBox.Show("Невозможно удалить подразделение. В нем работают сотрудники", "Ошибка удаления");
                return;
            }

            DBFunctions.ExecuteCommand("DELETE FROM org_structure WHERE id = @dept_id", parameters);
            var node2Delete = tvOrganizationStructure.SelectedNode;

            tvOrganizationStructure.SelectedNode = tvOrganizationStructure.SelectedNode.Parent;

            node2Delete.Remove();

            LoadDepartments();

        }

        //////////////////////////////
        /// Combobox
        //////////////////////////////
        
        private void LoadDepartments()
        {
            var dtDepartments = DBFunctions.ReadFromDB("SELECT DISTINCT id,name FROM org_structure ORDER BY name");

            cbDepartment.Items.Clear();

            foreach (DataRow departmentRow in dtDepartments.Rows)
            {
                cbDepartment.Items.Add(new Department((long)departmentRow["id"], (string)departmentRow["name"]));
            }
        }
        
        private Department FindDeptById(long id)
        {
            foreach (Department dept in cbDepartment.Items)
            {
                if (dept.Id == id)
                    return dept;
            }
            return null;
        }
        
        #endregion

        #region Работа с DataGridView
        
        private void CreateDGVColumns()
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = "FIO",
                HeaderText = "ФИО",
                DataPropertyName = "FIO",
                FillWeight = 100
            };

            dgvWorkers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                Name = "Phone_Official",
                HeaderText = "Тел.",
                DataPropertyName = "Phone_Official",
                FillWeight = 25,
                DefaultCellStyle = {Font = new Font(dgvWorkers.DefaultCellStyle.Font, FontStyle.Bold)}
            };

            dgvWorkers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                Name = "Phone_Dop",
                HeaderText = "Доп. тел.",
                DataPropertyName = "phone_dop",
                FillWeight = 25,
                DefaultCellStyle = {Font = new Font(dgvWorkers.DefaultCellStyle.Font, FontStyle.Bold)}
            };

            dgvWorkers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                Name = "Phone_Cell_1",
                HeaderText = "Сот. тел.",
                DataPropertyName = "phone_cell_1",
                FillWeight = 65,
                DefaultCellStyle = {Font = new Font(dgvWorkers.DefaultCellStyle.Font, FontStyle.Bold)}
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

            column = new DataGridViewTextBoxColumn
            {
                Name = "Department",
                HeaderText = "Подразделение",
                DataPropertyName = "Department",
                FillWeight = 55
            };

            dgvWorkers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                Name = "Cabinet",
                HeaderText = "Помещение",
                DataPropertyName = "Cabinet",
                FillWeight = 40
            };

            dgvWorkers.Columns.Add(column);


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

        private void RowFilter()
        {
            if (tbSearch.Text == "")
                _dtWorkers.DefaultView.RowFilter = "";
            else
            {
                var rfText = "";

                foreach (DataGridViewColumn clmn in dgvWorkers.Columns)
                {
                    if (!clmn.Visible)
                        continue;

                    if (rfText != "")
                        rfText += " OR ";
                    rfText += "`" + clmn.DataPropertyName + "`" + " LIKE '%" + tbSearch.Text + "%'";
                }

                _dtWorkers.DefaultView.RowFilter = rfText;
            }
        }



        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

            UpdateSystemMenu();

            #region Времянка по наполнению БД

            /*SQLiteConnection conn = DBFunctions.OpenConnection();

            SQLiteCommand comm = conn.CreateCommand();

            comm.CommandText = "INSERT INTO org_structure VALUES(NULL,0,'АК Грузомобиль')";
            comm.ExecuteNonQuery();
            comm.CommandText = "INSERT INTO org_structure VALUES(NULL,1,'Президент компании')";
            comm.ExecuteNonQuery();
            comm.CommandText = "INSERT INTO org_structure VALUES(NULL,4,'Слесарь Вася')";
            comm.ExecuteNonQuery();
            comm.CommandText = "INSERT INTO org_structure VALUES(NULL,1,'АХО')";
            comm.ExecuteNonQuery();

            
            
            
            comm.CommandText = "DELETE FROM workers";
            comm.ExecuteNonQuery();
            

            Bitmap img = new Bitmap("C:\\Dropbox\\Public\\20130812_133607-1.jpg");

            

            comm.CommandText = "INSERT INTO workers VALUES(NULL,'Иванов','Петр','Васильевич',4,'Руководитель ОАБП','313','+79110888155',NULL,302,@picture,NULL,NULL,'3345',NULL)";
            comm.Parameters.AddWithValue("picture", DBFunctions.ImageToByte(img,ImageFormat.Jpeg));
            
            for(int i = 0; i < 1000; i++)
                comm.ExecuteNonQuery();

            comm.CommandText = "INSERT INTO workers VALUES(NULL,'Стасюков','Михаил','Николаевич',1,'Президент корпорации','207',NULL,'+78127030505',305,NULL,NULL,NULL,'3345',2)";
            comm.ExecuteNonQuery();*/

            #endregion

            ControlsAcceptance();
            
            CreateDGVColumns();
            LoadData();           

        }
                
        private void LoadData()
        {
            dgvWorkers.CurrentCellChanged -= dgvWorkers_CurrentCellChanged;
            LoadOrganizationTree();
            LoadDepartments();
            LoadWorkers();

            FillForm();
            dgvWorkers.CurrentCellChanged += dgvWorkers_CurrentCellChanged;

            ActiveControl = tbSearch;
        }

        private void LoadWorkers()
        {
            var deptIdsString = GetDepartmentIdsString();

            _dtWorkers = DBFunctions.ReadFromDB(@"SELECT
            workers.id as id, 
            CONCAT(workers.second_name,' ',workers.name, 
            CASE WHEN NOT ISNULL(workers.third_name) AND workers.third_name <> '' THEN CONCAT(' ',workers.third_name) ELSE '' END) AS FIO,
            IFNULL(Departments.name,'') AS Department, 
            IFNULL(workers.position,'') AS Position,
            IFNULL(workers.second_name,'') AS s_name,
            IFNULL(workers.name,'') AS name,
            IFNULL(workers.third_name,'') AS t_name,
            workers.department AS dept_id,
            IFNULL(workers.phone_official,'') AS phone_official,
            IFNULL(workers.cabinet,'') AS cabinet,
            IFNULL(workers.phone_cell_1,'') AS phone_cell_1,
            IFNULL(workers.phone_cell_2,'') AS phone_cell_2,
            IFNULL(workers.phone_dop,'') AS phone_dop,
            IFNULL(workers.comment,'') AS comment,
            IFNULL(workers.responsibility,'') AS responsibility,
            IFNULL(boss_table.id,0) AS boss_id,
            IFNULL(CONCAT(boss_table.second_name,' ',boss_table.name, 
            CASE WHEN NOT ISNULL(boss_table.third_name) AND boss_table.third_name <> '' THEN CONCAT(' ',boss_table.third_name) ELSE '' END),'') AS boss_fio,
            IFNULL(workers.email_work,'') AS email_work,
            IFNULL(workers.email_personal,'') AS email_personal,
            IFNULL(workers.birthday,'') AS birthday
            FROM workers LEFT JOIN org_structure AS Departments ON workers.department = Departments.id
            LEFT JOIN workers AS boss_table ON workers.boss = boss_table.id
            WHERE Departments.id IN " + deptIdsString
            + " ORDER BY FIO");

            dgvWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkers.AutoGenerateColumns = false;
            dgvWorkers.DataSource = _dtWorkers;

            RowFilter();
        }
               
        private void FillForm()
        {
            var currRow = FindCurrentRow(dgvWorkers);
            if (currRow == null || _dtWorkers.Rows.Count == 0 || _newWorker)
            {                
                tbS_Name.Clear();
                tbName.Clear();
                tbT_Name.Clear();
                tbPosition.Clear();
                tbCabinet.Clear();
                tbOfficialPhone.Clear();
                tbCellPhone1.Clear();
                tbCellPhone2.Clear();
                tbPhoneAdd.Clear();
                tbComment.Clear();
                tbResponsibility.Clear();
                tbBoss.Clear();

                tbEmailWork.Clear();
                tbEmailPersonal.Clear();
                tbBirthday.Clear();

                pbPhoto.Image = null;
                cbDepartment.SelectedItem = null;
                _lastRow = null;
                

                if (_newWorker)
                {
                    cbDepartment.SelectedItem = FindDeptById((long)tvOrganizationStructure.SelectedNode.Tag);
                }

                return;
            }

            if (_lastRow == currRow)
                return;

            if (_editMode && Modified())
            {
                var res = MessageBox.Show(@"Данные были изменены. Сохранить?", @"Сохранение", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                    SaveData();
            }
            
            _lastRow = currRow;

            tbS_Name.Text = (string)currRow["s_name"];
            tbName.Text = (string)currRow["name"];
            tbT_Name.Text = (string)currRow["t_name"];

            tbPosition.Text = (string)currRow["position"];

            tbCabinet.Text = (string)currRow["cabinet"];
            tbOfficialPhone.Text = (string)currRow["phone_official"];
            tbCellPhone1.Text = (string)currRow["phone_cell_1"];
            tbCellPhone2.Text = (string)currRow["phone_cell_2"];

            tbPhoneAdd.Text = (string)currRow["phone_dop"];
            tbComment.Text = (string)currRow["comment"];
            tbResponsibility.Text = (string)currRow["responsibility"];

            tbEmailWork.Text = (string)currRow["email_work"];
            tbEmailPersonal.Text = (string)currRow["email_personal"];
            tbBirthday.Text = (string)currRow["birthday"];

            tbBoss.Text = (string)currRow["boss_fio"];
            tbBoss.Tag = (long)currRow["boss_id"];

            var parameters = new Dictionary<string, object>();
            parameters.Add("id", (long)currRow["id"]);
            var photoByteArray = DBFunctions.ReadScalarFromDB("SELECT photo FROM workers WHERE id = @id",parameters);
            
            if (photoByteArray != DBNull.Value)
            {
                pbPhoto.Image = DBFunctions.ByteToImage((byte[])photoByteArray);
            }
            else
            {
                pbPhoto.Image = null;
            }

            if (currRow["dept_id"] != DBNull.Value)
            {
                cbDepartment.SelectedItem = FindDeptById((long)currRow["dept_id"]);
            }
            else
            {
                cbDepartment.SelectedItem = null;
            }

        }

        private void dgvWorkers_CurrentCellChanged(object sender, EventArgs e)
        {            
            FillForm();
        }

        private void tvOrganizationStructure_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadWorkers();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            var currRow = FindCurrentRow(dgvWorkers);
            if (currRow == null)
                return;

            var openFileDialog = new OpenFileDialog {Filter = "Рисунки|*.png;*.jpg;*.bmp"};

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fi = new FileInfo(openFileDialog.FileName);

                if (fi.Length > 524288)
                {
                    MessageBox.Show("Размер файла не должен быть больше 512Кб");
                    return;
                }                

                if (!_newWorker)
                {

                    var imgByteArray = DBFunctions.ImageToByte(new Bitmap(openFileDialog.FileName), ImageFormat.Png);
                    
                    pbPhoto.Image = DBFunctions.ByteToImage(imgByteArray);

                    var parameters = new Dictionary<string, object>();
                    parameters.Add("id", (long)currRow["id"]);
                    parameters.Add("photo", imgByteArray);
                    DBFunctions.ExecuteCommand("UPDATE workers SET photo = @photo WHERE id = @id", parameters);
            
                }
            }           
            
        }
        
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RowFilter();
        }

        private bool Modified()
        {            
            if (_lastRow == null)
                return false;

            if (tbS_Name.Text != (String)_lastRow["s_name"])
                return true;

            if (tbName.Text != (String)_lastRow["name"])
                return true;

            if (tbT_Name.Text != (String)_lastRow["t_name"])
                return true;

            if (tbPosition.Text != (String)_lastRow["position"])
                return true;

            if (tbCabinet.Text != (String)_lastRow["cabinet"])
                return true;

            if (tbOfficialPhone.Text != (String)_lastRow["phone_official"])
                return true;

            if (tbCellPhone1.Text != (String)_lastRow["phone_cell_1"])
                return true;

            if (tbCellPhone2.Text != (String)_lastRow["phone_cell_2"])
                return true;

            if (tbPhoneAdd.Text != (String)_lastRow["phone_dop"])
                return true;

            if (tbComment.Text != (String)_lastRow["comment"])
                return true;

            if (tbEmailWork.Text != (String)_lastRow["email_work"])
                return true;
            if (tbEmailPersonal.Text != (String)_lastRow["email_personal"])
                return true;
            if (tbBirthday.Text != (String)_lastRow["birthday"])
                return true;

            if (tbResponsibility.Text != (String)_lastRow["responsibility"])
                return true;

            if ((long)tbBoss.Tag != (long)_lastRow["boss_id"])
                return true;
            
            if (_lastRow["dept_id"] == DBNull.Value || ((Department)cbDepartment.SelectedItem).Id != (long)_lastRow["dept_id"])
            {
                return true;
            }

            return false;
        }

        private void SaveData()
        {
            var parameters = new Dictionary<string, object>();
            
            if(!_newWorker)
                parameters.Add("id", _lastRow["id"]);

            parameters.Add("s_name", tbS_Name.Text);
            parameters.Add("name", tbName.Text);
            parameters.Add("t_name", tbT_Name.Text);
            parameters.Add("position", tbPosition.Text);
            parameters.Add("cabinet", tbCabinet.Text);
            parameters.Add("phone_official", tbOfficialPhone.Text);
            parameters.Add("phone_cell_1", tbCellPhone1.Text);
            parameters.Add("phone_cell_2", tbCellPhone2.Text);
            parameters.Add("dept_id", ((Department)cbDepartment.SelectedItem).Id);

            parameters.Add("phone_dop", tbPhoneAdd.Text);
            parameters.Add("responsibility", tbResponsibility.Text);
            parameters.Add("comment", tbComment.Text);

            parameters.Add("email_work", tbEmailWork.Text);
            parameters.Add("email_personal", tbEmailPersonal.Text);
            parameters.Add("birthday", tbBirthday.Text);
            
            parameters.Add("boss", tbBoss.Tag);

            

            if (!_newWorker)
            {
                DBFunctions.ExecuteCommand(@"UPDATE workers SET 
                        second_name = @s_name,
                        name = @name,
                        third_name = @t_name,
                        position = @position,
                        cabinet = @cabinet,
                        phone_official = @phone_official,
                        phone_cell_1 = @phone_cell_1,
                        phone_cell_2 = @phone_cell_2,
                        department = @dept_id,
                        phone_dop = @phone_dop,
                        responsibility = @responsibility,
                        comment = @comment,
                        email_work = @email_work,
                        email_personal = @email_personal,
                        birthday = @birthday,
                        boss = @boss
                        WHERE id = @id", parameters);
            }
            else
            {
                DBFunctions.ExecuteCommand(@"INSERT INTO workers 
                        (second_name,name,third_name,position,cabinet,phone_official,phone_cell_1,phone_cell_2,department,
                        phone_dop,responsibility,comment,boss,email_work,email_personal,birthday)
                        VALUES( 
                        @s_name,
                        @name,
                        @t_name,
                        @position,
                        @cabinet,
                        @phone_official,
                        @phone_cell_1,
                        @phone_cell_2,
                        @dept_id,
                        @phone_dop,                            
                        @responsibility,
                        @comment,
                        @boss,
                        @email_work,
                        @email_personal,
                        @birthday
                        )", parameters);
            }

            if (_newWorker)
            {
                _newWorker = false;

                LoadWorkers();
            }
            else
            {
                _lastRow["fio"] = tbS_Name.Text + " " + tbName.Text;
                if (tbT_Name.Text != "")
                    _lastRow["fio"] += " " + tbT_Name.Text;

                _lastRow["s_name"] = tbS_Name.Text;
                _lastRow["name"] = tbName.Text;
                _lastRow["t_name"] = tbT_Name.Text;
                _lastRow["position"] = tbPosition.Text;
                _lastRow["dept_id"] = ((Department)cbDepartment.SelectedItem).Id;
                _lastRow["department"] = ((Department)cbDepartment.SelectedItem).Name;

                _lastRow["cabinet"] = tbCabinet.Text;
                _lastRow["phone_official"] = tbOfficialPhone.Text;
                _lastRow["phone_cell_1"] = tbCellPhone1.Text;
                _lastRow["phone_cell_2"] = tbCellPhone2.Text;

                _lastRow["phone_dop"] = tbPhoneAdd.Text;
                _lastRow["comment"] = tbComment.Text;
                _lastRow["responsibility"] = tbResponsibility.Text;

                _lastRow["email_work"] = tbEmailWork.Text;
                _lastRow["email_personal"] = tbEmailPersonal.Text;
                _lastRow["birthday"] = tbBirthday.Text;

                _lastRow["boss_id"] = tbBoss.Tag;
                _lastRow["boss_fio"] = tbBoss.Text;

                if (!GetDepartmentIds(tvOrganizationStructure.SelectedNode).Contains((long)_lastRow["dept_id"]))
                {
                    var row2Delete = _lastRow;
                    _lastRow = null;
                    _dtWorkers.Rows.Remove(row2Delete);
                }

            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Modified() || _newWorker)
            {
                SaveData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvWorkers.ClearSelection();
            _lastRow = null;
            _newWorker = true;
            FillForm();
        }

        private void SelectBoss()
        {
            if (!tbBoss.Modified)
                return;

            var bsf = new BossSelectForm();
            bsf.Filter = tbBoss.Text;
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

        private void tbBoss_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbBoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectBoss();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var currRow = FindCurrentRow(dgvWorkers);
            if (currRow == null || _dtWorkers.Rows.Count == 0 || _newWorker)
            {
                return;
            }


            var parameters = new Dictionary<string, object> { { "id", currRow["id"] } };
            DBFunctions.ExecuteCommand("DELETE FROM workers WHERE id=@id", parameters);

            var dtChildWorkers = DBFunctions.ReadFromDB(@"SELECT 
            workers.id as id, 
            workers.second_name || ' ' || workers.name || 
            CASE WHEN workers.third_name NOT NULL AND workers.third_name <> '' THEN ' ' || workers.third_name ELSE '' END AS FIO
            FROM workers WHERE boss = @id",parameters);

            if(dtChildWorkers.Rows.Count == 0)
            {
                DBFunctions.ExecuteCommand("DELETE FROM workers WHERE id=@id", parameters);
                LoadWorkers();
            } else
            {
                string messageText = "Удаление невозможно. Сотрудник является руководителем для: ";

                foreach(DataRow childWorkerRow in dtChildWorkers.Rows)
                {
                    messageText += Environment.NewLine + childWorkerRow["FIO"] + " (" + childWorkerRow["id"] + ")";
                }

                MessageBox.Show(messageText);
            }           

        }


    }
}
