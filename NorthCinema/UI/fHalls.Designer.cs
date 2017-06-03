namespace NorthCinema.UI
{
    partial class fHalls
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
            this.NameHallLabel = new System.Windows.Forms.Label();
            this.NameHallInput = new System.Windows.Forms.TextBox();
            this.dataGridViewHalls = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.HallPlaces = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // NameHallLabel
            // 
            this.NameHallLabel.AutoSize = true;
            this.NameHallLabel.Location = new System.Drawing.Point(9, 19);
            this.NameHallLabel.Name = "NameHallLabel";
            this.NameHallLabel.Size = new System.Drawing.Size(84, 13);
            this.NameHallLabel.TabIndex = 1;
            this.NameHallLabel.Text = "Название зала";
            // 
            // NameHallInput
            // 
            this.NameHallInput.Location = new System.Drawing.Point(99, 16);
            this.NameHallInput.Name = "NameHallInput";
            this.NameHallInput.Size = new System.Drawing.Size(100, 20);
            this.NameHallInput.TabIndex = 3;
            // 
            // dataGridViewHalls
            // 
            this.dataGridViewHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHalls.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewHalls.MultiSelect = false;
            this.dataGridViewHalls.Name = "dataGridViewHalls";
            this.dataGridViewHalls.ReadOnly = true;
            this.dataGridViewHalls.Size = new System.Drawing.Size(366, 159);
            this.dataGridViewHalls.TabIndex = 4;
            this.dataGridViewHalls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHalls_CellClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(163, 267);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 225);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(163, 225);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(303, 225);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HallPlaces
            // 
            this.HallPlaces.AutoSize = true;
            this.HallPlaces.Location = new System.Drawing.Point(384, 12);
            this.HallPlaces.Name = "HallPlaces";
            this.HallPlaces.Size = new System.Drawing.Size(347, 207);
            this.HallPlaces.TabIndex = 9;
            this.HallPlaces.TabStop = false;
            this.HallPlaces.Text = "Схема зала";
            // 
            // fHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 336);
            this.Controls.Add(this.HallPlaces);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dataGridViewHalls);
            this.Controls.Add(this.NameHallInput);
            this.Controls.Add(this.NameHallLabel);
            this.Name = "fHalls";
            this.Text = "fHalls";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameHallLabel;
        private System.Windows.Forms.TextBox NameHallInput;
        private System.Windows.Forms.DataGridView dataGridViewHalls;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox HallPlaces;
    }
}