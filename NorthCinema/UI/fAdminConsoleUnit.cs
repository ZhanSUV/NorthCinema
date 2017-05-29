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
    public partial class fAdminConsoleUnit : Form
    {
        private AdminUser admin;
        public fAdminConsoleUnit(AdminUser admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void Film_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdminFilms console = new fAdminFilms(admin);
            console.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
