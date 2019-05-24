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
    public partial class FormSelectFromTable : Form
    {
        public int returnValue { get; private set; }

        public FormSelectFromTable()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //lease.SetResourceID(-1);
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

            if (this.Text == "Vælg resurse")
            {
                int resourceID = Convert.ToInt32(dataGridViewResources.Rows[selectedRow].Cells["ResourcesID"].Value);
                returnValue = resourceID;
            }
            else if (this.Text == "Vælg ordre")
            {
                int leaseID = Convert.ToInt32(dataGridViewResources.Rows[selectedRow].Cells["Ordrenummer"].Value);
                returnValue = leaseID;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}
