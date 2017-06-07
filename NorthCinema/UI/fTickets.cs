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
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fTickets()
        {
            InitializeComponent();
            ReadingFromDateBase reading = new ReadingFromDateBase();
            ticketsList = reading.ReadTickets();
            LoadDataGridView();
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
            dataGridViewTickets.Columns[0].Visible = false;
            dataGridViewTickets.Columns[4].Visible = false;
        }
    }
}
