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
    public partial class ChangePassword : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Employee _user;
        private Form1 _form1;

        public ChangePassword()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Receiving the details of the logged in user
        /// </summary>
        /// <param name="user">the logged in user</param>
        /// <param name="form1">The main form opened</param>
        public ChangePassword(Employee user, Form1 form1)
        {
            InitializeComponent();
            _user = user;
            _form1 = form1;
            PopulateUserID();
           
        }

        /// <summary>
        /// Populate the userid textfield with the logged user's id
        /// </summary>
        private void PopulateUserID()
        {
            txtuserid.Text = _user.Person_Id.ToString();
        }

        private void EditMyLoginInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtpassword.Text)) && txtpassword.Text == txtconfirmpass.Text)
                {
                    // query database from record with id
                    var user = goilRecordsDBEntities.Employees.FirstOrDefault(data => data.Person_Id == _user.Person_Id);

                    //if user exist
                    if (user != null) 
                    {
                        user.Password = txtconfirmpass.Text;

                        // saving changes to database
                        goilRecordsDBEntities.SaveChanges();
                        MessageBox.Show($"{user.Username}'s password changed successfully", "Change Password");
                        LoginForm login = new LoginForm(_form1);
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields and make sure passwords match", "Change Password Error");
                }
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
