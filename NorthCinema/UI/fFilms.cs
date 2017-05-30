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
        int indexRow;
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
                dataGridViewFilm.Columns[0].Visible = false;
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
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(films.Films.Last());
            sourceData.ResetBindings(false); //подтверждает изменения
            // не работает так: dataGridViewFilm.Rows.Add(NameFilmInput.Text, FilmLengthInput.Text, AgeLimitInput.Text, PriceInput.Text);
        }
        private void dataGridViewFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                NameFilmInput.Text = dataGridViewFilm.Rows[e.RowIndex].Cells[1].Value.ToString();
                FilmLengthInput.Text = dataGridViewFilm.Rows[e.RowIndex].Cells[2].Value.ToString();
                AgeLimitInput.Text = dataGridViewFilm.Rows[e.RowIndex].Cells[3].Value.ToString();
                PriceInput.Text = dataGridViewFilm.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            films.Films[indexRow].FilmName = NameFilmInput.Text;
            films.Films[indexRow].LengthOfFilm= Convert.ToInt32(FilmLengthInput.Text);
            films.Films[indexRow].AgeLimit = Convert.ToInt32(AgeLimitInput.Text);
            films.Films[indexRow].Price = Convert.ToInt32(PriceInput.Text);
            UpdateDataBase updating = new UpdateDataBase();
            updating.UpdateInDatabase(films.Films[indexRow]);
            sourceData.ResetBindings(false);
        }
    }
}
