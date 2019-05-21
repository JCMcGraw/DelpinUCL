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
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();

            if (ProductGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string ModelID = ProductGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                string ModelName = ProductGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                string Price = ProductGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                

                ModelIDText.Text = ModelID;
                ModelNameText.Text = ModelName;
                ModelPriceText.Text = Price;
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Resource_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.dataSet4.Model);
            // TODO: This line of code loads data into the 'dataSet3.SubGroup' table. You can move, or remove it, as needed.
            this.subGroupTableAdapter.Fill(this.dataSet3.SubGroup);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.subGroupTableAdapter.FillBy(this.dataSet3.SubGroup);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
