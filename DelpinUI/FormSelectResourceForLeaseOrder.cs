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
        public FormSelectResourceForLeaseOrder(Lease lease)
        {
            InitializeComponent();
            this.lease = lease;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            lease.SetResourceID(-1);
            this.Close();
        }

        private void buttonSelectResource_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewResources.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en resurse");
                return;
            }

            int selectedRow = selectedRows[0].Index;
            int resourceID = Convert.ToInt32(dataGridViewResources.Rows[selectedRow].Cells["ResourcesID"].Value);

            lease.SetResourceID(resourceID);
            this.Close();
        }

        public void ShowResources(DataTable dataTable)
        {
            dataGridViewResources.DataSource = dataTable;
        }
    }
}
