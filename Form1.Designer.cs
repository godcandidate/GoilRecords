namespace GoilRecords
{
    partial class Form1
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.ibtndefaultPass = new FontAwesome.Sharp.IconButton();
            this.ibtnlogOut = new FontAwesome.Sharp.IconButton();
            this.ibtnManagerUser = new FontAwesome.Sharp.IconButton();
            this.ibtnChangePassword = new FontAwesome.Sharp.IconButton();
            this.ibtnRemoveRecord = new FontAwesome.Sharp.IconButton();
            this.ibtnAddRecord = new FontAwesome.Sharp.IconButton();
            this.ibtnLoadRecords = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentForm = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.ibtnMaximize = new FontAwesome.Sharp.IconButton();
            this.ibtnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconStatus = new FontAwesome.Sharp.IconPictureBox();
            this.gunacircleUserPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunacircleUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlSideMenu.Controls.Add(this.ibtndefaultPass);
            this.pnlSideMenu.Controls.Add(this.ibtnlogOut);
            this.pnlSideMenu.Controls.Add(this.ibtnManagerUser);
            this.pnlSideMenu.Controls.Add(this.ibtnChangePassword);
            this.pnlSideMenu.Controls.Add(this.ibtnRemoveRecord);
            this.pnlSideMenu.Controls.Add(this.ibtnAddRecord);
            this.pnlSideMenu.Controls.Add(this.ibtnLoadRecords);
            this.pnlSideMenu.Controls.Add(this.ibtnHome);
            this.pnlSideMenu.Controls.Add(this.panel3);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 661);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // ibtndefaultPass
            // 
            this.ibtndefaultPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtndefaultPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtndefaultPass.FlatAppearance.BorderSize = 0;
            this.ibtndefaultPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtndefaultPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtndefaultPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtndefaultPass.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.ibtndefaultPass.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtndefaultPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtndefaultPass.IconSize = 35;
            this.ibtndefaultPass.Location = new System.Drawing.Point(0, 460);
            this.ibtndefaultPass.Name = "ibtndefaultPass";
            this.ibtndefaultPass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtndefaultPass.Size = new System.Drawing.Size(200, 60);
            this.ibtndefaultPass.TabIndex = 10;
            this.ibtndefaultPass.Text = "Set Default Password";
            this.ibtndefaultPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtndefaultPass.UseVisualStyleBackColor = false;
            this.ibtndefaultPass.Click += new System.EventHandler(this.ibtndefaultPass_Click);
            // 
            // ibtnlogOut
            // 
            this.ibtnlogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnlogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnlogOut.FlatAppearance.BorderSize = 0;
            this.ibtnlogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnlogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnlogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnlogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnlogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnlogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlogOut.IconSize = 35;
            this.ibtnlogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnlogOut.Location = new System.Drawing.Point(0, 624);
            this.ibtnlogOut.Name = "ibtnlogOut";
            this.ibtnlogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnlogOut.Size = new System.Drawing.Size(200, 37);
            this.ibtnlogOut.TabIndex = 9;
            this.ibtnlogOut.Text = "    Log Out";
            this.ibtnlogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnlogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnlogOut.UseVisualStyleBackColor = false;
            this.ibtnlogOut.Click += new System.EventHandler(this.ibtnlogOut_Click);
            // 
            // ibtnManagerUser
            // 
            this.ibtnManagerUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnManagerUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnManagerUser.FlatAppearance.BorderSize = 0;
            this.ibtnManagerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnManagerUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnManagerUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnManagerUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnManagerUser.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnManagerUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnManagerUser.IconSize = 35;
            this.ibtnManagerUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnManagerUser.Location = new System.Drawing.Point(0, 400);
            this.ibtnManagerUser.Name = "ibtnManagerUser";
            this.ibtnManagerUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnManagerUser.Size = new System.Drawing.Size(200, 60);
            this.ibtnManagerUser.TabIndex = 7;
            this.ibtnManagerUser.Text = "    Manage User";
            this.ibtnManagerUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnManagerUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnManagerUser.UseVisualStyleBackColor = false;
            this.ibtnManagerUser.Click += new System.EventHandler(this.ibtnManagerUser_Click);
            // 
            // ibtnChangePassword
            // 
            this.ibtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnChangePassword.FlatAppearance.BorderSize = 0;
            this.ibtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnChangePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnChangePassword.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnChangePassword.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnChangePassword.IconSize = 35;
            this.ibtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnChangePassword.Location = new System.Drawing.Point(0, 340);
            this.ibtnChangePassword.Name = "ibtnChangePassword";
            this.ibtnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnChangePassword.Size = new System.Drawing.Size(200, 60);
            this.ibtnChangePassword.TabIndex = 6;
            this.ibtnChangePassword.Text = "    Change Password";
            this.ibtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnChangePassword.UseVisualStyleBackColor = false;
            this.ibtnChangePassword.Click += new System.EventHandler(this.ibtnChangePassword_Click);
            // 
            // ibtnRemoveRecord
            // 
            this.ibtnRemoveRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnRemoveRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnRemoveRecord.FlatAppearance.BorderSize = 0;
            this.ibtnRemoveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoveRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoveRecord.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnRemoveRecord.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.ibtnRemoveRecord.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnRemoveRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRemoveRecord.IconSize = 35;
            this.ibtnRemoveRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRemoveRecord.Location = new System.Drawing.Point(0, 280);
            this.ibtnRemoveRecord.Name = "ibtnRemoveRecord";
            this.ibtnRemoveRecord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnRemoveRecord.Size = new System.Drawing.Size(200, 60);
            this.ibtnRemoveRecord.TabIndex = 8;
            this.ibtnRemoveRecord.Text = "    Remove Record";
            this.ibtnRemoveRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRemoveRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRemoveRecord.UseVisualStyleBackColor = false;
            this.ibtnRemoveRecord.Click += new System.EventHandler(this.ibtnRemoveRecord_Click);
            // 
            // ibtnAddRecord
            // 
            this.ibtnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnAddRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAddRecord.FlatAppearance.BorderSize = 0;
            this.ibtnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAddRecord.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnAddRecord.IconChar = FontAwesome.Sharp.IconChar.FileClipboard;
            this.ibtnAddRecord.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnAddRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddRecord.IconSize = 35;
            this.ibtnAddRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddRecord.Location = new System.Drawing.Point(0, 220);
            this.ibtnAddRecord.Name = "ibtnAddRecord";
            this.ibtnAddRecord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnAddRecord.Size = new System.Drawing.Size(200, 60);
            this.ibtnAddRecord.TabIndex = 5;
            this.ibtnAddRecord.Text = "    Add Record";
            this.ibtnAddRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAddRecord.UseVisualStyleBackColor = false;
            this.ibtnAddRecord.Click += new System.EventHandler(this.ibtnAddRecord_Click);
            // 
            // ibtnLoadRecords
            // 
            this.ibtnLoadRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnLoadRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnLoadRecords.FlatAppearance.BorderSize = 0;
            this.ibtnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLoadRecords.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLoadRecords.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnLoadRecords.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.ibtnLoadRecords.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnLoadRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLoadRecords.IconSize = 35;
            this.ibtnLoadRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLoadRecords.Location = new System.Drawing.Point(0, 160);
            this.ibtnLoadRecords.Name = "ibtnLoadRecords";
            this.ibtnLoadRecords.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnLoadRecords.Size = new System.Drawing.Size(200, 60);
            this.ibtnLoadRecords.TabIndex = 3;
            this.ibtnLoadRecords.Text = "    Load Records";
            this.ibtnLoadRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLoadRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLoadRecords.UseVisualStyleBackColor = false;
            this.ibtnLoadRecords.Click += new System.EventHandler(this.ibtnLoadRecords_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 35;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 100);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnHome.Size = new System.Drawing.Size(200, 60);
            this.ibtnHome.TabIndex = 2;
            this.ibtnHome.Text = "    Home";
            this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHome.UseVisualStyleBackColor = false;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblCurrentForm
            // 
            this.lblCurrentForm.AutoSize = true;
            this.lblCurrentForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentForm.Location = new System.Drawing.Point(67, 22);
            this.lblCurrentForm.Name = "lblCurrentForm";
            this.lblCurrentForm.Size = new System.Drawing.Size(44, 16);
            this.lblCurrentForm.TabIndex = 1;
            this.lblCurrentForm.Text = "Home";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(688, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Login user";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.ibtnClose);
            this.pnlTitleBar.Controls.Add(this.ibtnMaximize);
            this.pnlTitleBar.Controls.Add(this.ibtnMinimize);
            this.pnlTitleBar.Controls.Add(this.iconStatus);
            this.pnlTitleBar.Controls.Add(this.lblUsername);
            this.pnlTitleBar.Controls.Add(this.gunacircleUserPic);
            this.pnlTitleBar.Controls.Add(this.lblCurrentForm);
            this.pnlTitleBar.Controls.Add(this.iconCurrentForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(884, 64);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // ibtnClose
            // 
            this.ibtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.ibtnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClose.IconSize = 20;
            this.ibtnClose.Location = new System.Drawing.Point(857, 3);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(22, 22);
            this.ibtnClose.TabIndex = 9;
            this.ibtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClose.UseVisualStyleBackColor = false;
            this.ibtnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibtnClose_MouseClick);
            // 
            // ibtnMaximize
            // 
            this.ibtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ibtnMaximize.FlatAppearance.BorderSize = 0;
            this.ibtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaximize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ibtnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMaximize.IconSize = 20;
            this.ibtnMaximize.Location = new System.Drawing.Point(829, 3);
            this.ibtnMaximize.Name = "ibtnMaximize";
            this.ibtnMaximize.Size = new System.Drawing.Size(22, 22);
            this.ibtnMaximize.TabIndex = 8;
            this.ibtnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMaximize.UseVisualStyleBackColor = false;
            this.ibtnMaximize.Click += new System.EventHandler(this.ibtnMaximize_Click);
            // 
            // ibtnMinimize
            // 
            this.ibtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ibtnMinimize.FlatAppearance.BorderSize = 0;
            this.ibtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.ibtnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMinimize.IconSize = 20;
            this.ibtnMinimize.Location = new System.Drawing.Point(801, 3);
            this.ibtnMinimize.Name = "ibtnMinimize";
            this.ibtnMinimize.Size = new System.Drawing.Size(22, 22);
            this.ibtnMinimize.TabIndex = 7;
            this.ibtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMinimize.UseVisualStyleBackColor = false;
            // 
            // iconStatus
            // 
            this.iconStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconStatus.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconStatus.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconStatus.IconColor = System.Drawing.Color.MediumPurple;
            this.iconStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStatus.Location = new System.Drawing.Point(582, 12);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(32, 32);
            this.iconStatus.TabIndex = 4;
            this.iconStatus.TabStop = false;
            // 
            // gunacircleUserPic
            // 
            this.gunacircleUserPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunacircleUserPic.Image = global::GoilRecords.Properties.Resources._1647416670940;
            this.gunacircleUserPic.ImageRotate = 0F;
            this.gunacircleUserPic.Location = new System.Drawing.Point(632, 8);
            this.gunacircleUserPic.Name = "gunacircleUserPic";
            this.gunacircleUserPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunacircleUserPic.Size = new System.Drawing.Size(50, 50);
            this.gunacircleUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunacircleUserPic.TabIndex = 2;
            this.gunacircleUserPic.TabStop = false;
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.Location = new System.Drawing.Point(29, 12);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentForm.TabIndex = 0;
            this.iconCurrentForm.TabStop = false;
            this.iconCurrentForm.Click += new System.EventHandler(this.iconCurrentForm_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(200, 64);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(884, 597);
            this.pnlDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunacircleUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibtnChangePassword;
        private FontAwesome.Sharp.IconButton ibtnLoadRecords;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunacircleUserPic;
        private System.Windows.Forms.Label lblUsername;
        private FontAwesome.Sharp.IconPictureBox iconStatus;
        private FontAwesome.Sharp.IconButton ibtnMinimize;
        private FontAwesome.Sharp.IconButton ibtnMaximize;
        private FontAwesome.Sharp.IconButton ibtnClose;
        private System.Windows.Forms.Panel pnlTitleBar;
        public System.Windows.Forms.Panel pnlDesktop;
        public FontAwesome.Sharp.IconButton ibtnAddRecord;
        public FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        public System.Windows.Forms.Label lblCurrentForm;
        private FontAwesome.Sharp.IconButton ibtnManagerUser;
        private FontAwesome.Sharp.IconButton ibtnRemoveRecord;
        private FontAwesome.Sharp.IconButton ibtnlogOut;
        private FontAwesome.Sharp.IconButton ibtndefaultPass;
    }
}

