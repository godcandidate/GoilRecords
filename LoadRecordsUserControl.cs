using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Xunit;

namespace GoilRecords
{
    public partial class LoadRecordsUserControl : UserControl
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        public LoadRecordsUserControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Fills the datagrid dgvrecord with record table from the database
        /// </summary>
        public void populateGridWithUserRecords(Employee user)
        {
            if (user.Username != "admin")
            {
                var query = from records in goilRecordsDBEntities.Records
                            where (records.UserID == user.Person_Id)
                            select new
                            {
                                records.UserID,
                                records.Record_Id,
                                records.Product_type,
                                records.Loading_depot,
                                records.Discharge_date,
                                records.Discharge_time,
                                records.Density_at15,
                                records.Product_temperature,
                                records.Quantity_discharged,
                                records.Density_observed,
                                records.Temperature_observed,
                                records.Marker_certificate,
                                records.Invoice_number,
                                records.Sulphur_amount,
                                records.BRV_number,
                                records.Compartment_number,
                                records.Contains_water,
                                records.Driver_name,
                                records.Density_difference
                            };
                dgvrecords.DataSource = query.ToList();
            }
            else
            {
                var record1 = goilRecordsDBEntities.Records
              .Select(data => new
              {
                  data.UserID,
                  data.Record_Id,
                  data.Product_type,
                  data.Loading_depot,
                  data.Discharge_date,
                  data.Discharge_time,
                  data.Density_at15,
                  data.Product_temperature,
                  data.Quantity_discharged,
                  data.Density_observed,
                  data.Temperature_observed,
                  data.Marker_certificate,
                  data.Invoice_number,
                  data.Sulphur_amount,
                  data.BRV_number,
                  data.Compartment_number,
                  data.Contains_water,
                  data.Driver_name,
                  data.Density_difference
              }
              ).ToList();

                dgvrecords.DataSource = record1;
            }
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtname.Text) || cmbSearchBy.SelectedIndex == -1)
                {
                    MessageBox.Show($"Missing fields, enter all search fields", "Search Errors");
                }
                else
                {
                    var searchby = cmbSearchBy.SelectedItem.ToString();
                    var keyword = txtname.Text;
                    
                    var query = goilRecordsDBEntities.Records.AsQueryable();
                    switch (searchby)
                    {
                        case "Product Type":
                            // query database from record with searchby
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Product_type == keyword
                                     select records);
                            break;

                        case "Loading Depot":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Loading_depot == keyword
                                     select records);
                            break;

                        case "Discharge date":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Loading_depot == keyword
                                     select records);
                            break;

                        case "Discharge time":
                            break;

                        case "Marker certificate":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Marker_certificate == keyword
                                     select records);
                            break;

                        case "Invoice number":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Invoice_number == keyword
                                     select records);
                            break;

                        case "BRV number":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.BRV_number == keyword
                                     select records);
                            break;

                        case "Compartment number":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Compartment_number == keyword
                                     select records);
                            break;

                        case "Contains_water":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Contains_water == keyword
                                     select records);
                            break;

                        case "Driver's name":
                            query = (from records in goilRecordsDBEntities.Records
                                     where records.Driver_name == keyword
                                     select records);
                            break;

                    }

                    int numberOfRecords = query.Count();
                    //var kom = query.ToList().
                    if (query != null)
                    {
                        dgvrecords.DataSource = query.ToList();
                        MessageBox.Show($"Search was successful,\n{numberOfRecords} record(s) found", "Search Results");
                    }
                    else
                        MessageBox.Show($"No records match, check inputs ", "Search Results");
                }
                
               


            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void ibtnuseDate_Click(object sender, EventArgs e)
        {
            int wordindex = cmbSearchBy.SelectedIndex;

            if (wordindex == 2 || wordindex == 3)
                pnlSearchDate.Visible = true;
            else if (wordindex == -1)
                MessageBox.Show("Select a searchby ", "Search Error");
            else
                MessageBox.Show("Searchby selected is not date/time type ", "Search Error");

        }

        private void btncloseDate_Click_1(object sender, EventArgs e)
        {
            pnlSearchDate.Visible = false;
        }

        private void cmbDateBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            switch (cmbDateBy.SelectedIndex)
            {
                
                case 0:
                    dateTimePicker1.CustomFormat = "yyyy";
                    dateTimePicker1.ShowUpDown = true;
                    break;
                case 1:
                    dateTimePicker1.CustomFormat = "MM/yyyy";
                    dateTimePicker1.ShowUpDown = true;
                    break;
                case 2:
                    dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                    dateTimePicker1.ShowUpDown = false;
                    break;
                default:
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    break;
            }
        }

        private void searchdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtname.Text) || cmbDateBy.SelectedIndex == -1)
                {
                    MessageBox.Show($"Missing fields, enter all search fields", "Search Errors");
                }
                else
                {
                    var searchkey = cmbSearchBy.SelectedItem.ToString();
                    var searchby = cmbDateBy.SelectedItem.ToString();
                    var keyword = dateTimePicker1.Value.Date;

                    var query = goilRecordsDBEntities.Records.AsQueryable();
                    if (searchkey == "Discharge date")
                        switch (searchby)
                        {
                            case "Year":
                                // query database from record with searchby
                                query = (from records in goilRecordsDBEntities.Records
                                         where records.Discharge_date.Year == keyword.Year
                                         select records);
                                break;

                            case "Month and Year":
                                query = (from records in goilRecordsDBEntities.Records
                                         where records.Discharge_date.Year == keyword.Year && records.Discharge_date.Month == keyword.Month
                                         select records); ;
                                break;
                            case "Date, Month and Year":
                                // query database from record with searchby
                                query = (from records in goilRecordsDBEntities.Records
                                         where records.Discharge_date == keyword
                                         select records);
                                break;
                        }
                    /* int numberOfRecords = query.Count();
                     //var kom = query.ToList().
                     if (query != null)
                     {
                         dgvrecords.DataSource = query.ToList();
                         MessageBox.Show($"Search was successful,\n{numberOfRecords} record(s) found", "Search Results");
                     }
                     else
                         MessageBox.Show($"No records match, check inputs ", "Search Results");*/

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
