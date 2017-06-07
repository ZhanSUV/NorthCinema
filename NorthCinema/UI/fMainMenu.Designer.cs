namespace NorthCinema
{
    partial class fMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Authorization = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(92, 173);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(98, 23);
            this.Authorization.TabIndex = 0;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(92, 215);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Authorization);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Button Exit;
    }
}

