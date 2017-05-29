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
    public partial class fAdminFilms : Form
    {
        public fAdminFilms(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                ListOfFilms films = reading.ReadFilms();
                dataGridViewFilm.DataSource = films.Films;
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                ListOfFilms films = reading.ReadFilms();
                dataGridViewFilm.DataSource = films.Films;
                dataGridViewFilm.Columns[0].Visible = false;
                AddButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
