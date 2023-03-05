using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GoilRecords.Form1;
//using System.Windows.Media;

namespace GoilRecords
{
    public partial class EditForm : Form
    {
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        private LoadRecords _loadRecords;
        private int record_id;
        
        

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int recordId, LoadRecords loadRecords = null)
        {
            InitializeComponent();
            this.record_id = recordId;
            populateFields();
            _loadRecords = loadRecords;

        }

        private void populateFields()
        {
            var record = goilRecordsDBEntities.Records.FirstOrDefault(data => data.Record_Id == record_id);

            if (record != null)
            {
                addRecordUserControl1.cmbProduct_type.Text = record.Product_type;
                addRecordUserControl1.txtLoadingDepot.Text = record.Loading_depot;
                addRecordUserControl1.dtpDischarge_date.Value = record.Discharge_date;
                addRecordUserControl1.dtpDischargeTime.Value = Convert.ToDateTime(record.Discharge_time.ToString());
                addRecordUserControl1.txtDensity15.Text = Convert.ToString(record.Density_at15);
                addRecordUserControl1.txtQuantityDischarged.Text = Convert.ToString(record.Quantity_discharged);
                addRecordUserControl1.txtProductTemperature.Text = Convert.ToString(record.Product_temperature);
                addRecordUserControl1.txtTemperature_observed.Text = Convert.ToString(record.Temperature_observed);
                addRecordUserControl1.txtDensity_observed.Text = Convert.ToString(record.Density_observed);
                addRecordUserControl1.txtMarkerCert.Text = record.Marker_certificate;
                addRecordUserControl1.txtInvoiceNo.Text = record.Invoice_number;
                addRecordUserControl1.txtBRV_No.Text = record.BRV_number;
                addRecordUserControl1.txtSulphurContent.Text = Convert.ToString(record.Sulphur_amount);
                addRecordUserControl1.txtCompartmentNo.Text = Convert.ToString(record.Compartment_number);
                addRecordUserControl1.cmbContainsWater.Text = record.Contains_water;
                addRecordUserControl1.txtDriverName.Text = record.Driver_name;
                addRecordUserControl1.txtDensity15_observed.Text = Convert.ToString(record.Density_observed);
                addRecordUserControl1.txtDensityDiff.Text = Convert.ToString(record.Density_difference);
            }
        }

        private void ibtnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                
                // creating fields variables
                var productType = addRecordUserControl1.cmbProduct_type.Text;
                var loadingdepot = addRecordUserControl1.txtLoadingDepot.Text;
                var discharge_date = addRecordUserControl1.dtpDischarge_date.Value.Date;
                var discharge_time = addRecordUserControl1.dtpDischargeTime.Value.TimeOfDay;
                var densityat15 = addRecordUserControl1.txtDensity15.Text;
                var productTemp = addRecordUserControl1.txtProductTemperature.Text;
                var productDensity = addRecordUserControl1.txtDensity15.Text;
                var Quantitydischarged = addRecordUserControl1.txtQuantityDischarged.Text;
                var observed_Temp = addRecordUserControl1.txtProductTemperature.Text;
                var observedDensity = addRecordUserControl1.txtDensity_observed.Text;
                var markerCert = addRecordUserControl1.txtMarkerCert.Text;
                var invoiceNumber = addRecordUserControl1.txtInvoiceNo.Text;
                var BRVnumber = addRecordUserControl1.txtBRV_No.Text;
                var sulphurAmount = addRecordUserControl1.txtSulphurContent.Text;
                var compartmentNumber = addRecordUserControl1.txtCompartmentNo.Text;
                var containsWater = addRecordUserControl1.cmbContainsWater.Text;
                var driverName = addRecordUserControl1.txtDriverName.Text;
                var density15_observed = addRecordUserControl1.txtDensity15_observed.Text;
                var densitydiff = addRecordUserControl1.txtDensityDiff.Text;



                // inserting into the database
                var record = goilRecordsDBEntities.Records.FirstOrDefault(data => data.Record_Id == record_id);

                record.Product_type = productType;
                record.Loading_depot = loadingdepot;
                record.Discharge_date = discharge_date;
                record.Discharge_time = discharge_time;
                record.Density_at15 = Convert.ToDouble(densityat15);
                record.Product_temperature = Convert.ToDouble(productTemp);
                record.Quantity_discharged = Convert.ToDouble(productDensity);
                record.Density_observed = Convert.ToDouble(observedDensity);
                record.Temperature_observed = Convert.ToDouble(observed_Temp);
                record.Marker_certificate = markerCert;
                record.Invoice_number = invoiceNumber;
                record.Sulphur_amount = Convert.ToDouble(sulphurAmount);
                record.BRV_number = BRVnumber;
                record.Compartment_number = compartmentNumber;
                record.Contains_water = containsWater;
                record.Driver_name = driverName;
                record.Density_difference = Convert.ToDouble(densitydiff);

                // saving changes to database
                goilRecordsDBEntities.SaveChanges();

                _loadRecords.populateGrid();
                MessageBox.Show("Record has been edited successfully", "Edit Record");
                

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
