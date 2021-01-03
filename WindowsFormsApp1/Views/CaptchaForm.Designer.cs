namespace VK_PARSER.Views
{
    partial class CaptchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaForm));
            this.Captcha_PB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Login_L = new System.Windows.Forms.Label();
            this.OK_B = new System.Windows.Forms.Button();
            this.Authorization_L = new System.Windows.Forms.Label();
            this.SearchPanel_P = new System.Windows.Forms.Panel();
            this.Answer_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Captcha_PB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SearchPanel_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // Captcha_PB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Captcha_PB, 2);
            this.Captcha_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Captcha_PB.Location = new System.Drawing.Point(5, 56);
            this.Captcha_PB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Captcha_PB.Name = "Captcha_PB";
            this.Captcha_PB.Size = new System.Drawing.Size(368, 95);
            this.Captcha_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Captcha_PB.TabIndex = 0;
            this.Captcha_PB.TabStop = false;
            this.Captcha_PB.Paint += new System.Windows.Forms.PaintEventHandler(this.Captcha_PB_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel_B, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Login_L, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OK_B, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Authorization_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Captcha_PB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchPanel_P, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 297);
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.Cancel_B.Location = new System.Drawing.Point(5, 255);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(368, 36);
            this.Cancel_B.TabIndex = 10;
            this.Cancel_B.Text = "Отмена";
            this.Cancel_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_B.UseVisualStyleBackColor = false;
            this.Cancel_B.Click += new System.EventHandler(this.Cancel_B_Click);
            // 
            // Login_L
            // 
            this.Login_L.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Login_L, 2);
            this.Login_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_L.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.Login_L.Location = new System.Drawing.Point(5, 156);
            this.Login_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Login_L.Name = "Login_L";
            this.Login_L.Size = new System.Drawing.Size(368, 17);
            this.Login_L.TabIndex = 1;
            this.Login_L.Text = "Значение CAPTCHA";
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
            this.OK_B.Location = new System.Drawing.Point(5, 214);
            this.OK_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(368, 36);
            this.OK_B.TabIndex = 5;
            this.OK_B.Text = "Подтвердить";
            this.OK_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK_B.UseVisualStyleBackColor = false;
            this.OK_B.Click += new System.EventHandler(this.Login_B_Click);
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
            this.Authorization_L.Size = new System.Drawing.Size(368, 46);
            this.Authorization_L.TabIndex = 8;
            this.Authorization_L.Text = "CAPTCHA";
            this.Authorization_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPanel_P
            // 
            this.SearchPanel_P.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.SearchPanel_P, 2);
            this.SearchPanel_P.Controls.Add(this.Answer_TB);
            this.SearchPanel_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel_P.Location = new System.Drawing.Point(5, 178);
            this.SearchPanel_P.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.SearchPanel_P.Name = "SearchPanel_P";
            this.SearchPanel_P.Size = new System.Drawing.Size(368, 31);
            this.SearchPanel_P.TabIndex = 9;
            this.SearchPanel_P.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchPanel_P_Paint);
            // 
            // Answer_TB
            // 
            this.Answer_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Answer_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.Answer_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Answer_TB.Location = new System.Drawing.Point(10, 6);
            this.Answer_TB.Name = "Answer_TB";
            this.Answer_TB.Size = new System.Drawing.Size(351, 18);
            this.Answer_TB.TabIndex = 0;
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 297);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTCHA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptchaForm_FormClosing);
            this.Load += new System.EventHandler(this.CaptchaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Captcha_PB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SearchPanel_P.ResumeLayout(false);
            this.SearchPanel_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Captcha_PB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Login_L;
        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Label Authorization_L;
        private System.Windows.Forms.Panel SearchPanel_P;
        public System.Windows.Forms.TextBox Answer_TB;
        private System.Windows.Forms.Button Cancel_B;
    }
}