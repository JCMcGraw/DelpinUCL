using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DelpinCore;

namespace DelpinUI
{
    public partial class Lease : Form
    {
        private Controller controller = new Controller();
        //private int resourceID = -1;
        private DataTable dataTableSubGroup = new DataTable();

        public Lease()
        {
            InitializeComponent();
        }

        private void Lease_Load(object sender, EventArgs e)
        {
            SetSelectionBoxes();
        }

        private void SetSelectionBoxes()
        {
            DataTable dataTableMainGroup = controller.GetMainGroup();
            dataTableSubGroup = controller.GetSubGroup();

            comboBoxMainGroup.DataSource = dataTableMainGroup;
            comboBoxMainGroup.DisplayMember = "Category";
            comboBoxMainGroup.ValueMember = "MainGroupID";


            comboBoxSubGroup.DataSource = dataTableSubGroup;
            comboBoxSubGroup.DisplayMember = "Category";
            comboBoxSubGroup.ValueMember = "SubGroupID";
        }


        private void comboBoxMainGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {comboBoxMainGroup.SelectedValue}";

                comboBoxSubGroup.DataSource = dv.ToTable();
                comboBoxSubGroup.DisplayMember = "Category";
                comboBoxSubGroup.ValueMember = "SubGroupID";
            }
            catch { }
        }

        //public void SetResourceID(int resourceID)
        //{
        //    this.resourceID = resourceID;
        //}

        private void SearchDebtorButton_Click(object sender, EventArgs e)
        {
            GetDebtoryByID(textBoxDebtorID.Text);
        }

        private void GetDebtoryByID(string debtorID)
        {
            DataTable dataTable = controller.ReadBusinessDebtor(debtorID);

            textBoxName.Text = (string)dataTable.Rows[0]["CompanyName"];
            textBoxBillingAddress.Text = (string)dataTable.Rows[0]["Street"];
            textBoxBillingCity.Text = (string)dataTable.Rows[0]["City"];
            textBoxBillingPostCode.Text = dataTable.Rows[0]["PostalCode"].ToString();
            textBoxPhone.Text = (string)dataTable.Rows[0]["Phone"];
            textBoxEmail.Text = (string)dataTable.Rows[0]["Email"];
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

            //DataTable dataTable = controller.ReadSpecefikModelResourcesBranch(modelID);
            DataTable dataTable = controller.GetAvailableResourcesForPeriod(modelID);

            FormSelectFromTable formSelectFromTable = new FormSelectFromTable();
            formSelectFromTable.ShowResources(dataTable);
            formSelectFromTable.SetTitle("Vælg resurse");
            var result = formSelectFromTable.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                int resourceID = formSelectFromTable.returnValue;

                dataGridViewLeaseOrders.Rows.Add();
                int lastRow = dataGridViewLeaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewLeaseOrders.Rows[lastRow].Cells["ResurseID"].Value = resourceID;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = dataGridViewResources.Rows[selectedRow].Cells["ModelName"].Value.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = dateTimePickerDeliveryDate.Value.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = dateTimePickerReturnDate.Value.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = dataGridViewResources.Rows[selectedRow].Cells["Price"].Value.ToString();

                dataGridViewLeaseOrders.Rows[lastRow].Cells["Gade"].Value = textBoxDeliveryAddress.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = textBoxDeliveryPostCode.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = textBoxDeliveryCity.Text;
            }
            

        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            DelpinCore.Lease lease = GetLeaseFromForm();

            string leaseSuccess = controller.CreateLease(lease);

            if (leaseSuccess.Contains("Success"))
            {
                string leaseNumber = Regex.Match(leaseSuccess, @"^[^;]+").ToString();
                textBoxLeaseNumber.Text = leaseNumber;
            }
        }

        private DelpinCore.Lease GetLeaseFromForm()
        {
            DelpinCore.Lease lease = new DelpinCore.Lease(textBoxDebtorID.Text, 1);

            lease.SetContactDetails(textBoxContactFirstName.Text, textBoxContactLastName.Text, textBoxContactPhone.Text);

            foreach (DataGridViewRow row in dataGridViewLeaseOrders.Rows)
            {
                if (row.Cells["ResurseID"].Value == null)
                {
                    continue;
                }
                int resouceID = Convert.ToInt32(row.Cells["ResurseID"].Value.ToString());
                DateTime deliveryDate = Convert.ToDateTime(row.Cells["Leveringsdato"].Value.ToString());
                DateTime returnDate = Convert.ToDateTime(row.Cells["Slutdato"].Value.ToString());
                decimal price = Convert.ToDecimal(row.Cells["Dagspris"].Value.ToString());

                string deliveryAddrress = row.Cells["Gade"].Value.ToString();
                int deliveryPostCode = Convert.ToInt32(row.Cells["Postkode"].Value.ToString());
                string deliveryCity = row.Cells["By"].Value.ToString();

                LeaseOrder leaseOrder = new LeaseOrder(deliveryDate, returnDate, price, resouceID);
                leaseOrder.SetDeliveryAddress(deliveryAddrress, deliveryPostCode, deliveryCity);

                lease.AddLeaseOrder(leaseOrder);
            }

            return lease;
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
                labelName.Text = "Firmanavn";
                labelDebtorID.Text = "CVR-nummer";
            }
            else
            {
                labelName.Text = "Navn";
                labelDebtorID.Text = "CPR-nummer";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.ReadSpecefikSubCataegori(Convert.ToInt32(comboBoxSubGroup.SelectedValue));

            dataGridViewResources.DataSource = dataTable;

            dataGridViewResources.Columns["ModelID"].Visible = false;
            dataGridViewResources.Columns["SubGroupID"].Visible = false;
            dataGridViewResources.Columns["ModelName"].Width = 150;
        }

        private void buttonFindLeaseByLeaseID_Click(object sender, EventArgs e)
        {
            GetLeaseByLeaseID(Convert.ToInt32(textBoxFindLeaseByLeaseID.Text));
        }

        private void GetLeaseByLeaseID(int leaseID)
        {
            DelpinCore.Lease lease = controller.ReadLeaseByLeaseID(leaseID);

            ClearAllTextBoxes();

            FillFormWithLease(lease);
        }

        private void FillFormWithLease(DelpinCore.Lease lease)
        {
            string debtorID = lease.debtorID;

            textBoxDebtorID.Text = debtorID;
            GetDebtoryByID(debtorID);

            textBoxContactFirstName.Text = lease.contactFirstName;
            textBoxContactLastName.Text = lease.contactLastName;
            textBoxContactPhone.Text = lease.contactPhone;
            textBoxLeaseNumber.Text = lease.leaseID.ToString();

            foreach(LeaseOrder leaseOrder in lease.GetLeaseOrders())
            {
                dataGridViewLeaseOrders.Rows.Add();
                int lastRow = dataGridViewLeaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewLeaseOrders.Rows[lastRow].Cells["ResurseID"].Value = leaseOrder.resourceID;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = leaseOrder.modelName;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = leaseOrder.startDate.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = leaseOrder.endDate.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = leaseOrder.leasePrice.ToString();

                dataGridViewLeaseOrders.Rows[lastRow].Cells["Gade"].Value = leaseOrder.deliveryStreet;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = leaseOrder.deliveryPostalCode.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = leaseOrder.deliveryCity;
            }

        }

        private void ClearAllTextBoxes()
        {
            dataGridViewLeaseOrders.Rows.Clear();

            foreach (Control c in this.Controls)
            {
                string getType = c.GetType().ToString();
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    c.Text = "";
                }
            }
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            DelpinCore.Lease lease = GetLeaseFromForm();
            lease.SetLeaseID(Convert.ToInt32(textBoxLeaseNumber.Text));
            string isUpdateSuccess = controller.UpdateLease(lease);

            MessageBox.Show(isUpdateSuccess);
        }

        private void buttonFindLeases_Click(object sender, EventArgs e)
        {
            FindLeasesByDebtorID(textBoxDebtorID.Text);
        }

        private void FindLeasesByDebtorID(string debtorID)
        {
            DataTable dataTable = controller.ReadLeasesByDebtor(debtorID);

            FormSelectFromTable formSelectFromTable = new FormSelectFromTable();
            formSelectFromTable.ShowResources(dataTable);
            formSelectFromTable.SetTitle("Vælg ordre");
            var result = formSelectFromTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                int leaseID = formSelectFromTable.returnValue;

                GetLeaseByLeaseID(leaseID);
            }
        }
    }
}
