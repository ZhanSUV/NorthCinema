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
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                sessionsList = reading.ReadSessions();
                foreach (var i in sessionsList.Sessions)
                {
                    filmIds.Add(i.FilmSession.FilmId);
                    hallIds.Add(i.HallSession.HallId);
                    
                }
                // столбцы не поменять, нужно искать способ
                /*
                sourceData.DataSource = sessionsList.Sessions;
                dataGridViewSessions.DataSource = sourceData;
                for (int i = 0; i < sourceData.Count; i++)
                {
                    dataGridViewSessions[2, i].Value = filmIds[i];
                }
                dataGridViewSessions.Refresh();
                dataGridViewSessions.Columns[0].Visible = false;*/


                //плохая реализация
                dataGridViewSessions.ColumnCount = 5;
                dataGridViewSessions.Columns[0].Name = "Session ID";
                dataGridViewSessions.Columns[0].Visible = false;
                dataGridViewSessions.Columns[1].Name = "Film ID";
                dataGridViewSessions.Columns[2].Name = "Hall ID";
                dataGridViewSessions.Columns[3].Name = "Date";
                dataGridViewSessions.Columns[4].Name = "Time";
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

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
