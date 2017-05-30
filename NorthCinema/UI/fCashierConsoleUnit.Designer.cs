namespace NorthCinema.UI
{
    partial class fCashierConsoleUnit
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
            this.FilmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmButton
            // 
            this.FilmButton.Location = new System.Drawing.Point(109, 39);
            this.FilmButton.Name = "FilmButton";
            this.FilmButton.Size = new System.Drawing.Size(75, 23);
            this.FilmButton.TabIndex = 0;
            this.FilmButton.Text = "Фильмы";
            this.FilmButton.UseVisualStyleBackColor = true;
            this.FilmButton.Click += new System.EventHandler(this.FilmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(109, 199);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fCashierConsoleUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FilmButton);
            this.Name = "fCashierConsoleUnit";
            this.Text = "fCashierConsoleUnit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilmButton;
        private System.Windows.Forms.Button ExitButton;
    }
}