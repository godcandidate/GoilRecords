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
    public partial class AddRecordUserControl : UserControl
    {
        
        public AddRecordUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if any field is empty
        /// </summary>
        /// <returns> 
        /// <c>True</c> if any field is empty 
        /// Otherwise <c>Null</c>
        /// </returns>
        public bool IsFieldEmpty()
        {
            if (string.IsNullOrEmpty(txtLoadingDepot.Text) || string.IsNullOrEmpty(txtProductTemperature.Text) ||
                string.IsNullOrEmpty(txtDensity15.Text) || string.IsNullOrEmpty(txtQuantityDischarged.Text) ||
                string.IsNullOrEmpty(txtTemperature_observed.Text) || string.IsNullOrEmpty(txtDensity_observed.Text) ||
                string.IsNullOrEmpty(txtMarkerCert.Text) || string.IsNullOrEmpty(txtInvoiceNo.Text) ||
                string.IsNullOrEmpty(txtSulphurContent.Text) || string.IsNullOrEmpty(txtBRV_No.Text) ||
                string.IsNullOrEmpty(txtCompartmentNo.Text) || string.IsNullOrEmpty(txtDriverName.Text) ||
                string.IsNullOrEmpty(txtDensity15_observed.Text) || string.IsNullOrEmpty(txtDensityDiff.Text)
                )
                return true;
           
            return false;
        }

        /// <summary> Clears all the fields on the window </summary>
        public void ClearFields()
        {
            txtLoadingDepot.Clear();
            txtProductTemperature.Clear();
            txtDensity15.Clear();
            txtQuantityDischarged.Clear();
            txtTemperature_observed.Clear();
            txtDensity_observed.Clear();
            txtMarkerCert.Clear();
            txtInvoiceNo.Clear();
            txtSulphurContent.Clear();
            txtBRV_No.Clear();
            txtCompartmentNo.Clear();
            txtDriverName.Clear();
            txtDensity15_observed.Clear();
            txtDensityDiff.Clear();
        }

        private void ibtnCalculateDensity_Click(object sender, EventArgs e)
        {
            string density_observed = txtDensity_observed.Text.TrimEnd();
            string temp_observed = txtTemperature_observed.Text.TrimEnd();
            double k = 1;

            if (cmbProduct_type.SelectedIndex != -1)
            {
                int index = cmbProduct_type.SelectedIndex;

                // constant varies for product types
                switch (index)
                {
                    case 1:
                        k = 0.9;
                        break;
                    case 2:
                    case 3:
                        k = 0.7;
                        break;
                }
                // checks if Density observed and Temperature observed have double values 
                if (Double.TryParse(density_observed, out double densOb) && Double.TryParse(temp_observed, out double tempOb))
                {
                    txtDensity15_observed.Text = (densOb + k * (tempOb - 15)).ToString();
                    txtDensityDiff.Text = (densOb + k * (tempOb - 15) - densOb).ToString();
                }
                else
                {
                    MessageBox.Show("Values in Density and Temperature observed must be numbers", "Calculation Error");
                }

            }
            else
            {
                MessageBox.Show("Error, select a product type", "Calculation Error");
            }

        }
    }
}
