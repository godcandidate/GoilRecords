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
    public partial class ViewRecord : Form
    {
        private int record_id;
        private readonly GoilRecordsDBEntities goilRecordsDBEntities = new GoilRecordsDBEntities();
        public ViewRecord()
        {
            InitializeComponent();
        }

        public ViewRecord(int recordId)
        {
            InitializeComponent();
            this.record_id = recordId;
            notEditableMode();
            populateFields();
            
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            addRecordUserControl1.ibtnCalculateDensity.Visible = false;
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
                addRecordUserControl1.txtDensity15_observed.Text = Convert.ToString(record.Density_at15Observed);
                addRecordUserControl1.txtDensityDiff.Text = Convert.ToString(record.Density_difference);
            }
        }
        /// <summary>
        /// Makes all the fields in the usercontrol form <c>ReadOnly</c>
        /// </summary>
        private void notEditableMode()
        {
            addRecordUserControl1.cmbProduct_type.Enabled = false;
            addRecordUserControl1.txtLoadingDepot.ReadOnly = true;
            addRecordUserControl1.dtpDischarge_date.Enabled = false;
            addRecordUserControl1.dtpDischargeTime.Enabled = false;
            addRecordUserControl1.txtDensity15.ReadOnly = true;
            addRecordUserControl1.txtQuantityDischarged.ReadOnly = true;
            addRecordUserControl1.txtProductTemperature.ReadOnly = true;
            addRecordUserControl1.txtTemperature_observed.ReadOnly = true;
            addRecordUserControl1.txtDensity_observed.ReadOnly = true;
            addRecordUserControl1.txtMarkerCert.ReadOnly = true;
            addRecordUserControl1.txtInvoiceNo.ReadOnly = true;
            addRecordUserControl1.txtBRV_No.ReadOnly = true;
            addRecordUserControl1.txtSulphurContent.ReadOnly = true;
            addRecordUserControl1.txtCompartmentNo.ReadOnly = true;
            addRecordUserControl1.cmbContainsWater.Enabled = false;
            addRecordUserControl1.txtDriverName.ReadOnly = true;
            addRecordUserControl1.txtDensity15_observed.ReadOnly = true;
            addRecordUserControl1.txtDensityDiff.ReadOnly = true;
        }
    }
}
