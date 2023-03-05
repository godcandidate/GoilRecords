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

        public ManageUser()
        {
            InitializeComponent();
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

        private void ibtnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row
                var person_id = loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Person_Id"].Value.ToString();

                // query database from Employee with id
                var user = goilRecordsDBEntities.Employees.FirstOrDefault(data => data.Person_Id == person_id);

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
     
            
            // get id of selected row
            var person_id = loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Person_Id"].Value.ToString();

            var user = goilRecordsDBEntities.Employees.FirstOrDefault(data => data.Person_Id == person_id);

            var adduserform = new AddEditUser(user, this);
            adduserform.ShowDialog();
        }
    }
}
