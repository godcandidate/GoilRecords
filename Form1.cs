using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GoilRecords
{
    public partial class Form1 : Form
    {
        
        // fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm = new RemoveRecords();

        private Employee _user;

        /// <summary>
        /// Initialize Components
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // constructor 
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlSideMenu.Controls.Add(leftBorderBtn);

            // hides the default title bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public Form1(Employee user)
        {
            InitializeComponent();

            // constructor 
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlSideMenu.Controls.Add(leftBorderBtn);

            // hides the default title bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //logged in user
            _user= user;
            lblUsername.Text = user.Person_name;

            if (user.Username != "admin")
            {
                ibtnManagerUser.Visible = false;
                ibtndefaultPass.Visible = false;

            }
        }

        /// <summary>
        /// Constructs different color combinations
        /// </summary>
        /// <remarks>
        /// <c>RGBColor.color1 to RGBColor.color6 each gives a specific color code</c>
        /// </remarks>
        ////Structs
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.Aquamarine;
        }


        /// <summary>
        /// Highlights the activated button
        /// </summary>
        /// <param name="senderBtn">The activated button when clicked</param>
        /// <param name="color">The RGBcolor of the highlight of the activated button </param>
        /// <remarks><c>DisableButton() deactivates the button if activated otherwise Null</c></remarks>
        private void ActivateButton(object senderBtn, Color color)
        {
           
            if (senderBtn != null)
            {
                DisableButton();

                // button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Bold);

                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // icon of current form
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;
                lblCurrentForm.Text = currentBtn.Text;
            }
        }

        /// <summary>
        /// Changes the clicked button to default settings
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);
            }
        }
        /// <summary>
        /// A combination of statements to drag the window by the pnliltlebar
        /// </summary>
        // Drag form by pnlTitlebar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // end

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // opening child form
        /// <summary>
        /// opens a form in the pnlDesktop
        /// </summary>
        /// <param name="childForm">form to open in panel</param>
        private void OpenChildForm(Form childForm)
        {
            if (childForm.Name != currentChildForm.Name) 
            {
                // open only one form
                currentChildForm.Close();

                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlDesktop.Controls.Add(childForm);
                pnlDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void ibtnClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMaximize_Click(object sender, EventArgs e)
        {
           
            // remove form border when maximized 
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                WindowState= FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

        }

        private void iconCurrentForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The form is currently {WindowState}");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // remove form border when maximized 
            if (WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void ibtnLoadRecords_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new LoadRecords(_user));
        }

       


        private void ibtnManagerUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new ManageUser(_user));
        }

        private void ibtnAddRecord_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new AddRecords(_user));
        }

        private void ibtnRemoveRecord_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new RemoveRecords(_user));
        }

        private void ibtnChangePassword_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new ChangePassword(_user, this));
        }

        private void ibtndefaultPass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new ChangePassword(_user, this, true));
        }

        private void ibtnlogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            DialogResult result = MessageBox.Show($"Are you sure you want to logout",
                   "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                LoginForm login = new LoginForm();
                this.Hide();

                // exits all working background applications
                login.FormClosed += (s, args) => this.Close();
                login.FormClosed += (s, args) => Application.Exit();

                login.Show();
                this.Close();

            }
           
        }
    }
}
