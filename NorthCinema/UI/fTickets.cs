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
        AuthorisedUser user;
        ListOfTickets ticketsList;
        ListOfPercents percentsList;
        ListOfStatusTickets statusTicketList;
        ListOfTotalPercents totalPercentList;
        ListOfSessions sessionList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fTickets(AuthorisedUser user)
        {
            InitializeComponent();
            this.user = user;
            ReadingFromDateBase reading = new ReadingFromDateBase();
            ticketsList = reading.ReadTickets();
            percentsList = reading.ReadPercentages();
            totalPercentList = reading.ReadTotalPercents();
            statusTicketList = reading.ReadStatusTickets();
            sessionList = reading.ReadSessions();
            LoadDataGridView();
        }
        public fTickets(AuthorisedUser user, Session session, int row, int placeNumber, double price)
        {
            InitializeComponent();
            this.user = user;
            ReadingFromDateBase reading = new ReadingFromDateBase();
            ticketsList = reading.ReadTickets();
            percentsList = reading.ReadPercentages();
            totalPercentList = reading.ReadTotalPercents();
            statusTicketList = reading.ReadStatusTickets();
            sessionList = reading.ReadSessions();
            LoadDataGridView();
            SessionInput.Text = session.FilmSession.FilmName;
            RowInput.Text = row.ToString();
            PlaceNumberInput.Text = placeNumber.ToString();
            PriceInput.Text = price.ToString();
            TicketInput.Text = (ticketsList.Tickets.Count() + 1).ToString();
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
                    ticketsList.Tickets[j].Place,
                    ticketsList.Tickets[j].Row,
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            statusTicketList.AddStatusTicketInList(statusTicketList.StatusTicketList.Count() + 1, user.UserId,
                Convert.ToInt32(TicketInput.Text), "Продано", DatePicker.Value, TimePicker.Value.TimeOfDay);
            ticketsList.AddTicketInList(ticketsList.Tickets.Count() + 1,
                sessionList.Sessions.Find(x => x.FilmSession.FilmName == SessionInput.Text),
                Convert.ToInt32(PlaceNumberInput.Text), Convert.ToInt32(RowInput.Text),
                AgeVistorPicker.Value, Convert.ToInt32(PriceInput.Text));
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(ticketsList.Tickets.Last());
            writing.WriteInDatabase(statusTicketList.StatusTicketList.Last());
            LoadDataGridView();
        }
    }
}
