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
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Location = new System.Drawing.Point(21, 139);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.Size = new System.Drawing.Size(503, 205);
            this.dataGridViewSessions.TabIndex = 0;
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
            // DateComboBox
            // 
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Location = new System.Drawing.Point(91, 76);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(170, 21);
            this.DateComboBox.TabIndex = 11;
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Location = new System.Drawing.Point(91, 103);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(170, 21);
            this.TimeComboBox.TabIndex = 12;
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
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(449, 350);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(229, 350);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
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
            // fSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 432);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.FilmComboBox);
            this.Controls.Add(this.HallComboBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FilmIdLabel);
            this.Controls.Add(this.HallIdLabel);
            this.Controls.Add(this.dataGridViewSessions);
            this.Name = "fSessions";
            this.Text = "fSessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Label HallIdLabel;
        private System.Windows.Forms.Label FilmIdLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox HallComboBox;
        private System.Windows.Forms.ComboBox FilmComboBox;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.ComboBox TimeComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}