using System;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmFindPerson : Form
    {
        // Declare a delegate to define the signature for sending data back
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare the event using the delegate
        public event DataBackEventHandler DataBack;

        public frmFindPerson()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the event to pass the selected PersonID back to the caller form
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
