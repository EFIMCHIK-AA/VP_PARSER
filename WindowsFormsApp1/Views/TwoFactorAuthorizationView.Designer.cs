namespace WindowsFormsApp1.Views
{
    partial class TwoFactorAuthorizationView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Login_L = new System.Windows.Forms.Label();
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Authorization_L = new System.Windows.Forms.Label();
            this.SearchPanel_P = new System.Windows.Forms.Panel();
            this.Code_TB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SearchPanel_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Login_L, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OK_B, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_B, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Authorization_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchPanel_P, 0, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 197);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Login_L
            // 
            this.Login_L.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Login_L, 2);
            this.Login_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_L.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.Login_L.Location = new System.Drawing.Point(5, 56);
            this.Login_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Login_L.Name = "Login_L";
            this.Login_L.Size = new System.Drawing.Size(437, 17);
            this.Login_L.TabIndex = 1;
            this.Login_L.Text = "Код авторизации";
            this.Login_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.OK_B, 2);
            this.OK_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.OK_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.OK_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.OK_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.OK_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.OK_B.Location = new System.Drawing.Point(5, 114);
            this.OK_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(437, 36);
            this.OK_B.TabIndex = 5;
            this.OK_B.Text = "Подтвердить";
            this.OK_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // Cancel_B
            // 
            this.Cancel_B.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.Cancel_B, 2);
            this.Cancel_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.Cancel_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Cancel_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Cancel_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.Cancel_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Cancel_B.Location = new System.Drawing.Point(5, 155);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(437, 36);
            this.Cancel_B.TabIndex = 6;
            this.Cancel_B.Text = "Выход";
            this.Cancel_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_B.UseVisualStyleBackColor = false;
            // 
            // Authorization_L
            // 
            this.Authorization_L.AutoSize = true;
            this.Authorization_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.SetColumnSpan(this.Authorization_L, 2);
            this.Authorization_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Authorization_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_L.Font = new System.Drawing.Font("Verdana", 16F);
            this.Authorization_L.ForeColor = System.Drawing.Color.White;
            this.Authorization_L.Location = new System.Drawing.Point(5, 5);
            this.Authorization_L.Margin = new System.Windows.Forms.Padding(5);
            this.Authorization_L.Name = "Authorization_L";
            this.Authorization_L.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Authorization_L.Size = new System.Drawing.Size(437, 46);
            this.Authorization_L.TabIndex = 8;
            this.Authorization_L.Text = "Двухфакторная авторизация";
            this.Authorization_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPanel_P
            // 
            this.SearchPanel_P.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.SearchPanel_P, 2);
            this.SearchPanel_P.Controls.Add(this.Code_TB);
            this.SearchPanel_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel_P.Location = new System.Drawing.Point(5, 78);
            this.SearchPanel_P.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.SearchPanel_P.Name = "SearchPanel_P";
            this.SearchPanel_P.Size = new System.Drawing.Size(437, 31);
            this.SearchPanel_P.TabIndex = 9;
            this.SearchPanel_P.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchPanel_P_Paint);
            // 
            // Code_TB
            // 
            this.Code_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Code_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.Code_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Code_TB.Location = new System.Drawing.Point(10, 6);
            this.Code_TB.Name = "Code_TB";
            this.Code_TB.Size = new System.Drawing.Size(420, 18);
            this.Code_TB.TabIndex = 0;
            // 
            // TwoFactorAuthorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwoFactorAuthorizationView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Двухфакторная авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwoFactorAuthorizationView_FormClosing);
            this.Load += new System.EventHandler(this.TwoFactorAuthorizationView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SearchPanel_P.ResumeLayout(false);
            this.SearchPanel_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Login_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label Authorization_L;
        private System.Windows.Forms.Panel SearchPanel_P;
        public System.Windows.Forms.TextBox Code_TB;
    }
}