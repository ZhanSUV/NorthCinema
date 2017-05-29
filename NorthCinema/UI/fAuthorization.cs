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
using NorthCinema.App;

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
            Logining login = new Logining(LoginInput.Text, PasswordInput.Text);
            if (login.status != null)
            {
                if (login.status.ToUpper() == "ADMIN")
                {
                    AdminUser admin = new AdminUser(login.userId, login.lastName, login.firstName,
                        login.secondName, login.status, login.login, login.password);
                    fAdminConsoleUnit adminConsole = new fAdminConsoleUnit(admin);
                    adminConsole.ShowDialog();
                }
                else if (login.status.ToUpper() == "CASHIER")
                {
                    CashierUser cashier = new CashierUser(login.userId, login.lastName, login.firstName,
                        login.secondName, login.status, login.login, login.password);
                    fCashierConsoleUnit cashierConsole = new fCashierConsoleUnit(cashier);
                    cashierConsole.ShowDialog();
                }
                else if (login.status.ToUpper() == "VISITOR")
                {

                }
                LoginInput.Text = "";
                PasswordInput.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный логин, пароль");
                PasswordInput.Text = "";
            }
            this.Show();
        }
    }
}
