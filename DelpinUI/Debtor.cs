﻿using System;
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
    public partial class Debtor : Form
    {
        public Debtor()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cvrText.Visible = true;
                CvrLabel.Visible = true;
                BnameLabel.Visible = true;
                BnameText.Visible = true;
                CreateBdeb.Visible = true;
                ViewBdeb.Visible = true;
                PfnameLabel.Visible = false;
                PfnameText.Visible = false;
                PlnameLabel.Visible = false;
                PlnameText.Visible = false;
                CreatePdeb.Visible = false;
                ViewPdeb.Visible = false;

            }
            else
            {
                cprText.Visible = true;
                cprLabel.Visible = true;
                BnameLabel.Visible = false;
                BnameText.Visible = false;
                CreateBdeb.Visible = false;
                PfnameLabel.Visible = true;
                PfnameText.Visible = true;
                PlnameLabel.Visible = true;
                PlnameText.Visible = true;
                CreatePdeb.Visible = true;
                ViewPdeb.Visible = false;


            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
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
                CreateBdeb.Visible = false;
                CreatePdeb.Visible = true;
                ViewPdeb.Visible = true;
                ViewBdeb.Visible = false;
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
            // TODO: This line of code loads data into the 'dataSet2.Debtor' table. You can move, or remove it, as needed.
            this.debtorTableAdapter1.Fill(this.dataSet2.Debtor);
            // TODO: This line of code loads data into the 'dataSet1.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.dataSet1.Personal);
            // TODO: This line of code loads data into the 'dataSet1.Debtor' table. You can move, or remove it, as needed.
            this.debtorTableAdapter.Fill(this.dataSet1.Debtor);
            // TODO: This line of code loads data into the 'dataSet1.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter.Fill(this.dataSet1.Business);

        }

        private void PlnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBdeb_Click(object sender, EventArgs e)
        {
            //indsæt business debitor
        }

        private void CreatePdeb_Click(object sender, EventArgs e)
        {
            //indsæt privat debitor
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
        private void ViewBdeb_CellClick()
        {
            //cvrText.Text = ViewBdeb[0, e.RowIndex].Value.ToString();
            //BnameText.Text = ViewBdeb[1, e.RowIndex].Value.ToString();
            //BcontactText.Text = ViewBdeb[2, e.RowIndex].Value.ToString();
            //BcontactPhoText.Text = ViewBdeb[2, e.RowIndex].Value.ToString();
            //adressText.Text = ViewBdeb[2, e.RowIndex].Value.ToString();
            //cityText.Text = ViewBdeb[2, e.RowIndex].Value.ToString();
        }

        private void ViewBdeb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
