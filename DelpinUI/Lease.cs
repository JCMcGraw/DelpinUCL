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
    public partial class Lease : Form
    {
        public Lease()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            {

                DateTime date = this.dateTimePicker1.Value;

                this.startdateText.Text = DateTime.Now.ToString("yyyy-MM-dd");

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker2.Value;

            this.endDateText.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Lease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.dataSet4.Model);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                textBox1.Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
