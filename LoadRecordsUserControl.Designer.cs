namespace GoilRecords
{
    partial class LoadRecordsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvrecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.ibtnuseDate = new FontAwesome.Sharp.IconButton();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.pnlSearchRecords = new System.Windows.Forms.Panel();
            this.pnlSearchDate = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btncloseDate = new FontAwesome.Sharp.IconButton();
            this.searchdate = new FontAwesome.Sharp.IconButton();
            this.cmbDateBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSearchUser = new System.Windows.Forms.Panel();
            this.txtusname = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cmbUserBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecords)).BeginInit();
            this.pnlSearchRecords.SuspendLayout();
            this.pnlSearchDate.SuspendLayout();
            this.pnlSearchUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvrecords
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvrecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvrecords.ColumnHeadersHeight = 30;
            this.dgvrecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrecords.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvrecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecords.Location = new System.Drawing.Point(3, 111);
            this.dgvrecords.Name = "dgvrecords";
            this.dgvrecords.RowHeadersVisible = false;
            this.dgvrecords.Size = new System.Drawing.Size(864, 395);
            this.dgvrecords.TabIndex = 0;
            this.dgvrecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvrecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvrecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvrecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvrecords.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvrecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvrecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvrecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrecords.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvrecords.ThemeStyle.ReadOnly = false;
            this.dgvrecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvrecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvrecords.ThemeStyle.RowsStyle.Height = 22;
            this.dgvrecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Search by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(106, 43);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(199, 23);
            this.txtname.TabIndex = 28;
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.BackColor = System.Drawing.Color.Blue;
            this.ibtnRefresh.FlatAppearance.BorderSize = 0;
            this.ibtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRefresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRefresh.ForeColor = System.Drawing.Color.White;
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 35;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(801, 79);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(66, 26);
            this.ibtnRefresh.TabIndex = 31;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.UseVisualStyleBackColor = false;
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BackColor = System.Drawing.Color.Red;
            this.ibtnSearch.FlatAppearance.BorderSize = 0;
            this.ibtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSearch.ForeColor = System.Drawing.Color.White;
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 35;
            this.ibtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSearch.Location = new System.Drawing.Point(106, 72);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(66, 26);
            this.ibtnSearch.TabIndex = 30;
            this.ibtnSearch.Text = "Search";
            this.ibtnSearch.UseVisualStyleBackColor = false;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // ibtnuseDate
            // 
            this.ibtnuseDate.BackColor = System.Drawing.Color.Blue;
            this.ibtnuseDate.FlatAppearance.BorderSize = 0;
            this.ibtnuseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnuseDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnuseDate.ForeColor = System.Drawing.Color.White;
            this.ibtnuseDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnuseDate.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnuseDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnuseDate.IconSize = 35;
            this.ibtnuseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnuseDate.Location = new System.Drawing.Point(209, 72);
            this.ibtnuseDate.Name = "ibtnuseDate";
            this.ibtnuseDate.Size = new System.Drawing.Size(96, 26);
            this.ibtnuseDate.TabIndex = 33;
            this.ibtnuseDate.Text = "Use Dates/Time";
            this.ibtnuseDate.UseVisualStyleBackColor = false;
            this.ibtnuseDate.Click += new System.EventHandler(this.ibtnuseDate_Click);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Product Type",
            "Loading Depot",
            "Discharge date",
            "Discharge time",
            "Marker certificate",
            "Invoice number",
            "BRV number",
            "Compartment number",
            "Contains_water",
            "Drive name"});
            this.cmbSearchBy.Location = new System.Drawing.Point(106, 3);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(199, 25);
            this.cmbSearchBy.TabIndex = 26;
            // 
            // pnlSearchRecords
            // 
            this.pnlSearchRecords.Controls.Add(this.pnlSearchDate);
            this.pnlSearchRecords.Controls.Add(this.cmbSearchBy);
            this.pnlSearchRecords.Controls.Add(this.txtname);
            this.pnlSearchRecords.Controls.Add(this.ibtnuseDate);
            this.pnlSearchRecords.Controls.Add(this.label1);
            this.pnlSearchRecords.Controls.Add(this.label13);
            this.pnlSearchRecords.Controls.Add(this.ibtnSearch);
            this.pnlSearchRecords.Location = new System.Drawing.Point(15, 3);
            this.pnlSearchRecords.Name = "pnlSearchRecords";
            this.pnlSearchRecords.Size = new System.Drawing.Size(308, 102);
            this.pnlSearchRecords.TabIndex = 35;
            // 
            // pnlSearchDate
            // 
            this.pnlSearchDate.Controls.Add(this.dateTimePicker1);
            this.pnlSearchDate.Controls.Add(this.btncloseDate);
            this.pnlSearchDate.Controls.Add(this.searchdate);
            this.pnlSearchDate.Controls.Add(this.cmbDateBy);
            this.pnlSearchDate.Controls.Add(this.label2);
            this.pnlSearchDate.Controls.Add(this.label3);
            this.pnlSearchDate.Location = new System.Drawing.Point(3, 0);
            this.pnlSearchDate.Name = "pnlSearchDate";
            this.pnlSearchDate.Size = new System.Drawing.Size(308, 102);
            this.pnlSearchDate.TabIndex = 36;
            this.pnlSearchDate.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // btncloseDate
            // 
            this.btncloseDate.BackColor = System.Drawing.Color.Blue;
            this.btncloseDate.FlatAppearance.BorderSize = 0;
            this.btncloseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseDate.ForeColor = System.Drawing.Color.White;
            this.btncloseDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btncloseDate.IconColor = System.Drawing.Color.Gainsboro;
            this.btncloseDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncloseDate.IconSize = 35;
            this.btncloseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncloseDate.Location = new System.Drawing.Point(239, 72);
            this.btncloseDate.Name = "btncloseDate";
            this.btncloseDate.Size = new System.Drawing.Size(66, 26);
            this.btncloseDate.TabIndex = 36;
            this.btncloseDate.Text = "Close";
            this.btncloseDate.UseVisualStyleBackColor = false;
            this.btncloseDate.Click += new System.EventHandler(this.btncloseDate_Click);
            // 
            // searchdate
            // 
            this.searchdate.BackColor = System.Drawing.Color.Red;
            this.searchdate.FlatAppearance.BorderSize = 0;
            this.searchdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdate.ForeColor = System.Drawing.Color.White;
            this.searchdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.searchdate.IconColor = System.Drawing.Color.Gainsboro;
            this.searchdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchdate.IconSize = 35;
            this.searchdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchdate.Location = new System.Drawing.Point(119, 72);
            this.searchdate.Name = "searchdate";
            this.searchdate.Size = new System.Drawing.Size(66, 26);
            this.searchdate.TabIndex = 35;
            this.searchdate.Text = "Search";
            this.searchdate.UseVisualStyleBackColor = false;
            this.searchdate.Click += new System.EventHandler(this.searchdate_Click);
            // 
            // cmbDateBy
            // 
            this.cmbDateBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateBy.FormattingEnabled = true;
            this.cmbDateBy.Items.AddRange(new object[] {
            "Year",
            "Month and Year",
            "Date, Month and Year",
            "Time"});
            this.cmbDateBy.Location = new System.Drawing.Point(119, 3);
            this.cmbDateBy.Name = "cmbDateBy";
            this.cmbDateBy.Size = new System.Drawing.Size(186, 25);
            this.cmbDateBy.TabIndex = 31;
            this.cmbDateBy.SelectedIndexChanged += new System.EventHandler(this.cmbDateBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search date by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Value";
            // 
            // pnlSearchUser
            // 
            this.pnlSearchUser.Controls.Add(this.txtusname);
            this.pnlSearchUser.Controls.Add(this.iconButton1);
            this.pnlSearchUser.Controls.Add(this.cmbUserBy);
            this.pnlSearchUser.Controls.Add(this.label4);
            this.pnlSearchUser.Controls.Add(this.label5);
            this.pnlSearchUser.Location = new System.Drawing.Point(332, 3);
            this.pnlSearchUser.Name = "pnlSearchUser";
            this.pnlSearchUser.Size = new System.Drawing.Size(308, 102);
            this.pnlSearchUser.TabIndex = 44;
            this.pnlSearchUser.Visible = false;
            // 
            // txtusname
            // 
            this.txtusname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusname.Location = new System.Drawing.Point(109, 43);
            this.txtusname.Name = "txtusname";
            this.txtusname.Size = new System.Drawing.Size(196, 23);
            this.txtusname.TabIndex = 37;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(109, 72);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(66, 26);
            this.iconButton1.TabIndex = 35;
            this.iconButton1.Text = "Search";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // cmbUserBy
            // 
            this.cmbUserBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserBy.FormattingEnabled = true;
            this.cmbUserBy.Items.AddRange(new object[] {
            "Person ID",
            "Person name",
            "Username"});
            this.cmbUserBy.Location = new System.Drawing.Point(109, 6);
            this.cmbUserBy.Name = "cmbUserBy";
            this.cmbUserBy.Size = new System.Drawing.Size(196, 25);
            this.cmbUserBy.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Search by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name";
            // 
            // LoadRecordsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.pnlSearchUser);
            this.Controls.Add(this.pnlSearchRecords);
            this.Controls.Add(this.ibtnRefresh);
            this.Controls.Add(this.dgvrecords);
            this.Name = "LoadRecordsUserControl";
            this.Size = new System.Drawing.Size(870, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecords)).EndInit();
            this.pnlSearchRecords.ResumeLayout(false);
            this.pnlSearchRecords.PerformLayout();
            this.pnlSearchDate.ResumeLayout(false);
            this.pnlSearchDate.PerformLayout();
            this.pnlSearchUser.ResumeLayout(false);
            this.pnlSearchUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtname;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        public Guna.UI2.WinForms.Guna2DataGridView dgvrecords;
        public FontAwesome.Sharp.IconButton ibtnSearch;
        private FontAwesome.Sharp.IconButton ibtnuseDate;
        public System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Panel pnlSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public FontAwesome.Sharp.IconButton btncloseDate;
        public FontAwesome.Sharp.IconButton searchdate;
        public System.Windows.Forms.ComboBox cmbDateBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel pnlSearchRecords;
        public System.Windows.Forms.TextBox txtusname;
        public FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.ComboBox cmbUserBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel pnlSearchUser;
    }
}
