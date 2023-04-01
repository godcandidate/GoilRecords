namespace GoilRecords
{
    partial class ChangePassword
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.lblConfirmpass = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.BackColor = System.Drawing.Color.Red;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Location = new System.Drawing.Point(214, 266);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(139, 34);
            this.btnChangePassword.TabIndex = 52;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "User ID";
            // 
            // txtuserid
            // 
            this.txtuserid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtuserid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(268, 66);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.Size = new System.Drawing.Size(180, 27);
            this.txtuserid.TabIndex = 48;
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtconfirmpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpass.Location = new System.Drawing.Point(269, 174);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '*';
            this.txtconfirmpass.Size = new System.Drawing.Size(180, 27);
            this.txtconfirmpass.TabIndex = 56;
            // 
            // lblConfirmpass
            // 
            this.lblConfirmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmpass.AutoSize = true;
            this.lblConfirmpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmpass.ForeColor = System.Drawing.Color.White;
            this.lblConfirmpass.Location = new System.Drawing.Point(130, 179);
            this.lblConfirmpass.Name = "lblConfirmpass";
            this.lblConfirmpass.Size = new System.Drawing.Size(125, 17);
            this.lblConfirmpass.TabIndex = 55;
            this.lblConfirmpass.Text = "Confirm Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(268, 120);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(180, 27);
            this.txtpassword.TabIndex = 53;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(129, 123);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 54;
            this.lblPass.Text = "Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(567, 337);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.lblConfirmpass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserid);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.EditMyLoginInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Label lblConfirmpass;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblPass;
    }
}