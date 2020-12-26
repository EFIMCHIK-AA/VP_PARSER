namespace WindowsFormsApp1.Views
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
            this.Captcha_PB = new System.Windows.Forms.PictureBox();
            this.Answer_TB = new System.Windows.Forms.TextBox();
            this.Login_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Captcha_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Captcha_PB
            // 
            this.Captcha_PB.Location = new System.Drawing.Point(12, 12);
            this.Captcha_PB.Name = "Captcha_PB";
            this.Captcha_PB.Size = new System.Drawing.Size(258, 67);
            this.Captcha_PB.TabIndex = 0;
            this.Captcha_PB.TabStop = false;
            // 
            // Answer_TB
            // 
            this.Answer_TB.Location = new System.Drawing.Point(12, 101);
            this.Answer_TB.Name = "Answer_TB";
            this.Answer_TB.Size = new System.Drawing.Size(258, 20);
            this.Answer_TB.TabIndex = 1;
            // 
            // Login_B
            // 
            this.Login_B.Location = new System.Drawing.Point(12, 127);
            this.Login_B.Name = "Login_B";
            this.Login_B.Size = new System.Drawing.Size(258, 29);
            this.Login_B.TabIndex = 5;
            this.Login_B.Text = "Подтвердить";
            this.Login_B.UseVisualStyleBackColor = true;
            this.Login_B.Click += new System.EventHandler(this.Login_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Значение CAPTCHA";
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_B);
            this.Controls.Add(this.Answer_TB);
            this.Controls.Add(this.Captcha_PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchaForm";
            this.ShowIcon = false;
            this.Text = "CAPTCHA";
            ((System.ComponentModel.ISupportInitialize)(this.Captcha_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Login_B;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Captcha_PB;
        public System.Windows.Forms.TextBox Answer_TB;
    }
}