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
    public partial class fTickets : Form
    {
        ListOfTickets ticketsList;
        ListOfPercents percentsList;
        ListOfTotalPercents totalPercentList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fTickets()
        {
            InitializeComponent();
            ReadingFromDateBase reading = new ReadingFromDateBase();
            ticketsList = reading.ReadTickets();
            percentsList = reading.ReadPercentages();
            totalPercentList = reading.ReadTotalPercents();
            LoadDataGridView();
        }
        public fTickets(Session session, int row, int placeNumber, double price)
        {
            InitializeComponent();
            ReadingFromDateBase reading = new ReadingFromDateBase();
            ticketsList = reading.ReadTickets();
            percentsList = reading.ReadPercentages();
            totalPercentList = reading.ReadTotalPercents();
            LoadDataGridView();
            SessionInput.Text = session.FilmSession.FilmName;
            RowInput.Text = row.ToString();
            PlaceNumberInput.Text = placeNumber.ToString();
            PriceInput.Text = price.ToString();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataGridView()
        {
            var table = new DataTable();
            table.Columns.Add("Билет");
            table.Columns.Add("Сеанс");
            table.Columns.Add("Ряд");
            table.Columns.Add("Место");
            table.Columns.Add("Дата рождения покупателя");
            table.Columns.Add("Цена");
            table.Rows.Add();
            for (int j = 0; j < ticketsList.Tickets.Count; j++)
            {
                table.Rows.Add(ticketsList.Tickets[j].TicketId,
                    ticketsList.Tickets[j].TicketSession.FilmSession.FilmName,
                    ticketsList.Tickets[j].Place.Row,
                    ticketsList.Tickets[j].Place.PlaceNumber,
                    ticketsList.Tickets[j].AgeVisitor.ToShortDateString(),
                    ticketsList.Tickets[j].Price);
            }
            dataGridViewTickets.DataSource = table;
            (dataGridViewTickets.DataSource as DataTable).DefaultView.RowFilter = string.Format("Isnull(Билет, '') <> ''");
            dataGridViewTickets.Columns[4].Visible = false;
            // перекинуть на CellClicked
            sourceData.DataSource = totalPercentList.TotalPercents;
            dataGridViewPercents.DataSource = sourceData;
            dataGridViewPercents.Columns[0].Visible = false;
            dataGridViewPercents.Columns[1].HeaderText = "Процент";
        }

        private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow != -1)
            {
                TicketInput.Text = dataGridViewTickets.Rows[indexRow].Cells[0].Value.ToString();
                SessionInput.Text = dataGridViewTickets.Rows[indexRow].Cells[1].Value.ToString();
                RowInput.Text = dataGridViewTickets.Rows[indexRow].Cells[2].Value.ToString();
                PlaceNumberInput.Text = dataGridViewTickets.Rows[indexRow].Cells[3].Value.ToString();

                PriceInput.Text = dataGridViewTickets.Rows[indexRow].Cells[5].Value.ToString();
            }
        }
    }
}
