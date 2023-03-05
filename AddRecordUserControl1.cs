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

      
    }
}
