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
    public partial class fHalls : Form
    {
        ListOfHalls hallsList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fHalls(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                hallsList = reading.ReadHalls();
                sourceData.DataSource = hallsList.Halls;
                dataGridViewHalls.DataSource = sourceData;
                dataGridViewHalls.Columns[0].Visible = false;
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                hallsList = reading.ReadHalls();
                sourceData.DataSource = hallsList.Halls;
                dataGridViewHalls.DataSource = sourceData;
                dataGridViewHalls.Columns[0].Visible = false;
                AddButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                NameHallInput.Text = dataGridViewHalls.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            hallsList.AddHallInList(hallsList.Halls[hallsList.Halls.Count() - 1].HallId + 1, NameHallInput.Text);
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(hallsList.Halls.Last());
            sourceData.ResetBindings(false);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            hallsList.Halls[indexRow].HallName = NameHallInput.Text;
            UpdatingDataBase updating = new UpdatingDataBase();
            updating.UpdateInDatabase(hallsList.Halls[indexRow]);
            sourceData.ResetBindings(false); //подтверждает изменения
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletingFromDateBase deleting = new DeletingFromDateBase();
            deleting.DeleteFromDatabase(hallsList.Halls[indexRow]);
            hallsList.Halls.RemoveAt(indexRow);
            sourceData.ResetBindings(false);
        }
    }
}
