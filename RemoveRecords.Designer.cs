namespace GoilRecords
{
    partial class RemoveRecords
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
            this.ibtnDeleteAll = new FontAwesome.Sharp.IconButton();
            this.ibtnDeleteRecord = new FontAwesome.Sharp.IconButton();
            this.ibtnViewRecord = new FontAwesome.Sharp.IconButton();
            this.loadRecordsUserControl1 = new GoilRecords.LoadRecordsUserControl();
            this.SuspendLayout();
            // 
            // ibtnDeleteAll
            // 
            this.ibtnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.ibtnDeleteAll.FlatAppearance.BorderSize = 0;
            this.ibtnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDeleteAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.ibtnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnDeleteAll.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDeleteAll.IconSize = 35;
            this.ibtnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDeleteAll.Location = new System.Drawing.Point(385, 517);
            this.ibtnDeleteAll.Name = "ibtnDeleteAll";
            this.ibtnDeleteAll.Size = new System.Drawing.Size(158, 29);
            this.ibtnDeleteAll.TabIndex = 38;
            this.ibtnDeleteAll.Text = "Delete All";
            this.ibtnDeleteAll.UseVisualStyleBackColor = false;
            this.ibtnDeleteAll.Visible = false;
            // 
            // ibtnDeleteRecord
            // 
            this.ibtnDeleteRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnDeleteRecord.BackColor = System.Drawing.Color.Blue;
            this.ibtnDeleteRecord.FlatAppearance.BorderSize = 0;
            this.ibtnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDeleteRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDeleteRecord.ForeColor = System.Drawing.Color.White;
            this.ibtnDeleteRecord.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnDeleteRecord.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDeleteRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDeleteRecord.IconSize = 35;
            this.ibtnDeleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDeleteRecord.Location = new System.Drawing.Point(623, 517);
            this.ibtnDeleteRecord.Name = "ibtnDeleteRecord";
            this.ibtnDeleteRecord.Size = new System.Drawing.Size(158, 29);
            this.ibtnDeleteRecord.TabIndex = 37;
            this.ibtnDeleteRecord.Text = "Delete Record";
            this.ibtnDeleteRecord.UseVisualStyleBackColor = false;
            this.ibtnDeleteRecord.Click += new System.EventHandler(this.ibtnDeleteRecord_Click);
            // 
            // ibtnViewRecord
            // 
            this.ibtnViewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnViewRecord.BackColor = System.Drawing.Color.Blue;
            this.ibtnViewRecord.FlatAppearance.BorderSize = 0;
            this.ibtnViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnViewRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnViewRecord.ForeColor = System.Drawing.Color.White;
            this.ibtnViewRecord.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnViewRecord.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnViewRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnViewRecord.IconSize = 35;
            this.ibtnViewRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnViewRecord.Location = new System.Drawing.Point(108, 517);
            this.ibtnViewRecord.Name = "ibtnViewRecord";
            this.ibtnViewRecord.Size = new System.Drawing.Size(158, 29);
            this.ibtnViewRecord.TabIndex = 39;
            this.ibtnViewRecord.Text = "View Record";
            this.ibtnViewRecord.UseVisualStyleBackColor = false;
            this.ibtnViewRecord.Click += new System.EventHandler(this.ibtnViewRecord_Click);
            // 
            // loadRecordsUserControl1
            // 
            this.loadRecordsUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadRecordsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.loadRecordsUserControl1.Location = new System.Drawing.Point(-1, 1);
            this.loadRecordsUserControl1.Name = "loadRecordsUserControl1";
            this.loadRecordsUserControl1.Size = new System.Drawing.Size(870, 510);
            this.loadRecordsUserControl1.TabIndex = 0;
            // 
            // RemoveRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.ibtnViewRecord);
            this.Controls.Add(this.ibtnDeleteAll);
            this.Controls.Add(this.ibtnDeleteRecord);
            this.Controls.Add(this.loadRecordsUserControl1);
            this.Name = "RemoveRecords";
            this.Text = "RemoveRecords";
            this.ResumeLayout(false);

        }

        #endregion

        private LoadRecordsUserControl loadRecordsUserControl1;
        private FontAwesome.Sharp.IconButton ibtnDeleteAll;
        private FontAwesome.Sharp.IconButton ibtnDeleteRecord;
        private FontAwesome.Sharp.IconButton ibtnViewRecord;
    }
}