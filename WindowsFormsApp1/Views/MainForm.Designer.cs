namespace WindowsFormsApp1.Views
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Data_DGV = new System.Windows.Forms.DataGridView();
            this.Male = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Female = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups_DGV = new System.Windows.Forms.DataGridView();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Log_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.StartRange_P = new System.Windows.Forms.Panel();
            this.StartRangeAge_TB = new System.Windows.Forms.TextBox();
            this.EndRange_P = new System.Windows.Forms.Panel();
            this.EndRangeAge_TB = new System.Windows.Forms.TextBox();
            this.Start_B = new System.Windows.Forms.Button();
            this.EndRange_L = new System.Windows.Forms.Label();
            this.StartRange_L = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserAgeFilter_CB = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportSplit_B = new System.Windows.Forms.Button();
            this.Export_B = new System.Windows.Forms.Button();
            this.Description_L = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserName_B = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_DGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.StartRange_P.SuspendLayout();
            this.EndRange_P.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_DGV
            // 
            this.Data_DGV.AllowUserToAddRows = false;
            this.Data_DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Data_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Data_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle8.NullValue = "Не задано";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Data_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Male,
            this.Female});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_DGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.Data_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_DGV.Location = new System.Drawing.Point(3, 55);
            this.Data_DGV.Margin = new System.Windows.Forms.Padding(1);
            this.Data_DGV.Name = "Data_DGV";
            this.Data_DGV.ReadOnly = true;
            this.Data_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Data_DGV.RowHeadersVisible = false;
            this.Data_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Data_DGV.Size = new System.Drawing.Size(532, 343);
            this.Data_DGV.TabIndex = 15;
            // 
            // Male
            // 
            this.Male.HeaderText = "Мужские";
            this.Male.Name = "Male";
            this.Male.ReadOnly = true;
            this.Male.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Female
            // 
            this.Female.HeaderText = "Женские";
            this.Female.Name = "Female";
            this.Female.ReadOnly = true;
            this.Female.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Groups_DGV
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Groups_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Groups_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Groups_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Groups_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Groups_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle11.NullValue = "Не задано";
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Groups_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groups_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameGroup});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_DGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.Groups_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Groups_DGV.Location = new System.Drawing.Point(2, 53);
            this.Groups_DGV.Margin = new System.Windows.Forms.Padding(1);
            this.Groups_DGV.MultiSelect = false;
            this.Groups_DGV.Name = "Groups_DGV";
            this.Groups_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Groups_DGV.RowHeadersVisible = false;
            this.Groups_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Groups_DGV.Size = new System.Drawing.Size(355, 389);
            this.Groups_DGV.TabIndex = 17;
            // 
            // NameGroup
            // 
            this.NameGroup.HeaderText = "Наименование";
            this.NameGroup.Name = "NameGroup";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 799);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Log_TB, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 591);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(902, 203);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // Log_TB
            // 
            this.Log_TB.BackColor = System.Drawing.Color.White;
            this.Log_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.Log_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Log_TB.Location = new System.Drawing.Point(5, 57);
            this.Log_TB.Multiline = true;
            this.Log_TB.Name = "Log_TB";
            this.Log_TB.ReadOnly = true;
            this.Log_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_TB.Size = new System.Drawing.Size(892, 141);
            this.Log_TB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лог";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel8.ColumnCount = 8;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel8, 2);
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.Controls.Add(this.StartRange_P, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.EndRange_P, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.Start_B, 7, 0);
            this.tableLayoutPanel8.Controls.Add(this.EndRange_L, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.StartRange_L, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.UserAgeFilter_CB, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(912, 41);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // StartRange_P
            // 
            this.StartRange_P.BackColor = System.Drawing.Color.White;
            this.StartRange_P.Controls.Add(this.StartRangeAge_TB);
            this.StartRange_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartRange_P.Location = new System.Drawing.Point(345, 5);
            this.StartRange_P.Margin = new System.Windows.Forms.Padding(5);
            this.StartRange_P.Name = "StartRange_P";
            this.StartRange_P.Size = new System.Drawing.Size(140, 31);
            this.StartRange_P.TabIndex = 23;
            this.StartRange_P.Visible = false;
            this.StartRange_P.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // StartRangeAge_TB
            // 
            this.StartRangeAge_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartRangeAge_TB.BackColor = System.Drawing.Color.White;
            this.StartRangeAge_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartRangeAge_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.StartRangeAge_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.StartRangeAge_TB.Location = new System.Drawing.Point(4, 7);
            this.StartRangeAge_TB.Name = "StartRangeAge_TB";
            this.StartRangeAge_TB.Size = new System.Drawing.Size(131, 18);
            this.StartRangeAge_TB.TabIndex = 0;
            this.StartRangeAge_TB.Text = "1";
            this.StartRangeAge_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndRange_P
            // 
            this.EndRange_P.BackColor = System.Drawing.Color.White;
            this.EndRange_P.Controls.Add(this.EndRangeAge_TB);
            this.EndRange_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndRange_P.Location = new System.Drawing.Point(567, 5);
            this.EndRange_P.Margin = new System.Windows.Forms.Padding(5);
            this.EndRange_P.Name = "EndRange_P";
            this.EndRange_P.Size = new System.Drawing.Size(140, 31);
            this.EndRange_P.TabIndex = 7;
            this.EndRange_P.Visible = false;
            this.EndRange_P.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EndRangeAge_TB
            // 
            this.EndRangeAge_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndRangeAge_TB.BackColor = System.Drawing.Color.White;
            this.EndRangeAge_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndRangeAge_TB.Font = new System.Drawing.Font("Verdana", 11F);
            this.EndRangeAge_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.EndRangeAge_TB.Location = new System.Drawing.Point(4, 8);
            this.EndRangeAge_TB.Name = "EndRangeAge_TB";
            this.EndRangeAge_TB.Size = new System.Drawing.Size(131, 18);
            this.EndRangeAge_TB.TabIndex = 0;
            this.EndRangeAge_TB.Text = "150";
            this.EndRangeAge_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start_B
            // 
            this.Start_B.BackColor = System.Drawing.Color.White;
            this.Start_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Start_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.Start_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Start_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Start_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.Start_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(161)))));
            this.Start_B.Location = new System.Drawing.Point(717, 5);
            this.Start_B.Margin = new System.Windows.Forms.Padding(5);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(190, 31);
            this.Start_B.TabIndex = 22;
            this.Start_B.Text = "Начать";
            this.Start_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Start_B.UseVisualStyleBackColor = false;
            this.Start_B.Click += new System.EventHandler(this.button2_Click);
            // 
            // EndRange_L
            // 
            this.EndRange_L.AutoSize = true;
            this.EndRange_L.BackColor = System.Drawing.Color.Transparent;
            this.EndRange_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndRange_L.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRange_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.EndRange_L.Location = new System.Drawing.Point(490, 5);
            this.EndRange_L.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EndRange_L.Name = "EndRange_L";
            this.EndRange_L.Size = new System.Drawing.Size(72, 31);
            this.EndRange_L.TabIndex = 5;
            this.EndRange_L.Text = "| Конец";
            this.EndRange_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndRange_L.Visible = false;
            // 
            // StartRange_L
            // 
            this.StartRange_L.AutoSize = true;
            this.StartRange_L.BackColor = System.Drawing.Color.Transparent;
            this.StartRange_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartRange_L.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRange_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.StartRange_L.Location = new System.Drawing.Point(257, 5);
            this.StartRange_L.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.StartRange_L.Name = "StartRange_L";
            this.StartRange_L.Size = new System.Drawing.Size(83, 31);
            this.StartRange_L.TabIndex = 5;
            this.StartRange_L.Text = "| Начало";
            this.StartRange_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartRange_L.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(122, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Настройки |";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserAgeFilter_CB
            // 
            this.UserAgeFilter_CB.AutoSize = true;
            this.UserAgeFilter_CB.BackColor = System.Drawing.Color.White;
            this.UserAgeFilter_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgeFilter_CB.Font = new System.Drawing.Font("Verdana", 12F);
            this.UserAgeFilter_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.UserAgeFilter_CB.Location = new System.Drawing.Point(128, 6);
            this.UserAgeFilter_CB.Margin = new System.Windows.Forms.Padding(0, 6, 0, 5);
            this.UserAgeFilter_CB.Name = "UserAgeFilter_CB";
            this.UserAgeFilter_CB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserAgeFilter_CB.Size = new System.Drawing.Size(129, 30);
            this.UserAgeFilter_CB.TabIndex = 4;
            this.UserAgeFilter_CB.Text = "По возрасту";
            this.UserAgeFilter_CB.UseVisualStyleBackColor = false;
            this.UserAgeFilter_CB.CheckedChanged += new System.EventHandler(this.UserAgeFilter_CB_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ExportSplit_B, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Export_B, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Description_L, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Data_DGV, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(369, 101);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 485);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // ExportSplit_B
            // 
            this.ExportSplit_B.BackColor = System.Drawing.Color.White;
            this.ExportSplit_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportSplit_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExportSplit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportSplit_B.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExportSplit_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ExportSplit_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ExportSplit_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportSplit_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.ExportSplit_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(161)))));
            this.ExportSplit_B.Location = new System.Drawing.Point(2, 443);
            this.ExportSplit_B.Margin = new System.Windows.Forms.Padding(0);
            this.ExportSplit_B.Name = "ExportSplit_B";
            this.ExportSplit_B.Size = new System.Drawing.Size(534, 40);
            this.ExportSplit_B.TabIndex = 25;
            this.ExportSplit_B.Text = "Экспортировать (Раздельно)";
            this.ExportSplit_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExportSplit_B.UseVisualStyleBackColor = false;
            this.ExportSplit_B.Click += new System.EventHandler(this.ExportSplit_B_Click);
            // 
            // Export_B
            // 
            this.Export_B.BackColor = System.Drawing.Color.White;
            this.Export_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Export_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Export_B.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Export_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Export_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Export_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.Export_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(161)))));
            this.Export_B.Location = new System.Drawing.Point(2, 401);
            this.Export_B.Margin = new System.Windows.Forms.Padding(0);
            this.Export_B.Name = "Export_B";
            this.Export_B.Size = new System.Drawing.Size(534, 40);
            this.Export_B.TabIndex = 24;
            this.Export_B.Text = "Экспортировать (Все номера)";
            this.Export_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Export_B.UseVisualStyleBackColor = false;
            this.Export_B.Click += new System.EventHandler(this.Export_B_Click);
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.BackColor = System.Drawing.Color.Transparent;
            this.Description_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Description_L.Font = new System.Drawing.Font("Verdana", 14F);
            this.Description_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.Description_L.Location = new System.Drawing.Point(5, 2);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(528, 50);
            this.Description_L.TabIndex = 1;
            this.Description_L.Text = "Полученные номера";
            this.Description_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.UserName_B, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(912, 55);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 19F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(55, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "VK : Номера телефонов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserName_B
            // 
            this.UserName_B.AutoSize = true;
            this.UserName_B.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserName_B.BackColor = System.Drawing.Color.White;
            this.UserName_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserName_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserName_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.UserName_B.FlatAppearance.BorderSize = 0;
            this.UserName_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UserName_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UserName_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserName_B.Font = new System.Drawing.Font("Verdana", 10F);
            this.UserName_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.UserName_B.Location = new System.Drawing.Point(787, 12);
            this.UserName_B.Margin = new System.Windows.Forms.Padding(12, 12, 5, 12);
            this.UserName_B.MinimumSize = new System.Drawing.Size(120, 31);
            this.UserName_B.Name = "UserName_B";
            this.UserName_B.Size = new System.Drawing.Size(120, 31);
            this.UserName_B.TabIndex = 4;
            this.UserName_B.Text = "Выход";
            this.UserName_B.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UserName_B.UseVisualStyleBackColor = false;
            this.UserName_B.Click += new System.EventHandler(this.UserName_B_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Groups_DGV, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 101);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 485);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(161)))));
            this.button1.Location = new System.Drawing.Point(1, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сохранить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Группы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 799);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(928, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VK PARSER";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_DGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.StartRange_P.ResumeLayout(false);
            this.StartRange_P.PerformLayout();
            this.EndRange_P.ResumeLayout(false);
            this.EndRange_P.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Data_DGV;
        public System.Windows.Forms.DataGridView Groups_DGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        public System.Windows.Forms.TextBox EndRangeAge_TB;
        private System.Windows.Forms.Button Start_B;
        public System.Windows.Forms.Label EndRange_L;
        public System.Windows.Forms.Label StartRange_L;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox UserAgeFilter_CB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button UserName_B;
        public System.Windows.Forms.TextBox StartRangeAge_TB;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel EndRange_P;
        public System.Windows.Forms.Panel StartRange_P;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Log_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Male;
        private System.Windows.Forms.DataGridViewTextBoxColumn Female;
        private System.Windows.Forms.Button Export_B;
        private System.Windows.Forms.Button ExportSplit_B;
        public System.Windows.Forms.Label label1;
    }
}