namespace NorthCinema.UI
{
    partial class fAdminFilms
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
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameFilmLabel = new System.Windows.Forms.Label();
            this.LengthFilmLabel = new System.Windows.Forms.Label();
            this.AgeLimitLabel = new System.Windows.Forms.Label();
            this.TicketPriceLabel = new System.Windows.Forms.Label();
            this.NameFilmInput = new System.Windows.Forms.TextBox();
            this.FilmLengthInput = new System.Windows.Forms.TextBox();
            this.AgeLimitInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.AllowUserToOrderColumns = true;
            this.dataGridViewFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFilm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(21, 176);
            this.dataGridViewFilm.MultiSelect = false;
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.ReadOnly = true;
            this.dataGridViewFilm.Size = new System.Drawing.Size(520, 166);
            this.dataGridViewFilm.TabIndex = 0;
            this.dataGridViewFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(240, 346);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(464, 348);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(464, 390);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NameFilmLabel
            // 
            this.NameFilmLabel.AutoSize = true;
            this.NameFilmLabel.Location = new System.Drawing.Point(18, 37);
            this.NameFilmLabel.Name = "NameFilmLabel";
            this.NameFilmLabel.Size = new System.Drawing.Size(100, 13);
            this.NameFilmLabel.TabIndex = 6;
            this.NameFilmLabel.Text = "Название фильма";
            // 
            // LengthFilmLabel
            // 
            this.LengthFilmLabel.AutoSize = true;
            this.LengthFilmLabel.Location = new System.Drawing.Point(18, 70);
            this.LengthFilmLabel.Name = "LengthFilmLabel";
            this.LengthFilmLabel.Size = new System.Drawing.Size(80, 13);
            this.LengthFilmLabel.TabIndex = 7;
            this.LengthFilmLabel.Text = "Длительность";
            this.LengthFilmLabel.UseMnemonic = false;
            // 
            // AgeLimitLabel
            // 
            this.AgeLimitLabel.AutoSize = true;
            this.AgeLimitLabel.Location = new System.Drawing.Point(18, 102);
            this.AgeLimitLabel.Name = "AgeLimitLabel";
            this.AgeLimitLabel.Size = new System.Drawing.Size(134, 13);
            this.AgeLimitLabel.TabIndex = 8;
            this.AgeLimitLabel.Text = "Возрастное ограничение";
            // 
            // TicketPriceLabel
            // 
            this.TicketPriceLabel.AutoSize = true;
            this.TicketPriceLabel.Location = new System.Drawing.Point(18, 139);
            this.TicketPriceLabel.Name = "TicketPriceLabel";
            this.TicketPriceLabel.Size = new System.Drawing.Size(71, 13);
            this.TicketPriceLabel.TabIndex = 9;
            this.TicketPriceLabel.Text = "Цена билета";
            // 
            // NameFilmInput
            // 
            this.NameFilmInput.Location = new System.Drawing.Point(158, 33);
            this.NameFilmInput.Name = "NameFilmInput";
            this.NameFilmInput.Size = new System.Drawing.Size(172, 20);
            this.NameFilmInput.TabIndex = 11;
            // 
            // FilmLengthInput
            // 
            this.FilmLengthInput.Location = new System.Drawing.Point(158, 65);
            this.FilmLengthInput.Name = "FilmLengthInput";
            this.FilmLengthInput.Size = new System.Drawing.Size(172, 20);
            this.FilmLengthInput.TabIndex = 12;
            // 
            // AgeLimitInput
            // 
            this.AgeLimitInput.Location = new System.Drawing.Point(158, 100);
            this.AgeLimitInput.Name = "AgeLimitInput";
            this.AgeLimitInput.Size = new System.Drawing.Size(172, 20);
            this.AgeLimitInput.TabIndex = 13;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(158, 138);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(172, 20);
            this.PriceInput.TabIndex = 14;
            // 
            // fAdminFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 439);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.AgeLimitInput);
            this.Controls.Add(this.FilmLengthInput);
            this.Controls.Add(this.NameFilmInput);
            this.Controls.Add(this.TicketPriceLabel);
            this.Controls.Add(this.AgeLimitLabel);
            this.Controls.Add(this.LengthFilmLabel);
            this.Controls.Add(this.NameFilmLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridViewFilm);
            this.Name = "fAdminFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdminFilms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label NameFilmLabel;
        private System.Windows.Forms.Label LengthFilmLabel;
        private System.Windows.Forms.Label AgeLimitLabel;
        private System.Windows.Forms.Label TicketPriceLabel;
        private System.Windows.Forms.TextBox NameFilmInput;
        private System.Windows.Forms.TextBox FilmLengthInput;
        private System.Windows.Forms.TextBox AgeLimitInput;
        private System.Windows.Forms.TextBox PriceInput;
    }
}