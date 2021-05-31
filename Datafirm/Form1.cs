using System;
using System.Activities.Expressions;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Filter = false;// Переменная показывает активны ли фильтры
        public void UpdateDateBasa()// Функция обновление главной таблицы Person
        {
            Validate();
            personTableBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(database1DataSet);
            personTableTableAdapter.Fill(database1DataSet.PersonTable);
        }
        public void UpdateDateBasa1()// Функция обновления таблицы LeaderDepartment
        {
            Validate();
            leaderDepartmentTableBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(database1DataSet);
            leaderDepartmentTableTableAdapter.Fill(database1DataSet.LeaderDepartmentTable);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.DepartmentTable". При необходимости она может быть перемещена или удалена.
            departmentTableTableAdapter.Fill(database1DataSet.DepartmentTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.LeaderDepartmentTable". При необходимости она может быть перемещена или удалена.
            leaderDepartmentTableTableAdapter.Fill(database1DataSet.LeaderDepartmentTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ProcessTable". При необходимости она может быть перемещена или удалена.
            processTableTableAdapter.Fill(database1DataSet.ProcessTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PositionTable". При необходимости она может быть перемещена или удалена.
            positionTableTableAdapter.Fill(database1DataSet.PositionTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PersonTable". При необходимости она может быть перемещена или удалена.
            personTableTableAdapter.Fill(database1DataSet.PersonTable);
            FunctionAddInfo(0);//Вызов функции добавление информации в TextBox'ы
            RemoveFilter();//Вызов функции очистки фильтров

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox1.Text.Length == 0)
           {
                RemoveFilter();
           }
           else if (Filter == true)//проверка значение переменной Filter
            {
                personTableBindingSource.Filter = string.Format("convert(Position, 'System.String') Like '%{0}%' ", comboBox1.SelectedValue);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Filter == false)//проверка значение переменной Filter
            {
                Form2 af = new Form2
                {
                    Owner = this
                };
                af.ShowDialog();
            }
            else
                MessageBox.Show("Сперва выключите фильтры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (personTableDataGridView.RowCount > 0 && Filter == false)
            {
                Form3 af = new Form3
                {
                    Owner = this
                };
                af.ShowDialog();
            }
            else if(Filter == true)
                MessageBox.Show("Сперва выключите фильтры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Профиль не выбран,выберите чтобы продолжить!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (personTableDataGridView.RowCount > 0)
            {
                //Check if an item is selected to delete it.
                DeleteFromDateBasa();
                //personTableTableAdapter.Delete(G);
            }
            else
                MessageBox.Show("Профиль не выбран,выберите чтобы продолжить!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteFromDateBasa()
        {
            int a = personTableDataGridView.CurrentRow.Index;//Переменная отвечающая за индекс выбранной ячейки
            personTableDataGridView.Rows.Remove(personTableDataGridView.Rows[a]);//Удалить эту ячейку
            UpdateDateBasa();//Обновить БД
            if (positionComboBox.Text.Length > 0)
            {
                if (int.Parse(positionComboBox.SelectedValue.ToString()) >= 0)
                {
                    int position = int.Parse(positionComboBox.SelectedValue.ToString());
                    if (position == 3)
                    {
                        leaderDepartmentTableTableAdapter.Delete(int.Parse(idPersonTextBox.Text), fIOTextBox.Text);//удаляет запись
                        UpdateDateBasa1();//Обновить БД
                        UpdateDateBasa();//Обновить БД
                    }
                    FunctionAddInfo(0);//Обновляем информацию о текущей ячейки
                }
            }
        }

        private void RemoveFilter()
        {
            personTableBindingSource.RemoveFilter();//Очищает фильтры поиска
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length == 0)
            {
                RemoveFilter();
            }
            else if (Filter == true)
            {
                personTableBindingSource.Filter = string.Format("convert(Department, 'System.String') Like '%{0}%' ", comboBox2.SelectedValue);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RemoveFilter();
        }

        private void PersonTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                FunctionAddInfo(i);//считытает информацию с выбранной ячейки
            }
        }
        public void FunctionAddInfo(int i)
        {
            if (Filter == false && personTableDataGridView.RowCount>0)
            {
                idPersonTextBox.Text = Convert.ToString(personTableDataGridView[0, i].Value);
                fIOTextBox.Text = Convert.ToString(personTableDataGridView[1, i].Value);
                birthdayDateTimePicker.Value = Convert.ToDateTime(personTableDataGridView[2, i].Value);
                genderComboBox.Text = Convert.ToString(personTableDataGridView[3, i].Value);
                positionComboBox.SelectedValue = (personTableDataGridView[4, i].Value);
                departmentComboBox.SelectedValue = (personTableDataGridView[5, i].Value);
                fIOLeaderComboBox.SelectedValue = (personTableDataGridView[6, i].Value);
                processComboBox.SelectedValue = (personTableDataGridView[7, i].Value);
                directorInfoTextBox.Text = Convert.ToString(personTableDataGridView[8, i].Value);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button4.Enabled = true;
                Filter = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button4.Enabled = false;
                Filter = false;
                RemoveFilter();
            }
        }
    }
}
