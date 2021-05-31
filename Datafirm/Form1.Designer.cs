namespace Datafirm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label directorInfoLabel;
            System.Windows.Forms.Label idPersonLabel;
            System.Windows.Forms.Label processLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label fIOLeaderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Datafirm.Database1DataSet();
            this.personTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.PersonTableTableAdapter();
            this.tableAdapterManager = new Datafirm.Database1DataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.positionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorInfoTextBox = new System.Windows.Forms.TextBox();
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.processTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIOLeaderComboBox = new System.Windows.Forms.ComboBox();
            this.leaderDepartmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPersonTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.personTableDataGridView = new System.Windows.Forms.DataGridView();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.positionTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.PositionTableTableAdapter();
            this.processTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.ProcessTableTableAdapter();
            this.leaderDepartmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter();
            this.departmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.DepartmentTableTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DirectorInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            directorInfoLabel = new System.Windows.Forms.Label();
            idPersonLabel = new System.Windows.Forms.Label();
            processLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            fIOLeaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // directorInfoLabel
            // 
            directorInfoLabel.AutoSize = true;
            directorInfoLabel.Location = new System.Drawing.Point(882, 269);
            directorInfoLabel.Name = "directorInfoLabel";
            directorInfoLabel.Size = new System.Drawing.Size(68, 13);
            directorInfoLabel.TabIndex = 81;
            directorInfoLabel.Text = "Director Info:";
            // 
            // idPersonLabel
            // 
            idPersonLabel.AutoSize = true;
            idPersonLabel.Location = new System.Drawing.Point(882, 61);
            idPersonLabel.Name = "idPersonLabel";
            idPersonLabel.Size = new System.Drawing.Size(55, 13);
            idPersonLabel.TabIndex = 69;
            idPersonLabel.Text = "Id Person:";
            // 
            // processLabel
            // 
            processLabel.AutoSize = true;
            processLabel.Location = new System.Drawing.Point(882, 242);
            processLabel.Name = "processLabel";
            processLabel.Size = new System.Drawing.Size(48, 13);
            processLabel.TabIndex = 80;
            processLabel.Text = "Process:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(882, 87);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(27, 13);
            fIOLabel.TabIndex = 71;
            fIOLabel.Text = "FIO:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(882, 114);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 73;
            birthdayLabel.Text = "Birthday:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(882, 139);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 75;
            genderLabel.Text = "Gender:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(882, 166);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 77;
            positionLabel.Text = "Position:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(882, 192);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 78;
            departmentLabel.Text = "Department:";
            // 
            // fIOLeaderLabel
            // 
            fIOLeaderLabel.AutoSize = true;
            fIOLeaderLabel.Location = new System.Drawing.Point(882, 218);
            fIOLeaderLabel.Name = "fIOLeaderLabel";
            fIOLeaderLabel.Size = new System.Drawing.Size(60, 13);
            fIOLeaderLabel.TabIndex = 79;
            fIOLeaderLabel.Text = "FIOLeader:";
            // 
            // personTableBindingSource
            // 
            this.personTableBindingSource.AllowNew = false;
            this.personTableBindingSource.DataMember = "PersonTable";
            this.personTableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableTableAdapter
            // 
            this.personTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableTableAdapter = null;
            this.tableAdapterManager.LeaderDepartmentTableTableAdapter = null;
            this.tableAdapterManager.PersonTableTableAdapter = this.personTableTableAdapter;
            this.tableAdapterManager.PositionTableTableAdapter = null;
            this.tableAdapterManager.ProcessTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Datafirm.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.personTableBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(866, 25);
            this.bindingNavigator1.TabIndex = 88;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataSource = this.departmentTableBindingSource;
            this.departmentComboBox.DisplayMember = "NameDepartment";
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(953, 189);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(200, 21);
            this.departmentComboBox.TabIndex = 87;
            this.departmentComboBox.ValueMember = "IdDepartment";
            // 
            // departmentTableBindingSource
            // 
            this.departmentTableBindingSource.DataMember = "DepartmentTable";
            this.departmentTableBindingSource.DataSource = this.database1DataSet;
            // 
            // positionComboBox
            // 
            this.positionComboBox.DataSource = this.positionTableBindingSource;
            this.positionComboBox.DisplayMember = "NamePosition";
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(953, 163);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(200, 21);
            this.positionComboBox.TabIndex = 86;
            this.positionComboBox.ValueMember = "IdPosition";
            // 
            // positionTableBindingSource
            // 
            this.positionTableBindingSource.DataMember = "PositionTable";
            this.positionTableBindingSource.DataSource = this.database1DataSet;
            // 
            // directorInfoTextBox
            // 
            this.directorInfoTextBox.Location = new System.Drawing.Point(953, 269);
            this.directorInfoTextBox.Name = "directorInfoTextBox";
            this.directorInfoTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorInfoTextBox.TabIndex = 85;
            // 
            // processComboBox
            // 
            this.processComboBox.DataSource = this.processTableBindingSource;
            this.processComboBox.DisplayMember = "NameProcess";
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(953, 242);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(200, 21);
            this.processComboBox.TabIndex = 84;
            this.processComboBox.ValueMember = "IdProcess";
            // 
            // processTableBindingSource
            // 
            this.processTableBindingSource.DataMember = "ProcessTable";
            this.processTableBindingSource.DataSource = this.database1DataSet;
            // 
            // fIOLeaderComboBox
            // 
            this.fIOLeaderComboBox.DataSource = this.leaderDepartmentTableBindingSource;
            this.fIOLeaderComboBox.DisplayMember = "NameLeaderDepartment";
            this.fIOLeaderComboBox.FormattingEnabled = true;
            this.fIOLeaderComboBox.Location = new System.Drawing.Point(953, 215);
            this.fIOLeaderComboBox.Name = "fIOLeaderComboBox";
            this.fIOLeaderComboBox.Size = new System.Drawing.Size(200, 21);
            this.fIOLeaderComboBox.TabIndex = 83;
            this.fIOLeaderComboBox.ValueMember = "IdLeaderDepartment";
            // 
            // leaderDepartmentTableBindingSource
            // 
            this.leaderDepartmentTableBindingSource.DataMember = "LeaderDepartmentTable";
            this.leaderDepartmentTableBindingSource.DataSource = this.database1DataSet;
            // 
            // idPersonTextBox
            // 
            this.idPersonTextBox.Location = new System.Drawing.Point(953, 58);
            this.idPersonTextBox.Name = "idPersonTextBox";
            this.idPersonTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPersonTextBox.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 69);
            this.button1.TabIndex = 66;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // personTableDataGridView
            // 
            this.personTableDataGridView.AllowUserToAddRows = false;
            this.personTableDataGridView.AllowUserToDeleteRows = false;
            this.personTableDataGridView.AllowUserToResizeColumns = false;
            this.personTableDataGridView.AllowUserToResizeRows = false;
            this.personTableDataGridView.AutoGenerateColumns = false;
            this.personTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Process,
            this.DirectorInfo});
            this.personTableDataGridView.DataSource = this.personTableBindingSource;
            this.personTableDataGridView.Location = new System.Drawing.Point(12, 40);
            this.personTableDataGridView.MultiSelect = false;
            this.personTableDataGridView.Name = "personTableDataGridView";
            this.personTableDataGridView.ReadOnly = true;
            this.personTableDataGridView.Size = new System.Drawing.Size(841, 280);
            this.personTableDataGridView.TabIndex = 63;
            this.personTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonTableDataGridView_CellClick);
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.Location = new System.Drawing.Point(953, 84);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 72;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(953, 110);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 74;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderComboBox.Location = new System.Drawing.Point(953, 136);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderComboBox.TabIndex = 76;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(714, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 69);
            this.button3.TabIndex = 68;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(367, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 69);
            this.button2.TabIndex = 67;
            this.button2.Text = "Посмотреть профиль / редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // positionTableTableAdapter
            // 
            this.positionTableTableAdapter.ClearBeforeFill = true;
            // 
            // processTableTableAdapter
            // 
            this.processTableTableAdapter.ClearBeforeFill = true;
            // 
            // leaderDepartmentTableTableAdapter
            // 
            this.leaderDepartmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableTableAdapter
            // 
            this.departmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(221, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "Включить фильтры";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(604, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 34);
            this.button4.TabIndex = 90;
            this.button4.Text = "Сбросить фильтры";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.positionTableBindingSource;
            this.comboBox1.DisplayMember = "NamePosition";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.ValueMember = "IdPosition";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departmentTableBindingSource;
            this.comboBox2.DisplayMember = "NameDepartment";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(476, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 92;
            this.comboBox2.ValueMember = "IdDepartment";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPerson";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPerson";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn5.DataSource = this.positionTableBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "NamePosition";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "IdPosition";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn6.DataSource = this.departmentTableBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "NameDepartment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Подразделение";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdDepartment";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FIOLeader";
            this.dataGridViewTextBoxColumn7.DataSource = this.leaderDepartmentTableBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "NameLeaderDepartment";
            this.dataGridViewTextBoxColumn7.HeaderText = "ФИО руководителя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "IdLeaderDepartment";
            // 
            // Process
            // 
            this.Process.DataPropertyName = "Process";
            this.Process.DataSource = this.processTableBindingSource;
            this.Process.DisplayMember = "NameProcess";
            this.Process.HeaderText = "Процесс";
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            this.Process.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Process.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Process.ValueMember = "IdProcess";
            // 
            // DirectorInfo
            // 
            this.DirectorInfo.DataPropertyName = "DirectorInfo";
            this.DirectorInfo.HeaderText = "Информация о директоре";
            this.DirectorInfo.Name = "DirectorInfo";
            this.DirectorInfo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 405);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(directorInfoLabel);
            this.Controls.Add(idPersonLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.directorInfoTextBox);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.fIOLeaderComboBox);
            this.Controls.Add(this.idPersonTextBox);
            this.Controls.Add(processLabel);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(positionLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(fIOLeaderLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personTableDataGridView);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource personTableBindingSource;
        public Database1DataSet database1DataSet;
        public Database1DataSetTableAdapters.PersonTableTableAdapter personTableTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ComboBox departmentComboBox;
        public System.Windows.Forms.ComboBox positionComboBox;
        public System.Windows.Forms.TextBox directorInfoTextBox;
        public System.Windows.Forms.ComboBox processComboBox;
        public System.Windows.Forms.ComboBox fIOLeaderComboBox;
        public System.Windows.Forms.TextBox idPersonTextBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView personTableDataGridView;
        public System.Windows.Forms.TextBox fIOTextBox;
        public System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        public System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource positionTableBindingSource;
        private Database1DataSetTableAdapters.PositionTableTableAdapter positionTableTableAdapter;
        private System.Windows.Forms.BindingSource processTableBindingSource;
        private Database1DataSetTableAdapters.ProcessTableTableAdapter processTableTableAdapter;
        private System.Windows.Forms.BindingSource departmentTableBindingSource;
        private Database1DataSetTableAdapters.DepartmentTableTableAdapter departmentTableTableAdapter;
        public Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter leaderDepartmentTableTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.BindingSource leaderDepartmentTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorInfo;
    }
}