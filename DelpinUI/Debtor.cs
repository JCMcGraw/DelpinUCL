using DelpinCore;
using System;
using System.Data;
using System.Windows.Forms;

namespace DelpinUI
{
    public partial class Debtor : Form
    {
        Controller controller = new Controller();
        
        public Debtor()
        {
            InitializeComponent();
            updateDatagridView();

        }
       
        
        //public static void CancelDelete()
        //{
        //    const string message = "Er du sikker på du vil slette brugeren?";
        //    const string caption = "Annuller";
        //    var result = MessageBox.Show(message, caption,
        //                                 MessageBoxButtons.YesNo,
        //                                 MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
                
        //}
        //update table
        private void ClearTextBox()
        {
            cprText.Clear();
            cvrText.Clear();
            BnameText.Clear();
            PfnameText.Clear();
            PlnameText.Clear();
            adressText.Clear();
            city.Clear();
            postalcodeText.Clear();
            phoneText.Clear();
            emailText.Clear();
        }


        private void updateDatagridView()
        {
            
            {
                DataTable dataTable = controller.SelectAllBusiness();
                ViewDeb.DataSource = dataTable;
            }
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataTable dataTable = controller.SelectAllBusiness();
                ViewDeb.DataSource = dataTable;

                cvrText.Visible = true;
                CvrLabel.Visible = true;
                cprText.Visible = false;
                cprLabel.Visible = false;
                BnameLabel.Visible = true;
                BnameText.Visible = true;
                CreateDeb.Visible = true;
                ViewDeb.Visible = true;
                PfnameLabel.Visible = false;
                PfnameText.Visible = false;
                PlnameLabel.Visible = false;
                PlnameText.Visible = false;
                
          
            }
            else
            {
                //cprText.Visible = true;
                //cprLabel.Visible = true;
                //BnameLabel.Visible = false;
                //BnameText.Visible = false;
                //CreateDeb.Visible = true;
                //PfnameLabel.Visible = true;
                //PfnameText.Visible = true;
                //PlnameLabel.Visible = true;
                //PlnameText.Visible = true;
             

            }
            ClearTextBox();
         



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                DataTable dataTable = controller.SelectAllPersonal();
                ViewDeb.DataSource = dataTable;

                cvrText.Visible = false;
                CvrLabel.Visible = false;
                cprText.Visible = true;
                cprLabel.Visible = true;
                BnameLabel.Visible = false;
                BnameText.Visible = false;
                PfnameLabel.Visible = true;
                PfnameText.Visible = true;
                PlnameLabel.Visible = true;
                PlnameText.Visible = true;
                CreateDeb.Visible = true;
           
                ViewDeb.Visible = true;
            }
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Debtor_Load(object sender, EventArgs e)
        {


        }

        private void PlnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBdeb_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               
                if(Utility.CheckForValidCVRNumber(cvrText.Text) == false)
                    {
                    MessageBox.Show("Ugyldigt CVR-nummer");
                    return;
                    

                    }
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                    {
                    MessageBox.Show("Ugyldigt CVR-nummer");
                    return;
                    }
                
                    string succes = controller.CreateBusinessDebtor(cvrText.Text, adressText.Text, Convert.ToInt32(postalcodeText.Text), city.Text,
                    phoneText.Text, emailText.Text, cvrText.Text, BnameText.Text);
                    MessageBox.Show(succes);
                
              
            }
            if(radioButton2.Checked)
            {
                if (Utility.CheckForValidCPRNumber(cprText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt CPR-nummer");
                    return;


                }
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }

                string succes = controller.CreatePersonalDebtor(cprText.Text, adressText.Text, Convert.ToInt32(postalcodeText.Text), city.Text, phoneText.Text, emailText.Text, cprText.Text,
                     PfnameText.Text, PlnameText.Text);
                    MessageBox.Show(succes);
                
               
            }


        }



        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.debtorTableAdapter.FillBy(this.dataSet1.Debtor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void ViewBdeb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataTable dataTable = controller.SelectSpecificBusiness(cvrText.Text);


                BnameText.Text = (string)dataTable.Rows[0]["Firmanavn"];
                adressText.Text = (string)dataTable.Rows[0]["Gade"];
                city.Text = dataTable.Rows[0]["By"].ToString();
                postalcodeText.Text = dataTable.Rows[0]["Postnummer"].ToString();
                phoneText.Text = (string)dataTable.Rows[0]["Telefonnummer"];
                emailText.Text = (string)dataTable.Rows[0]["E-mail"];
            }
            if (radioButton2.Checked)
            {
                

                DataTable dataTable = controller.SelectSpecificPersonal(cprText.Text);


                PfnameText.Text = (string)dataTable.Rows[0]["Fornavn"];
                PlnameText.Text = (string)dataTable.Rows[0]["Efternavn"];
                adressText.Text = (string)dataTable.Rows[0]["Gade"];
                city.Text = dataTable.Rows[0]["By"].ToString();
                postalcodeText.Text = dataTable.Rows[0]["Postnummer"].ToString();
                phoneText.Text = (string)dataTable.Rows[0]["Telefonnummer"];
                emailText.Text = (string)dataTable.Rows[0]["E-mail"];

            }



        }

        private void UpdateDebtor_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                CreateDeb.Visible = false;
                SaveDebtor.Visible = true;
                CancelUpdate.Visible = true;
                UpdateDebtor.Visible = false;
            }
            if (radioButton2.Checked)
            {
                CreateDeb.Visible = false;
                SaveDebtor.Visible = true;
                CancelUpdate.Visible = true;
                UpdateDebtor.Visible = false;
            }

        }
       

        private void SaveDebtor_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }


                string succes = controller.UpdateBusinessDebtor(cvrText.Text, adressText.Text, Convert.ToInt32(postalcodeText.Text), city.Text,
                    phoneText.Text, emailText.Text, cvrText.Text, BnameText.Text);
                    MessageBox.Show(succes);
               


                
            }
            if (radioButton2.Checked)
            {
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }



                string succes = controller.UpdatePersonalDebtor(cprText.Text, adressText.Text, Convert.ToInt32(postalcodeText.Text), city.Text,
                    phoneText.Text, emailText.Text, cprText.Text, PfnameText.Text, PlnameText.Text);
                    MessageBox.Show(succes);
                



                

            }
            CreateDeb.Visible = true;
            UpdateDebtor.Visible = true;
            SaveDebtor.Visible = false;
            CancelUpdate.Visible = false;
            ClearTextBox();
         
        }

        private void CancelUpdate_Click(object sender, EventArgs e)
        {
            CreateDeb.Visible = true;
            UpdateDebtor.Visible = true;
            SaveDebtor.Visible = false;
            CancelUpdate.Visible = false;
            ClearTextBox();
         


        }

        private void DeleteDebtor_Click(object sender, EventArgs e)
        {
            //indsæt slet debtor metode
            if (radioButton1.Checked)
            {
                //CancelDelete();
                const string message = "Er du sikker på du vil slette Kunden?";
                const string caption = "Annuller";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string Success = controller.DeleteBusinessDebter(cvrText.Text);
                    MessageBox.Show(Success);
                    ClearTextBox();
                }
                else
                {
                    
                }

                
            }
            if (radioButton2.Checked)
            {
                string Success = controller.DeletePersonalDebtor(cprText.Text);
                MessageBox.Show(Success);
                ClearTextBox();
            }
        }
    }
}
