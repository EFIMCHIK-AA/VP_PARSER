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
            this.Web_WB = new System.Windows.Forms.WebBrowser();
            this.LoaderTable_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.Loader_PB = new System.Windows.Forms.PictureBox();
            this.DescOps_L = new System.Windows.Forms.Label();
            this.LoaderTable_TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loader_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Web_WB
            // 
            this.Web_WB.AllowWebBrowserDrop = false;
            this.Web_WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Web_WB.Location = new System.Drawing.Point(0, 0);
            this.Web_WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_WB.Name = "Web_WB";
            this.Web_WB.Size = new System.Drawing.Size(393, 468);
            this.Web_WB.TabIndex = 8;
            this.Web_WB.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.Web_WB_Navigated);
            this.Web_WB.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Web_WB_Navigating);
            this.Web_WB.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.Web_WB_ProgressChanged);
            // 
            // LoaderTable_TLP
            // 
            this.LoaderTable_TLP.BackColor = System.Drawing.Color.White;
            this.LoaderTable_TLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LoaderTable_TLP.ColumnCount = 1;
            this.LoaderTable_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoaderTable_TLP.Controls.Add(this.Loader_PB, 0, 0);
            this.LoaderTable_TLP.Controls.Add(this.DescOps_L, 0, 1);
            this.LoaderTable_TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderTable_TLP.Location = new System.Drawing.Point(0, 0);
            this.LoaderTable_TLP.Name = "LoaderTable_TLP";
            this.LoaderTable_TLP.Padding = new System.Windows.Forms.Padding(3);
            this.LoaderTable_TLP.RowCount = 2;
            this.LoaderTable_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LoaderTable_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoaderTable_TLP.Size = new System.Drawing.Size(393, 468);
            this.LoaderTable_TLP.TabIndex = 9;
            this.LoaderTable_TLP.Visible = false;
            // 
            // Loader_PB
            // 
            this.Loader_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loader_PB.Image = global::WindowsFormsApp1.Properties.Resources.loader;
            this.Loader_PB.Location = new System.Drawing.Point(9, 9);
            this.Loader_PB.Margin = new System.Windows.Forms.Padding(5);
            this.Loader_PB.Name = "Loader_PB";
            this.Loader_PB.Size = new System.Drawing.Size(375, 311);
            this.Loader_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Loader_PB.TabIndex = 0;
            this.Loader_PB.TabStop = false;
            // 
            // DescOps_L
            // 
            this.DescOps_L.AutoSize = true;
            this.DescOps_L.BackColor = System.Drawing.Color.White;
            this.DescOps_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescOps_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.DescOps_L.Location = new System.Drawing.Point(9, 331);
            this.DescOps_L.Margin = new System.Windows.Forms.Padding(5);
            this.DescOps_L.Name = "DescOps_L";
            this.DescOps_L.Size = new System.Drawing.Size(375, 128);
            this.DescOps_L.TabIndex = 1;
            this.DescOps_L.Text = "Загрузка страницы...\r\n\r\nЕсли анимация загрузки проигрывается слишком долго, то пр" +
    "оверьте подключение к интернету и перезаупустите программу";
            this.DescOps_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 468);
            this.Controls.Add(this.Web_WB);
            this.Controls.Add(this.LoaderTable_TLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AuthorizationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationView_Load);
            this.LoaderTable_TLP.ResumeLayout(false);
            this.LoaderTable_TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loader_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser Web_WB;
        public System.Windows.Forms.TableLayoutPanel LoaderTable_TLP;
        public System.Windows.Forms.PictureBox Loader_PB;
        public System.Windows.Forms.Label DescOps_L;
    }
}

