namespace WindowsFormsApp1.Views
{
    partial class AuthorizationView
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
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Login_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(23, 40);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(208, 20);
            this.Login_TB.TabIndex = 0;
            this.Login_TB.Text = "+79069243777";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(23, 82);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(208, 20);
            this.Password_TB.TabIndex = 2;
            this.Password_TB.Text = "Aleks1290!";
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // Login_B
            // 
            this.Login_B.Location = new System.Drawing.Point(23, 109);
            this.Login_B.Name = "Login_B";
            this.Login_B.Size = new System.Drawing.Size(208, 29);
            this.Login_B.TabIndex = 4;
            this.Login_B.Text = "Войти";
            this.Login_B.UseVisualStyleBackColor = true;
            this.Login_B.Click += new System.EventHandler(this.Login_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(23, 144);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(208, 29);
            this.Exit_B.TabIndex = 5;
            this.Exit_B.Text = "Выйти";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // AuthorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 196);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Login_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Login_TB;
        public System.Windows.Forms.TextBox Password_TB;
        public System.Windows.Forms.Button Login_B;
        public System.Windows.Forms.Button Exit_B;
    }
}

