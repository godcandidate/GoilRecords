namespace GoilRecords
{
    partial class EditForm
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
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnSaveChanges = new FontAwesome.Sharp.IconButton();
            this.addRecordUserControl1 = new GoilRecords.AddRecordUserControl();
            this.SuspendLayout();
            // 
            // ibtnCancel
            // 
            this.ibtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnCancel.BackColor = System.Drawing.Color.Blue;
            this.ibtnCancel.FlatAppearance.BorderSize = 0;
            this.ibtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCancel.ForeColor = System.Drawing.Color.White;
            this.ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCancel.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancel.IconSize = 35;
            this.ibtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCancel.Location = new System.Drawing.Point(234, 508);
            this.ibtnCancel.Name = "ibtnCancel";
            this.ibtnCancel.Size = new System.Drawing.Size(158, 29);
            this.ibtnCancel.TabIndex = 41;
            this.ibtnCancel.Text = "Cancel";
            this.ibtnCancel.UseVisualStyleBackColor = false;
            this.ibtnCancel.Click += new System.EventHandler(this.ibtnCancel_Click);
            // 
            // ibtnSaveChanges
            // 
            this.ibtnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSaveChanges.BackColor = System.Drawing.Color.Blue;
            this.ibtnSaveChanges.FlatAppearance.BorderSize = 0;
            this.ibtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSaveChanges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.ibtnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnSaveChanges.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSaveChanges.IconSize = 35;
            this.ibtnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSaveChanges.Location = new System.Drawing.Point(555, 508);
            this.ibtnSaveChanges.Name = "ibtnSaveChanges";
            this.ibtnSaveChanges.Size = new System.Drawing.Size(158, 29);
            this.ibtnSaveChanges.TabIndex = 42;
            this.ibtnSaveChanges.Text = "Save Changes";
            this.ibtnSaveChanges.UseVisualStyleBackColor = false;
            this.ibtnSaveChanges.Click += new System.EventHandler(this.ibtnSaveChanges_Click);
            // 
            // addRecordUserControl1
            // 
            this.addRecordUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRecordUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addRecordUserControl1.Location = new System.Drawing.Point(12, 45);
            this.addRecordUserControl1.Name = "addRecordUserControl1";
            this.addRecordUserControl1.Size = new System.Drawing.Size(853, 439);
            this.addRecordUserControl1.TabIndex = 43;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.addRecordUserControl1);
            this.Controls.Add(this.ibtnSaveChanges);
            this.Controls.Add(this.ibtnCancel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnSaveChanges;
        private AddRecordUserControl addRecordUserControl1;
    }
}