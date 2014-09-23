namespace TelSpr
{
    partial class TelSprMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Администрация");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("АК Грузомобиль", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelSprMainForm));
            this.verticalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tvOrganizationStructure = new System.Windows.Forms.TreeView();
            this.btnExpandTree = new System.Windows.Forms.Button();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmailPersonal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmailWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResponsibility = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBoss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhoneAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCellPhone2 = new System.Windows.Forms.TextBox();
            this.labelCellPhone2 = new System.Windows.Forms.Label();
            this.tbCellPhone1 = new System.Windows.Forms.TextBox();
            this.labelCellPhone1 = new System.Windows.Forms.Label();
            this.tbCabinet = new System.Windows.Forms.TextBox();
            this.labelCabinet = new System.Windows.Forms.Label();
            this.tbOfficialPhone = new System.Windows.Forms.TextBox();
            this.labelOfficialPhone = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbT_Name = new System.Windows.Forms.TextBox();
            this.tbS_Name = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.cmOrganizationTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddOrgUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteOrgUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditOrgUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalSplitContainer.Panel1.SuspendLayout();
            this.verticalSplitContainer.Panel2.SuspendLayout();
            this.verticalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.cmOrganizationTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // verticalSplitContainer
            // 
            this.verticalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.verticalSplitContainer.IsSplitterFixed = true;
            this.verticalSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verticalSplitContainer.Name = "verticalSplitContainer";
            // 
            // verticalSplitContainer.Panel1
            // 
            this.verticalSplitContainer.Panel1.Controls.Add(this.tvOrganizationStructure);
            this.verticalSplitContainer.Panel1.Controls.Add(this.btnExpandTree);
            // 
            // verticalSplitContainer.Panel2
            // 
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbBirthday);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label7);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbEmailPersonal);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label6);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbEmailWork);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label5);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbComment);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label4);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbResponsibility);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label3);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbBoss);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label2);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbPhoneAdd);
            this.verticalSplitContainer.Panel2.Controls.Add(this.label1);
            this.verticalSplitContainer.Panel2.Controls.Add(this.btnDelete);
            this.verticalSplitContainer.Panel2.Controls.Add(this.btnAdd);
            this.verticalSplitContainer.Panel2.Controls.Add(this.btnSave);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbCellPhone2);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelCellPhone2);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbCellPhone1);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelCellPhone1);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbCabinet);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelCabinet);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbOfficialPhone);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelOfficialPhone);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbPosition);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelPosition);
            this.verticalSplitContainer.Panel2.Controls.Add(this.cbDepartment);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelDepartment);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbName);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbT_Name);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbS_Name);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelFIO);
            this.verticalSplitContainer.Panel2.Controls.Add(this.pbPhoto);
            this.verticalSplitContainer.Panel2.Controls.Add(this.dgvWorkers);
            this.verticalSplitContainer.Panel2.Controls.Add(this.tbSearch);
            this.verticalSplitContainer.Panel2.Controls.Add(this.labelSearch);
            this.verticalSplitContainer.Size = new System.Drawing.Size(1184, 673);
            this.verticalSplitContainer.SplitterDistance = 300;
            this.verticalSplitContainer.SplitterWidth = 2;
            this.verticalSplitContainer.TabIndex = 0;
            // 
            // tvOrganizationStructure
            // 
            this.tvOrganizationStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOrganizationStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvOrganizationStructure.HideSelection = false;
            this.tvOrganizationStructure.Location = new System.Drawing.Point(0, 0);
            this.tvOrganizationStructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvOrganizationStructure.Name = "tvOrganizationStructure";
            treeNode1.Name = "Администрация";
            treeNode1.Text = "Администрация";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "АК Грузомобиль";
            this.tvOrganizationStructure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvOrganizationStructure.Size = new System.Drawing.Size(275, 673);
            this.tvOrganizationStructure.TabIndex = 1;
            this.tvOrganizationStructure.TabStop = false;
            this.tvOrganizationStructure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOrganizationStructure_AfterSelect);
            this.tvOrganizationStructure.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvOrganizationStructure_NodeMouseClick);
            // 
            // btnExpandTree
            // 
            this.btnExpandTree.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExpandTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpandTree.Location = new System.Drawing.Point(275, 0);
            this.btnExpandTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpandTree.Name = "btnExpandTree";
            this.btnExpandTree.Size = new System.Drawing.Size(25, 673);
            this.btnExpandTree.TabIndex = 0;
            this.btnExpandTree.TabStop = false;
            this.btnExpandTree.Text = "<";
            this.btnExpandTree.UseVisualStyleBackColor = true;
            this.btnExpandTree.Click += new System.EventHandler(this.btnExpandTree_Click);
            // 
            // tbBirthday
            // 
            this.tbBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBirthday.Location = new System.Drawing.Point(168, 638);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(129, 29);
            this.tbBirthday.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Дата рождения";
            // 
            // tbEmailPersonal
            // 
            this.tbEmailPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmailPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmailPersonal.Location = new System.Drawing.Point(556, 534);
            this.tbEmailPersonal.Name = "tbEmailPersonal";
            this.tbEmailPersonal.Size = new System.Drawing.Size(320, 29);
            this.tbEmailPersonal.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(486, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "личная";
            // 
            // tbEmailWork
            // 
            this.tbEmailWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmailWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmailWork.Location = new System.Drawing.Point(147, 534);
            this.tbEmailWork.Name = "tbEmailWork";
            this.tbEmailWork.Size = new System.Drawing.Size(315, 29);
            this.tbEmailWork.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Почта рабочая";
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComment.Location = new System.Drawing.Point(147, 603);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(729, 29);
            this.tbComment.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Комментарий";
            // 
            // tbResponsibility
            // 
            this.tbResponsibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbResponsibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResponsibility.Location = new System.Drawing.Point(147, 568);
            this.tbResponsibility.Name = "tbResponsibility";
            this.tbResponsibility.Size = new System.Drawing.Size(729, 29);
            this.tbResponsibility.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Обязанности";
            // 
            // tbBoss
            // 
            this.tbBoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBoss.Location = new System.Drawing.Point(321, 499);
            this.tbBoss.Name = "tbBoss";
            this.tbBoss.Size = new System.Drawing.Size(526, 29);
            this.tbBoss.TabIndex = 17;
            this.tbBoss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBoss_KeyDown);
            this.tbBoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBoss_KeyPress);
            this.tbBoss.Leave += new System.EventHandler(this.tbBoss_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Руководитель";
            // 
            // tbPhoneAdd
            // 
            this.tbPhoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPhoneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhoneAdd.Location = new System.Drawing.Point(520, 429);
            this.tbPhoneAdd.Name = "tbPhoneAdd";
            this.tbPhoneAdd.Size = new System.Drawing.Size(139, 29);
            this.tbPhoneAdd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Доп. тел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(644, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 31);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(524, 638);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 31);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(763, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 31);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCellPhone2
            // 
            this.tbCellPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCellPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCellPhone2.Location = new System.Drawing.Point(681, 464);
            this.tbCellPhone2.Name = "tbCellPhone2";
            this.tbCellPhone2.Size = new System.Drawing.Size(196, 29);
            this.tbCellPhone2.TabIndex = 16;
            // 
            // labelCellPhone2
            // 
            this.labelCellPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCellPhone2.AutoSize = true;
            this.labelCellPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCellPhone2.Location = new System.Drawing.Point(566, 466);
            this.labelCellPhone2.Name = "labelCellPhone2";
            this.labelCellPhone2.Size = new System.Drawing.Size(105, 24);
            this.labelCellPhone2.TabIndex = 15;
            this.labelCellPhone2.Text = "Сот. тел. 2";
            this.labelCellPhone2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCellPhone1
            // 
            this.tbCellPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCellPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCellPhone1.Location = new System.Drawing.Point(321, 464);
            this.tbCellPhone1.Name = "tbCellPhone1";
            this.tbCellPhone1.Size = new System.Drawing.Size(225, 29);
            this.tbCellPhone1.TabIndex = 14;
            // 
            // labelCellPhone1
            // 
            this.labelCellPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCellPhone1.AutoSize = true;
            this.labelCellPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCellPhone1.Location = new System.Drawing.Point(163, 466);
            this.labelCellPhone1.Name = "labelCellPhone1";
            this.labelCellPhone1.Size = new System.Drawing.Size(146, 24);
            this.labelCellPhone1.TabIndex = 13;
            this.labelCellPhone1.Text = "Сотовый тел. 1";
            // 
            // tbCabinet
            // 
            this.tbCabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCabinet.Location = new System.Drawing.Point(783, 429);
            this.tbCabinet.Name = "tbCabinet";
            this.tbCabinet.Size = new System.Drawing.Size(93, 29);
            this.tbCabinet.TabIndex = 12;
            // 
            // labelCabinet
            // 
            this.labelCabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCabinet.AutoSize = true;
            this.labelCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCabinet.Location = new System.Drawing.Point(665, 431);
            this.labelCabinet.Name = "labelCabinet";
            this.labelCabinet.Size = new System.Drawing.Size(115, 24);
            this.labelCabinet.TabIndex = 11;
            this.labelCabinet.Text = "Помещение";
            // 
            // tbOfficialPhone
            // 
            this.tbOfficialPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOfficialPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOfficialPhone.Location = new System.Drawing.Point(321, 429);
            this.tbOfficialPhone.Name = "tbOfficialPhone";
            this.tbOfficialPhone.Size = new System.Drawing.Size(91, 29);
            this.tbOfficialPhone.TabIndex = 10;
            // 
            // labelOfficialPhone
            // 
            this.labelOfficialPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOfficialPhone.AutoSize = true;
            this.labelOfficialPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfficialPhone.Location = new System.Drawing.Point(163, 431);
            this.labelOfficialPhone.Name = "labelOfficialPhone";
            this.labelOfficialPhone.Size = new System.Drawing.Size(154, 24);
            this.labelOfficialPhone.TabIndex = 9;
            this.labelOfficialPhone.Text = "Служебный тел.";
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPosition.Location = new System.Drawing.Point(321, 394);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(556, 29);
            this.tbPosition.TabIndex = 8;
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(163, 396);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(112, 24);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Должность";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(321, 356);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(556, 32);
            this.cbDepartment.TabIndex = 6;
            // 
            // labelDepartment
            // 
            this.labelDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.Location = new System.Drawing.Point(161, 358);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(154, 24);
            this.labelDepartment.TabIndex = 5;
            this.labelDepartment.Text = "Подразделение";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(500, 321);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 29);
            this.tbName.TabIndex = 3;
            // 
            // tbT_Name
            // 
            this.tbT_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbT_Name.Location = new System.Drawing.Point(693, 321);
            this.tbT_Name.Name = "tbT_Name";
            this.tbT_Name.Size = new System.Drawing.Size(184, 29);
            this.tbT_Name.TabIndex = 4;
            // 
            // tbS_Name
            // 
            this.tbS_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbS_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbS_Name.Location = new System.Drawing.Point(241, 321);
            this.tbS_Name.Name = "tbS_Name";
            this.tbS_Name.Size = new System.Drawing.Size(252, 29);
            this.tbS_Name.TabIndex = 2;
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(161, 324);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(54, 24);
            this.labelFIO.TabIndex = 4;
            this.labelFIO.Text = "ФИО";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto.Location = new System.Drawing.Point(7, 322);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(150, 200);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 3;
            this.pbPhoto.TabStop = false;
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToResizeRows = false;
            this.dgvWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(5, 44);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.RowHeadersVisible = false;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(872, 272);
            this.dgvWorkers.TabIndex = 2;
            this.dgvWorkers.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(83, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(794, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(12, 10);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(64, 24);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Поиск";
            // 
            // cmOrganizationTree
            // 
            this.cmOrganizationTree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmOrganizationTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddOrgUnit,
            this.menuEditOrgUnit,
            this.menuDeleteOrgUnit});
            this.cmOrganizationTree.Name = "cmOrganizationTree";
            this.cmOrganizationTree.Size = new System.Drawing.Size(302, 104);
            this.cmOrganizationTree.Opening += new System.ComponentModel.CancelEventHandler(this.cmOrganizationTree_Opening);
            // 
            // menuAddOrgUnit
            // 
            this.menuAddOrgUnit.Name = "menuAddOrgUnit";
            this.menuAddOrgUnit.Size = new System.Drawing.Size(301, 26);
            this.menuAddOrgUnit.Text = "Добавить подразделение";
            this.menuAddOrgUnit.Click += new System.EventHandler(this.menuAddOrgUnit_Click);
            // 
            // menuDeleteOrgUnit
            // 
            this.menuDeleteOrgUnit.Name = "menuDeleteOrgUnit";
            this.menuDeleteOrgUnit.Size = new System.Drawing.Size(301, 26);
            this.menuDeleteOrgUnit.Text = "Удалить подразделение";
            this.menuDeleteOrgUnit.Click += new System.EventHandler(this.menuDeleteOrgUnit_Click);
            // 
            // menuEditOrgUnit
            // 
            this.menuEditOrgUnit.Name = "menuEditOrgUnit";
            this.menuEditOrgUnit.Size = new System.Drawing.Size(301, 26);
            this.menuEditOrgUnit.Text = "Редактировать подразделение";
            this.menuEditOrgUnit.Click += new System.EventHandler(this.menuEditOrgUnit_Click);
            // 
            // TelSprMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 673);
            this.Controls.Add(this.verticalSplitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelSprMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонный справочник АК ГРУЗОМОБИЛЬ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.verticalSplitContainer.Panel1.ResumeLayout(false);
            this.verticalSplitContainer.Panel2.ResumeLayout(false);
            this.verticalSplitContainer.Panel2.PerformLayout();
            this.verticalSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.cmOrganizationTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer verticalSplitContainer;
        private System.Windows.Forms.Button btnExpandTree;
        private System.Windows.Forms.TreeView tvOrganizationStructure;
        private System.Windows.Forms.ContextMenuStrip cmOrganizationTree;
        private System.Windows.Forms.ToolStripMenuItem menuAddOrgUnit;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteOrgUnit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox tbS_Name;
        private System.Windows.Forms.TextBox tbT_Name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox tbCabinet;
        private System.Windows.Forms.Label labelCabinet;
        private System.Windows.Forms.TextBox tbOfficialPhone;
        private System.Windows.Forms.Label labelOfficialPhone;
        private System.Windows.Forms.TextBox tbCellPhone2;
        private System.Windows.Forms.Label labelCellPhone2;
        private System.Windows.Forms.TextBox tbCellPhone1;
        private System.Windows.Forms.Label labelCellPhone1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbPhoneAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResponsibility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmailPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmailWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem menuEditOrgUnit;
    }
}

