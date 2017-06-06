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
                for (int i = 0; i < hallsList.Halls.Count; i++)
                {
                    hallsList.Halls[i].Places = reading.ReadPlacesInHall(hallsList.Halls[i].HallId);
                }
                placesList = reading.ReadAllPlacesOfAllHalls();
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
                LoadSchemeOfHall(hallsList.Halls[indexRow].SeatingCapacity, hallsList.Halls[indexRow].PlacesInRow);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            HallPlaces.Controls.Clear();
            if (SeatingCapacityInput.Text == "" || PlacesInRowInput.Text == "" || SeatingCapacityInput.Text == "0"
                || PlacesInRowInput.Text == "0")
            {
                MessageBox.Show("Нельзя создать пустой зал");
            }
            else
            {
                int id = 1;
                if (hallsList.Halls.Count != 0)
                {
                    id = hallsList.Halls.Count + 1;
                }
                hallsList.AddHallInList(id, NameHallInput.Text,
                    Convert.ToInt32(SeatingCapacityInput.Text), Convert.ToInt32(PlacesInRowInput.Text));

                WritingInDatabase writing = new WritingInDatabase();

                writing.WriteInDatabase(hallsList.Halls.Last());

                FillingPlaces(hallsList.Halls.Last());

                sourceData.ResetBindings(false);

                LoadSchemeOfHall(Convert.ToInt32(SeatingCapacityInput.Text), Convert.ToInt32(PlacesInRowInput.Text));
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (indexRow != -1)
            {
                hallsList.Halls[indexRow].HallName = NameHallInput.Text;
                hallsList.Halls[indexRow].PlacesInRow = Convert.ToInt32(PlacesInRowInput.Text);
                hallsList.Halls[indexRow].SeatingCapacity = Convert.ToInt32(SeatingCapacityInput.Text);
                UpdatingDataBase updating = new UpdatingDataBase();
                updating.UpdateInDatabase(hallsList.Halls[indexRow]);
                sourceData.ResetBindings(false); //подтверждает изменения
                HallPlaces.Controls.Clear();
                DeletingFromDateBase deleting = new DeletingFromDateBase();
                deleting.DeleteFromDatabase(hallsList.Halls[indexRow].Places);
                hallsList.Halls[indexRow].Places.Clear();
                ReadingFromDateBase reading = new ReadingFromDateBase();
                placesList = reading.ReadAllPlacesOfAllHalls();
                FillingPlaces(hallsList.Halls[indexRow]);
                LoadSchemeOfHall(hallsList.Halls[indexRow].SeatingCapacity, hallsList.Halls[indexRow].PlacesInRow);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxesAndGroupBox();
            if (indexRow != -1)
            {
                DeletingFromDateBase deleting = new DeletingFromDateBase();
                deleting.DeleteFromDatabase(hallsList.Halls[indexRow]);
                deleting.DeleteFromDatabase(hallsList.Halls[indexRow].Places);
                hallsList.Halls.RemoveAt(indexRow);
                ReadingFromDateBase reading = new ReadingFromDateBase();
                placesList = reading.ReadAllPlacesOfAllHalls();
                sourceData.ResetBindings(false);
            }
        }
        private void LoadSchemeOfHall(int seatingCapacity, int placesInRowLimit)
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
                if (i == buttonArray.Length - 1 && notEven)
                {
                    buttonArray[i] = new Button[leftPlaces];
                }
                for (int j = 0; j < buttonArray[i].Length; j++)
                {
                    buttonArray[i][j] = new Button();
                    buttonArray[i][j].Size = new Size(30, 30);
                    buttonArray[i][j].Name = (i + 1).ToString();
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
        private void FillingPlaces(Hall hall)
        {
            int hallId = hall.HallId;
            int seatingCapacity = hall.SeatingCapacity;
            int placesInRowLimit = hall.PlacesInRow;
            WritingInDatabase writing = new WritingInDatabase();
            int placeId = placesList.Places.Count() + 1;
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
                    PlaceInHall place = new PlaceInHall(placeId, hallId, i, j);
                    hall.Places.Add(place);
                    placesList.Places.Add(place);
                    placeId++;
                }
            }
            writing.WriteInDatabase(hall.Places);
            //writing.WriteInDatabase(placesList);
        }
        private void SelectedPlaceInHall(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            RowInput.Text = clickedButton.Name;
            PlaceInput.Text = clickedButton.Text;
        }
        private void ClearAllTextBoxesAndGroupBox()
        {
            HallPlaces.Controls.Clear();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(TextBox))
                            d.Text = string.Empty;

                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }
    }
}

