namespace DelpinUI
{
    partial class Debtor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PfnameText = new System.Windows.Forms.TextBox();
            this.PlnameText = new System.Windows.Forms.TextBox();
            this.adressText = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.postalcodeText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.PfnameLabel = new System.Windows.Forms.Label();
            this.PlnameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cprText = new System.Windows.Forms.TextBox();
            this.cprLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BemailLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cvrText = new System.Windows.Forms.TextBox();
            this.CvrLabel = new System.Windows.Forms.Label();
            this.BnameText = new System.Windows.Forms.TextBox();
            this.BnameLabel = new System.Windows.Forms.Label();
            this.CreateDeb = new System.Windows.Forms.Button();
            this.ViewDeb = new System.Windows.Forms.DataGridView();
            this.businessBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new DelpinUI.DataSet7();
            this.businessBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new DelpinUI.DataSet5();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DelpinUI.DataSet1();
            this.debtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new DelpinUI.DataSet6();
            this.businessTableAdapter = new DelpinUI.DataSet1TableAdapters.BusinessTableAdapter();
            this.debtorTableAdapter = new DelpinUI.DataSet1TableAdapters.DebtorTableAdapter();
            this.personalTableAdapter = new DelpinUI.DataSet1TableAdapters.PersonalTableAdapter();
            this.debtorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new DelpinUI.DataSet2();
            this.debtorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.debtorTableAdapter1 = new DelpinUI.DataSet2TableAdapters.DebtorTableAdapter();
            this.fKBusinessDebtor4830B400BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPersonalDebtor45544755BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter1 = new DelpinUI.DataSet5TableAdapters.BusinessTableAdapter();
            this.personalTableAdapter1 = new DelpinUI.DataSet6TableAdapters.PersonalTableAdapter();
            this.businessTableAdapter2 = new DelpinUI.DataSet7TableAdapters.BusinessTableAdapter();
            this.GetBdeb = new System.Windows.Forms.Button();
            this.UpdateDebtor = new System.Windows.Forms.Button();
            this.DeleteDebtor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBusinessDebtor4830B400BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonalDebtor45544755BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PfnameText
            // 
            this.PfnameText.Location = new System.Drawing.Point(12, 102);
            this.PfnameText.Name = "PfnameText";
            this.PfnameText.Size = new System.Drawing.Size(100, 20);
            this.PfnameText.TabIndex = 0;
            this.PfnameText.Visible = false;
            // 
            // PlnameText
            // 
            this.PlnameText.Location = new System.Drawing.Point(126, 102);
            this.PlnameText.Name = "PlnameText";
            this.PlnameText.Size = new System.Drawing.Size(100, 20);
            this.PlnameText.TabIndex = 1;
            this.PlnameText.Visible = false;
            this.PlnameText.TextChanged += new System.EventHandler(this.PlnameText_TextChanged);
            // 
            // adressText
            // 
            this.adressText.Location = new System.Drawing.Point(15, 140);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(100, 20);
            this.adressText.TabIndex = 4;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(15, 179);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 5;
            // 
            // postalcodeText
            // 
            this.postalcodeText.Location = new System.Drawing.Point(130, 179);
            this.postalcodeText.Name = "postalcodeText";
            this.postalcodeText.Size = new System.Drawing.Size(61, 20);
            this.postalcodeText.TabIndex = 6;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(15, 224);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(15, 267);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 8;
            // 
            // PfnameLabel
            // 
            this.PfnameLabel.AutoSize = true;
            this.PfnameLabel.Location = new System.Drawing.Point(12, 87);
            this.PfnameLabel.Name = "PfnameLabel";
            this.PfnameLabel.Size = new System.Drawing.Size(33, 13);
            this.PfnameLabel.TabIndex = 7;
            this.PfnameLabel.Text = "Navn";
            this.PfnameLabel.Visible = false;
            // 
            // PlnameLabel
            // 
            this.PlnameLabel.AutoSize = true;
            this.PlnameLabel.Location = new System.Drawing.Point(123, 87);
            this.PlnameLabel.Name = "PlnameLabel";
            this.PlnameLabel.Size = new System.Drawing.Size(53, 13);
            this.PlnameLabel.TabIndex = 8;
            this.PlnameLabel.Text = "Efternavn";
            this.PlnameLabel.Visible = false;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(16, 124);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(45, 13);
            this.adressLabel.TabIndex = 9;
            this.adressLabel.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Postnr";
            // 
            // cprText
            // 
            this.cprText.Location = new System.Drawing.Point(12, 64);
            this.cprText.Name = "cprText";
            this.cprText.Size = new System.Drawing.Size(100, 20);
            this.cprText.TabIndex = 12;
            this.cprText.Visible = false;
            // 
            // cprLabel
            // 
            this.cprLabel.AutoSize = true;
            this.cprLabel.Location = new System.Drawing.Point(11, 46);
            this.cprLabel.Name = "cprLabel";
            this.cprLabel.Size = new System.Drawing.Size(63, 13);
            this.cprLabel.TabIndex = 13;
            this.cprLabel.Text = "Cpr-nummer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tlfnummer";
            // 
            // BemailLabel
            // 
            this.BemailLabel.AutoSize = true;
            this.BemailLabel.Location = new System.Drawing.Point(15, 251);
            this.BemailLabel.Name = "BemailLabel";
            this.BemailLabel.Size = new System.Drawing.Size(35, 13);
            this.BemailLabel.TabIndex = 15;
            this.BemailLabel.Text = "E-mail";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erhverv";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Privat";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cvrText
            // 
            this.cvrText.Location = new System.Drawing.Point(12, 64);
            this.cvrText.Name = "cvrText";
            this.cvrText.Size = new System.Drawing.Size(100, 20);
            this.cvrText.TabIndex = 0;
            // 
            // CvrLabel
            // 
            this.CvrLabel.AutoSize = true;
            this.CvrLabel.Location = new System.Drawing.Point(11, 46);
            this.CvrLabel.Name = "CvrLabel";
            this.CvrLabel.Size = new System.Drawing.Size(63, 13);
            this.CvrLabel.TabIndex = 25;
            this.CvrLabel.Text = "Cvr-nummer";
            // 
            // BnameText
            // 
            this.BnameText.Location = new System.Drawing.Point(13, 102);
            this.BnameText.Name = "BnameText";
            this.BnameText.Size = new System.Drawing.Size(163, 20);
            this.BnameText.TabIndex = 1;
            // 
            // BnameLabel
            // 
            this.BnameLabel.AutoSize = true;
            this.BnameLabel.Location = new System.Drawing.Point(12, 87);
            this.BnameLabel.Name = "BnameLabel";
            this.BnameLabel.Size = new System.Drawing.Size(56, 13);
            this.BnameLabel.TabIndex = 27;
            this.BnameLabel.Text = "Firmanavn";
            // 
            // CreateDeb
            // 
            this.CreateDeb.Location = new System.Drawing.Point(19, 403);
            this.CreateDeb.Name = "CreateDeb";
            this.CreateDeb.Size = new System.Drawing.Size(75, 23);
            this.CreateDeb.TabIndex = 32;
            this.CreateDeb.Text = "Opret";
            this.CreateDeb.UseVisualStyleBackColor = true;
            this.CreateDeb.Click += new System.EventHandler(this.CreateBdeb_Click);
            // 
            // ViewDeb
            // 
            this.ViewDeb.AllowUserToOrderColumns = true;
            this.ViewDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDeb.Location = new System.Drawing.Point(286, 13);
            this.ViewDeb.Name = "ViewDeb";
            this.ViewDeb.Size = new System.Drawing.Size(812, 425);
            this.ViewDeb.TabIndex = 33;
            this.ViewDeb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewBdeb_CellContentClick);
            this.ViewDeb.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewDeb_CellMouseClick);
            // 
            // businessBindingSource3
            // 
            this.businessBindingSource3.DataMember = "Business";
            this.businessBindingSource3.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource2
            // 
            this.businessBindingSource2.DataMember = "Business";
            this.businessBindingSource2.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtorBindingSource
            // 
            this.debtorBindingSource.DataMember = "Debtor";
            this.debtorBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // businessBindingSource1
            // 
            this.businessBindingSource1.DataMember = "Business";
            this.businessBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // personalBindingSource1
            // 
            this.personalBindingSource1.DataMember = "Personal";
            this.personalBindingSource1.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // debtorTableAdapter
            // 
            this.debtorTableAdapter.ClearBeforeFill = true;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // debtorBindingSource1
            // 
            this.debtorBindingSource1.DataMember = "Debtor";
            this.debtorBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtorBindingSource2
            // 
            this.debtorBindingSource2.DataMember = "Debtor";
            this.debtorBindingSource2.DataSource = this.dataSet2;
            // 
            // debtorTableAdapter1
            // 
            this.debtorTableAdapter1.ClearBeforeFill = true;
            // 
            // fKBusinessDebtor4830B400BindingSource
            // 
            this.fKBusinessDebtor4830B400BindingSource.DataMember = "FK__Business__Debtor__4830B400";
            this.fKBusinessDebtor4830B400BindingSource.DataSource = this.debtorBindingSource;
            // 
            // fKPersonalDebtor45544755BindingSource
            // 
            this.fKPersonalDebtor45544755BindingSource.DataMember = "FK__Personal__Debtor__45544755";
            this.fKPersonalDebtor45544755BindingSource.DataSource = this.debtorBindingSource1;
            // 
            // businessTableAdapter1
            // 
            this.businessTableAdapter1.ClearBeforeFill = true;
            // 
            // personalTableAdapter1
            // 
            this.personalTableAdapter1.ClearBeforeFill = true;
            // 
            // businessTableAdapter2
            // 
            this.businessTableAdapter2.ClearBeforeFill = true;
            // 
            // GetBdeb
            // 
            this.GetBdeb.Location = new System.Drawing.Point(118, 62);
            this.GetBdeb.Name = "GetBdeb";
            this.GetBdeb.Size = new System.Drawing.Size(75, 23);
            this.GetBdeb.TabIndex = 36;
            this.GetBdeb.Text = "Hent debitor";
            this.GetBdeb.UseVisualStyleBackColor = true;
            this.GetBdeb.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateDebtor
            // 
            this.UpdateDebtor.Location = new System.Drawing.Point(103, 403);
            this.UpdateDebtor.Name = "UpdateDebtor";
            this.UpdateDebtor.Size = new System.Drawing.Size(75, 23);
            this.UpdateDebtor.TabIndex = 37;
            this.UpdateDebtor.Text = "Ret Debitor";
            this.UpdateDebtor.UseVisualStyleBackColor = true;
            this.UpdateDebtor.Click += new System.EventHandler(this.UpdateDebtor_Click);
            // 
            // DeleteDebtor
            // 
            this.DeleteDebtor.Location = new System.Drawing.Point(184, 403);
            this.DeleteDebtor.Name = "DeleteDebtor";
            this.DeleteDebtor.Size = new System.Drawing.Size(75, 23);
            this.DeleteDebtor.TabIndex = 40;
            this.DeleteDebtor.Text = "Slet";
            this.DeleteDebtor.UseVisualStyleBackColor = true;
            this.DeleteDebtor.Click += new System.EventHandler(this.DeleteDebtor_Click);
            // 
            // Debtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.ViewDeb);
            this.Controls.Add(this.GetBdeb);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BemailLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.PlnameLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.postalcodeText);
            this.Controls.Add(this.adressText);
            this.Controls.Add(this.CvrLabel);
            this.Controls.Add(this.cprLabel);
            this.Controls.Add(this.cprText);
            this.Controls.Add(this.PfnameLabel);
            this.Controls.Add(this.BnameLabel);
            this.Controls.Add(this.BnameText);
            this.Controls.Add(this.PfnameText);
            this.Controls.Add(this.PlnameText);
            this.Controls.Add(this.cvrText);
            this.Controls.Add(this.DeleteDebtor);
            this.Controls.Add(this.city);
            this.Controls.Add(this.CreateDeb);
            this.Controls.Add(this.UpdateDebtor);
            this.Name = "Debtor";
            this.Text = "Debtor";
            this.Load += new System.EventHandler(this.Debtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBusinessDebtor4830B400BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonalDebtor45544755BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PfnameText;
        private System.Windows.Forms.TextBox adressText;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox postalcodeText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label PfnameLabel;
        private System.Windows.Forms.Label PlnameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cprText;
        private System.Windows.Forms.Label cprLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BemailLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox cvrText;
        private System.Windows.Forms.Label CvrLabel;
        private System.Windows.Forms.TextBox BnameText;
        private System.Windows.Forms.Label BnameLabel;
        private System.Windows.Forms.TextBox PlnameText;
        private System.Windows.Forms.Button CreateDeb;
        private System.Windows.Forms.DataGridView ViewDeb;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private DataSet1TableAdapters.BusinessTableAdapter businessTableAdapter;
        private System.Windows.Forms.BindingSource debtorBindingSource;
        private DataSet1TableAdapters.DebtorTableAdapter debtorTableAdapter;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private DataSet1TableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.BindingSource businessBindingSource1;
        private System.Windows.Forms.BindingSource fKBusinessDebtor4830B400BindingSource;
        private System.Windows.Forms.BindingSource debtorBindingSource1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource debtorBindingSource2;
        private DataSet2TableAdapters.DebtorTableAdapter debtorTableAdapter1;
        private System.Windows.Forms.BindingSource fKPersonalDebtor45544755BindingSource;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource businessBindingSource2;
        private DataSet5TableAdapters.BusinessTableAdapter businessTableAdapter1;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource personalBindingSource1;
        private DataSet6TableAdapters.PersonalTableAdapter personalTableAdapter1;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource businessBindingSource3;
        private DataSet7TableAdapters.BusinessTableAdapter businessTableAdapter2;
        private System.Windows.Forms.Button GetBdeb;
        private System.Windows.Forms.Button UpdateDebtor;
        private System.Windows.Forms.Button DeleteDebtor;
    }
}