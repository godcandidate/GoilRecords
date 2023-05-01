namespace GoilRecords
{
    partial class AddRecords
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
            this.ibtnClear = new FontAwesome.Sharp.IconButton();
            this.ibtnAdd = new FontAwesome.Sharp.IconButton();
            this.addRecordUserControl11 = new GoilRecords.AddRecordUserControl();
            this.SuspendLayout();
            // 
            // ibtnClear
            // 
            this.ibtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnClear.BackColor = System.Drawing.Color.Red;
            this.ibtnClear.FlatAppearance.BorderSize = 0;
            this.ibtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnClear.ForeColor = System.Drawing.Color.White;
            this.ibtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnClear.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClear.IconSize = 35;
            this.ibtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClear.Location = new System.Drawing.Point(215, 526);
            this.ibtnClear.Name = "ibtnClear";
            this.ibtnClear.Size = new System.Drawing.Size(158, 29);
            this.ibtnClear.TabIndex = 34;
            this.ibtnClear.Text = "Clear Fields";
            this.ibtnClear.UseVisualStyleBackColor = false;
            this.ibtnClear.Click += new System.EventHandler(this.ibtnClear_Click);
            // 
            // ibtnAdd
            // 
            this.ibtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnAdd.BackColor = System.Drawing.Color.Blue;
            this.ibtnAdd.FlatAppearance.BorderSize = 0;
            this.ibtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdd.ForeColor = System.Drawing.Color.White;
            this.ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdd.IconSize = 35;
            this.ibtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAdd.Location = new System.Drawing.Point(553, 526);
            this.ibtnAdd.Name = "ibtnAdd";
            this.ibtnAdd.Size = new System.Drawing.Size(158, 29);
            this.ibtnAdd.TabIndex = 33;
            this.ibtnAdd.Text = "Add Record";
            this.ibtnAdd.UseVisualStyleBackColor = false;
            this.ibtnAdd.Click += new System.EventHandler(this.ibtnAdd_Click);
            // 
            // addRecordUserControl11
            // 
            this.addRecordUserControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRecordUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addRecordUserControl11.Location = new System.Drawing.Point(12, 36);
            this.addRecordUserControl11.Name = "addRecordUserControl11";
            this.addRecordUserControl11.Size = new System.Drawing.Size(853, 464);
            this.addRecordUserControl11.TabIndex = 35;
            // 
            // AddRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.addRecordUserControl11);
            this.Controls.Add(this.ibtnAdd);
            this.Controls.Add(this.ibtnClear);
            this.Name = "AddRecords";
            this.Text = "AddRecords";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnClear;
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private AddRecordUserControl addRecordUserControl11;
    }
}