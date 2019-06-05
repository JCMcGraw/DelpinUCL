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
        //private void ClearTextBox()
        //{
        //    cprText.Clear();
        //    cvrText.Clear();
        //    BnameText.Clear();
        //    PfnameText.Clear();
        //    PlnameText.Clear();
        //    adressText.Clear();
        //    city.Clear();
        //    postalcodeText.Clear();
        //    phoneText.Clear();
        //    emailText.Clear();
        //}

        //Clears all available Textboxes

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
        }

        //updates the debtor datagridview
        private void updateDatagridView()
        {
            if(radioButton1.Checked)
            {
                DataTable dataTable = controller.DisplayAllBusinessDebtor();
                ViewDeb.DataSource = dataTable;
            }

            else
            {
                DataTable dataTable = controller.DisplayAllPersonalDebtor();
                ViewDeb.DataSource = dataTable;
            }       
        }
 
        //Display create debtor forms with radiobutton 
        private void showBdebtor()
        {
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataTable dataTable = controller.DisplayAllBusinessDebtor();
                ViewDeb.DataSource = dataTable;

                //cvrText.Visible = true;
                //CvrLabel.Visible = true;
                //cprText.Visible = false;
                //cprLabel.Visible = false;
                //BnameLabel.Visible = true;
                //BnameText.Visible = true;
                //CreateDeb.Visible = true;
                //ViewDeb.Visible = true;
                //PfnameLabel.Visible = false;
                //PfnameText.Visible = false;
                //PlnameLabel.Visible = false;
                //PlnameText.Visible = false;
                showBdebtor();
            }

            //else
            //{
            //    cvrText.Visible = false;
            //    CvrLabel.Visible = false;
            //    cprText.Visible = true;
            //    cprLabel.Visible = true;
            //    BnameLabel.Visible = false;
            //    BnameText.Visible = false;
            //    CreateDeb.Visible = true;
            //    PfnameLabel.Visible = true;
            //    PfnameText.Visible = true;
            //    PlnameLabel.Visible = true;
            //    PlnameText.Visible = true;
            //}
            ClearAllTextBoxes();
        }

        private void ShowPdebtor()
        {
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DataTable dataTable = controller.DisplayAllPersonalDebtor();
                ViewDeb.DataSource = dataTable;

                //cvrText.Visible = false;
                //CvrLabel.Visible = false;
                //cprText.Visible = true;
                //cprLabel.Visible = true;
                //BnameLabel.Visible = false;
                //BnameText.Visible = false;
                //PfnameLabel.Visible = true;
                //PfnameText.Visible = true;
                //PlnameLabel.Visible = true;
                //PlnameText.Visible = true;
                //CreateDeb.Visible = true;
                //ViewDeb.Visible = true;
                ShowPdebtor();
            }
        }
        
        private void Debtor_Load(object sender, EventArgs e) //Denne bliver ikke brugt Den skal fjernes Correct
        {


        }

        //create debtor and refreshes datagridview
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
                    MessageBox.Show("Ugyldig E-mailadresse");
                    return;
                }

                string succes = controller.CreateBusinessDebtor(cvrText.Text, adressText.Text.Replace("'","''"), Convert.ToInt32(postalcodeText.Text), city.Text.Replace("'", "''"),
                phoneText.Text, emailText.Text, cvrText.Text, BnameText.Text.Replace("'", "''"));
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

                string succes = controller.CreatePersonalDebtor(cprText.Text, adressText.Text.Replace("'", "''"), Convert.ToInt32(postalcodeText.Text), city.Text.Replace("'", "''"), phoneText.Text, emailText.Text, cprText.Text,
                PfnameText.Text.Replace("'", "''"), PlnameText.Text.Replace("'", "''"));
                MessageBox.Show(succes);
            }
            updateDatagridView();
            ClearAllTextBoxes();
        }

        //Get Businessdebtor from CVR
        private void getBusinessDebtor()
        {
            {
            

                string cvr = ViewDeb.SelectedRows[0].Cells[0].Value + string.Empty;
                string bName = ViewDeb.SelectedRows[0].Cells[1].Value + string.Empty;
                string adresse = ViewDeb.SelectedRows[0].Cells[2].Value + string.Empty;
                string City = ViewDeb.SelectedRows[0].Cells[4].Value + string.Empty;
                string pCode = ViewDeb.SelectedRows[0].Cells[3].Value + string.Empty;
                string phoneN = ViewDeb.SelectedRows[0].Cells[5].Value + string.Empty;
                string eMail = ViewDeb.SelectedRows[0].Cells[6].Value + string.Empty;

                cvrText.Text = cvr;
                BnameText.Text = bName;
                adressText.Text = adresse;
                city.Text = City;
                postalcodeText.Text = pCode;
                phoneText.Text = phoneN;
                emailText.Text = eMail;
            }
        }




        //Get PersonalDebtor from ssn
        private void getPersonalDebtor()
        {
            {

                string cpr = ViewDeb.SelectedRows[0].Cells[0].Value + string.Empty;
                string Fname = ViewDeb.SelectedRows[0].Cells[1].Value + string.Empty;
                string Lname = ViewDeb.SelectedRows[0].Cells[2].Value + string.Empty;
                string adresse = ViewDeb.SelectedRows[0].Cells[3].Value + string.Empty;
                string City = ViewDeb.SelectedRows[0].Cells[5].Value + string.Empty;
                string pCode = ViewDeb.SelectedRows[0].Cells[4].Value + string.Empty;
                string phoneN = ViewDeb.SelectedRows[0].Cells[6].Value + string.Empty;
                string eMail = ViewDeb.SelectedRows[0].Cells[7].Value + string.Empty;

                cprText.Text = cpr;
                PfnameText.Text = Fname;
                PlnameText.Text = Lname;
                adressText.Text = adresse;
                city.Text = City;
                postalcodeText.Text = pCode;
                phoneText.Text = phoneN;
                emailText.Text = eMail;
            }
        }



           
        // get specific debtor Business or Personal
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Utility.CheckForValidCVRNumber(cvrText.Text) == false)
                {
                    MessageBox.Show("Ugyldig CVRnummer");
                    return;


                }
                else
                {
                    DataTable dataTable = controller.DisplaySpeceficBusinessDebtor(cvrText.Text);
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Der blev ikke fundet nogle debitorer, prøv at indtaste CVR-nummeret igen.");
                        return;
                    }


                    BnameText.Text = (string)dataTable.Rows[0]["Firmanavn"];
                    adressText.Text = (string)dataTable.Rows[0]["Gade"];
                    city.Text = dataTable.Rows[0]["By"].ToString();
                    postalcodeText.Text = dataTable.Rows[0]["Postnummer"].ToString();
                    phoneText.Text = (string)dataTable.Rows[0]["Telefonnummer"];
                    emailText.Text = (string)dataTable.Rows[0]["E-mail"];
                }
            }
            
            
            if (radioButton2.Checked)
            {
                if (Utility.CheckForValidCPRNumber(cprText.Text) == false)
                {
                    MessageBox.Show("Ugyldig CPRnummer");
                    return;


                }
                else
                {
                    DataTable dataTable = controller.DisplaySpeceficPersonalDebtor(cprText.Text);
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Der blev ikke fundet nogle debitorer, prøv at indtaste CPR-nummeret igen.");
                        return;
                    }


                        PfnameText.Text = (string)dataTable.Rows[0]["Fornavn"];
                    PlnameText.Text = (string)dataTable.Rows[0]["Efternavn"];
                    adressText.Text = (string)dataTable.Rows[0]["Gade"];
                    city.Text = dataTable.Rows[0]["By"].ToString();
                    postalcodeText.Text = dataTable.Rows[0]["Postnummer"].ToString();
                    phoneText.Text = (string)dataTable.Rows[0]["Telefonnummer"];
                    emailText.Text = (string)dataTable.Rows[0]["E-mail"];
                }
            }
           
           




        }
        
        private void UpdateDebtor_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }
                string message = "Vil du rette kunden?";
                string caption = "Annuller";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string succes = controller.UpdateBusinessDebtor(cvrText.Text, adressText.Text.Replace("'", "''"), Convert.ToInt32(postalcodeText.Text), city.Text.Replace("'", "''"),
                   phoneText.Text, emailText.Text, cvrText.Text, BnameText.Text.Replace("'", "''"));
                    MessageBox.Show(succes);
                }
                else
                {

                }



             




            }
            if (radioButton2.Checked)
            {
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }
                if (Utility.CheckForValidEmail(emailText.Text) == false)
                {
                    MessageBox.Show("Ugyldigt E-mailadresse");
                    return;
                }
                string message = "Vil du rette kunden?";
                string caption = "Annuller";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string succes = controller.UpdatePersonalDebtor(cprText.Text, adressText.Text.Replace("'", "''"), Convert.ToInt32(postalcodeText.Text), city.Text.Replace("'", "''"),
                     phoneText.Text, emailText.Text, cprText.Text, PfnameText.Text.Replace("'", "''"), PlnameText.Text.Replace("'", "''"));
                    MessageBox.Show(succes);

                }
                else
                {

                }



                





            }
            
            CreateDeb.Visible = true;
            UpdateDebtor.Visible = true;
            updateDatagridView();
            ClearAllTextBoxes();
            //if(radioButton1.Checked)
            //{
            //    CreateDeb.Visible = false;
            //    SaveDebtor.Visible = true;
            //    CancelUpdate.Visible = true;
            //    UpdateDebtor.Visible = false;
            //}
            //if (radioButton2.Checked)
            //{
            //    CreateDeb.Visible = false;
            //    SaveDebtor.Visible = true;
            //    CancelUpdate.Visible = true;
            //    UpdateDebtor.Visible = false;
            //}

        }
       

        
        
        //Delete debtor and updates datagridview
        private void DeleteDebtor_Click(object sender, EventArgs e)
        {
            //indsæt slet debtor metode
            if (radioButton1.Checked)
            {
                
                string message = "Er du sikker på du vil slette Kunden?";
                string caption = "Annuller";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string Success = controller.DeleteBusinessDebter(cvrText.Text);
                    MessageBox.Show(Success);
                    ClearAllTextBoxes();
                }
                else
                {
                    
                }

                
            }
            if (radioButton2.Checked)
            {
                
                string message = "Er du sikker på du vil slette Kunden?";
                string caption = "Annuller";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string Success = controller.DeletePersonalDebtor(cprText.Text);
                    MessageBox.Show(Success);
                    ClearAllTextBoxes();
                }
                else
                {

                }
               
            }
            updateDatagridView();
        }

        private void ViewDeb_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(radioButton1.Checked)
            {
                if (e.RowIndex > -1)
                {
                    ViewDeb.Rows[e.RowIndex].Selected = true;
                    getBusinessDebtor();

                }
                else
                { }   
            }
            if (radioButton2.Checked)
            {
                if (e.RowIndex > -1)
                {
                    ViewDeb.Rows[e.RowIndex].Selected = true;
                    getPersonalDebtor();
                    
                }
            }
            else
            { }
        }
    }
}
