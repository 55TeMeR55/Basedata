namespace Datafirm
{
    partial class Form3
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
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.processTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Datafirm.Database1DataSet();
            this.fIOLeaderComboBox = new System.Windows.Forms.ComboBox();
            this.leaderDepartmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDirectorInfo = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.directorInfoTextBox = new System.Windows.Forms.TextBox();
            this.labelFIOLeader = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.positionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.idPersonTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.departmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.DepartmentTableTableAdapter();
            this.tableAdapterManager = new Datafirm.Database1DataSetTableAdapters.TableAdapterManager();
            this.leaderDepartmentTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter();
            this.positionTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.PositionTableTableAdapter();
            this.processTableTableAdapter = new Datafirm.Database1DataSetTableAdapters.ProcessTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // processComboBox
            // 
            this.processComboBox.DataSource = this.processTableBindingSource;
            this.processComboBox.DisplayMember = "NameProcess";
            this.processComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(149, 119);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(200, 21);
            this.processComboBox.TabIndex = 66;
            this.processComboBox.ValueMember = "IdProcess";
            this.processComboBox.Visible = false;
            // 
            // processTableBindingSource
            // 
            this.processTableBindingSource.DataMember = "ProcessTable";
            this.processTableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIOLeaderComboBox
            // 
            this.fIOLeaderComboBox.DataSource = this.leaderDepartmentTableBindingSource;
            this.fIOLeaderComboBox.DisplayMember = "NameLeaderDepartment";
            this.fIOLeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fIOLeaderComboBox.FormattingEnabled = true;
            this.fIOLeaderComboBox.Location = new System.Drawing.Point(149, 119);
            this.fIOLeaderComboBox.Name = "fIOLeaderComboBox";
            this.fIOLeaderComboBox.Size = new System.Drawing.Size(200, 21);
            this.fIOLeaderComboBox.TabIndex = 65;
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
            this.departmentComboBox.Location = new System.Drawing.Point(149, 119);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(200, 21);
            this.departmentComboBox.TabIndex = 64;
            this.departmentComboBox.ValueMember = "IdDepartment";
            this.departmentComboBox.Visible = false;
            // 
            // departmentTableBindingSource
            // 
            this.departmentTableBindingSource.DataMember = "DepartmentTable";
            this.departmentTableBindingSource.DataSource = this.database1DataSet;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(53, 94);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(68, 13);
            this.labelPosition.TabIndex = 63;
            this.labelPosition.Text = "Должность:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(53, 67);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 13);
            this.labelGender.TabIndex = 62;
            this.labelGender.Text = "Пол:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(54, 41);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(89, 13);
            this.labelBirthday.TabIndex = 61;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(53, 15);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 60;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelDirectorInfo
            // 
            this.labelDirectorInfo.AutoSize = true;
            this.labelDirectorInfo.Location = new System.Drawing.Point(5, 118);
            this.labelDirectorInfo.Name = "labelDirectorInfo";
            this.labelDirectorInfo.Size = new System.Drawing.Size(138, 13);
            this.labelDirectorInfo.TabIndex = 59;
            this.labelDirectorInfo.Text = "Информация о директоре";
            this.labelDirectorInfo.Visible = false;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(33, 118);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(51, 13);
            this.labelProcess.TabIndex = 58;
            this.labelProcess.Text = "Процесс";
            this.labelProcess.Visible = false;
            // 
            // directorInfoTextBox
            // 
            this.directorInfoTextBox.Location = new System.Drawing.Point(149, 118);
            this.directorInfoTextBox.Name = "directorInfoTextBox";
            this.directorInfoTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorInfoTextBox.TabIndex = 57;
            this.directorInfoTextBox.Visible = false;
            // 
            // labelFIOLeader
            // 
            this.labelFIOLeader.AutoSize = true;
            this.labelFIOLeader.Location = new System.Drawing.Point(33, 118);
            this.labelFIOLeader.Name = "labelFIOLeader";
            this.labelFIOLeader.Size = new System.Drawing.Size(110, 13);
            this.labelFIOLeader.TabIndex = 56;
            this.labelFIOLeader.Text = "ФИО руководителя:";
            this.labelFIOLeader.Visible = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(35, 117);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(90, 13);
            this.labelDepartment.TabIndex = 55;
            this.labelDepartment.Text = "Подразделения:";
            this.labelDepartment.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 54;
            this.button2.Text = "Повысить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // positionComboBox
            // 
            this.positionComboBox.DataSource = this.positionTableBindingSource;
            this.positionComboBox.DisplayMember = "NamePosition";
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.Enabled = false;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(149, 88);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(200, 21);
            this.positionComboBox.TabIndex = 53;
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
            this.button1.Location = new System.Drawing.Point(215, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 52;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // idPersonTextBox
            // 
            this.idPersonTextBox.Location = new System.Drawing.Point(149, -17);
            this.idPersonTextBox.Name = "idPersonTextBox";
            this.idPersonTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPersonTextBox.TabIndex = 48;
            this.idPersonTextBox.Visible = false;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.Location = new System.Drawing.Point(149, 9);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 49;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(149, 35);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 50;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderComboBox.Location = new System.Drawing.Point(149, 61);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderComboBox.TabIndex = 51;
            // 
            // departmentTableTableAdapter
            // 
            this.departmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableTableAdapter = this.departmentTableTableAdapter;
            this.tableAdapterManager.LeaderDepartmentTableTableAdapter = this.leaderDepartmentTableTableAdapter;
            this.tableAdapterManager.PersonTableTableAdapter = null;
            this.tableAdapterManager.PositionTableTableAdapter = this.positionTableTableAdapter;
            this.tableAdapterManager.ProcessTableTableAdapter = this.processTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Datafirm.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 209);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.fIOLeaderComboBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelDirectorInfo);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.directorInfoTextBox);
            this.Controls.Add(this.labelFIOLeader);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idPersonTextBox);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.genderComboBox);
            this.Name = "Form3";
            this.Text = "Форма редактирования";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderDepartmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.ComboBox fIOLeaderComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDirectorInfo;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.TextBox directorInfoTextBox;
        private System.Windows.Forms.Label labelFIOLeader;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idPersonTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource departmentTableBindingSource;
        private Database1DataSetTableAdapters.DepartmentTableTableAdapter departmentTableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.LeaderDepartmentTableTableAdapter leaderDepartmentTableTableAdapter;
        private System.Windows.Forms.BindingSource leaderDepartmentTableBindingSource;
        private Database1DataSetTableAdapters.PositionTableTableAdapter positionTableTableAdapter;
        private System.Windows.Forms.BindingSource positionTableBindingSource;
        private Database1DataSetTableAdapters.ProcessTableTableAdapter processTableTableAdapter;
        private System.Windows.Forms.BindingSource processTableBindingSource;
    }
}