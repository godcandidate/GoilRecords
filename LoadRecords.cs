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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printing a separator 
            Graphics g = e.Graphics;
            int startX = e.MarginBounds.Left;
            int endX = e.MarginBounds.Right;
            int y = 80;

            e.Graphics.DrawString("Goil Record System", new Font("Georgia", 12), Brushes.Red, new Point(200, 10));
            e.Graphics.DrawString("Printed by " + _user.Username, new Font("Century Gothic", 10), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("Printed on " + DateTime.Now, new Font("Century Gothic", 10), Brushes.Black, new Point(10, 60));

            Pen separatorPen = new Pen(Color.Black, 2);
            g.DrawLine(separatorPen, startX, y, endX, y);
            int count = 100;

            //looping through the data to print each 
            for (int i=0; i<=19; i++)
            {
                e.Graphics.DrawString(loadRecordsUserControl1.dgvrecords.Columns[i].HeaderText + "  : " +
                    loadRecordsUserControl1.dgvrecords.SelectedRows[0].Cells[i].Value.ToString(), 
                    new Font("Century Gothic", 10), Brushes.Black, new Point(40, count));
                count += 40;
            }
        }

        private void ibtnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 600, 700);
            printPreviewDialog1.ShowDialog();
        }
    }
}
