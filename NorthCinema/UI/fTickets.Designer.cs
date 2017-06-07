namespace NorthCinema.UI
{
    partial class fTickets
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
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SessionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SessionInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridViewPercents = new System.Windows.Forms.DataGridView();
            this.TicketLabel = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.TicketInput = new System.Windows.Forms.TextBox();
            this.RowInput = new System.Windows.Forms.TextBox();
            this.PlaceNumberInput = new System.Windows.Forms.TextBox();
            this.AgeVisitorLabel = new System.Windows.Forms.Label();
            this.AgeVistorPicker = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPercents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(21, 205);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTickets.Size = new System.Drawing.Size(369, 168);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // SessionLabel
            // 
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Location = new System.Drawing.Point(19, 34);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(38, 13);
            this.SessionLabel.TabIndex = 3;
            this.SessionLabel.Text = "Сеанс";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(19, 107);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Цена";
            // 
            // SessionInput
            // 
            this.SessionInput.Location = new System.Drawing.Point(113, 31);
            this.SessionInput.Name = "SessionInput";
            this.SessionInput.Size = new System.Drawing.Size(100, 20);
            this.SessionInput.TabIndex = 7;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(113, 107);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 20);
            this.PriceInput.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 379);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(315, 379);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(170, 379);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(315, 421);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridViewPercents
            // 
            this.dataGridViewPercents.AllowUserToAddRows = false;
            this.dataGridViewPercents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPercents.Location = new System.Drawing.Point(426, 205);
            this.dataGridViewPercents.MultiSelect = false;
            this.dataGridViewPercents.Name = "dataGridViewPercents";
            this.dataGridViewPercents.ReadOnly = true;
            this.dataGridViewPercents.RowHeadersVisible = false;
            this.dataGridViewPercents.Size = new System.Drawing.Size(324, 168);
            this.dataGridViewPercents.TabIndex = 16;
            // 
            // TicketLabel
            // 
            this.TicketLabel.AutoSize = true;
            this.TicketLabel.Location = new System.Drawing.Point(19, 9);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(37, 13);
            this.TicketLabel.TabIndex = 17;
            this.TicketLabel.Text = "Билет";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Location = new System.Drawing.Point(19, 60);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(26, 13);
            this.RowLabel.TabIndex = 18;
            this.RowLabel.Text = "Ряд";
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(19, 81);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(39, 13);
            this.PlaceNumberLabel.TabIndex = 19;
            this.PlaceNumberLabel.Text = "Место";
            // 
            // TicketInput
            // 
            this.TicketInput.Location = new System.Drawing.Point(113, 6);
            this.TicketInput.Name = "TicketInput";
            this.TicketInput.Size = new System.Drawing.Size(100, 20);
            this.TicketInput.TabIndex = 20;
            // 
            // RowInput
            // 
            this.RowInput.Location = new System.Drawing.Point(113, 57);
            this.RowInput.Name = "RowInput";
            this.RowInput.Size = new System.Drawing.Size(100, 20);
            this.RowInput.TabIndex = 21;
            // 
            // PlaceNumberInput
            // 
            this.PlaceNumberInput.Location = new System.Drawing.Point(113, 81);
            this.PlaceNumberInput.Name = "PlaceNumberInput";
            this.PlaceNumberInput.Size = new System.Drawing.Size(100, 20);
            this.PlaceNumberInput.TabIndex = 22;
            // 
            // AgeVisitorLabel
            // 
            this.AgeVisitorLabel.Location = new System.Drawing.Point(19, 133);
            this.AgeVisitorLabel.Name = "AgeVisitorLabel";
            this.AgeVisitorLabel.Size = new System.Drawing.Size(100, 28);
            this.AgeVisitorLabel.TabIndex = 23;
            this.AgeVisitorLabel.Text = "Дата рождения посетителя";
            // 
            // AgeVistorPicker
            // 
            this.AgeVistorPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AgeVistorPicker.Location = new System.Drawing.Point(113, 133);
            this.AgeVistorPicker.Name = "AgeVistorPicker";
            this.AgeVistorPicker.ShowUpDown = true;
            this.AgeVistorPicker.Size = new System.Drawing.Size(100, 20);
            this.AgeVistorPicker.TabIndex = 25;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(22, 179);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 26;
            this.DatePicker.Value = new System.DateTime(2017, 6, 7, 20, 28, 11, 0);
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(241, 179);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(149, 20);
            this.TimePicker.TabIndex = 27;
            this.TimePicker.Value = new System.DateTime(2017, 6, 7, 20, 28, 18, 0);
            // 
            // fTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 466);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.AgeVistorPicker);
            this.Controls.Add(this.AgeVisitorLabel);
            this.Controls.Add(this.PlaceNumberInput);
            this.Controls.Add(this.RowInput);
            this.Controls.Add(this.TicketInput);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.RowLabel);
            this.Controls.Add(this.TicketLabel);
            this.Controls.Add(this.dataGridViewPercents);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.SessionInput);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SessionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "fTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPercents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox SessionInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridViewPercents;
        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox TicketInput;
        private System.Windows.Forms.TextBox RowInput;
        private System.Windows.Forms.TextBox PlaceNumberInput;
        private System.Windows.Forms.Label AgeVisitorLabel;
        private System.Windows.Forms.DateTimePicker AgeVistorPicker;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
    }
}