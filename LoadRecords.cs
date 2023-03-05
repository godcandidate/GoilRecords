using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GoilRecords
{
    public partial class LoadRecords : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Employee _user;

        public LoadRecords()
        {
            InitializeComponent();
            populateGrid();
        }

        public LoadRecords(Employee user)
        {
            InitializeComponent();
            _user = user;
            populateGrid();
        }



        /// <summary>
        /// Fills the datagrid dgvrecord with logged in user's records table from the database
        /// </summary>
        public void populateGrid()
        {
            loadRecordsUserControl1.populateGridWithUserRecords(_user);
        }

        private void ibtnView_Click(object sender, EventArgs e)
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

        private void ibtnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var record_id = (int)loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells["Record_Id"].Value;

                var editform = new EditForm(record_id, this);
                editform.ShowDialog();
               
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "View Error");
            }

        }
    }
}
