using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoilRecords
{
    public partial class LoginForm : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Form1 _form1;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _form1.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtusername.Text.Trim();
                var password = txtpassword.Text;

                // create password from encryption from utils class


                // select username,password from login table
                var user = goilRecordsDBEntities.Employees.FirstOrDefault(data1 => data1.Username == username &&
                data1.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials", "Login Error");
                }
                else
                {

                    var mainwindow = new Form1(user);
                    mainwindow.Show();
                    this.Hide();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something wnet wrong. Please try again", "Login Error");
            }
        }
    }
}
