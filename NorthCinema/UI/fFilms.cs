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
                Film film1 = new Film(1, "2+2", 120, 6, 150);
                Film film2 = new Film(2, "Крик", 100, 18, 200);
                Film film3 = new Film(3, "Адвокат дьявола", 140, 16, 180);
                List<Film> filmList = new List<Film>();
                filmList.Add(film1);
                filmList.Add(film2);
                filmList.Add(film3);
                ListOfFilms films = new ListOfFilms(filmList);
                dataGridViewFilm.DataSource = films.Films;
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                Film film1 = new Film(1, "2+2", 120, 6, 150);
                Film film2 = new Film(2, "Крик", 100, 18, 200);
                Film film3 = new Film(3, "Адвокат дьявола", 140, 16, 180);
                List<Film> filmList = new List<Film>();
                filmList.Add(film1);
                filmList.Add(film2);
                filmList.Add(film3);
                ListOfFilms films = new ListOfFilms(filmList);
                //Domain.Models.ListOfFilms films = new Domain.Models.ListOfFilms(filmList);
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
