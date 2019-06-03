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
        private DataTable dataTableAccSubGroup = new DataTable();
        private DataTable dataTableAccDelete = new DataTable();


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
        private void DeleteAcc()
        {
            var selectedRows = ShowAllAcc.SelectedRows;
            int selectedRow = selectedRows[0].Index;
            int AccModelID = Convert.ToInt32(ShowAllAcc.Rows[selectedRow].Cells["Tilhørsnummer"].Value);
            controller.DeleteAccessory(AccModelID);
            UpdateAccTable();
        }
       
        private void UpdateAccTable()
        {
            DataTable dataTableViewAcc = controller.DisplayAccesoryRelations();
            ShowAllAcc.DataSource = dataTableViewAcc;
        }
        private void SetStatusComboBoxToDefault()
        {
            

            ComboModelMain.SelectedIndex = 0;


            ComboModelSub.SelectedIndex = 0;
        }
        private void ClearAllTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                string getType = c.GetType().ToString();
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    c.Text = "";
                }
            }
            SetStatusComboBoxToDefault();

        }
        private void updateDatagridViewModel()
        {


            DataTable dataTable = controller.DisplayModel();
            ModelGridView.DataSource = dataTable;


        }
        private void updateDatagridViewResource()
        {


            DataTable dataTable = controller.DisplayAllResources();
            resourceGridView.DataSource = dataTable;


        }



        private void SetSelectionBoxes()
        {
            DataTable dataTableMainGroup = controller.DisplayMainGroup();
            dataTableSubGroup = controller.DisplaySubGroup();

            ComboModelSub.DataSource = dataTableSubGroup;
            ComboModelSub.DisplayMember = "Category";
            ComboModelSub.ValueMember = "SubGroupID";



            ComboModelMain.DataSource = dataTableMainGroup;
            ComboModelMain.DisplayMember = "Category";
            ComboModelMain.ValueMember = "MainGroupID";



            AccSub.DataSource = dataTableSubGroup;
            AccSub.DisplayMember = "Category";
            AccSub.ValueMember = "SubGroupID";

            AccMain.DataSource = dataTableMainGroup;
            AccMain.DisplayMember = "Category";
            AccMain.ValueMember = "MainGroupID";


            dataTableAccSubGroup = dataTableSubGroup.Copy();
            
            AddAccSub.DataSource = dataTableAccSubGroup;
            AddAccSub.DisplayMember = "Category";
            AddAccSub.ValueMember = "SubGroupID";

            DataTable AddAccView2 = dataTableMainGroup.Copy();

            AddAccMain.DataSource = AddAccView2;
            AddAccMain.DisplayMember = "Category";
            AddAccMain.ValueMember = "MainGroupID";



            DataTable AddAccDelete = dataTableMainGroup.Copy();

            AddAccMain.DataSource = AddAccView2;
            AddAccMain.DisplayMember = "Category";
            AddAccMain.ValueMember = "MainGroupID";




            DataTable dataTableBranch = controller.DisplayBranch();

            branchID.DataSource = dataTableBranch;
            branchID.DisplayMember = "City";
            branchID.ValueMember = "BranchID";

            DataTable dataTable = controller.DisplayAllResources();
            resourceGridView.DataSource = dataTable;

            DataTable dataTableAcc = controller.DisplayAccesoryRelations();
            ShowAllAcc.DataSource = dataTableAcc;


            //DataTable dataTableAccDelete = controller.DisplayAccessoryRelationsBySubGroupID();
            MainAcc.DataSource = dataTableAccDelete;
            MainAcc.DisplayMember = "";
            MainAcc.ValueMember = "subGroupID";

            DataTable dataTableModel = controller.DisplayModel();
            ModelGridView.DataSource = dataTableModel;

            DataTable dataTableAccModel = controller.DisplayModel();

            AccModelView.DataSource = dataTableAccModel;

            DataTable dataTableAddAccModel = controller.DisplayAccModel();

            AddAcc.DataSource = dataTableAddAccModel;
            AddAcc.DataSource = dataTableModel;

            DataTable dataTableAccView = controller.DisplayAccModel();

            DataTable dataTableDeleteAcc = controller.DisplayAccesoryRelations();
            //dataTable = controller.DisplayAccessoryRelationsBySubGroupID();

            AddAcc.DataSource = dataTableAddAccModel;
            AddAcc.DataSource = dataTableModel;

            
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

            string succes = controller.CreateModel(ModelName.Text, Convert.ToDouble(ModelPrice.Text),
                Convert.ToInt32(ComboModelSub.SelectedValue), Convert.ToDouble(Weight.Text));
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
                DataView dv = new DataView(dataTableSubGroup);
                dv.RowFilter = $"MainGroup = {ComboModelMain.SelectedValue}";

                ComboModelSub.DataSource = dv.ToTable();
                ComboModelSub.DisplayMember = "Category";
                ComboModelSub.ValueMember = "SubGroupID";
            }
            catch { }
        }
    
      
        private void CreateRessource_Click(object sender, EventArgs e)
        {
            string succes = controller.CreateResource(Convert.ToInt32(ressourceID.Text),Convert.ToInt32(ResourceModelID.Text), Convert.ToInt32(branchID.SelectedValue));
            MessageBox.Show(succes);
            updateDatagridViewResource();
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
            const string message = "Er du sikker på du vil slette Resursen?";
            const string caption = "Annuller";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string succes = controller.DeactivateResource(Convert.ToInt32(ressourceID.Text));
                MessageBox.Show(succes);
                updateDatagridViewResource();
            }
            else
            {

            }

            
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

            GetModelByModelID(Convert.ToInt32(ModelID.Text));
        }
        private void GetModelByModelID(int ModelID)
        {
            DataTable dataTable = controller.DisplaySpecificModel(ModelID);


            ModelName.Text = (string)dataTable.Rows[0]["Modelnavn"];
            ModelPrice.Text = dataTable.Rows[0]["Pris"].ToString();
            Weight.Text = (string)dataTable.Rows[0]["Vægt"].ToString();
            ComboModelMain.SelectedValue = dataTable.Rows[0]["Hovedgruppe"].ToString();
            ComboModelSub.SelectedValue = dataTable.Rows[0]["Undergruppe"].ToString();
        }
        private void ModelGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ModelGridView.Rows[e.RowIndex].Selected = true;
            }
        }
        private void UpdateModel_Click(object sender, EventArgs e)
        {
            const string message = "Vil du rette resursen?";
            const string caption = "Annuller";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                string succes = controller.UpdateModel(Convert.ToInt32(ModelID.Text), ModelName.Text, Convert.ToDouble(ModelPrice.Text),
                 Convert.ToInt32(ComboModelSub.SelectedValue), Convert.ToDouble(Weight.Text));
                MessageBox.Show(succes);

            }
            else
            {

            }
            updateDatagridViewModel();
            ClearAllTextBoxes();


        }

        private void AccModelView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AccModel.Text = AccModelView.CurrentCell.Value.ToString();
        }

        private void AccModelView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AccModel.Text = AccModelView.CurrentCell.Value.ToString();
        }

        private void SaveModel_Click(object sender, EventArgs e)
        {
            //string succes = controller.UpdateModel(Convert.ToInt32(ModelID.Text), ModelName.Text, Convert.ToDouble(ModelPrice.Text),
            //    Convert.ToInt32(ComboModelSub.SelectedValue), Convert.ToDouble(Weight.Text));
            //MessageBox.Show(succes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.DisplaySpecificResources(Convert.ToInt32(ressourceID.Text));

            ResourceModelID.Text = dataTable.Rows[0]["Modelnummer"].ToString();
            //ModelName.Text = dataTable.Rows[0]["Modelnummer"].ToString();
           
            
            branchID.SelectedValue = dataTable.Rows[0]["Afdelingsnummer"].ToString();

            //string succes = controller.DisplaySpecificResources(ressourceID.Text));
            //MessageBox.Show(succes);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            const string message = ("Vil du fjerne tilbehøret fra");
            const string caption = "Annuller";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                DeleteAcc();

            }
            else
            {

            }
            UpdateAccTable();
            ClearAllTextBoxes();

        }

        private void ComboModelMain_SelectedIndexChanged(object sender, EventArgs e)
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

        private void AddAccMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableAccSubGroup);
                dv.RowFilter = $"MainGroup = {AddAccMain.SelectedValue}";


                AddAccSub.DataSource = dv.ToTable();
                AddAccSub.DisplayMember = "Category";
                AddAccSub.ValueMember = "SubGroupID";
            }
            catch { }
        }

        private void AddAccSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = controller.DisplayModelBySubgroupID(Convert.ToInt32(AddAccSub.SelectedValue));
                AddAcc.DataSource = dataTable;
            }
            catch { }

        }

        private void DeleteModel_Click(object sender, EventArgs e)
        {
            const string message = "Er du sikker på du vil slette Modellen?";
            const string caption = "Annuller";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string succes = controller.DeleteModel(Convert.ToInt32(ModelID.Text));
                MessageBox.Show(succes);

            }
            else
            {

            }
            ClearAllTextBoxes();
            updateDatagridViewModel();


        }

        private void ComboModelSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AccModelID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ModelGridView.Rows[e.RowIndex].Selected = true;
                
                string Modelid = ModelGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                int Modelnummer = Convert.ToInt32(Modelid);
                GetModelByModelID(Modelnummer);
                ModelID.Text = Modelid;

            }
        }
        

        private void resourceGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                resourceGridView.Rows[e.RowIndex].Selected = true;

                string Resourceid = resourceGridView.Rows[e.RowIndex].Cells[0].Value + string.Empty;
                string ModelId = resourceGridView.Rows[e.RowIndex].Cells[1].Value + string.Empty;
                string BranchID = resourceGridView.Rows[e.RowIndex].Cells[4].Value + string.Empty;

                
                ressourceID.Text = Resourceid;
                ResourceModelID.Text = ModelId;
                branchID.SelectedValue = BranchID;
            }
        }

        private void AccModelView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                AccModelView.Rows[e.RowIndex].Selected = true;
            }
        }
        private void AccModelView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                AccModelView.Rows[e.RowIndex].Selected = true;

                string accModel = AccModelView.Rows[e.RowIndex].Cells[0].Value + string.Empty;
                AccModel.Text = accModel;
            }

        }

        private void AddAcc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                AddAcc.Rows[e.RowIndex].Selected = true;
            }
        }
      


        private void ShowAllAcc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowAllAcc.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AddAcc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
                AddAcc.Rows[e.RowIndex].Selected = true;
                string Addacc = AddAcc.Rows[e.RowIndex].Cells[0].Value + string.Empty;
                 
                AddAccModel.Text = Addacc;

            }
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dataTableAccDelete);
                dv.RowFilter = $"MainGroup = {MainAcc.SelectedValue}";


                SubAcc.DataSource = dv.ToTable();
                SubAcc.DisplayMember = "Category";
                SubAcc.ValueMember = "SubGroupID";
            }
            catch { }

        }

        private void SubAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}


