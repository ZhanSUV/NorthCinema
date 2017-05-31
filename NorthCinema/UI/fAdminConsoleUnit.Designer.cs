namespace NorthCinema.UI
{
    partial class fAdminConsoleUnit
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
            this.Film = new System.Windows.Forms.Button();
            this.Session = new System.Windows.Forms.Button();
            this.Hall = new System.Windows.Forms.Button();
            this.Cashier = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Film
            // 
            this.Film.Location = new System.Drawing.Point(101, 16);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(75, 23);
            this.Film.TabIndex = 0;
            this.Film.Text = "Фильмы";
            this.Film.UseVisualStyleBackColor = true;
            this.Film.Click += new System.EventHandler(this.Film_Click);
            // 
            // Session
            // 
            this.Session.Location = new System.Drawing.Point(101, 58);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(75, 23);
            this.Session.TabIndex = 1;
            this.Session.Text = "Сеансы";
            this.Session.UseVisualStyleBackColor = true;
            this.Session.Click += new System.EventHandler(this.Session_Click);
            // 
            // Hall
            // 
            this.Hall.Location = new System.Drawing.Point(101, 100);
            this.Hall.Name = "Hall";
            this.Hall.Size = new System.Drawing.Size(75, 23);
            this.Hall.TabIndex = 2;
            this.Hall.Text = "Кинозалы";
            this.Hall.UseVisualStyleBackColor = true;
            this.Hall.Click += new System.EventHandler(this.Hall_Click);
            // 
            // Cashier
            // 
            this.Cashier.Location = new System.Drawing.Point(101, 141);
            this.Cashier.Name = "Cashier";
            this.Cashier.Size = new System.Drawing.Size(75, 23);
            this.Cashier.TabIndex = 3;
            this.Cashier.Text = "Кассиры";
            this.Cashier.UseVisualStyleBackColor = true;
            this.Cashier.Click += new System.EventHandler(this.Cashier_Click);
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(101, 184);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(75, 23);
            this.Percent.TabIndex = 4;
            this.Percent.Text = "Проценты";
            this.Percent.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(101, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fAdminConsoleUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Cashier);
            this.Controls.Add(this.Hall);
            this.Controls.Add(this.Session);
            this.Controls.Add(this.Film);
            this.Name = "fAdminConsoleUnit";
            this.Text = "fAdminConsoleUnit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Film;
        private System.Windows.Forms.Button Session;
        private System.Windows.Forms.Button Hall;
        private System.Windows.Forms.Button Cashier;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Exit;
    }
}