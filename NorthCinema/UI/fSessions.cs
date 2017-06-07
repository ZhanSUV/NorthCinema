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
        ListOfFilms filmList;
        ListOfHalls hallList;
        List<int> filmIds = new List<int>();
        List<int> hallIds = new List<int>();
        AuthorisedUser user;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fSessions(AuthorisedUser user)
        {
            this.user = user;
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                foreach (var i in sessionsList.Sessions)
                {
                    filmIds.Add(i.FilmSession.FilmId);
                    hallIds.Add(i.HallSession.HallId);
                    
                }
                LoadDataGridView();
                filmList = reading.ReadFilms();
                hallList = reading.ReadHalls();
                FilmComboBox.DataSource = filmList.Films;
                FilmComboBox.DisplayMember = "FilmName";
                FilmComboBox.ValueMember = "FilmId";
                HallComboBox.DataSource = hallList.Halls;
                HallComboBox.DisplayMember = "HallName";
                HallComboBox.ValueMember = "HallId";
            }
            else
            {
                this.user = user;
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                foreach (var i in sessionsList.Sessions)
                {
                    filmIds.Add(i.FilmSession.FilmId);
                    hallIds.Add(i.HallSession.HallId);
                }
                for (int i = 0; i < sourceData.Count; i++)
                {
                    dataGridViewSessions[2, i].Value = filmIds[i];
                }
                LoadDataGridView();
                filmList = reading.ReadFilms();
                hallList = reading.ReadHalls();
                FilmComboBox.DataSource = filmList.Films;
                FilmComboBox.DisplayMember = "FilmName";
                FilmComboBox.ValueMember = "FilmId";
                HallComboBox.DataSource = hallList.Halls;
                HallComboBox.DisplayMember = "HallName";
                HallComboBox.ValueMember = "HallId";
                AddButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                FilmComboBox.Text = dataGridViewSessions.Rows[indexRow].Cells[1].Value.ToString();
                HallComboBox.Text = dataGridViewSessions.Rows[indexRow].Cells[2].Value.ToString();
                DateInputPicker.Value = Convert.ToDateTime(dataGridViewSessions.Rows[indexRow].Cells[3].Value.ToString());
                TimeInputPicker.Value = Convert.ToDateTime(dataGridViewSessions.Rows[indexRow].Cells[4].Value.ToString());
                if (user.GetType() == typeof(CashierUser))
                {
                    this.Hide();
                    Session session = sessionsList.Sessions[indexRow];
                    fHalls console = new fHalls(user, session);
                    console.ShowDialog();
                    this.Show();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            sessionsList.AddSessionInList(filmList.Films.Last().FilmId + 1, 
                filmList.Films.Find(x => x.FilmName == FilmComboBox.Text), 
                hallList.Halls.Find(x => x.HallName == HallComboBox.Text), 
                DateInputPicker.Value, TimeInputPicker.Value.TimeOfDay);
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(sessionsList.Sessions.Last());
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            //плохая реализация
            var table = new DataTable();
            table.Columns.Add("Сеанс");
            table.Columns.Add("Фильм");
            table.Columns.Add("Залл");
            table.Columns.Add("Дата");
            table.Columns.Add("Время");
            table.Rows.Add();
            for (int j = 0; j < sessionsList.Sessions.Count; j++)
            {
                table.Rows.Add(sessionsList.Sessions[j].SessionId, 
                    sessionsList.Sessions[j].FilmSession.FilmName,
                    sessionsList.Sessions[j].HallSession.HallName, 
                    sessionsList.Sessions[j].DateSession.Date.ToShortDateString(),
                    sessionsList.Sessions[j].TimeSession);
            }
            dataGridViewSessions.DataSource = table;
            (dataGridViewSessions.DataSource as DataTable).DefaultView.RowFilter = string.Format("Isnull(Сеанс, '') <> ''");
            dataGridViewSessions.Columns[0].Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sessionsList.Sessions[indexRow].FilmSession = filmList.Films.Find(x => x.FilmName == FilmComboBox.Text);
            sessionsList.Sessions[indexRow].HallSession = hallList.Halls.Find(x => x.HallName == HallComboBox.Text);
            sessionsList.Sessions[indexRow].DateSession = DateInputPicker.Value;
            sessionsList.Sessions[indexRow].TimeSession = TimeInputPicker.Value.TimeOfDay;
            UpdatingDataBase updating = new UpdatingDataBase();
            updating.UpdateInDatabase(sessionsList.Sessions[indexRow]);
            LoadDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletingFromDateBase deleting = new DeletingFromDateBase();
            deleting.DeleteFromDatabase(sessionsList.Sessions[indexRow]);
            sessionsList.Sessions.RemoveAt(indexRow);
            LoadDataGridView();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            (dataGridViewSessions.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            string date = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            (dataGridViewSessions.DataSource as DataTable).DefaultView.RowFilter = string.Format("Дата = '{0}'", date);
        }

        private void FindButton_Click(object sender, EventArgs e)
        { 
            string nameFilm = FilterNameFilmInput.Text;
            (dataGridViewSessions.DataSource as DataTable).DefaultView.RowFilter = string.Format("Фильм = '{0}'", nameFilm);
        }

        private void FilterNameFilmWithDate_Click(object sender, EventArgs e)
        {
            string date = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            string nameFilm = FilterNameFilmInput.Text;
            (dataGridViewSessions.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("Дата = '{0}' and Фильм = '{1}'", date, nameFilm);
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
