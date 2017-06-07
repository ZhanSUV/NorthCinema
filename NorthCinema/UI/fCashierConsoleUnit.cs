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
namespace NorthCinema.UI
{
    public partial class fCashierConsoleUnit : Form
    {
        private CashierUser cashier;
        public fCashierConsoleUnit(CashierUser cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
        }

        private void FilmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdminFilms console = new fAdminFilms(cashier);
            console.ShowDialog();
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTickets console = new fTickets(cashier);
            console.ShowDialog();
            this.Show();
        }

        private void SessionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSessions console = new fSessions(cashier);
            console.ShowDialog();
            this.Show();
        }
    }
}
