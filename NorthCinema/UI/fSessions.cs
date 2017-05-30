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
    public partial class fSessions : Form
    {
        ListOfSessions sessionsList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fSessions(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                sourceData.DataSource = sessionsList.Sessions;
                dataGridViewSessions.DataSource = sourceData;
                dataGridViewSessions.Columns[0].Visible = false;
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                sourceData.DataSource = sessionsList.Sessions;
                dataGridViewSessions.DataSource = sourceData;
                dataGridViewSessions.Columns[0].Visible = false;
                AddButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
