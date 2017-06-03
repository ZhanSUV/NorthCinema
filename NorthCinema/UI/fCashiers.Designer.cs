namespace NorthCinema.UI
{
    partial class fCashiers
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.SecondNameInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.dataGridViewCashiers = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashiers)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 42);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 15);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(14, 69);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.SecondNameLabel.TabIndex = 2;
            this.SecondNameLabel.Text = "Отчество";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(14, 96);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(14, 123);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(70, 39);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(141, 20);
            this.FirstNameInput.TabIndex = 5;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(70, 12);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(141, 20);
            this.LastNameInput.TabIndex = 6;
            // 
            // SecondNameInput
            // 
            this.SecondNameInput.Location = new System.Drawing.Point(70, 66);
            this.SecondNameInput.Name = "SecondNameInput";
            this.SecondNameInput.Size = new System.Drawing.Size(141, 20);
            this.SecondNameInput.TabIndex = 7;
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(70, 93);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(141, 20);
            this.LoginInput.TabIndex = 8;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(70, 120);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(141, 20);
            this.PasswordInput.TabIndex = 9;
            // 
            // dataGridViewCashiers
            // 
            this.dataGridViewCashiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashiers.Location = new System.Drawing.Point(44, 146);
            this.dataGridViewCashiers.MultiSelect = false;
            this.dataGridViewCashiers.Name = "dataGridViewCashiers";
            this.dataGridViewCashiers.ReadOnly = true;
            this.dataGridViewCashiers.Size = new System.Drawing.Size(383, 196);
            this.dataGridViewCashiers.TabIndex = 10;
            this.dataGridViewCashiers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCashiers_CellClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(44, 348);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(352, 348);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(200, 348);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(390, 402);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fCashiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 437);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridViewCashiers);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.SecondNameInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "fCashiers";
            this.Text = "fCashiers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashiers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox SecondNameInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.DataGridView dataGridViewCashiers;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}