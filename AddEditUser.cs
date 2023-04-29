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
    public partial class AddEditUser : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private ManageUser _manageuser;
        private bool _isEditMode;
        private string _userid;
        

        public AddEditUser()
        {
            InitializeComponent();
            
        }

        public AddEditUser(ManageUser manageuser = null)
        {
            InitializeComponent();
            this.Text = "Add User";
            _manageuser = manageuser;
        }

        public AddEditUser(Employee user, ManageUser manageuser = null)
        {
            InitializeComponent();
            _manageuser = manageuser;
            _isEditMode = true;
            this.Text = "Edit User";
            btnAddUser.Text = "Save changes";

            // userID and admin username cannot be changed
            personInfoUserControl1.txtPersonID.Enabled = false;
            if (user.Username == "admin")
                personInfoUserControl1.txtUsername.Enabled = false;

            PopulateFields(user);
        }

        /// <summary>
        /// Populates the fields of form
        /// </summary>
        /// <param name="user">The user whose info is to be edited</param>
        public void PopulateFields(Employee user)
        {

            personInfoUserControl1.txtPersonID.Text = user.Person_Id;
            personInfoUserControl1.txtPersonName.Text = user.Person_name;
            personInfoUserControl1.txtPersonMobile.Text = user.Person_mobile;
            personInfoUserControl1.txtUsername.Text = user.Username;
            _userid = user.Person_Id.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool isFieldEmpty = personInfoUserControl1.IsFieldEmpty();
            if (isFieldEmpty)
                MessageBox.Show("Missing fields, make sure all fields are filled", "Add Error");
            else
            {
                try
                {
                    string action;
                    if (_isEditMode) 
                    {
                        string id = personInfoUserControl1.txtPersonID.Text.ToString();
                        action = "Update";
                        // query database from record with id
                        var user = goilRecordsDBEntities.Employees.FirstOrDefault(data => data.Person_Id == id);

                        user.Person_Id = personInfoUserControl1.txtPersonID.Text;
                        user.Person_name = personInfoUserControl1.txtPersonName.Text;
                        user.Person_mobile = personInfoUserControl1.txtPersonMobile.Text;
                        user.Username = personInfoUserControl1.txtUsername.Text;

                    }

                    else
                    {
                        action = "Add";
                        // inserting into the database
                        var user = new Employee();


                        user.Person_Id = personInfoUserControl1.txtPersonID.Text.Trim();
                        user.Person_name = personInfoUserControl1.txtPersonName.Text.Trim();
                        user.Person_mobile = personInfoUserControl1.txtPersonMobile.Text.Trim();
                        user.Username = personInfoUserControl1.txtUsername.Text.Trim();
                        user.Password = "pass123";


                        // saving changes to database
                        goilRecordsDBEntities.Employees.Add(user);
                    }

                    
                    goilRecordsDBEntities.SaveChanges();

                    _manageuser.populateGrid();
                    MessageBox.Show($"User has been {action}ed successfully", $"{action} User");
                    personInfoUserControl1.ClearFields();

                }
                catch (Exception)
                {

                    MessageBox.Show("An error occured, try again", "Add Error");
                }
            }
        }
    }
}
