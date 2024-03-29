﻿using System;
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
    public partial class AddRecords : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private Employee _user;

        /// <summary>
        /// InitializeComponents
        /// </summary>
        public AddRecords()
        {
            InitializeComponent();
        }

        /// <summary>
        /// InitializeComponents
        /// </summary>
        /// <param name="user">The user logged in</param>
        public AddRecords(Employee user)
        {
            _user = user;
            InitializeComponent();
        }


        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            bool isFieldEmpty = addRecordUserControl11.IsFieldEmpty();
            if (isFieldEmpty)
                MessageBox.Show("Missing fields, make sure all fields are filled", "Add Error");
            else
            {
                try
                {

                    // creating fields variables
                    var productType = addRecordUserControl11.cmbProduct_type.SelectedItem.ToString();
                    var loadingdepot = addRecordUserControl11.txtLoadingDepot.Text.TrimEnd();
                    var discharge_date = addRecordUserControl11.dtpDischarge_date.Value.Date;
                    var discharge_time = addRecordUserControl11.dtpDischargeTime.Value.TimeOfDay;
                    var densityat15 = addRecordUserControl11.txtDensity15.Text.TrimEnd();
                    var productTemp = addRecordUserControl11.txtProductTemperature.Text.TrimEnd();
                    var productDensity = addRecordUserControl11.txtDensity15.Text.TrimEnd();
                    var Quantitydischarged = addRecordUserControl11.txtQuantityDischarged.Text.TrimEnd();
                    var observed_Temp = addRecordUserControl11.txtTemperature_observed.Text.TrimEnd();
                    var observedDensity = addRecordUserControl11.txtDensity_observed.Text.TrimEnd();
                    var markerCert = addRecordUserControl11.txtMarkerCert.Text.TrimEnd();
                    var invoiceNumber = addRecordUserControl11.txtInvoiceNo.Text.TrimEnd();
                    var BRVnumber = addRecordUserControl11.txtBRV_No.Text.TrimEnd();
                    var sulphurAmount = addRecordUserControl11.txtSulphurContent.Text.TrimEnd();
                    var compartmentNumber = addRecordUserControl11.txtCompartmentNo.Text.TrimEnd();
                    var containsWater = addRecordUserControl11.cmbContainsWater.SelectedItem.ToString();
                    var driverName = addRecordUserControl11.txtDriverName.Text.TrimEnd();
                
                    var density15_observed = addRecordUserControl11.txtDensity15_observed.Text.TrimEnd();
                    var densitydiff = addRecordUserControl11.txtDensityDiff.Text.TrimEnd();
                    

                    
                    // inserting into the database
                    var record = new Record();

                    record.UserID = _user.Person_Id;
                    record.Product_type = productType;
                    record.Loading_depot = loadingdepot;
                    record.Discharge_date = discharge_date;
                    record.Discharge_time= discharge_time;
                    record.Density_at15 = Convert.ToDouble(densityat15);
                    record.Product_temperature = Convert.ToDouble(productTemp);
                    record.Quantity_discharged= Convert.ToDouble(productDensity);
                    record.Density_observed = Convert.ToDouble(observedDensity);
                    record.Temperature_observed = Convert.ToDouble(observed_Temp);
                    record.Marker_certificate = markerCert;
                    record.Invoice_number= invoiceNumber;
                    record.Sulphur_amount = Convert.ToDouble(sulphurAmount);
                    record.BRV_number = BRVnumber;
                    record.Compartment_number = compartmentNumber;
                    record.Contains_water = containsWater;
                    record.Driver_name = driverName;
                    record.Density_at15Observed = Convert.ToDouble(density15_observed);
                    record.Density_difference = Convert.ToDouble(densitydiff);

                    // saving changes to database
                    goilRecordsDBEntities.Records.Add(record);
                    goilRecordsDBEntities.SaveChanges();

                    MessageBox.Show("Record has been added successfully", "Add Record");


                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void ibtnClear_Click(object sender, EventArgs e)
        {
            addRecordUserControl11.ClearFields();

        }

    }
}
