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
    public partial class ShowStockModel : Form
    {
        public int returnValue { get; private set; }
        public string modelName { get; private set; }
        public decimal dailyPrice { get; private set; }

        public ShowStockModel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void ShowResources(DataTable dataTable) //Ingen referance
        {
            StockGridView.DataSource = dataTable;
            AutoSizeAllColumns();
        }

        private void AutoSizeAllColumns()
        {
            for (int i = 0; i < StockGridView.ColumnCount; i++)
            {
                StockGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void SetTitle(string title)  //Ingen referance
        {
            this.Text = title;
        }
    }
}
