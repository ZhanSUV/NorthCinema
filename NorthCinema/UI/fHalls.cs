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
    public partial class fHalls : Form
    {
        Button[][] buttonArray = new Button[1][];
        ListOfPlacesInHalls placesList;
        ListOfHalls hallsList;
        BindingSource sourceData = new BindingSource();
        int indexRow;
        public fHalls(object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminUser))
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                hallsList = reading.ReadHalls();
                placesList = reading.ReadPlacesInHall();
                sourceData.DataSource = hallsList.Halls;
                dataGridViewHalls.DataSource = sourceData;
                dataGridViewHalls.Columns[0].Visible = false;
                dataGridViewHalls.Columns[1].HeaderText = "Название";
                dataGridViewHalls.Columns[2].HeaderText = "Кол-во мест";
                dataGridViewHalls.Columns[3].HeaderText = "Кол-во мест в ряду";
                //LoadSchemeOfHall();
            }
            else
            {
                //класс, считывающий данные из бд и это в List засунуть; 
                ReadingFromDateBase reading = new ReadingFromDateBase();
                hallsList = reading.ReadHalls();
                sourceData.DataSource = hallsList.Halls;
                dataGridViewHalls.DataSource = sourceData;
                dataGridViewHalls.Columns[0].Visible = false;
                dataGridViewHalls.Columns[1].HeaderText = "Название";
                dataGridViewHalls.Columns[2].HeaderText = "Кол-во мест";
                dataGridViewHalls.Columns[3].HeaderText = "Кол-во мест в ряду";
                AddButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
                //LoadSchemeOfHall();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HallPlaces.Controls.Clear();
            indexRow = e.RowIndex;
            if (e.RowIndex != -1) // исключает ошибки(когда нажимается на столбец)
            {
                NameHallInput.Text = dataGridViewHalls.Rows[e.RowIndex].Cells[1].Value.ToString();
                SeatingCapacityInput.Text = dataGridViewHalls.Rows[e.RowIndex].Cells[2].Value.ToString();
                PlacesInRowInput.Text = dataGridViewHalls.Rows[e.RowIndex].Cells[3].Value.ToString();
                LoadSchemeOfHall2(hallsList.Halls[indexRow].SeatingCapacity, hallsList.Halls[indexRow].PlacesInRow);
            }   
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            hallsList.AddHallInList(hallsList.Halls[hallsList.Halls.Count() - 1].HallId + 1, NameHallInput.Text, 
                Convert.ToInt32(SeatingCapacityInput.Text), Convert.ToInt32(PlacesInRowInput.Text));
            WritingInDatabase writing = new WritingInDatabase();
            writing.WriteInDatabase(hallsList.Halls.Last());
            sourceData.ResetBindings(false);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            hallsList.Halls[indexRow].HallName = NameHallInput.Text;
            hallsList.Halls[indexRow].PlacesInRow = Convert.ToInt32(PlacesInRowInput.Text);
            hallsList.Halls[indexRow].SeatingCapacity = Convert.ToInt32(SeatingCapacityInput.Text);
            UpdatingDataBase updating = new UpdatingDataBase();
            updating.UpdateInDatabase(hallsList.Halls[indexRow]);
            sourceData.ResetBindings(false); //подтверждает изменения
            HallPlaces.Controls.Clear();
            LoadSchemeOfHall(hallsList.Halls[indexRow].SeatingCapacity, hallsList.Halls[indexRow].PlacesInRow);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletingFromDateBase deleting = new DeletingFromDateBase();
            deleting.DeleteFromDatabase(hallsList.Halls[indexRow]);
            hallsList.Halls.RemoveAt(indexRow);
            sourceData.ResetBindings(false);
        }
        private void LoadSchemeOfHall(int seatingCapacity, int placesInRowLimit)
        {
            //HallPlaces.Width = this.Width / 2;
            //HallPlaces.Height = this.Height / 2;
            int X = 6;
            int Y = 19;
            Button[] buttonArray = new Button[seatingCapacity];
            bool notEven = false;
            int limitPlacesInRow = placesInRowLimit;
            int rows = 1;
            int maxRows = (buttonArray.Length / limitPlacesInRow) + 1;
            int lastPlaces = buttonArray.Length % limitPlacesInRow;
            if (lastPlaces != 0)
            {
                notEven = true;
                //maxRows = lastPlaces;
            }
            int placesInRow = 1;
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(30, 30);
                buttonArray[i].Text = placesInRow.ToString();
                //buttonArray[i].MouseClick += new MouseEventHandler(SelectPlaceInHall);
                if (rows == maxRows && notEven)
                {
                    X += 35 * (limitPlacesInRow - lastPlaces) / 2;
                    notEven = false;
                }
                buttonArray[i].Location = new Point(X, Y);
                HallPlaces.Controls.Add(buttonArray[i]);
                if (placesInRow != limitPlacesInRow)
                {
                    X += 35;
                    placesInRow++;
                }
                else
                {
                    X += 35;
                    Label rowLabel = new Label();
                    rowLabel.Size = new Size(40, 30);
                    rowLabel.Location = new Point(X, Y);
                    rowLabel.Text = "Ряд " + rows + " ";
                    HallPlaces.Controls.Add(rowLabel);
                    X = 6;
                    Y += 40;
                    placesInRow = 1;
                    rows++;
                }
                /*
                if (HallPlaces.Width > this.Width / 2)
                {
                    this.Width = HallPlaces.Width + this.Width / 2;

                }
                if (HallPlaces.Height > this.Height / 2)
                {
                    this.Height = HallPlaces.Height + this.Height / 2;
                }
                */
            }
        }
        private void LoadSchemeOfHall2(int seatingCapacity, int placesInRowLimit)
        {
            RowInput.Clear();
            PlaceInput.Clear();
            int X = 6;
            int Y = 19;
            bool notEven = false;
            int leftPlaces = seatingCapacity % placesInRowLimit;
            if (leftPlaces != 0)
            {
                notEven = true;
                buttonArray = new Button[(seatingCapacity / placesInRowLimit + 1)][];
            }
            else
            {
                buttonArray = new Button[seatingCapacity / placesInRowLimit][];
            }
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button[placesInRowLimit];
                if(i == buttonArray.Length - 1 && notEven)
                {
                    buttonArray[i] = new Button[leftPlaces];
                }
                for (int j = 0; j < buttonArray[i].Length; j++)
                {
                    buttonArray[i][j] = new Button();
                    buttonArray[i][j].Size = new Size(30, 30);
                    buttonArray[i][j].Name = i.ToString();
                    buttonArray[i][j].Text = (j + 1).ToString();
                    buttonArray[i][j].MouseClick += new MouseEventHandler(SelectedPlaceInHall);
                    if (i == buttonArray.Length - 1 && notEven)
                    {
                        X += 35 * (placesInRowLimit - leftPlaces) / 2;
                        notEven = false;
                    }
                    buttonArray[i][j].Location = new Point(X, Y);
                    HallPlaces.Controls.Add(buttonArray[i][j]);
                    X += 35;
                }
                Label rowLabel = new Label();
                rowLabel.Size = new Size(40, 30);
                rowLabel.Location = new Point(35 * buttonArray[0].Length, Y);
                rowLabel.Text = "Ряд " + (i + 1) + " ";
                HallPlaces.Controls.Add(rowLabel);
                X = 6;
                Y += 40;
            }
        }
        private void FillingPlaces(int hallId, int seatingCapacity, int placesInRowLimit)
        {
            WritingInDatabase writing = new WritingInDatabase();
            int rows = 0;
            bool notEven = false;
            int leftPlaces = seatingCapacity % placesInRowLimit;
            if (leftPlaces != 0)
            {
                rows = (seatingCapacity / placesInRowLimit) + 1;
                notEven = true;
            }
            else
            {
                rows = seatingCapacity / placesInRowLimit;
            }
            for (int i = 1; i <= rows; i++)
            {
                if (i == rows && notEven)
                {
                    placesInRowLimit = leftPlaces;
                }
                for (int j = 1; j <= placesInRowLimit; j++)
                { 
                    placesList.AddPlacesInHall(placesList.Places.Count() - 1, hallId, i, j);
                }
            }
           
            //writing.WriteInDatabase(placesList);
        }
        private void SelectedPlaceInHall(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            RowInput.Text = clickedButton.Name;
            PlaceInput.Text = clickedButton.Text;
        }
    }
}

