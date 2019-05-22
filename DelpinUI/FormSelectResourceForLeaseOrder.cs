using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelpinUI
{
    public partial class FormSelectResourceForLeaseOrder : Form
    {
        Lease lease = new Lease();
        public FormSelectResourceForLeaseOrder()
        {
            InitializeComponent();
        }

        public FormSelectResourceForLeaseOrder(Lease lease)
        {
            this.lease = lease;
        }

        private void buttonSelectResource_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            lease.SetResourceID(-1);
        }
    }
}
