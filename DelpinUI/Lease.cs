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
    //JC - Whole class
    public partial class Lease : Form
    {
        private Controller controller = new Controller();
        private DataTable dataTableSubGroup = new DataTable();

        public Lease()
        {
            InitializeComponent();
            leaseStatus.SelectedIndex = 0;
            deliveryZoneComboBox.SelectedIndex = 0;
        }

        public void OpenLeaseAutomatically(int leaseID)
        {
            GetLeaseByLeaseID(leaseID);
        }


        //Functions to set selection boxes during load
        private void Lease_Load(object sender, EventArgs e)
        {
            SetSelectionBoxes();
            SetDataGridViewLeaseOrdersColumnTypes();
        }

        private void SetDataGridViewLeaseOrdersColumnTypes()
        {
            leaseOrders.Columns["Dagspris"].ValueType = typeof(decimal);
            leaseOrders.Columns["Levering"].ValueType = typeof(decimal);
            leaseOrders.Columns["Dagspris"].DefaultCellStyle.Format = "N2";
            leaseOrders.Columns["Levering"].DefaultCellStyle.Format = "N2";

            leaseOrders.Columns["Postkode"].ValueType = typeof(int);
            leaseOrders.Columns["Resurse"].ReadOnly = true;


            leaseOrders.Columns["Leveringsdato"].ValueType = typeof(DateTime);
            leaseOrders.Columns["Slutdato"].ValueType = typeof(DateTime);
        }

        private void SetSelectionBoxes()
        {
            DataTable dataTableMainGroup = controller.DisplayMainGroup();
            dataTableSubGroup = controller.DisplaySubGroup();

            SubGroup.DataSource = dataTableSubGroup;
            SubGroup.DisplayMember = "Category";
            SubGroup.ValueMember = "SubGroupID";

            MainGroup.DataSource = dataTableMainGroup;
            MainGroup.DisplayMember = "Category";
            MainGroup.ValueMember = "MainGroupID";


            UpdateResourceDataGrid(Convert.ToInt32(SubGroup.SelectedValue));
        }

        //Methods handling category comboboxes
        private void MainGroup_SelectedIndexChanged(object sender, EventArgs e)
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

        //Functions to find debtor by ID
        private void SearchDebtorButton_Click(object sender, EventArgs e)
        {
            GetDebtoryByID(debtorIDTextBox.Text);
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
                debtorName.Text = (string)dataTable.Rows[0]["CompanyName"];
            }
            else
            {
                debtorName.Text = (string)dataTable.Rows[0]["FirstName"] + " " + (string)dataTable.Rows[0]["LastName"];
            }

            billingAddress.Text = (string)dataTable.Rows[0]["Street"];
            billingCity.Text = (string)dataTable.Rows[0]["City"];
            billingPostCode.Text = dataTable.Rows[0]["PostalCode"].ToString();
            phoneNumber.Text = (string)dataTable.Rows[0]["Phone"];
            debtorEmail.Text = (string)dataTable.Rows[0]["Email"];
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

        //function to add resource to lease open on the form
        private void AddResourceToOrderButton_Click(object sender, EventArgs e)
        {
            var selectedRows = esourcesDataGridView.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en varemodel at indsætte");
                return;
            }

            int selectedRow = selectedRows[0].Index;
            int modelID = Convert.ToInt32(esourcesDataGridView.Rows[selectedRow].Cells["ModelID"].Value);

            AddResourceToLease(modelID);
        }

        private void AddResourceToLease(int modelID)
        {
            DateTime startDate = DeliveryDate.Value;
            DateTime endDate = ReturnDate.Value;
            
            DataTable dataTable = controller.GetAvailableResourcesForPeriod(modelID, Utility.BranchID, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

            FormSelectFromTable formSelectFromTable = new FormSelectFromTable();
            formSelectFromTable.ShowResources(dataTable);
            formSelectFromTable.SetTitle("Vælg resurse");
            var result = formSelectFromTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                int resourceID = formSelectFromTable.returnValue;

                SelectResource(resourceID, formSelectFromTable);
            }
        }

        private void SelectResource(int resourceID, FormSelectFromTable formSelectFromTable)
        {
            leaseOrders.Rows.Add();
            int lastRow = leaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
            leaseOrders.Rows[lastRow].Cells["ResurseID"].Value = resourceID;
            leaseOrders.Rows[lastRow].Cells["Resurse"].Value = formSelectFromTable.modelName;
            leaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = DeliveryDate.Value.ToString("yyyy/MM/dd");
            leaseOrders.Rows[lastRow].Cells["Slutdato"].Value = ReturnDate.Value.ToString("yyyy/MM/dd");
            leaseOrders.Rows[lastRow].Cells["Dagspris"].Value = formSelectFromTable.dailyPrice.ToString("N2");

            leaseOrders.Rows[lastRow].Cells["Gade"].Value = deliveryAddressTextBox.Text;
            leaseOrders.Rows[lastRow].Cells["Postkode"].Value = deliveryPostCodeTextBox.Text;
            leaseOrders.Rows[lastRow].Cells["By"].Value = deliveryCityTextBox.Text;

            int weight = Convert.ToInt32(esourcesDataGridView.Rows[esourcesDataGridView.SelectedRows[0].Index].Cells["WeightKG"].Value);
            double deliveryPrice = GetDeliveryPrice(Convert.ToInt32(deliveryZoneComboBox.Text), weight);
            leaseOrders.Rows[lastRow].Cells["Levering"].Value = deliveryPrice.ToString("N2");
        }

        private double GetDeliveryPrice(int zone, int tonnage)
        {
            bool ton = false;
            if (tonnage > 8000) { ton = true; }

            double deliveryPrice = controller.GetItemsFromDeliveryTable(zone, ton);
            return deliveryPrice;
        }

        //Function to create Lease and save to database
        private void CreateLease_Click(object sender, EventArgs e)
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
                this.leaseNumber.Text = leaseNumber;
                AddOpenStatusesToComboBox();


                createLease.Enabled = false;
                updateLease.Enabled = true;
                deleteLease.Enabled = true;
                updateStatus.Enabled = true;
                writeInvoice.Enabled = true;
                MessageBox.Show($"Ordren blev oprettet med ordrenummer {leaseNumber}");
            }

        }

        private bool CheckOrderIsGood()
        {
            if (billingAddress.Text == "")
            {
                MessageBox.Show("Vælg kunde før du opretter ordren");
                return false;
            }
            if(leaseNumber.Text != "")
            {
                MessageBox.Show("Denne ordre er allerede oprettet. Ville du opdatere?");
                return false;
            }

            return true;
        }

        private DelpinCore.Lease GetLeaseFromForm()
        {
            bool active = false;
            if (leaseStatus.SelectedText != "Slettet")
            {
                active = true;
            }

            DelpinCore.Lease lease = new DelpinCore.Lease(debtorIDTextBox.Text, Utility.BranchID, active);

            lease.SetContactDetails(contactFirstName.Text, contactLastName.Text, contactPhone.Text);

            foreach (DataGridViewRow row in leaseOrders.Rows)
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

        //Function to use billing address for shipping
        private void checkBoxUseBillingAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (useBillingAddress.Checked == true)
            {
                deliveryAddressTextBox.Text = billingAddress.Text;
                deliveryCityTextBox.Text = billingCity.Text;
                deliveryPostCodeTextBox.Text = billingPostCode.Text;
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


        //functions to get lease loaded to form
        private void buttonFindLeaseByLeaseID_Click(object sender, EventArgs e)
        {
            bool validLeaseID = int.TryParse(textBoxFindLeaseByLeaseID.Text, out int leaseID);
            if (validLeaseID == false)
            {
                MessageBox.Show("Det indtastede ordrenummer er ikke korrekt, prøv igen.");
                return;
            }    

            GetLeaseByLeaseID(leaseID);
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

            createLease.Enabled = false;
            updateLease.Enabled = true;
            deleteLease.Enabled = true;
            updateStatus.Enabled = true;
            writeInvoice.Enabled = true;
        }

        private void buttonFindLeases_Click(object sender, EventArgs e)
        {
            FindLeasesByDebtorID(debtorIDTextBox.Text);
        }

        private void FindLeasesByDebtorID(string debtorID)
        {
            DataTable dataTable = controller.ReadLeasesByDebtorID(debtorID);

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
                createLease.Enabled = false;
                updateLease.Enabled = true;
                deleteLease.Enabled = true;
                updateStatus.Enabled = true;
                writeInvoice.Enabled = true;
            }
        }

        private void textBoxFindLeaseByLeaseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bool validLeaseID = int.TryParse(textBoxFindLeaseByLeaseID.Text, out int leaseID);
                if (validLeaseID == false)
                {
                    MessageBox.Show("Det indtastede ordrenummer er ikke korrekt, prøv igen.");
                    return;
                }

                GetLeaseByLeaseID(leaseID);
            }
        }

        private void FillFormWithLease(DelpinCore.Lease lease)
        {
            string debtorID = lease.debtorID;

            if (debtorID.Length == 10)
            {
                personalRadioButton.Checked = true;
            }
            else
            {
                businessRadioButton.Checked = true;
            }

            debtorIDTextBox.Text = debtorID;
            GetDebtoryByID(debtorID);

            contactFirstName.Text = lease.contactFirstName;
            contactLastName.Text = lease.contactLastName;
            contactPhone.Text = lease.contactPhone;
            leaseNumber.Text = lease.leaseID.ToString();


            if (lease.active == true)
            {
                AddOpenStatusesToComboBox();
                FillStatus(lease.status);
            }
            else
            {
                AddClosedStatusesToComboBox();
            }

            foreach (LeaseOrder leaseOrder in lease.GetLeaseOrders())
            {
                leaseOrders.Rows.Add();
                int lastRow = leaseOrders.Rows.GetLastRow(DataGridViewElementStates.Visible);
                leaseOrders.Rows[lastRow].Cells["ResurseID"].Value = leaseOrder.resourceID;
                leaseOrders.Rows[lastRow].Cells["Resurse"].Value = leaseOrder.modelName;
                leaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = leaseOrder.startDate.ToString("yyyy/MM/dd");
                leaseOrders.Rows[lastRow].Cells["Slutdato"].Value = leaseOrder.endDate.ToString("yyyy/MM/dd");
                leaseOrders.Rows[lastRow].Cells["Dagspris"].Value = leaseOrder.leasePrice.ToString("N2");
                leaseOrders.Rows[lastRow].Cells["Levering"].Value = leaseOrder.deliveryPrice.ToString("N2");

                leaseOrders.Rows[lastRow].Cells["Gade"].Value = leaseOrder.deliveryStreet;
                leaseOrders.Rows[lastRow].Cells["Postkode"].Value = leaseOrder.deliveryPostalCode.ToString();
                leaseOrders.Rows[lastRow].Cells["By"].Value = leaseOrder.deliveryCity;
            }

        }

        private void ClearAllTextBoxes()
        {
            leaseOrders.Rows.Clear();

            foreach (Control c in this.Controls)
            {
                string getType = c.GetType().ToString();
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    c.Text = "";
                }
            }

            createLease.Enabled = true;
            updateLease.Enabled = false;
            deleteLease.Enabled = false;
            updateStatus.Enabled = false;
            writeInvoice.Enabled = false;

            SetStatusComboBoxToDefault();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            DelpinCore.Lease lease = GetLeaseFromForm();
            lease.SetLeaseID(Convert.ToInt32(leaseNumber.Text));
            string isUpdateSuccess = controller.UpdateLease(lease);

            MessageBox.Show(isUpdateSuccess);
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

        //function to set statuses of lease
        private void FillStatus(string status)
        {
            switch (status)
            {
                case "Åben":
                    leaseStatus.SelectedIndex = 0;
                    break;
                case "Leveret":
                    leaseStatus.SelectedIndex = 1;
                    break;
                case "Returneret":
                    leaseStatus.SelectedIndex = 2;
                    break;
                case "Betalt":
                    leaseStatus.SelectedIndex = 3;
                    break;
            }
        }

        private void AddOpenStatusesToComboBox()
        {
            leaseStatus.Items.Clear();

            leaseStatus.Items.Add("Åben");
            leaseStatus.Items.Add("Leveret");
            leaseStatus.Items.Add("Returneret");
            leaseStatus.Items.Add("Betalt");

            leaseStatus.SelectedIndex = 0;
        }

        private void AddClosedStatusesToComboBox()
        {
            leaseStatus.Items.Clear();

            leaseStatus.Items.Add("Slettet");
            leaseStatus.Items.Add("Genåbn");

            leaseStatus.SelectedIndex = 0;
        }

        private void SetStatusComboBoxToDefault()
        {
            leaseStatus.Items.Clear();

            leaseStatus.Items.Add("Ikke oprettet");

            leaseStatus.SelectedIndex = 0;
        }

        //function to delease lease
        private void buttonDeleteLease_Click(object sender, EventArgs e)
        {
            if (leaseNumber.Text.Length > 0)
            {
                int leaseID = Convert.ToInt32(leaseNumber.Text);

                DialogResult dialogResult = MessageBox.Show($"Vil du sletter ordre nummer {leaseID}", "Slet ordre", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deleteSuccess = controller.DeactivateLease(leaseID);
                    if (deleteSuccess == "Success")
                    {
                        MessageBox.Show($"Ordre {leaseID} blev slettet");
                        ClearAllTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Der opstod en fejl, ordren blev ikke slettet");
                    }
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
            string status = leaseStatus.Items[leaseStatus.SelectedIndex].ToString();
            int leaseID = Convert.ToInt32(leaseNumber.Text);
            if (status == "Genåbn")
            {
                controller.ReactivateLease(leaseID);
                GetLeaseByLeaseID(leaseID);
                
            }
            else if (status == "Slettet")
            {
                MessageBox.Show("Denne ordre er allerede slettet!");
            }
            else
            {
                string isSuccess = controller.UpdateLeaseStatus(status, leaseID);
            }
        }

        private void comboBoxSubGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateResourceDataGrid(Convert.ToInt32(SubGroup.SelectedValue));
            }
            catch { }
        }

        //functions for handling resource datagrid
        private void UpdateResourceDataGrid(int subgroupID)
        {
            DataTable dataTable = controller.ReadSpecefikSubCataegori(subgroupID);

            esourcesDataGridView.DataSource = dataTable;

            esourcesDataGridView.Columns["ModelID"].Visible = false;
            esourcesDataGridView.Columns["SubGroupID"].Visible = false;
            esourcesDataGridView.Columns["ModelName"].Width = 150;

            esourcesDataGridView.Columns["ModelName"].HeaderText = "Model";
            esourcesDataGridView.Columns["Price"].HeaderText = "Dagspris";
            esourcesDataGridView.Columns["WeightKG"].HeaderText = "Vægt";

        }

        private void dataGridViewResources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                esourcesDataGridView.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(esourcesDataGridView.Rows[e.RowIndex].Cells["ModelID"].Value);

                AddResourceToLease(modelID);

                ReadAccessoriesToComboBox(modelID);
            }
        }

        private void dataGridViewResources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                esourcesDataGridView.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(esourcesDataGridView.Rows[e.RowIndex].Cells["ModelID"].Value);
                
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

        //print invoice
        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            string pdfSuccess = controller.MakePDF(Convert.ToInt32( leaseNumber.Text));

            if (pdfSuccess == "Filen kan ikke gemmes")
            {
                MessageBox.Show("Fakturaen kunne ikke gemmes, tjek eventuelt om du allerede har fakturan åben.");
            }
        }

        //function to handle format errors in leaseorder grid
        private void dataGridViewLeaseOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Den indtastede værdi er ikke korrekt!");
            leaseOrders.CancelEdit();
        }

        //checking if postcode is valid
        private void textBoxDeliveryPostCode_Leave(object sender, EventArgs e)
        {
            if (Utility.CheckForValidPostCode(deliveryPostCodeTextBox.Text) == false && deliveryPostCodeTextBox.Text != "")
            {
                MessageBox.Show("Den indtastede postkode er ikke korrekt, indtast den venligst igen!");
                deliveryPostCodeTextBox.Text = "";
            }
        }
    }
}
