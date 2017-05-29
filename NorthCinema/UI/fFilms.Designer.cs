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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(21, 12);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.Size = new System.Drawing.Size(520, 166);
            this.dataGridViewFilm.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 182);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(240, 182);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(464, 184);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(464, 344);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fAdminFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 379);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridViewFilm);
            this.Name = "fAdminFilms";
            this.Text = "fAdminFilms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}