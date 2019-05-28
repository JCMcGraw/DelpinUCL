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
            comboBoxDeliveryZone.SelectedIndex = 0;
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

            UpdateResourceDataGrid(Convert.ToInt32(comboBoxSubGroup.SelectedValue));
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

        private bool CheckDebtorID(string debtorID)
        {
            if (radioButtonBusiness.Checked == true)
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
            if (radioButtonBusiness.Checked == true)
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

            if (radioButtonBusiness.Checked == true)
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
            var selectedRows = dataGridViewResources.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en varemodel at indsætte");
                return;
            }

            int selectedRow = selectedRows[0].Index;
            int modelID = Convert.ToInt32(dataGridViewResources.Rows[selectedRow].Cells["ModelID"].Value);

            AddResourceToLease(modelID);
        }

        private void AddResourceToLease(int modelID)
        {
            DateTime startDate = dateTimePickerDeliveryDate.Value;
            DateTime endDate = dateTimePickerReturnDate.Value;

            //DataTable dataTable = controller.ReadSpecefikModelResourcesBranch(modelID);
            DataTable dataTable = controller.GetAvailableResourcesForPeriod(modelID, 1, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

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
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Leveringsdato"].Value = dateTimePickerDeliveryDate.Value.ToString("yyyy/MM/dd");
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Slutdato"].Value = dateTimePickerReturnDate.Value.ToString("yyyy/MM/dd");
                //dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = dataGridViewResources.Rows[selectedRow].Cells["Price"].Value.ToString();
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = formSelectFromTable.dailyPrice.ToString("N2");

                dataGridViewLeaseOrders.Rows[lastRow].Cells["Gade"].Value = textBoxDeliveryAddress.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Postkode"].Value = textBoxDeliveryPostCode.Text;
                dataGridViewLeaseOrders.Rows[lastRow].Cells["By"].Value = textBoxDeliveryCity.Text;

                int weight = Convert.ToInt32(dataGridViewResources.Rows[dataGridViewResources.SelectedRows[0].Index].Cells["WeightKG"].Value);
                double deliveryPrice = GetDeliveryPrice(Convert.ToInt32(comboBoxDeliveryZone.Text), weight);
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

                int deliveryPostCode = 0;
                try
                {
                    deliveryPostCode = Convert.ToInt32(row.Cells["Postkode"].Value.ToString());
                }
                catch { }
                string deliveryCity = row.Cells["By"].Value.ToString();

                LeaseOrder leaseOrder = new LeaseOrder(deliveryDate, returnDate, price, resouceID);
                leaseOrder.SetDeliveryAddress(deliveryAddrress, deliveryPostCode, deliveryCity);
                lease.SetStatus("Åben");

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
                dataGridViewLeaseOrders.Rows[lastRow].Cells["Dagspris"].Value = leaseOrder.leasePrice.ToString();

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
            FindLeasesByDebtorID(textBoxDebtorID.Text);
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
            }
        }

        private void dateTimePickerDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDeliveryDate.Value < DateTime.Today)
            {
                MessageBox.Show("Du kan ikke sætte en dato tidligere end i dag!");
                dateTimePickerDeliveryDate.Value = DateTime.Today;
            }
            if(dateTimePickerDeliveryDate.Value >= dateTimePickerReturnDate.Value)
            {
                dateTimePickerReturnDate.Value = dateTimePickerDeliveryDate.Value.AddDays(1);
            }
        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerReturnDate.Value < dateTimePickerDeliveryDate.Value)
            {
                MessageBox.Show("Du kan ikke sætte tilbageleveringsdato tidligere end leveringsdatoen!");
                dateTimePickerReturnDate.Value = dateTimePickerDeliveryDate.Value.AddDays(1);
            }
        }

        private void buttonAddAccessory_Click(object sender, EventArgs e)
        {
            AddResourceToLease(Convert.ToInt32(comboBoxAccessory.SelectedValue));
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
                UpdateResourceDataGrid(Convert.ToInt32(comboBoxSubGroup.SelectedValue));
            }
            catch { }
        }

        private void UpdateResourceDataGrid(int subgroupID)
        {
            DataTable dataTable = controller.ReadSpecefikSubCataegori(subgroupID);

            dataGridViewResources.DataSource = dataTable;

            dataGridViewResources.Columns["ModelID"].Visible = false;
            dataGridViewResources.Columns["SubGroupID"].Visible = false;
            dataGridViewResources.Columns["ModelName"].Width = 150;

            dataGridViewResources.Columns["ModelName"].HeaderText = "Model";
            dataGridViewResources.Columns["Price"].HeaderText = "Dagspris";
            dataGridViewResources.Columns["WeightKG"].HeaderText = "Vægt";

        }

        private void dataGridViewResources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewResources.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(dataGridViewResources.Rows[e.RowIndex].Cells["ModelID"].Value);

                AddResourceToLease(modelID);

                ReadAccessoriesToComboBox(modelID);
            }
        }

        private void dataGridViewResources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewResources.Rows[e.RowIndex].Selected = true;

                int modelID = Convert.ToInt32(dataGridViewResources.Rows[e.RowIndex].Cells["ModelID"].Value);
                
                ReadAccessoriesToComboBox(modelID);
            }
        }

        private void ReadAccessoriesToComboBox(int modelID)
        {
            DataTable dataTable = controller.ReadAccessory(modelID);
            try
            {
                comboBoxAccessory.DataSource = dataTable;
                comboBoxAccessory.DisplayMember = "ModelName";
                comboBoxAccessory.ValueMember = "ModelID";
            }
            catch { }
        }
    }
}
