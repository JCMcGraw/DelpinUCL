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
    public partial class Resource : Form

    {
        private Controller controller = new Controller();

        private DataTable dataTableSubGroup = new DataTable();


        public Resource()
        {
            InitializeComponent();

            if (ModelGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string ModelID = ModelGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                string ModelName = ModelGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                string Price = ModelGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                

                //this.ModelID.Text = ModelID;
                this.ModelName.Text = ModelName;
                ModelPrice.Text = Price;
            }


        }
        private void Resource_Load(object sender, EventArgs e)
        {
            SetSelectionBoxes();
            // TODO: This line of code loads data into the 'dataSet4.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.dataSet4.Model);
            // TODO: This line of code loads data into the 'dataSet3.SubGroup' table. You can move, or remove it, as needed.
            this.subGroupTableAdapter.Fill(this.dataSet3.SubGroup);

            

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


            comboBoxShowMain.DataSource = dataTableMainGroup;
            comboBoxShowMain.DisplayMember = "Category";
            comboBoxShowMain.ValueMember = "MainGroupID";


            comboBoxShowSub.DataSource = dataTableSubGroup;
            comboBoxShowSub.DisplayMember = "Category";
            comboBoxShowSub.ValueMember = "SubGroupID";



            DataTable dataTableBranch = controller.GetBranch();

            //comboBoxBranch.DataSource = dataTableBranch;
            //comboBoxBranch.DisplayMember = "City";
            //comboBoxBranch.ValueMember = "BranchID";
            
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

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            string sub;
            sub = comboBoxSubGroup.ValueMember;

            //string succes = controller.CreateResource(Convert.ToInt32(RessourceID.Text), Convert.ToInt32(comboBoxBranch.SelectedValue), ModelName.Text,
            //    Convert.ToDouble(ModelPrice.Text), Convert.ToInt32(comboBoxSubGroup.SelectedValue), Convert.ToDouble(Weight.Text));
            //MessageBox.Show(succes);
        }

        private void comboBoxMainGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
       
        
        private void AddAccesories_Click(object sender, EventArgs e)
        {
            //controller.CreateAccessory()
        }

        private void comboBoxShowSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        
        {

        }

        private void comboBoxMainGroup_SelectedIndexChanged_2(object sender, EventArgs e)
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

        private void comboBoxSubGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = controller.DisplayModelBySubgroupID(Convert.ToInt32(comboBoxSubGroup.SelectedValue));
                ModelGridView.DataSource = dataTable;
            }
            catch { }
            }

        private void comboBoxShowMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
