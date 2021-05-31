using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datafirm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ProcessTable". При необходимости она может быть перемещена или удалена.
            this.processTableTableAdapter.Fill(this.database1DataSet.ProcessTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PositionTable". При необходимости она может быть перемещена или удалена.
            this.positionTableTableAdapter.Fill(this.database1DataSet.PositionTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.LeaderDepartmentTable". При необходимости она может быть перемещена или удалена.
            this.leaderDepartmentTableTableAdapter.Fill(this.database1DataSet.LeaderDepartmentTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.DepartmentTable". При необходимости она может быть перемещена или удалена.
            this.departmentTableTableAdapter.Fill(this.database1DataSet.DepartmentTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PersonTable". При необходимости она может быть перемещена или удалена.
            this.personTableTableAdapter.Fill(this.database1DataSet.PersonTable);
            Form1 main = Owner as Form1;
            if (main != null)
            {
                int ID = Properties.Settings.Default.Parameter;//Переменная отвечающая за индекс в таблице руководитель подразделения
                if (idPersonTextBox.Text == "")
                {
                    idPersonTextBox.Text = ID.ToString();
                }
                birthdayDateTimePicker.Value = DateTime.Today;//Актуальная дата
            }
            positionComboBox.SelectedValue = 1;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (genderComboBox.Text.Length ==1 && fIOTextBox.Text.Length >= 1)
            {
                Form1 main = Owner as Form1;
                if (main != null)
                {
                    int department = 0;
                    if (departmentComboBox.Text.Length > 0)
                    {
                        if (int.Parse(departmentComboBox.SelectedValue.ToString()) >= 1)
                        {
                            department = int.Parse(departmentComboBox.SelectedValue.ToString());
                        }
                    }
                    int position = 0;
                    if (positionComboBox.Text.Length > 0)
                    {
                        if (int.Parse(positionComboBox.SelectedValue.ToString()) >= 1)
                        {
                            position = int.Parse(positionComboBox.SelectedValue.ToString());
                        }
                    }
                    int leader = 0;
                    if (fIOLeaderComboBox.Text.Length > 0)
                    {
                        if (int.Parse(fIOLeaderComboBox.SelectedValue.ToString()) >= 1)
                        {
                            leader = int.Parse(fIOLeaderComboBox.SelectedValue.ToString());
                        }
                    }
                    int process = 0;
                    if (processComboBox.Text.Length > 0)
                    {
                        if (int.Parse(processComboBox.SelectedValue.ToString()) >= 1)
                        {
                            process = int.Parse(processComboBox.SelectedValue.ToString());
                        }
                    }
                    main.personTableTableAdapter.Insert(fIOTextBox.Text, birthdayDateTimePicker.Value, genderComboBox.Text, department,  leader,  position, process, directorInfoTextBox.Text);//Запись в бд
                    main.UpdateDateBasa();//Обновить бд
                    if (position == 3)
                    {
                        main.leaderDepartmentTableTableAdapter.Insert(int.Parse(idPersonTextBox.Text), fIOTextBox.Text);//Если добавляем руководителя подразделения то его добавляем как и в таблицу person так и в таблицу leaderDepartment
                        main.UpdateDateBasa1();
                    }
                    MessageBox.Show("Запись прошла успешно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.Parameter = Properties.Settings.Default.Parameter + 1;//обновляем значение переменной
                    this.Close();
                    main.FunctionAddInfo(0);
                }
            }
            else if(genderComboBox.Text.Length == 1)
            {
                MessageBox.Show("Проверьте заполнение поля 'ФИО'", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  MessageBox.Show("Проверьте заполнение поля 'Пол'", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int switchUniqueInformation = 0;

            if (positionComboBox.Text.Length > 0)
            {
                if (!(int.Parse(positionComboBox.SelectedValue.ToString()) == null))
                {
                    switchUniqueInformation = int.Parse(positionComboBox.SelectedValue.ToString());
                }
            }
            //int switchUniqueInformation = int.Parse(positionComboBox.SelectedValue.ToString());
            switch (switchUniqueInformation)
            {
                case 0://скрываем незадействованные поля и зануляем им
                    fIOLeaderComboBox.Visible = false;
                    labelFIOLeader.Visible = false;

                    processComboBox.Visible = false;
                    labelProcess.Visible = false;

                    departmentComboBox.Visible = false;
                    labelDepartment.Visible = false;

                    directorInfoTextBox.Visible = false;
                    labelDirectorInfo.Visible = false;

                    fIOLeaderComboBox.SelectedValue = 0;
                    processComboBox.SelectedValue = 0;
                    departmentComboBox.SelectedValue = 0;
                    directorInfoTextBox.Text = "";
                    break;
                case 1:
                    fIOLeaderComboBox.Visible = true;
                    labelFIOLeader.Visible = true;

                    processComboBox.Visible = false;
                    labelProcess.Visible = false;

                    departmentComboBox.Visible = false;
                    labelDepartment.Visible = false;

                    directorInfoTextBox.Visible = false;
                    labelDirectorInfo.Visible = false;


                    processComboBox.SelectedValue = 0;
                    departmentComboBox.SelectedValue = 0;
                    directorInfoTextBox.Text = "";

                    break;
                case 2:
                    fIOLeaderComboBox.Visible = false;
                    labelFIOLeader.Visible = false;

                    processComboBox.Visible = true;
                    labelProcess.Visible = true;

                    departmentComboBox.Visible = false;
                    labelDepartment.Visible = false;

                    directorInfoTextBox.Visible = false;
                    labelDirectorInfo.Visible = false;

                    fIOLeaderComboBox.SelectedValue = 0;

                    departmentComboBox.SelectedValue = 0;
                    directorInfoTextBox.Text = "";
                    break;
                case 3:
                    fIOLeaderComboBox.Visible = false;
                    labelFIOLeader.Visible = false;

                    processComboBox.Visible = false;
                    labelProcess.Visible = false;

                    departmentComboBox.Visible = true;
                    labelDepartment.Visible = true;

                    directorInfoTextBox.Visible = false;
                    labelDirectorInfo.Visible = false;

                    fIOLeaderComboBox.SelectedValue = 0;
                    processComboBox.SelectedValue = 0;

                    directorInfoTextBox.Text = "";
                    break;
                case 4:
                    fIOLeaderComboBox.Visible = false;
                    labelFIOLeader.Visible = false;

                    processComboBox.Visible = false;
                    labelProcess.Visible = false;

                    departmentComboBox.Visible = false;
                    labelDepartment.Visible = false;

                    directorInfoTextBox.Visible = true;
                    labelDirectorInfo.Visible = true;

                    fIOLeaderComboBox.SelectedValue = 0;
                    processComboBox.SelectedValue = 0;
                    departmentComboBox.SelectedValue = 0;

                    break;
                default:
                    MessageBox.Show("Дальше повышать некуда!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
