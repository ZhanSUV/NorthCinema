using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using NorthCinema.Domain.Users;

namespace NorthCinema.UI
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //
            //админ
            /*AdminUser admin = new AdminUser(1, "Johnta", "Alexey", "Andreevich", "Admin");
            fAdminConsoleUnit console = new fAdminConsoleUnit(admin); */
            //кассир
            /*CashierUser cashier = new CashierUser(1, "Johnta", "Alexey", "Andreevich", "Cashier");
            fCashierConsoleUnit console = new fCashierConsoleUnit(cashier); 
            */
            //console.ShowDialog(); 
            this.Show();
            //App.Logining login = new App.Logining(LoginInput.Text, PasswordInput.Text);
        }
    }
}
