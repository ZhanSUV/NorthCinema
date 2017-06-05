namespace NorthCinema.UI
{
    partial class fProcents
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
            this.DiscountOrMarkupLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.dataGridViewPercents = new System.Windows.Forms.DataGridView();
            this.DiscountOrMarkupInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.PercentInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPercents)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountOrMarkupLabel
            // 
            this.DiscountOrMarkupLabel.AutoSize = true;
            this.DiscountOrMarkupLabel.Location = new System.Drawing.Point(25, 25);
            this.DiscountOrMarkupLabel.Name = "DiscountOrMarkupLabel";
            this.DiscountOrMarkupLabel.Size = new System.Drawing.Size(93, 13);
            this.DiscountOrMarkupLabel.TabIndex = 0;
            this.DiscountOrMarkupLabel.Text = "Скидка/Наценка";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(25, 63);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Описание";
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(25, 101);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(50, 13);
            this.PercentLabel.TabIndex = 2;
            this.PercentLabel.Text = "Процент";
            // 
            // dataGridViewPercents
            // 
            this.dataGridViewPercents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPercents.Location = new System.Drawing.Point(28, 142);
            this.dataGridViewPercents.Name = "dataGridViewPercents";
            this.dataGridViewPercents.Size = new System.Drawing.Size(494, 172);
            this.dataGridViewPercents.TabIndex = 3;
            this.dataGridViewPercents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPercents_CellClick);
            // 
            // DiscountOrMarkupInput
            // 
            this.DiscountOrMarkupInput.Location = new System.Drawing.Point(124, 22);
            this.DiscountOrMarkupInput.Name = "DiscountOrMarkupInput";
            this.DiscountOrMarkupInput.Size = new System.Drawing.Size(143, 20);
            this.DiscountOrMarkupInput.TabIndex = 4;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(124, 60);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(143, 20);
            this.DescriptionInput.TabIndex = 5;
            // 
            // PercentInput
            // 
            this.PercentInput.Location = new System.Drawing.Point(124, 98);
            this.PercentInput.Name = "PercentInput";
            this.PercentInput.Size = new System.Drawing.Size(143, 20);
            this.PercentInput.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(28, 320);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(236, 319);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(447, 319);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(447, 379);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fProcents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PercentInput);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.DiscountOrMarkupInput);
            this.Controls.Add(this.dataGridViewPercents);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DiscountOrMarkupLabel);
            this.Name = "fProcents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProcents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPercents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiscountOrMarkupLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.DataGridView dataGridViewPercents;
        private System.Windows.Forms.TextBox DiscountOrMarkupInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.TextBox PercentInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}