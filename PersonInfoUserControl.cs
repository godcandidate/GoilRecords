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
    public partial class PersonInfoUserControl : UserControl
    {
        public PersonInfoUserControl()
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
            if (string.IsNullOrEmpty(txtPersonID.Text) || string.IsNullOrEmpty(txtPersonName.Text) ||
                string.IsNullOrEmpty(txtPersonMobile.Text) || string.IsNullOrEmpty(txtUsername.Text)
                )
                return true;

            return false;
        }

        /// <summary> Clears all the fields on the window </summary>
        public void ClearFields()
        {
            txtPersonID.Clear();
            txtPersonName.Clear();
            txtPersonMobile.Clear();
            txtUsername.Clear();
        }

        /// <summary> Create variables for all the fields of the form </summary>
        public void FieldsVariables()
        {
            var personid = txtPersonID.Text;
            var personName = txtPersonName.Text;
            var personMobile = txtPersonMobile.Text;
            var username = txtUsername.Text;

        }
    }
}
