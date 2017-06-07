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
            this.TicketStatusLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SessionInput = new System.Windows.Forms.TextBox();
            this.DateOfEditInput = new System.Windows.Forms.TextBox();
            this.TicketStatusInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DateOfLastEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(21, 136);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTickets.Size = new System.Drawing.Size(369, 168);
            this.dataGridViewTickets.TabIndex = 0;
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
            this.SessionLabel.Location = new System.Drawing.Point(18, 10);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(38, 13);
            this.SessionLabel.TabIndex = 3;
            this.SessionLabel.Text = "Сеанс";
            // 
            // TicketStatusLabel
            // 
            this.TicketStatusLabel.AutoSize = true;
            this.TicketStatusLabel.Location = new System.Drawing.Point(18, 80);
            this.TicketStatusLabel.Name = "TicketStatusLabel";
            this.TicketStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.TicketStatusLabel.TabIndex = 4;
            this.TicketStatusLabel.Text = "Статус билета";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(18, 110);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Цена";
            // 
            // SessionInput
            // 
            this.SessionInput.Location = new System.Drawing.Point(145, 3);
            this.SessionInput.Name = "SessionInput";
            this.SessionInput.Size = new System.Drawing.Size(100, 20);
            this.SessionInput.TabIndex = 7;
            // 
            // DateOfEditInput
            // 
            this.DateOfEditInput.Location = new System.Drawing.Point(145, 38);
            this.DateOfEditInput.Name = "DateOfEditInput";
            this.DateOfEditInput.Size = new System.Drawing.Size(100, 20);
            this.DateOfEditInput.TabIndex = 8;
            // 
            // TicketStatusInput
            // 
            this.TicketStatusInput.Location = new System.Drawing.Point(145, 73);
            this.TicketStatusInput.Name = "TicketStatusInput";
            this.TicketStatusInput.Size = new System.Drawing.Size(100, 20);
            this.TicketStatusInput.TabIndex = 9;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(145, 107);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 20);
            this.PriceInput.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(315, 310);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(170, 310);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(315, 352);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DateOfLastEdit
            // 
            this.DateOfLastEdit.AutoSize = true;
            this.DateOfLastEdit.Location = new System.Drawing.Point(18, 45);
            this.DateOfLastEdit.Name = "DateOfLastEdit";
            this.DateOfLastEdit.Size = new System.Drawing.Size(122, 13);
            this.DateOfLastEdit.TabIndex = 15;
            this.DateOfLastEdit.Text = "Дата посл. изменения";
            // 
            // fTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.DateOfLastEdit);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.TicketStatusInput);
            this.Controls.Add(this.DateOfEditInput);
            this.Controls.Add(this.SessionInput);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TicketStatusLabel);
            this.Controls.Add(this.SessionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "fTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.Label TicketStatusLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox SessionInput;
        private System.Windows.Forms.TextBox DateOfEditInput;
        private System.Windows.Forms.TextBox TicketStatusInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DateOfLastEdit;
    }
}