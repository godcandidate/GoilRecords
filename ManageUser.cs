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
    public partial class ManageUser : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private string pass;
        public ManageUser()
        {
            InitializeComponent();
            populateGrid();
        }

        public ManageUser(Employee user)
        {
            InitializeComponent();
            pass = user.DefaultPass;
            loadRecordsUserControl1.pnlSearchRecords.Visible = false;
            loadRecordsUserControl1.pnlSearchUser.Visible = true;
            populateGrid();
        }



        /// <summary>
        /// Fills the datagrid dgvrecord with record table from the database
        /// </summary>
        public void populateGrid()
        {
            var user = goilRecordsDBEntities.Employees
               .Select(data => new
               {
                   data.Person_Id,
                   data.Person_name,
                   data.Username,
                   data.Person_mobile,
               }
               ).ToList();

            loadRecordsUserControl1.dgvrecords.DataSource = user;
        }

        
        private void ibtnAddUser_Click(object sender, EventArgs e)
        {
            var adduserform = new AddEditUser(this);
            adduserform.ShowDialog();
        }

        /// <summary>
        ///  Gets the id and search for specific user of the selected Row
        /// </summary>
        /// <returns>the user info found</returns>
        private Employee SelectedRow()
        {
            // get id of selected row
            var person_id = loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Person_Id"].Value.ToString();

            // search query to database from Employee with id
            var user = goilRecordsDBEntities.Employees.FirstOrDefault(data => data.Person_Id == person_id);
            return user;
        }

        private void ibtnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                var user = SelectedRow();

                DialogResult result = MessageBox.Show($"Are you sure you want to remove {user.Person_name}",
                    "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // delete from database
                    goilRecordsDBEntities.Employees.Remove(user);
                    goilRecordsDBEntities.SaveChanges();

                    populateGrid();
                    MessageBox.Show("User has been removed successfully", "Remove User");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, make sure a row is selected", "Remove Error");
            }
        }

        private void ibtnupdateUser_Click(object sender, EventArgs e)
        {
            var user = SelectedRow();

            var adduserform = new AddEditUser(user, this);
            adduserform.ShowDialog();
        }

       
        private void ibtnResetPassword_Click(object sender, EventArgs e)
        {
            var user = SelectedRow();

            DialogResult result = MessageBox.Show($"Are you sure you want to reset {user.Person_name}'s password to default",
                   "Reset to Default Password", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // delete from database
                user.Password = pass;
                goilRecordsDBEntities.SaveChanges();

                populateGrid();
                MessageBox.Show("Reset to Default password successfully", "Reset Default password");

            }
        }

    }
}
