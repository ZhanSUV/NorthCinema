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
        object number;  
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fSessions(object user)
        {
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
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                foreach (var i in sessionsList.Sessions)
                {
                    filmIds.Add(i.FilmSession.FilmId);
                    hallIds.Add(i.HallSession.HallId);

                }
                sourceData.DataSource = sessionsList.Sessions;
                dataGridViewSessions.DataSource = sourceData;
                for (int i = 0; i < sourceData.Count; i++)
                {
                    dataGridViewSessions[2, i].Value = filmIds[i];
                }
                dataGridViewSessions.Refresh();
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
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            sessionsList.AddSessionInList(filmList.Films[filmList.Films.Count() - 1].FilmId + 1, 
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

            dataGridViewSessions.ColumnCount = 5;
            dataGridViewSessions.Columns[0].Name = "Session ID";
            dataGridViewSessions.Columns[0].Visible = false;
            dataGridViewSessions.Columns[1].Name = "Фильм";
            dataGridViewSessions.Columns[2].Name = "Залл";
            dataGridViewSessions.Columns[3].Name = "Дата";
            dataGridViewSessions.Columns[4].Name = "Время";
            dataGridViewSessions.RowCount = sessionsList.Sessions.Count;
            for (int i = 0; i < dataGridViewSessions.ColumnCount; i++)
            {
                for (int j = 0; j < sessionsList.Sessions.Count; j++)
                {
                    if (i == 0)
                    {
                        dataGridViewSessions[i, j].Value = sessionsList.Sessions[j].SessionId;
                    }
                    else if (i == 1)
                    {
                        dataGridViewSessions[i, j].Value = sessionsList.Sessions[j].FilmSession.FilmName;
                    }
                    else if (i == 2)
                    {
                        dataGridViewSessions[i, j].Value = sessionsList.Sessions[j].HallSession.HallName;
                    }
                    else if (i == 3)
                    {
                        dataGridViewSessions[i, j].Value = sessionsList.Sessions[j].DateSession.Date.ToShortDateString();
                    }
                    else
                    {
                        dataGridViewSessions[i, j].Value = sessionsList.Sessions[j].TimeSession;
                    }
                }
            }
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
    }
}
