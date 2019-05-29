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

            ComboModelMain.DataSource = dataTableMainGroup;
            ComboModelMain.DisplayMember = "Category";
            ComboModelMain.ValueMember = "MainGroupID";


            ComboModelSub.DataSource = dataTableSubGroup;
            ComboModelSub.DisplayMember = "Category";
            ComboModelSub.ValueMember = "SubGroupID";


            AccMain.DataSource = dataTableMainGroup;
            AccMain.DisplayMember = "Category";
            AccMain.ValueMember = "MainGroupID";


            AccSub.DataSource = dataTableSubGroup;
            AccSub.DisplayMember = "Category";
            AccSub.ValueMember = "SubGroupID";




            DataTable dataTableBranch = controller.DisplayBranch();

            branchID.DataSource = dataTableBranch;
            branchID.DisplayMember = "City";
            branchID.ValueMember = "BranchID";

            DataTable dataTable = controller.DisplayAllResources();
            resourceGridView.DataSource = dataTable;

            DataTable dataTableModel = controller.DisplayModel();
            ModelGridView.DataSource = dataTableModel;

            DataTable dataTableAccModel = controller.DisplayModel();

            AccModelView.DataSource = dataTableAccModel;

            DataTable dataTableAddAccModel = controller.DisplayAccModel();
           
            AddAcc.DataSource = dataTableAddAccModel;
            //AddAcc.DataSource = dataTableModel;
        }


        private void comboBoxMainGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {ComboModelMain.SelectedValue}";

                ComboModelSub.DataSource = dv.ToTable();
                ComboModelSub.DisplayMember = "Category";
                ComboModelSub.ValueMember = "SubGroupID";
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

       

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            string sub;
            sub = ComboModelSub.ValueMember;

            string succes = controller.CreateModel(ModelName.Text,Convert.ToInt32(ModelPrice.Text),
                Convert.ToInt32(ComboModelSub.SelectedValue), Convert.ToInt32(Weight.Text));
            MessageBox.Show(succes);
        }

      
        
        private void AddAccesories_Click(object sender, EventArgs e)
        {
            //string addM = AccModelView.SelectedCells[1].ToString();
            //string addA = AddAcc.SelectedCells[1].ToString();

            //int m = Convert.ToInt32(addM);

            //int a = Convert.ToInt32(addA);

            string succes = controller.CreateAccessory(Convert.ToInt32(AccModel.Text),
                Convert.ToInt32(AddAccModel.Text));
            MessageBox.Show(succes);
        }

        private void comboBoxSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        
        {

        }

        private void comboBoxMainGroup_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {ComboModelMain.SelectedValue}";

                ComboModelSub.DataSource = dv.ToTable();
                ComboModelSub.DisplayMember = "Category";
                ComboModelSub.ValueMember = "SubGroupID";
            }
            catch { }
        }

        private void comboBoxSubGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = controller.DisplayModelBySubgroupID(Convert.ToInt32(ComboModelSub.SelectedValue));
                ModelGridView.DataSource = dataTable;
            }
            catch { }
            }

      
        private void CreateRessource_Click(object sender, EventArgs e)
        {
            string succes = controller.CreateResource(Convert.ToInt32(ressourceID.Text),Convert.ToInt32(ResourceModelID.Text), Convert.ToInt32(branchID.SelectedValue));
            MessageBox.Show(succes);
        }

        private void AccModelView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AccModel.Text = AccModelView.CurrentCell.Value.ToString();
        }

        private void AccSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {AccMain.SelectedValue}";

                AccSub.DataSource = dv.ToTable();
                AccSub.DisplayMember = "Category";
                AccSub.ValueMember = "SubGroupID";
            }
            catch { }
        }

        private void DeleteRessource_Click(object sender, EventArgs e)
        {
            string succes = controller.DeleteResource(Convert.ToInt32(ressourceID.Text));
            MessageBox.Show(succes);
        }

        private void AccMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {AccMain.SelectedValue}";
                

                AccSub.DataSource = dv.ToTable();
                AccSub.DisplayMember = "Category";
                AccSub.ValueMember = "SubGroupID";
            }
            catch { }
        }

        private void AddAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            AddAccModel.Text = AddAcc.CurrentCell.Value.ToString();
            


        }

        private void AccModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccSub_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = controller.DisplayModelBySubgroupID(Convert.ToInt32(AccSub.SelectedValue));
                AccModelView.DataSource = dataTable;
            }
            catch { }
        }

        private void ModelGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GetModel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.SelectSpecificModel(Convert.ToInt32(ModelID.Text));


            ModelName.Text = (string)dataTable.Rows[0]["Modelname"];
            //ModelPrice.Text = (string)dataTable.Rows[0]["Pris"];
            //Weight.Text = dataTable.Rows[0]["Vægt"]toString();
            //ComboModelSub = dataTable.Rows[0]["Undergruppe"].ToString();
            //phoneText.Text = (string)dataTable.Rows[0]["Telefonnummer"];
            //emailText.Text = (string)dataTable.Rows[0]["E-mail"];
        }
    }
}


