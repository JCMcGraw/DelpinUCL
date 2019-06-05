using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DelpinCore;

namespace DelpinUI
{
    public partial class saveBranch : Form
    {
        //SØ
        private Controller controller = new Controller();
        private DataTable dataTableSubGroup = new DataTable();

        //SØ
        public saveBranch()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.delpinikon;
            SetSelectionBoxes();
        }
        
        //SØ
        private void SetSelectionBoxes()
        {
            Utility.Branches = controller.DisplayBranch();
            Utility.Branches.Rows[0]["City"] = "Hovedkontor";

            chooseBranchComboBox.DataSource = Utility.Branches;
            chooseBranchComboBox.DisplayMember = "City";
            chooseBranchComboBox.ValueMember = "BranchID";

            string savedBranch = Utility.ReadFromTextFile("savedBranch.delpin");

            if (savedBranch == "FileNotFound")
            {
                return;
            }
            else
            {
                SetSavedBranch(savedBranch);
                SetDeliveries();
            }
        }

        //JC
        private void SetSavedBranch(string branchID)
        {
            try
            {
                Utility.BranchID = Convert.ToInt32(branchID);

                int index = 0;
                for (int i = 0; i < Utility.Branches.Rows.Count; i++)
                {
                    string ID = Utility.Branches.Rows[i]["BranchID"].ToString();
                    if (ID == branchID)
                    {
                        index = i;
                        break;
                    }
                }

                chooseBranchComboBox.SelectedIndex = index;
            }
            catch
            {
                Utility.BranchID = 1;
            }
        }

        //JC
        private void SetDeliveries()
        {
            try
            {
                DataTable dataTable = controller.DisplayDeliveriesforNextNDays(Convert.ToInt32(chooseBranchComboBox.SelectedValue), 1);

                if (dataTable.Rows.Count > 0 && dataTable.Columns[0].ColumnName != "ErrorMessage")
                {
                    ordersForDeliveryLabel.Text = "Ordrer til levering i de næste 2 dage for afdeling " + chooseBranchComboBox.GetItemText(chooseBranchComboBox.SelectedItem);
                    deliveriesInNextTwoDays.DataSource = dataTable;
                }
                else if (dataTable.Rows.Count == 0)
                {
                    ordersForDeliveryLabel.Text = "Ingen ordrer til levering i de næste 2 dage for afdeling " + chooseBranchComboBox.GetItemText(chooseBranchComboBox.SelectedItem);
                    deliveriesInNextTwoDays.DataSource = dataTable;
                }
                else
                {
                    ordersForDeliveryLabel.Text = "";
                    deliveriesInNextTwoDays.DataSource = null;
                }
            }
            catch { }
        }

        //SØ
        private void button1_Click(object sender, EventArgs e)
        {
            Debtor d = new Debtor();
            d.ShowDialog();
        }

        //SØ
        private void button2_Click(object sender, EventArgs e)
        {
            Resource r = new Resource();
            r.ShowDialog();
        }

        //SØ
        private void button3_Click(object sender, EventArgs e)
        {
            Lease l = new Lease();
            l.ShowDialog();
        }

        //JC
        private void saveBranchButton_Click(object sender, EventArgs e)
        {
            Utility.BranchID = (int)chooseBranchComboBox.SelectedValue;
            string isSuccess = Utility.WriteToTextFile("savedBranch.delpin", Utility.BranchID.ToString());

            if (isSuccess == "Success")
            {
                MessageBox.Show("Lokation blev gemt.");
            }
        }

        //JC
        private void chooseBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeliveries();
        }

        //JC
        private void deliveriesInNextTwoDays_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int leaseID = Convert.ToInt32(deliveriesInNextTwoDays.Rows[e.RowIndex].Cells["Ordrenummer"].Value.ToString());

                Lease lease = new Lease();
                lease.OpenLeaseAutomatically(leaseID);
                lease.ShowDialog();
            }
        }
    }
}
