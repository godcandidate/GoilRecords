using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoilRecords
{
    public partial class RemoveRecords : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Employee _user;

        public RemoveRecords()
        {
            InitializeComponent();
          
        }

        public RemoveRecords(Employee user)
        {
            _user = user;
            InitializeComponent();
            PopulateGrid(user);

        }
        /// <summary>
        /// Fills the datagrid dgvrecord with record table from the database
        /// </summary>
        public void PopulateGrid(Employee _user)
        {
            loadRecordsUserControl1.populateGridWithUserRecords(_user);   
        }

        private void ibtnViewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var record_id = (int)loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Record_Id"].Value;

                var viewrecord = new ViewRecord(record_id);
                viewrecord.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "View Error");
            }
        }

        private void ibtnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row
                var record_id = (int)loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Record_Id"].Value;

                // query database from record with id
                var record = goilRecordsDBEntities.Records.FirstOrDefault(data => data.Record_Id == record_id);

                DialogResult result = MessageBox.Show($"Are you sure you want to delete this record",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // delete from database
                    goilRecordsDBEntities.Records.Remove(record);
                    goilRecordsDBEntities.SaveChanges();

                    MessageBox.Show("Record data deleted successfully", "Delete Vehicle Record");
                    PopulateGrid(_user);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\r" + "Select the entire row to Delete", "Select Error");
            }
        }
    }
}
