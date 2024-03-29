﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace GoilRecords
{
    public partial class LoadRecordsUserControl : UserControl
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Employee _user;
        private bool success = true;
        public LoadRecordsUserControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Fills the datagrid dgvrecord with record table from the database
        /// </summary>
        public void populateGridWithUserRecords(Employee user)
        {
            _user = user;
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
                                records.Density_at15Observed,
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
                  data.Density_at15Observed,
                  data.Density_difference
              }
              ).ToList();

                dgvrecords.DataSource = record1;
            }
        }

        /// <summary>
        /// Fills the dgvrecords with the search result
        /// </summary>
        /// <param name="query"> Search result</param>
        private void SearchResults(IQueryable<Record> query)
        {
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

        /// <summary>
        /// Searches the database based on admin or user
        /// </summary>
        /// <param name="searchby">the category to search by</param>
        /// <param name="keyword">the keyword to search</param>
        /// <returns>
        /// The search results 
        /// </returns>
        private IQueryable<Record> SearchByRole(string searchby, string keyword)
        {
            var query = goilRecordsDBEntities.Records.AsQueryable();

            // Returns all results of search results
            if (_user.Username == "admin")
            {
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
            }

            //filters search results by user id
            else
            {
                switch (searchby)
                {
                    case "Product Type":
                        // query database from record with searchby
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Product_type == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Loading Depot":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Loading_depot == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Marker certificate":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Marker_certificate == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Invoice number":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Invoice_number == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "BRV number":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.BRV_number == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Compartment number":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Compartment_number == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Contains_water":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Contains_water == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                    case "Driver's name":
                        query = (from records in goilRecordsDBEntities.Records
                                 where records.Driver_name == keyword && records.UserID == _user.Person_Id
                                 select records);
                        break;

                }
            }

            return query;
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtname.Text) || cmbSearchBy.SelectedIndex == -1)
                {
                    MessageBox.Show($"Missing fields, enter all search fields", "Search Errors");
                }
                else if (cmbSearchBy.SelectedItem.ToString() == "Discharge date" || 
                    cmbSearchBy.SelectedItem.ToString() == "Discharge time")
                {
                    MessageBox.Show($"Use date/time for {cmbSearchBy.SelectedItem.ToString()}", "Search Error");
                }
                else
                {
                    var searchby = cmbSearchBy.SelectedItem.ToString();
                    var keyword = txtname.Text;

                    var query = SearchByRole(searchby, keyword);
                    SearchResults(query);
                   

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured, please try again", "Search Error");
            }
            
        }

        private void ibtnuseDate_Click(object sender, EventArgs e)
        {
            int wordindex = cmbSearchBy.SelectedIndex;
            string searchby = "";
            if (cmbSearchBy.SelectedIndex != -1)
                searchby = cmbSearchBy.SelectedItem.ToString();

            switch (wordindex)
            {
                case -1:
                    MessageBox.Show("Select a searchby ", "Search Error");
                    break;
                    // case 2 or 3
                case 2:
                case 3:
                    pnlSearchDate.Visible = true;
                    break;

                default:
                    MessageBox.Show($"{searchby} is not date/time type ", "Search Error");
                    break;
            }
        }


        private void btncloseDate_Click(object sender, EventArgs e)
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
                case 3:
                    // change the datetimepicker to timepicker
                    dateTimePicker1.Format = DateTimePickerFormat.Time;
                    dateTimePicker1.ShowUpDown = true;
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
                if (string.IsNullOrEmpty(dateTimePicker1.Value.ToString()) || (cmbDateBy.SelectedIndex == -1))
                {
                    MessageBox.Show($"Missing fields, enter all search fields", "Search Errors");
                }
                else
                {
                    var searchkey = cmbSearchBy.SelectedItem.ToString();
                    var searchby = cmbDateBy.SelectedItem.ToString();
                    var keyword = dateTimePicker1.Value.Date;
                    TimeSpan time = dateTimePicker1.Value.TimeOfDay;

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
                                         select records);
                                break;

                            case "Date, Month and Year":
                                query = (from records in goilRecordsDBEntities.Records
                                         where records.Discharge_date == keyword
                                         select records);
                                break;

                            default:
                                MessageBox.Show($"{searchkey} field has no time type ", "Search Error");
                                success = false;
                                break;
                        }

                    else if (searchkey == "Discharge time")
                    {
                        switch (searchby)
                        {
                            case "Time":
                                query = (from records in goilRecordsDBEntities.Records
                                         where records.Discharge_time == time
                                         select records);
                                break;

                            default:
                                MessageBox.Show($"{searchkey} field has only time type ", "Search Error");
                                success = false;
                                break;
                        }

                    }
                    if (success)
                        SearchResults(query);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void ibtnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtusname.Text) || cmbUserBy.SelectedIndex == -1)
                {
                    MessageBox.Show($"Missing fields, enter all search fields", "Search Errors");
                }
                else
                {
                    var searchby = cmbUserBy.SelectedItem.ToString();
                    var keyword = txtusname.Text;

                    var query = goilRecordsDBEntities.Employees.AsQueryable();
                    switch (searchby)
                    {
                        case "Person ID":
                            // query database from employee with searchby
                            query = (from users in goilRecordsDBEntities.Employees
                                     where users.Person_Id == keyword
                                     select users);
                            break;

                        case "Person name":
                            query = (from users in goilRecordsDBEntities.Employees
                                     where users.Person_name == keyword
                                     select users);
                            break;

                        case "Username":
                            query = (from users in goilRecordsDBEntities.Employees
                                     where users.Username == keyword
                                     select users);
                            break;
                    }
                    int numberOfUsers = query.Count();
                    //var kom = query.ToList().
                    if (query != null)
                    {
                        dgvrecords.DataSource = query.ToList();
                        MessageBox.Show($"Search was successful,\n{numberOfUsers} user(s) found", "Search Results");
                    }
                    else
                        MessageBox.Show($"No records match, check inputs ", "Search Results");


                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured, please try again", "Search Error");
            }
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            populateGridWithUserRecords(_user);
        }
    }
}
