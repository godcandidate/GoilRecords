namespace GoilRecords
{
    partial class ViewRecord
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
            this.addRecordUserControl1 = new GoilRecords.AddRecordUserControl();
            this.SuspendLayout();
            // 
            // addRecordUserControl1
            // 
            this.addRecordUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addRecordUserControl1.Location = new System.Drawing.Point(0, 12);
            this.addRecordUserControl1.Name = "addRecordUserControl1";
            this.addRecordUserControl1.Size = new System.Drawing.Size(869, 470);
            this.addRecordUserControl1.TabIndex = 0;
            // 
            // ViewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(868, 500);
            this.Controls.Add(this.addRecordUserControl1);
            this.Name = "ViewRecord";
            this.Text = "ViewRecord";
            this.Load += new System.EventHandler(this.ViewRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AddRecordUserControl addRecordUserControl1;
    }
}