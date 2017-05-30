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
        ListOfFilms films;
        BindingSource sourceData = new BindingSource();
        public fAdminFilms(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                films = reading.ReadFilms();
                sourceData.DataSource = films.Films;
                dataGridViewFilm.DataSource = sourceData;
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                films = reading.ReadFilms();
                sourceData.DataSource = films.Films;
                dataGridViewFilm.DataSource = sourceData;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //sourceData.DataSource = films.Films;
            films.AddFilmInList(4, NameFilmInput.Text, Convert.ToInt32(FilmLengthInput.Text),
                 Convert.ToInt32(AgeLimitInput.Text), Convert.ToInt32(PriceInput.Text));
            sourceData.ResetBindings(false);

            // не работает так: dataGridViewFilm.Rows.Add(NameFilmInput.Text, FilmLengthInput.Text, AgeLimitInput.Text, PriceInput.Text);
        }
    }
}
