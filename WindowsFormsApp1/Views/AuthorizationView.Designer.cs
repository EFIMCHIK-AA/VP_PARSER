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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Login_L = new System.Windows.Forms.Label();
            this.Password_L = new System.Windows.Forms.Label();
            this.ShowPassword_CB = new System.Windows.Forms.CheckBox();
            this.Login_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Authorization_L = new System.Windows.Forms.Label();
            this.Logo_PB = new System.Windows.Forms.PictureBox();
            this.SearchPanel_P = new System.Windows.Forms.Panel();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).BeginInit();
            this.SearchPanel_P.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Login_L, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Password_L, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ShowPassword_CB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Login_B, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Exit_B, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Authorization_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Logo_PB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchPanel_P, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 285);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Login_L
            // 
            this.Login_L.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Login_L, 2);
            this.Login_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_L.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.Login_L.Location = new System.Drawing.Point(169, 56);
            this.Login_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Login_L.Name = "Login_L";
            this.Login_L.Size = new System.Drawing.Size(462, 17);
            this.Login_L.TabIndex = 1;
            this.Login_L.Text = "Имя пользователя";
            // 
            // Password_L
            // 
            this.Password_L.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Password_L, 2);
            this.Password_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password_L.Font = new System.Drawing.Font("Verdana", 10F);
            this.Password_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.Password_L.Location = new System.Drawing.Point(169, 114);
            this.Password_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Password_L.Name = "Password_L";
            this.Password_L.Size = new System.Drawing.Size(462, 17);
            this.Password_L.TabIndex = 5;
            this.Password_L.Text = "Пароль";
            // 
            // ShowPassword_CB
            // 
            this.ShowPassword_CB.AutoSize = true;
            this.ShowPassword_CB.BackColor = System.Drawing.Color.White;
            this.ShowPassword_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPassword_CB.Font = new System.Drawing.Font("Verdana", 10F);
            this.ShowPassword_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.ShowPassword_CB.Location = new System.Drawing.Point(169, 172);
            this.ShowPassword_CB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ShowPassword_CB.Name = "ShowPassword_CB";
            this.ShowPassword_CB.Size = new System.Drawing.Size(149, 21);
            this.ShowPassword_CB.TabIndex = 3;
            this.ShowPassword_CB.Text = "Показать пароль";
            this.ShowPassword_CB.UseVisualStyleBackColor = false;
            this.ShowPassword_CB.CheckedChanged += new System.EventHandler(this.ShowPassword_CB_CheckedChanged);
            // 
            // Login_B
            // 
            this.Login_B.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.Login_B, 2);
            this.Login_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.Login_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Login_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Login_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Login_B.Location = new System.Drawing.Point(169, 203);
            this.Login_B.Margin = new System.Windows.Forms.Padding(5);
            this.Login_B.Name = "Login_B";
            this.Login_B.Size = new System.Drawing.Size(462, 36);
            this.Login_B.TabIndex = 5;
            this.Login_B.Text = "Войти";
            this.Login_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login_B.UseVisualStyleBackColor = false;
            this.Login_B.Click += new System.EventHandler(this.Login_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.Exit_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Exit_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Exit_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.Exit_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Exit_B.Location = new System.Drawing.Point(169, 244);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(462, 36);
            this.Exit_B.TabIndex = 6;
            this.Exit_B.Text = "Выход";
            this.Exit_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Authorization_L
            // 
            this.Authorization_L.AutoSize = true;
            this.Authorization_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.SetColumnSpan(this.Authorization_L, 3);
            this.Authorization_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Authorization_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_L.Font = new System.Drawing.Font("Verdana", 16F);
            this.Authorization_L.ForeColor = System.Drawing.Color.White;
            this.Authorization_L.Location = new System.Drawing.Point(5, 5);
            this.Authorization_L.Margin = new System.Windows.Forms.Padding(5);
            this.Authorization_L.Name = "Authorization_L";
            this.Authorization_L.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Authorization_L.Size = new System.Drawing.Size(626, 46);
            this.Authorization_L.TabIndex = 8;
            this.Authorization_L.Text = "Авторизация";
            this.Authorization_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo_PB
            // 
            this.Logo_PB.BackColor = System.Drawing.Color.Transparent;
            this.Logo_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_PB.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PB.Image")));
            this.Logo_PB.Location = new System.Drawing.Point(5, 56);
            this.Logo_PB.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.Logo_PB.Name = "Logo_PB";
            this.tableLayoutPanel1.SetRowSpan(this.Logo_PB, 7);
            this.Logo_PB.Size = new System.Drawing.Size(159, 224);
            this.Logo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PB.TabIndex = 0;
            this.Logo_PB.TabStop = false;
            this.Logo_PB.Paint += new System.Windows.Forms.PaintEventHandler(this.Logo_PB_Paint);
            // 
            // SearchPanel_P
            // 
            this.SearchPanel_P.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.SearchPanel_P, 2);
            this.SearchPanel_P.Controls.Add(this.Login_TB);
            this.SearchPanel_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel_P.Location = new System.Drawing.Point(169, 78);
            this.SearchPanel_P.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.SearchPanel_P.Name = "SearchPanel_P";
            this.SearchPanel_P.Size = new System.Drawing.Size(462, 31);
            this.SearchPanel_P.TabIndex = 9;
            this.SearchPanel_P.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchPanel_P_Paint);
            // 
            // Login_TB
            // 
            this.Login_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.Login_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Login_TB.Location = new System.Drawing.Point(10, 6);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(423, 18);
            this.Login_TB.TabIndex = 0;
            this.Login_TB.Text = "+79069243777";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.Password_TB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(169, 136);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 31);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Password_TB
            // 
            this.Password_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.Password_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Password_TB.Location = new System.Drawing.Point(10, 6);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(423, 18);
            this.Password_TB.TabIndex = 0;
            this.Password_TB.Text = "Aleks1290!";
            this.Password_TB.UseSystemPasswordChar = true;
            // 
            // AuthorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AuthorizationView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthorizationView_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).EndInit();
            this.SearchPanel_P.ResumeLayout(false);
            this.SearchPanel_P.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Login_L;
        private System.Windows.Forms.Label Password_L;
        private System.Windows.Forms.CheckBox ShowPassword_CB;
        private System.Windows.Forms.Button Login_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Label Authorization_L;
        private System.Windows.Forms.PictureBox Logo_PB;
        private System.Windows.Forms.Panel SearchPanel_P;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Password_TB;
    }
}

