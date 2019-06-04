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
    //JC - whole class
    public partial class FormSelectFromTable : Form
    {
        public int returnValue { get; private set; }
        public string modelName { get; private set; }
        public decimal dailyPrice { get; private set; }

        public FormSelectFromTable()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSelectResource_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewResources.SelectedRows;
            if (selectedRows.Count < 1)
            {
                MessageBox.Show("Vælg en linje!");
                return;
            }

            int selectedRow = selectedRows[0].Index;

            SelectRow(selectedRow);
        }

        private void SelectRow(int rowIndex)
        {
            if (this.Text == "Vælg resurse")
            {
                if (CheckIfResourceAvailable(rowIndex) == true)
                {
                    int resourceID = Convert.ToInt32(dataGridViewResources.Rows[rowIndex].Cells["ResurseID"].Value);
                    returnValue = resourceID;
                    modelName = dataGridViewResources.Rows[rowIndex].Cells["Model"].Value.ToString();
                    dailyPrice = Convert.ToDecimal(dataGridViewResources.Rows[rowIndex].Cells["Dagspris"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Denne vare kan ikke bookes i denne periode!");
                    return;
                }
            }
            else if (this.Text == "Vælg ordre")
            {
                int leaseID = Convert.ToInt32(dataGridViewResources.Rows[rowIndex].Cells["Ordrenummer"].Value);
                returnValue = leaseID;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool CheckIfResourceAvailable(int selectedRow)
        {
            if (dataGridViewResources.Rows[selectedRow].Cells["Tilgængelighed"].Value.ToString() == "Fri")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowResources(DataTable dataTable)
        {
            dataGridViewResources.DataSource = dataTable;
            AutoSizeAllColumns();
        }

        private void AutoSizeAllColumns()
        {
            for(int i = 0; i < dataGridViewResources.ColumnCount; i++)
            {
                dataGridViewResources.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        private void dataGridViewResources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewResources.Rows[e.RowIndex].Selected = true;

                SelectRow(e.RowIndex);
            }
        }

        private void dataGridViewResources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewResources.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
