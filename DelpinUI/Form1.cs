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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debtor d = new Debtor();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resource r = new Resource();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lease l = new Lease();
            l.ShowDialog();
        }
    }
}
