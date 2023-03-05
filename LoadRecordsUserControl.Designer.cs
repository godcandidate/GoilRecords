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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvrecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrecords
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvrecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrecords.ColumnHeadersHeight = 30;
            this.dgvrecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrecords.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.cmbSearchBy.Location = new System.Drawing.Point(109, 10);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(186, 25);
            this.cmbSearchBy.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 13);
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
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(109, 50);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 23);
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
            this.ibtnSearch.Location = new System.Drawing.Point(109, 79);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(66, 26);
            this.ibtnSearch.TabIndex = 30;
            this.ibtnSearch.Text = "Search";
            this.ibtnSearch.UseVisualStyleBackColor = false;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // LoadRecordsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.ibtnRefresh);
            this.Controls.Add(this.ibtnSearch);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dgvrecords);
            this.Name = "LoadRecordsUserControl";
            this.Size = new System.Drawing.Size(870, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        public System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtname;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        public Guna.UI2.WinForms.Guna2DataGridView dgvrecords;
        public FontAwesome.Sharp.IconButton ibtnSearch;
    }
}
