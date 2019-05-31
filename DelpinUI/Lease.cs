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
        private DataTable dataTableSubGroup = new DataTable();

        public Lease()
        {
            InitializeComponent();
            comboBoxLeaseStatus.SelectedIndex = 0;
            deliveryZoneComboBox.SelectedIndex = 0;
        }

        private void Lease_Load(object sender, EventArgs e)
        {
            SetSelectionBoxes();
            SetDataGridViewLeaseOrdersColumnTypes();
        }

        private void SetDataGridViewLeaseOrdersColumnTypes()
        {
            dataGridViewLeaseOrders.Columns["Dagspris"].ValueType = typeof(decimal);
            dataGridViewLeaseOrders.Columns["Levering"].ValueType = typeof(decimal);
            dataGridViewLeaseOrders.Columns["Dagspris"].DefaultCellStyle.Format = "N2";
            dataGridViewLeaseOrders.Columns["Levering"].DefaultCellStyle.Format = "N2";

            dataGridViewLeaseOrders.Columns["Postkode"].ValueType = typeof(int);
            dataGridViewLeaseOrders.Columns["Resurse"].ReadOnly = true;


            dataGridViewLeaseOrders.Columns["Leveringsdato"].ValueType = typeof(DateTime);
            dataGridViewLeaseOrders.Columns["Slutdato"].ValueType = typeof(DateTime);
        }

        private void SetSelectionBoxes()
        {
            DataTable dataTableMainGroup = controller.GetMainGroup();
            dataTableSubGroup = controller.GetSubGroup();

            MainGroup.DataSource = dataTableMainGroup;
            MainGroup.DisplayMember = "Category";
            MainGroup.ValueMember = "MainGroupID";


            SubGroup.DataSource = dataTableSubGroup;
            SubGroup.DisplayMember = "Category";
            SubGroup.ValueMember = "SubGroupID";

            UpdateResourceDataGrid(Convert.ToInt32(SubGroup.SelectedValue));
        }


        private void comboBoxMainGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {MainGroup.SelectedValue}";

                SubGroup.DataSource = dv.ToTable();
                SubGroup.DisplayMember = "Category";
                SubGroup.ValueMember = "SubGroupID";
            }
            catch { }
        }

        //public void SetResourceID(int resourceID)
        //{
        //    this.resourceID = resourceID;
        //}

        private void SearchDebtorButton_Click(object sender, EventArgs e)
        {
            GetDebtoryByID(debtorIDTextBox.Text);
        }

        private bool CheckDebtorID(string debtorID)
        {
            if (businessRadioButton.Checked == true)
            {
                if (Utility.CheckForValidCVRNumber(debtorID) == false)
                {
                    MessageBox.Show("CVR-nummeret er ikke korrekt, prøv at indtaste det igen");
                    return false;
                }
            }
            else
            {
                if (Utility.CheckForValidCPRNumber(debtorID) == false)
                {
                    MessageBox.Show("CPR-nummeret er ikke korrekt, prøv at indtaste det igen. Bemærk at CPR-nummeret skal indtastes uden bindestreg");
                    return false;
                }
            }
            return true;
        }

        private void GetDebtoryByID(string debtorID)
        {
            if (CheckDebtorID(debtorID) == false)
            {
                return;
            }

            DataTable dataTable;
            if (businessRadioButton.Checked == true)
            {
                dataTable = controller.ReadBusinessDebtor(debtorID);
            }
            else
            {
                dataTable = controller.ReadPersonalDebtor(debtorID);
            }

            if (dataTable.Rows.Count == 0)
            {
                AskIfNewCustomerShouldBeMade();
                return;
            }

            if (businessRadioButton.Checked == true)
            {
                textBoxName.Text = (string)dataTable.Rows[0]["CompanyName"];
            }
            else
            {
                textBoxName.Text = (string)dataTable.Rows[0]["FirstName"] + " " + (string)dataTable.Rows[0]["LastName"];
            }
            
            textBoxBillingAddress.Text = (string)dataTable.Rows[0]["Street"];
            textBoxBillingCity.Text = (string)dataTable.Rows[0]["City"];
            textBoxBillingPostCode.Text = dataTable.Rows[0]["PostalCode"].ToString();
            textBoxPhone.Text = (string)dataTable.Rows[0]["Phone"];
            textBoxEmail.Text = (string)dataTable.Rows[0]["Email"];
        }

        private void AskIfNewCustomerShouldBeMade()
        {
            DialogResult dialogResult = MessageBox.Show("Der blev ikke fundet en kunde med det angivne debitornummer, " +
                "vil du oprette en ny debitor", "Ingen debitor fundet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Debtor debtor = new Debtor();
                debtor.ShowDialog();
            }
        }

        private void AddResourceToOrderButton_Click(object sender, EventArgs e)
        {
            var selectedRows = ResourcesdataGridView.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en varemodel at indsætte");
                return;
            }

            int selectedRow = selectedRows[0].Index;
            int modelID = Convert.ToInt32(ResourcesdataGridView.Rows[selectedRow].Cells["ModelID"].Value);

            AddResourceToLease(modelID);
        }

        private void AddResourceToLease(int modelID)
        {
            DateTime startDate = DeliveryDate.Value;
            DateTime endDate = ReturnDate.Value;

            //DataTable dataTable = controller.ReadSpecefikModelResourcesBranch(modelID);
            DataTable dataTable = controller.GetAvailableResourcesForPeriod(modelID, Utility.BranchID, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

            FormSelectFromTable formSelectFromTable = new FormSelectFromTable();
            formSelectFromTable.ShowResources(dataTable);
            formSelectFromTable.SetTitle("Vælg resurse");
            var result = formSelectFromTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                int resourceID = formSelectFromTable.returnValue;

                dataGridViewLeaseOrders.Rows.Add();
                int lastRow = dataGridViewLeaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewLeaseOrders.Rows[lastRow].Cells["ResurseID"].Value = resourceID;
                //dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = dataGridViewResources.Rows[selectedRow].Cells["ModelName"].Value.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = formSelectFromTable.modelName;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = DeliveryDate.Value.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = ReturnDate.Value.ToString("yyyy/MM/dd");
                //dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = dataGridViewResources.Rows[selectedRow].Cells["Price"].Value.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = formSelectFromTable.dailyPrice.ToString("N2");

                dataGridViewLeaseOrders.Rows[lastRow].Cells["Gade"].Value = deliveryAddressTextBox.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = deliveryPostCodeTextBox.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = deliveryCityTextBox.Text;

                int weight = Convert.ToInt32(ResourcesdataGridView.Rows[ResourcesdataGridView.SelectedRows[0].Index].Cells["WeightKG"].Value);
                double deliveryPrice = GetDeliveryPrice(Convert.ToInt32(deliveryZoneComboBox.Text), weight);
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Levering"].Value = deliveryPrice.ToString("N2");
            }
        }

        private double GetDeliveryPrice(int zone, int tonnage)
        {
            bool ton = false;
            if (tonnage > 8000) { ton = true; }

            double deliveryPrice = controller.GetItemsFromDeliveryTable(zone, ton);
            return deliveryPrice;
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (CheckOrderIsGood() == false)
            {
                return;
            }

            DelpinCore.Lease lease = GetLeaseFromForm();

            string leaseSuccess = controller.CreateLease(lease);

            if (leaseSuccess.Contains("Success"))
            {
                string leaseNumber = Regex.Match(leaseSuccess, @"^[^;]+").ToString();
                textBoxLeaseNumber.Text = leaseNumber;
                AddStatusesToComboBox();


                buttonCreateOrder.Enabled = false;
                buttonUpdateOrder.Enabled = true;
                buttonDeleteLease.Enabled = true;
                buttonUpdateStatus.Enabled = true;
                buttonInvoice.Enabled = true;
            }

        }

        private bool CheckOrderIsGood()
        {
            if (textBoxBillingAddress.Text == "")
            {
                MessageBox.Show("Vælg kunde før du opretter ordren");
                return false;
            }
            if(textBoxLeaseNumber.Text != "")
            {
                MessageBox.Show("Denne ordre er allerede oprettet. Ville du opdatere?");
                return false;
            }

            return true;
        }

        private DelpinCore.Lease GetLeaseFromForm()
        {
            DelpinCore.Lease lease = new DelpinCore.Lease(debtorIDTextBox.Text, Utility.BranchID);

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
                decimal deliveryPrice = Convert.ToDecimal(row.Cells["Levering"].Value.ToString());

                string deliveryAddrress = row.Cells["Gade"].Value.ToString();

                int deliveryPostCode = 0;
                try
                {
                    deliveryPostCode = Convert.ToInt32(row.Cells["Postkode"].Value.ToString());
                }
                catch { }
                string deliveryCity = row.Cells["By"].Value.ToString();

                LeaseOrder leaseOrder = new LeaseOrder(deliveryDate, returnDate, price, resouceID);
                leaseOrder.SetDeliveryAddress(deliveryAddrress, deliveryPostCode, deliveryCity, deliveryPrice);
                lease.SetStatus("Åben");

                lease.AddLeaseOrder(leaseOrder);
            }

            return lease;
        }

        private void checkBoxUseBillingAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (useBillingAddress.Checked == true)
            {
                deliveryAddressTextBox.Text = textBoxBillingAddress.Text;
                deliveryCityTextBox.Text = textBoxBillingCity.Text;
                deliveryPostCodeTextBox.Text = textBoxBillingPostCode.Text;
            }
            else
            {
                deliveryAddressTextBox.Text = "";
                deliveryCityTextBox.Text = "";
                deliveryPostCodeTextBox.Text = "";
            }
        }

        private void radioButtonBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (businessRadioButton.Checked == true)
            {
                labelName.Text = "Firmanavn";
                debtorIDLabel.Text = "CVR-nummer";
            }
            else
            {
                labelName.Text = "Navn";
                debtorIDLabel.Text = "CPR-nummer";
            }
        }

        private void buttonFindLeaseByLeaseID_Click(object sender, EventArgs e)
        {
            GetLeaseByLeaseID(Convert.ToInt32(textBoxFindLeaseByLeaseID.Text));
        }

        private void GetLeaseByLeaseID(int leaseID)
        {
            DelpinCore.Lease lease = controller.ReadLeaseByLeaseID(leaseID);

            if(lease.debtorID == "-1")
            {
                MessageBox.Show("Ordren blev ikke fundet, prøv at indtaste ordrenummeret igen.");
                return;
            }

            ClearAllTextBoxes();

            FillFormWithLease(lease);

            buttonCreateOrder.Enabled = false;
            buttonUpdateOrder.Enabled = true;
            buttonDeleteLease.Enabled = true;
            buttonUpdateStatus.Enabled = true;
            buttonInvoice.Enabled = true;
        }

        private void FillFormWithLease(DelpinCore.Lease lease)
        {
            string debtorID = lease.debtorID;

            debtorIDTextBox.Text = debtorID;
            GetDebtoryByID(debtorID);

            textBoxContactFirstName.Text = lease.contactFirstName;
            textBoxContactLastName.Text = lease.contactLastName;
            textBoxContactPhone.Text = lease.contactPhone;
            textBoxLeaseNumber.Text = lease.leaseID.ToString();

            AddStatusesToComboBox();
            FillStatus(lease.status);

            foreach (LeaseOrder leaseOrder in lease.GetLeaseOrders())
            {
                dataGridViewLeaseOrders.Rows.Add();
                int lastRow = dataGridViewLeaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewLeaseOrders.Rows[lastRow].Cells["ResurseID"].Value = leaseOrder.resourceID;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Resurse"].Value = leaseOrder.modelName;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = leaseOrder.startDate.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = leaseOrder.endDate.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = leaseOrder.leasePrice.ToString("N2");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Levering"].Value = leaseOrder.deliveryPrice.ToString("N2");

                dataGridViewLeaseOrders.Rows[lastRow].Cells["Gade"].Value = leaseOrder.deliveryStreet;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = leaseOrder.deliveryPostalCode.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = leaseOrder.deliveryCity;
            }

        }

        private void FillStatus(string status)
        {
            switch (status)
            {
                case "Åben":
                    comboBoxLeaseStatus.SelectedIndex = 0;
                    break;
                case "Leveret":
                    comboBoxLeaseStatus.SelectedIndex = 1;
                    break;
                case "Returneret":
                    comboBoxLeaseStatus.SelectedIndex = 2;
                    break;
                case "Betalt":
                    comboBoxLeaseStatus.SelectedIndex = 3;
                    break;
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

            buttonCreateOrder.Enabled = true;
            buttonUpdateOrder.Enabled = false;
            buttonDeleteLease.Enabled = false;
            buttonUpdateStatus.Enabled = false;
            buttonInvoice.Enabled = false;

            SetStatusComboBoxToDefault();
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
            FindLeasesByDebtorID(debtorIDTextBox.Text);
        }

        private void FindLeasesByDebtorID(string debtorID)
        {
            DataTable dataTable = controller.ReadLeasesByDebtor(debtorID);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Der blev ikke fundet nogle ordrer, prøv at indtaste kundenummeret igen.");
                return;
            }

            FormSelectFromTable formSelectFromTable = new FormSelectFromTable();
            formSelectFromTable.ShowResources(dataTable);
            formSelectFromTable.SetTitle("Vælg ordre");
            var result = formSelectFromTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                int leaseID = formSelectFromTable.returnValue;

                GetLeaseByLeaseID(leaseID);
                buttonCreateOrder.Enabled = false;
                buttonUpdateOrder.Enabled = true;
                buttonDeleteLease.Enabled = true;
                buttonUpdateStatus.Enabled = true;
                buttonInvoice.Enabled = true;
            }
        }

        private void dateTimePickerDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            if (DeliveryDate.Value < DateTime.Today)
            {
                MessageBox.Show("Du kan ikke sætte en dato tidligere end i dag!");
                DeliveryDate.Value = DateTime.Today;
            }
            if(DeliveryDate.Value >= ReturnDate.Value)
            {
                ReturnDate.Value = DeliveryDate.Value.AddDays(1);
            }
        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (ReturnDate.Value < DeliveryDate.Value)
            {
                MessageBox.Show("Du kan ikke sætte tilbageleveringsdato tidligere end leveringsdatoen!");
                ReturnDate.Value = DeliveryDate.Value.AddDays(1);
            }
        }

        private void buttonAddAccessory_Click(object sender, EventArgs e)
        {
            AddResourceToLease(Convert.ToInt32(accessoryComboBox.SelectedValue));
        }

        private void AddStatusesToComboBox()
        {
            comboBoxLeaseStatus.Items.Clear();

            comboBoxLeaseStatus.Items.Add("Åben");
            comboBoxLeaseStatus.Items.Add("Leveret");
            comboBoxLeaseStatus.Items.Add("Returneret");
            comboBoxLeaseStatus.Items.Add("Betalt");

            comboBoxLeaseStatus.SelectedIndex = 0;
        }

        private void SetStatusComboBoxToDefault()
        {
            comboBoxLeaseStatus.Items.Clear();

            comboBoxLeaseStatus.Items.Add("Ikke oprettet");

            comboBoxLeaseStatus.SelectedIndex = 0;
        }

        private void buttonDeleteLease_Click(object sender, EventArgs e)
        {
            if (textBoxLeaseNumber.Text.Length > 0)
            {
                int leaseID = Convert.ToInt32(textBoxLeaseNumber.Text);

                DialogResult dialogResult = MessageBox.Show($"Vil du sletter ordre nummer {leaseID}", "Slet ordre", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controller.DeactivateLease(leaseID);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Vælg en ordre at slette.");
            }
        }
      
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            string status = comboBoxLeaseStatus.Items[comboBoxLeaseStatus.SelectedIndex].ToString();
            int leaseID = Convert.ToInt32(textBoxLeaseNumber.Text);

            string isSuccess = controller.UpdateLeaseStatus(status, leaseID);
        }

        private void comboBoxSubGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateResourceDataGrid(Convert.ToInt32(SubGroup.SelectedValue));
            }
            catch { }
        }

        private void UpdateResourceDataGrid(int subgroupID)
        {
            DataTable dataTable = controller.ReadSpecefikSubCataegori(subgroupID);

            ResourcesdataGridView.DataSource = dataTable;

            ResourcesdataGridView.Columns["ModelID"].Visible = false;
            ResourcesdataGridView.Columns["SubGroupID"].Visible = false;
            ResourcesdataGridView.Columns["ModelName"].Width = 150;

            ResourcesdataGridView.Columns["ModelName"].HeaderText = "Model";
            ResourcesdataGridView.Columns["Price"].HeaderText = "Dagspris";
            ResourcesdataGridView.Columns["WeightKG"].HeaderText = "Vægt";

        }

        private void dataGridViewResources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ResourcesdataGridView.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(ResourcesdataGridView.Rows[e.RowIndex].Cells["ModelID"].Value);

                AddResourceToLease(modelID);

                ReadAccessoriesToComboBox(modelID);
            }
        }

        private void dataGridViewResources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ResourcesdataGridView.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(ResourcesdataGridView.Rows[e.RowIndex].Cells["ModelID"].Value);
                
                ReadAccessoriesToComboBox(modelID);
            }
        }

        private void ReadAccessoriesToComboBox(int modelID)
        {
            DataTable dataTable = controller.ReadAccessory(modelID);
            try
            {
                accessoryComboBox.DataSource = dataTable;
                accessoryComboBox.DisplayMember = "ModelName";
                accessoryComboBox.ValueMember = "ModelID";
            }
            catch { }
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            controller.MakePDF(Convert.ToInt32( textBoxLeaseNumber.Text));
        }

        private void dataGridViewLeaseOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Den indtastede værdi er ikke korrekt!");
            dataGridViewLeaseOrders.CancelEdit();
        }

        private void textBoxDeliveryPostCode_Leave(object sender, EventArgs e)
        {
            if (Utility.CheckForValidPostCode(deliveryPostCodeTextBox.Text) == false)
            {
                MessageBox.Show("Den indtastede postkode er ikke korrekt, indtast den venligst igen!");
                deliveryPostCodeTextBox.Text = "";
            }
        }
    }
}
