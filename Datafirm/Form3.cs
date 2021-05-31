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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool UpdateToLeaderDepartment = false, UpdateToDirector = false;
        private void Form3_Load(object sender, EventArgs e)
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
            Form1 main = Owner as Form1;
            if (main != null)
            {//считаваем информацию об сотруднике
                idPersonTextBox.Text = main.idPersonTextBox.Text;
                fIOTextBox.Text = main.fIOTextBox.Text;
                birthdayDateTimePicker.Value = main.birthdayDateTimePicker.Value;
                genderComboBox.Text = main.genderComboBox.Text;
                positionComboBox.SelectedValue = main.positionComboBox.SelectedValue;
                departmentComboBox.SelectedValue = main.departmentComboBox.SelectedValue;
                fIOLeaderComboBox.SelectedValue = main.fIOLeaderComboBox.SelectedValue;
                processComboBox.SelectedValue = main.processComboBox.SelectedValue;
                directorInfoTextBox.Text = main.directorInfoTextBox.Text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
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
                int origdepartment = 0;
                if (main.departmentComboBox.Text.Length > 0)
                {
                    if (int.Parse(main.departmentComboBox.SelectedValue.ToString()) >= 1)
                    {
                        origdepartment = int.Parse(main.departmentComboBox.SelectedValue.ToString());
                    }
                }
                int origposition = 0;
                if (main.positionComboBox.Text.Length > 0)
                {
                    if (int.Parse(main.positionComboBox.SelectedValue.ToString()) >= 1)
                    {
                        origposition = int.Parse(main.positionComboBox.SelectedValue.ToString());
                    }
                }
                int origleader = 0;
                if (main.fIOLeaderComboBox.Text.Length > 0)
                {
                    if (int.Parse(main.fIOLeaderComboBox.SelectedValue.ToString()) >= 1)
                    {
                        origleader = int.Parse(main.fIOLeaderComboBox.SelectedValue.ToString());
                    }
                }
                int origprocess = 0;
                if (main.processComboBox.Text.Length > 0)
                {
                    if (int.Parse(main.processComboBox.SelectedValue.ToString()) >= 1)
                    {
                        origprocess = int.Parse(main.processComboBox.SelectedValue.ToString());
                    }
                }
                main.personTableTableAdapter.Update(fIOTextBox.Text, birthdayDateTimePicker.Value, genderComboBox.Text, department,  leader,  position, process, directorInfoTextBox.Text, int.Parse(idPersonTextBox.Text), main.fIOTextBox.Text, main.birthdayDateTimePicker.Value, main.genderComboBox.Text, origdepartment, origleader, origposition, origprocess, main.directorInfoTextBox.Text, int.Parse(main.idPersonTextBox.Text));
                if (position == 3 && UpdateToLeaderDepartment == true)//если мы повышаем контролера до руководителя то вносим изменения как в главную так и в второстепенную таблицу
                {
                    main.leaderDepartmentTableTableAdapter.Insert(int.Parse(idPersonTextBox.Text), fIOTextBox.Text);//запись в соответствующую таблицу
                    main.UpdateDateBasa1();
                    main.UpdateDateBasa();//обнова
                }
                else if(position == 3 && UpdateToLeaderDepartment == false)
                {
                    main.leaderDepartmentTableTableAdapter.Update(int.Parse(idPersonTextBox.Text), fIOTextBox.Text, int.Parse(main.idPersonTextBox.Text), main.fIOTextBox.Text);//если мы изменяем у руководителя что либо кто ме должности то обновляем соот. запись
                    main.UpdateDateBasa1();
                    main.UpdateDateBasa();
                }
                if (position == 4 && UpdateToDirector == true)//если это руководитель и его повысили до директора то 
                {
                    main.leaderDepartmentTableTableAdapter.Delete(int.Parse(idPersonTextBox.Text),fIOTextBox.Text);
                    main.UpdateDateBasa1();
                    main.UpdateDateBasa();
                }
                    MessageBox.Show("Обновление прошло успешно!","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                main.UpdateDateBasa();
                main.FunctionAddInfo(0);
            }


        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int switchUniqueInformation = 0;

                if (positionComboBox.Text.Length > 0)
                {
                    if (!(int.Parse(positionComboBox.SelectedValue.ToString()) == null))
                    {
                        switchUniqueInformation = int.Parse(positionComboBox.SelectedValue.ToString());
                    }
                }
                switch (switchUniqueInformation)
                {
                    case 0://скрываем ненужные поля
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

        private void Button2_Click(object sender, EventArgs e)
        {
            int switchUniqueInformation = int.Parse(positionComboBox.SelectedValue.ToString());

            switch (switchUniqueInformation)
            {
                case 0://Повышаем сотрудника
                    positionComboBox.SelectedValue = 1;
                    MessageBox.Show("Сотрудник повышен до " + positionComboBox.Text + "!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    positionComboBox.SelectedValue = 2;
                    MessageBox.Show("Сотрудник повышен до " + positionComboBox.Text + "!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    positionComboBox.SelectedValue = 3;
                    UpdateToLeaderDepartment = true;
                    MessageBox.Show("Сотрудник повышен до " + positionComboBox.Text + "!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    positionComboBox.SelectedValue = 4;
                    UpdateToLeaderDepartment = false;
                    UpdateToDirector = true;
                    MessageBox.Show("Сотрудник повышен до " + positionComboBox.Text + "!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default://сообщаяем пользователю что все
                    MessageBox.Show("Дальше повышать некуда!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
        }
    }
}
