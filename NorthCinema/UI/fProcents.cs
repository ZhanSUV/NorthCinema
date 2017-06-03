using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthCinema.Domain.Users;
using NorthCinema.Domain.Models;
using NorthCinema.Infrastructure;

namespace NorthCinema.UI
{
    public partial class fProcents : Form
    {
        ListOfPercents percentList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fProcents(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                ReadingFromDateBase reading = new ReadingFromDateBase();
                percentList = reading.ReadPercentages();
                sourceData.DataSource = percentList.Percents;
                dataGridViewPercents.DataSource = sourceData;
                dataGridViewPercents.Columns[0].Visible = false;
                dataGridViewPercents.Columns[1].HeaderText = "Скидка/Наценка";
                dataGridViewPercents.Columns[2].HeaderText = "Описание";
                dataGridViewPercents.Columns[3].HeaderText = "Процент";
            }
            else
            {
                this.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            percentList.AddPercentInList(percentList.Percents[percentList.Percents.Count() - 1].PercentId,
                DiscountOrMarkupInput.Text, DescriptionInput.Text, Convert.ToInt32(PercentInput.Text));
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(percentList.Percents.Last());
            sourceData.ResetBindings(false);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            percentList.Percents[indexRow].PercentType = DiscountOrMarkupInput.Text;
            percentList.Percents[indexRow].PercentDescription = DescriptionInput.Text;
            percentList.Percents[indexRow].PercentValue = Convert.ToInt32(PercentInput.Text);
            UpdatingDataBase updating = new UpdatingDataBase();
            updating.UpdateInDatabase(percentList.Percents[indexRow]);
            sourceData.ResetBindings(false); //подтверждает изменения
        }

        private void dataGridViewPercents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                DiscountOrMarkupInput.Text = dataGridViewPercents.Rows[e.RowIndex].Cells[1].Value.ToString();
                DescriptionInput.Text = dataGridViewPercents.Rows[e.RowIndex].Cells[2].Value.ToString();
                PercentInput.Text = dataGridViewPercents.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletingFromDateBase deleting = new DeletingFromDateBase();
            deleting.DeleteFromDatabase(percentList.Percents[indexRow]);
            percentList.Percents.RemoveAt(indexRow);
            sourceData.ResetBindings(false); //подтверждает изменения
        }
    }
}
