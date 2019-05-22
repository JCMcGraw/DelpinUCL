using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelpinCore;

namespace DelpinUI
{
    public partial class Lease : Form
    {
        private Controller controller = new Controller();
        private int resourceID = -1;

        public Lease()
        {
            InitializeComponent();
        }

        private void Lease_Load(object sender, EventArgs e)
        {
            
        }

        public void SetResourceID(int resourceID)
        {
            this.resourceID = resourceID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBoxDebtorID.Text = string.Empty;
            }
            else
            {
                textBoxDebtorID.Text = comboBox1.SelectedItem.ToString();
            }
        }


        private void SearchDebtorButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.ReadBusinessDebtor(textBoxDebtorID.Text);

            textBoxName.Text = (string)dataTable.Rows[0]["CompanyName"];
            textBoxBillingAddress.Text = (string)dataTable.Rows[0]["Street"];
            textBoxBillingCity.Text = (string)dataTable.Rows[0]["City"];
            textBoxBillingPostCode.Text = dataTable.Rows[0]["PostalCode"].ToString();
            textBoxPhone.Text = (string)dataTable.Rows[0]["Phone"];
            textBoxEmail.Text = (string)dataTable.Rows[0]["Email"];
            textBoxContactName.Text = (string)dataTable.Rows[0]["ContactFname"] + " " + (string)dataTable.Rows[0]["ContactLname"];
            textBoxContactPhone.Text = (string)dataTable.Rows[0]["ContactPhone"];
        }



        private void AddResourceToOrderButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewResources.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en varemodel at indsætte");
                return;
            }

            int selectedRow = selectedRows[0].Index;
            int modelID = Convert.ToInt32(dataGridViewResources.Rows[selectedRow].Cells["ModelID"].Value);

            DataTable dataTable = controller.ReadSpecefikModelResourcesBranch(modelID);

            FormSelectResourceForLeaseOrder formSelectResourceForLeaseOrder = new FormSelectResourceForLeaseOrder(this);

            //MessageBox.Show(modelID.ToString());
            dataGridViewLeaseOrders.Rows.Add();
            int lastRow = dataGridViewLeaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
            dataGridViewLeaseOrders.Rows[lastRow].Cells["ResurseID"].Value = "12345";
            dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = "Schwamborn - BEF 201";
            dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = dateTimePickerDeliveryDate.Value.ToString("yyyy/MM/dd");
            dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = dateTimePickerReturnDate.Value.ToString("yyyy/MM/dd");
            dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = "300";

            dataGridViewLeaseOrders.Rows[lastRow].Cells["Levering"].Value = textBoxDeliveryAddress.Text;
            dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = textBoxDeliveryPostCode.Text;
            dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = textBoxDeliveryCity.Text;

        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            DelpinCore.Lease lease = new DelpinCore.Lease(textBoxDebtorID.Text, 1);

            foreach(DataGridViewRow row in dataGridViewLeaseOrders.Rows)
            {
                if (row.Cells["ResurseID"].Value == null)
                {
                    continue;
                }
                int resouceID = Convert.ToInt32(row.Cells["ResurseID"].Value.ToString());
                DateTime deliveryDate = Convert.ToDateTime(row.Cells["Leveringsdato"].Value.ToString());
                DateTime returnDate = Convert.ToDateTime(row.Cells["Slutdato"].Value.ToString());
                decimal price = Convert.ToDecimal(row.Cells["Dagspris"].Value.ToString());

                string deliveryAddrress = row.Cells["Levering"].Value.ToString();
                int deliveryPostCode = Convert.ToInt32(row.Cells["Postkode"].Value.ToString());
                string deliveryCity = row.Cells["By"].Value.ToString();

                LeaseOrder leaseOrder = new LeaseOrder(deliveryDate, returnDate, price, resouceID);
                leaseOrder.AddDeliveryAddress(deliveryAddrress, deliveryPostCode, deliveryCity);

                lease.AddLeaseOrder(leaseOrder);
            }

            controller.CreateLease(lease);
        }

        private void checkBoxUseBillingAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseBillingAddress.Checked == true)
            {
                textBoxDeliveryAddress.Text = textBoxBillingAddress.Text;
                textBoxDeliveryCity.Text = textBoxBillingCity.Text;
                textBoxDeliveryPostCode.Text = textBoxBillingPostCode.Text;
            }
            else
            {
                textBoxDeliveryAddress.Text = "";
                textBoxDeliveryCity.Text = "";
                textBoxDeliveryPostCode.Text = "";
            }
        }

        private void radioButtonBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBusiness.Checked == true)
            {
                labelContactName.Visible = true;
                labelContactPhone.Visible = true;
                textBoxContactName.Visible = true;
                textBoxContactPhone.Visible = true;
                labelName.Text = "Firmanavn";
                labelDebtorID.Text = "CVR-nummer";
            }
            else
            {
                labelContactName.Visible = false;
                labelContactPhone.Visible = false;
                textBoxContactName.Visible = false;
                textBoxContactPhone.Visible = false;
                labelName.Text = "Navn";
                labelDebtorID.Text = "CPR-nummer";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.ReadSpecefikSubCataegori(1);

            dataGridViewResources.DataSource = dataTable;

            dataGridViewResources.Columns["ModelID"].Visible = false;
            dataGridViewResources.Columns["SubGroupID"].Visible = false;
            dataGridViewResources.Columns["ModelName"].Width = 150;
        }
    }
}
