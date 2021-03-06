﻿namespace NorthCinema.UI
{
    partial class fSessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.HallIdLabel = new System.Windows.Forms.Label();
            this.FilmIdLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.HallComboBox = new System.Windows.Forms.ComboBox();
            this.FilmComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DateInputPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeInputPicker = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SearchingNameFilm = new System.Windows.Forms.Label();
            this.FilterNameFilmInput = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FilterNameFilmWithDate = new System.Windows.Forms.Button();
            this.ResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AllowUserToAddRows = false;
            this.dataGridViewSessions.AllowUserToOrderColumns = true;
            this.dataGridViewSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Location = new System.Drawing.Point(21, 132);
            this.dataGridViewSessions.MultiSelect = false;
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.ReadOnly = true;
            this.dataGridViewSessions.RowHeadersVisible = false;
            this.dataGridViewSessions.Size = new System.Drawing.Size(503, 205);
            this.dataGridViewSessions.TabIndex = 0;
            this.dataGridViewSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSessions_CellClick);
            // 
            // HallIdLabel
            // 
            this.HallIdLabel.AutoSize = true;
            this.HallIdLabel.Location = new System.Drawing.Point(27, 18);
            this.HallIdLabel.Name = "HallIdLabel";
            this.HallIdLabel.Size = new System.Drawing.Size(26, 13);
            this.HallIdLabel.TabIndex = 2;
            this.HallIdLabel.Text = "Зал";
            // 
            // FilmIdLabel
            // 
            this.FilmIdLabel.AutoSize = true;
            this.FilmIdLabel.Location = new System.Drawing.Point(27, 49);
            this.FilmIdLabel.Name = "FilmIdLabel";
            this.FilmIdLabel.Size = new System.Drawing.Size(44, 13);
            this.FilmIdLabel.TabIndex = 3;
            this.FilmIdLabel.Text = "Фильм";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(27, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Дата";
            // 
            // HallComboBox
            // 
            this.HallComboBox.FormattingEnabled = true;
            this.HallComboBox.Location = new System.Drawing.Point(91, 18);
            this.HallComboBox.Name = "HallComboBox";
            this.HallComboBox.Size = new System.Drawing.Size(170, 21);
            this.HallComboBox.TabIndex = 9;
            // 
            // FilmComboBox
            // 
            this.FilmComboBox.FormattingEnabled = true;
            this.FilmComboBox.Location = new System.Drawing.Point(91, 46);
            this.FilmComboBox.Name = "FilmComboBox";
            this.FilmComboBox.Size = new System.Drawing.Size(170, 21);
            this.FilmComboBox.TabIndex = 10;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(27, 106);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 13);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Время";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 350);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(449, 350);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(229, 350);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(449, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DateInputPicker
            // 
            this.DateInputPicker.CustomFormat = "";
            this.DateInputPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInputPicker.Location = new System.Drawing.Point(91, 76);
            this.DateInputPicker.MinDate = new System.DateTime(2016, 8, 17, 0, 0, 0, 0);
            this.DateInputPicker.Name = "DateInputPicker";
            this.DateInputPicker.Size = new System.Drawing.Size(200, 20);
            this.DateInputPicker.TabIndex = 18;
            this.DateInputPicker.Value = new System.DateTime(2017, 6, 3, 12, 52, 45, 0);
            // 
            // TimeInputPicker
            // 
            this.TimeInputPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeInputPicker.CustomFormat = "HH:mm";
            this.TimeInputPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeInputPicker.Location = new System.Drawing.Point(91, 106);
            this.TimeInputPicker.Name = "TimeInputPicker";
            this.TimeInputPicker.RightToLeftLayout = true;
            this.TimeInputPicker.ShowUpDown = true;
            this.TimeInputPicker.Size = new System.Drawing.Size(200, 20);
            this.TimeInputPicker.TabIndex = 19;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(585, 132);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 20;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // SearchingNameFilm
            // 
            this.SearchingNameFilm.AutoSize = true;
            this.SearchingNameFilm.Location = new System.Drawing.Point(582, 1);
            this.SearchingNameFilm.Name = "SearchingNameFilm";
            this.SearchingNameFilm.Size = new System.Drawing.Size(100, 13);
            this.SearchingNameFilm.TabIndex = 21;
            this.SearchingNameFilm.Text = "Название фильма";
            // 
            // FilterNameFilmInput
            // 
            this.FilterNameFilmInput.Location = new System.Drawing.Point(585, 17);
            this.FilterNameFilmInput.Name = "FilterNameFilmInput";
            this.FilterNameFilmInput.Size = new System.Drawing.Size(164, 20);
            this.FilterNameFilmInput.TabIndex = 22;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(585, 45);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(164, 23);
            this.FindButton.TabIndex = 23;
            this.FindButton.Text = "Фильтр по названию";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FilterNameFilmWithDate
            // 
            this.FilterNameFilmWithDate.Location = new System.Drawing.Point(585, 72);
            this.FilterNameFilmWithDate.Name = "FilterNameFilmWithDate";
            this.FilterNameFilmWithDate.Size = new System.Drawing.Size(164, 23);
            this.FilterNameFilmWithDate.TabIndex = 24;
            this.FilterNameFilmWithDate.Text = "Фильтр по названию и дате";
            this.FilterNameFilmWithDate.UseVisualStyleBackColor = true;
            this.FilterNameFilmWithDate.Click += new System.EventHandler(this.FilterNameFilmWithDate_Click);
            // 
            // ResetFilter
            // 
            this.ResetFilter.Location = new System.Drawing.Point(585, 102);
            this.ResetFilter.Name = "ResetFilter";
            this.ResetFilter.Size = new System.Drawing.Size(164, 23);
            this.ResetFilter.TabIndex = 25;
            this.ResetFilter.Text = "Сброс фильтра";
            this.ResetFilter.UseVisualStyleBackColor = true;
            this.ResetFilter.Click += new System.EventHandler(this.ResetFilter_Click);
            // 
            // fSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 432);
            this.Controls.Add(this.ResetFilter);
            this.Controls.Add(this.FilterNameFilmWithDate);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FilterNameFilmInput);
            this.Controls.Add(this.SearchingNameFilm);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.TimeInputPicker);
            this.Controls.Add(this.DateInputPicker);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.FilmComboBox);
            this.Controls.Add(this.HallComboBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FilmIdLabel);
            this.Controls.Add(this.HallIdLabel);
            this.Controls.Add(this.dataGridViewSessions);
            this.Name = "fSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HallIdLabel;
        private System.Windows.Forms.Label FilmIdLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox HallComboBox;
        private System.Windows.Forms.ComboBox FilmComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.DateTimePicker DateInputPicker;
        private System.Windows.Forms.DateTimePicker TimeInputPicker;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label SearchingNameFilm;
        private System.Windows.Forms.TextBox FilterNameFilmInput;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button FilterNameFilmWithDate;
        private System.Windows.Forms.Button ResetFilter;
    }
}