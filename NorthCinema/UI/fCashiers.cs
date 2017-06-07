using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthCinema.Domain.Models;
using NorthCinema.Domain.Users;
using NorthCinema.Infrastructure;

namespace NorthCinema.UI
{
    public partial class fCashiers : Form
    {
        AuthorisedUser user;
        ListOfCashiers cashiersList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fCashiers(AuthorisedUser user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                this.user = user;
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                reading.ReadFromDateBase();
                cashiersList = new ListOfCashiers(reading.cashierList);
                sourceData.DataSource = cashiersList.Cashiers;
                dataGridViewCashiers.DataSource = sourceData;
                dataGridViewCashiers.Columns[0].Visible = false;
                dataGridViewCashiers.Columns[1].HeaderText = "Фамилия";
                dataGridViewCashiers.Columns[2].HeaderText = "Имя";
                dataGridViewCashiers.Columns[3].HeaderText = "Отчество";
                dataGridViewCashiers.Columns[4].Visible = false;
                dataGridViewCashiers.Columns[5].HeaderText = "Логин";
                dataGridViewCashiers.Columns[6].HeaderText = "Пароль";
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                MessageBox.Show("Запрещено");
                this.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCashiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                LastNameInput.Text = dataGridViewCashiers.Rows[indexRow].Cells[1].Value.ToString();
                FirstNameInput.Text = dataGridViewCashiers.Rows[indexRow].Cells[2].Value.ToString();
                SecondNameInput.Text = dataGridViewCashiers.Rows[indexRow].Cells[3].Value.ToString();
                LoginInput.Text = dataGridViewCashiers.Rows[indexRow].Cells[5].Value.ToString();
                PasswordInput.Text = dataGridViewCashiers.Rows[indexRow].Cells[6].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            cashiersList.AddCashierInList(cashiersList.Cashiers.Max().UserId + 1, LastNameInput.Text,
                FirstNameInput.Text, SecondNameInput.Text, "Cashier", LoginInput.Text, PasswordInput.Text);
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(cashiersList.Cashiers.Last());
            sourceData.ResetBindings(false);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cashiersList.Cashiers[indexRow].LastName = LastNameInput.Text;
            cashiersList.Cashiers[indexRow].FirstName = FirstNameInput.Text;
            cashiersList.Cashiers[indexRow].SecondName = SecondNameInput.Text;
            cashiersList.Cashiers[indexRow].Login = LoginInput.Text;
            cashiersList.Cashiers[indexRow].Password = PasswordInput.Text;
            UpdatingDataBase updating = new UpdatingDataBase();
            updating.UpdateInDatabase(cashiersList.Cashiers[indexRow]);
            sourceData.ResetBindings(false); //подтверждает изменения
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletingFromDateBase deleting = new DeletingFromDateBase();
            deleting.DeleteFromDatabase(cashiersList.Cashiers[indexRow]);
            cashiersList.Cashiers.RemoveAt(indexRow);
            sourceData.ResetBindings(false); //подтверждает изменения
        }
    }
}
