namespace Datafirm
{
    partial class Form2
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
            this.personTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Datafirm.Database1DataSet();
            this.personTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.PersonTableTableAdapter();
            this.tableAdapterManager = new Datafirm.Database1DataSetTableAdapters.TableAdapterManager();
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.processTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIOLeaderComboBox = new System.Windows.Forms.ComboBox();
            this.leaderDepartmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDirectorInfo = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.directorInfoTextBox = new System.Windows.Forms.TextBox();
            this.labelFIOLeader = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.positionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.idPersonTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.departmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.DepartmentTableTableAdapter();
            this.leaderDepartmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter();
            this.positionTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.PositionTableTableAdapter();
            this.processTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.ProcessTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personTableBindingSource
            // 
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
            // processComboBox
            // 
            this.processComboBox.DataSource = this.processTableBindingSource;
            this.processComboBox.DisplayMember = "NameProcess";
            this.processComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(148, 111);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(200, 21);
            this.processComboBox.TabIndex = 52;
            this.processComboBox.ValueMember = "IdProcess";
            this.processComboBox.Visible = false;
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
            this.fIOLeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fIOLeaderComboBox.FormattingEnabled = true;
            this.fIOLeaderComboBox.Location = new System.Drawing.Point(148, 112);
            this.fIOLeaderComboBox.Name = "fIOLeaderComboBox";
            this.fIOLeaderComboBox.Size = new System.Drawing.Size(200, 21);
            this.fIOLeaderComboBox.TabIndex = 51;
            this.fIOLeaderComboBox.ValueMember = "IdLeaderDepartment";
            this.fIOLeaderComboBox.Visible = false;
            // 
            // leaderDepartmentTableBindingSource
            // 
            this.leaderDepartmentTableBindingSource.DataMember = "LeaderDepartmentTable";
            this.leaderDepartmentTableBindingSource.DataSource = this.database1DataSet;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataSource = this.departmentTableBindingSource;
            this.departmentComboBox.DisplayMember = "NameDepartment";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(148, 111);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(200, 21);
            this.departmentComboBox.TabIndex = 50;
            this.departmentComboBox.ValueMember = "IdDepartment";
            this.departmentComboBox.Visible = false;
            // 
            // departmentTableBindingSource
            // 
            this.departmentTableBindingSource.DataMember = "DepartmentTable";
            this.departmentTableBindingSource.DataSource = this.database1DataSet;
            // 
            // labelDirectorInfo
            // 
            this.labelDirectorInfo.AutoSize = true;
            this.labelDirectorInfo.Location = new System.Drawing.Point(4, 115);
            this.labelDirectorInfo.Name = "labelDirectorInfo";
            this.labelDirectorInfo.Size = new System.Drawing.Size(138, 13);
            this.labelDirectorInfo.TabIndex = 49;
            this.labelDirectorInfo.Text = "Информация о директоре";
            this.labelDirectorInfo.Visible = false;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(32, 115);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(51, 13);
            this.labelProcess.TabIndex = 48;
            this.labelProcess.Text = "Процесс";
            this.labelProcess.Visible = false;
            // 
            // directorInfoTextBox
            // 
            this.directorInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personTableBindingSource, "DirectorInfo", true));
            this.directorInfoTextBox.Location = new System.Drawing.Point(148, 113);
            this.directorInfoTextBox.Name = "directorInfoTextBox";
            this.directorInfoTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorInfoTextBox.TabIndex = 47;
            this.directorInfoTextBox.Visible = false;
            // 
            // labelFIOLeader
            // 
            this.labelFIOLeader.AutoSize = true;
            this.labelFIOLeader.Location = new System.Drawing.Point(32, 115);
            this.labelFIOLeader.Name = "labelFIOLeader";
            this.labelFIOLeader.Size = new System.Drawing.Size(110, 13);
            this.labelFIOLeader.TabIndex = 46;
            this.labelFIOLeader.Text = "ФИО руководителя:";
            this.labelFIOLeader.Visible = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(34, 114);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(90, 13);
            this.labelDepartment.TabIndex = 45;
            this.labelDepartment.Text = "Подразделения:";
            this.labelDepartment.Visible = false;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(33, 89);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(68, 13);
            this.labelPosition.TabIndex = 44;
            this.labelPosition.Text = "Должность:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(33, 62);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 13);
            this.labelGender.TabIndex = 43;
            this.labelGender.Text = "Пол:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(34, 36);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(89, 13);
            this.labelBirthday.TabIndex = 42;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(33, 10);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 41;
            this.labelFIO.Text = "ФИО:";
            // 
            // positionComboBox
            // 
            this.positionComboBox.DataSource = this.positionTableBindingSource;
            this.positionComboBox.DisplayMember = "NamePosition";
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(148, 86);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(200, 21);
            this.positionComboBox.TabIndex = 40;
            this.positionComboBox.ValueMember = "IdPosition";
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // positionTableBindingSource
            // 
            this.positionTableBindingSource.DataMember = "PositionTable";
            this.positionTableBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Создать запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // idPersonTextBox
            // 
            this.idPersonTextBox.Location = new System.Drawing.Point(176, -20);
            this.idPersonTextBox.Name = "idPersonTextBox";
            this.idPersonTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPersonTextBox.TabIndex = 35;
            this.idPersonTextBox.Visible = false;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.Location = new System.Drawing.Point(148, 7);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 36;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(148, 33);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 37;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderComboBox.Location = new System.Drawing.Point(148, 59);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderComboBox.TabIndex = 38;
            // 
            // departmentTableTableAdapter
            // 
            this.departmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // leaderDepartmentTableTableAdapter
            // 
            this.leaderDepartmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableTableAdapter
            // 
            this.positionTableTableAdapter.ClearBeforeFill = true;
            // 
            // processTableTableAdapter
            // 
            this.processTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 182);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.fIOLeaderComboBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.labelDirectorInfo);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.directorInfoTextBox);
            this.Controls.Add(this.labelFIOLeader);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idPersonTextBox);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.genderComboBox);
            this.Name = "Form2";
            this.Text = "Форма создания записи";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource personTableBindingSource;
        private Database1DataSetTableAdapters.PersonTableTableAdapter personTableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.ComboBox fIOLeaderComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label labelDirectorInfo;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.TextBox directorInfoTextBox;
        private System.Windows.Forms.Label labelFIOLeader;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idPersonTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.BindingSource departmentTableBindingSource;
        private Database1DataSetTableAdapters.DepartmentTableTableAdapter departmentTableTableAdapter;
        private System.Windows.Forms.BindingSource leaderDepartmentTableBindingSource;
        private Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter leaderDepartmentTableTableAdapter;
        private System.Windows.Forms.BindingSource positionTableBindingSource;
        private Database1DataSetTableAdapters.PositionTableTableAdapter positionTableTableAdapter;
        private System.Windows.Forms.BindingSource processTableBindingSource;
        private Database1DataSetTableAdapters.ProcessTableTableAdapter processTableTableAdapter;
    }
}