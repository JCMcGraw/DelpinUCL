namespace DelpinUI
{
    partial class Lease
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
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDebtorID = new System.Windows.Forms.TextBox();
            this.labelDebtorID = new System.Windows.Forms.Label();
            this.SearchDebtorButton = new System.Windows.Forms.Button();
            this.comboBoxAccessory = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxContactFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBillingAddress = new System.Windows.Forms.TextBox();
            this.textBoxBillingCity = new System.Windows.Forms.TextBox();
            this.textBoxBillingPostCode = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelBillingCity = new System.Windows.Forms.Label();
            this.labelBillingPostCode = new System.Windows.Forms.Label();
            this.labelContactFirstName = new System.Windows.Forms.Label();
            this.textBoxContactPhone = new System.Windows.Forms.TextBox();
            this.labelContactPhone = new System.Windows.Forms.Label();
            this.labelDeliveryPostCode = new System.Windows.Forms.Label();
            this.labelDeliveryCity = new System.Windows.Forms.Label();
            this.labelDeliveryAddress = new System.Windows.Forms.Label();
            this.textBoxDeliveryPostCode = new System.Windows.Forms.TextBox();
            this.textBoxDeliveryCity = new System.Windows.Forms.TextBox();
            this.textBoxDeliveryAddress = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.dataGridViewLeaseOrders = new System.Windows.Forms.DataGridView();
            this.ResurseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leveringsdato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slutdato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dagspris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Levering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postkode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxMainGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSubGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewResources = new System.Windows.Forms.DataGridView();
            this.AddResourceToOrderButton = new System.Windows.Forms.Button();
            this.checkBoxUseBillingAddress = new System.Windows.Forms.CheckBox();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonal = new System.Windows.Forms.RadioButton();
            this.textBoxLeaseNumber = new System.Windows.Forms.TextBox();
            this.labelLeaseNumber = new System.Windows.Forms.Label();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.labelContactPerson = new System.Windows.Forms.Label();
            this.labelContactLastName = new System.Windows.Forms.Label();
            this.textBoxContactLastName = new System.Windows.Forms.TextBox();
            this.buttonAddAccessory = new System.Windows.Forms.Button();
            this.labelFindLeaseByLeaseID = new System.Windows.Forms.Label();
            this.textBoxFindLeaseByLeaseID = new System.Windows.Forms.TextBox();
            this.buttonFindLeaseByLeaseID = new System.Windows.Forms.Button();
            this.buttonFindLeases = new System.Windows.Forms.Button();
            this.comboBoxLeaseStatus = new System.Windows.Forms.ComboBox();
            this.labelLeaseStatus = new System.Windows.Forms.Label();
            this.buttonDeleteLease = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.comboBoxDeliveryZone = new System.Windows.Forms.ComboBox();
            this.labelDeliveryZone = new System.Windows.Forms.Label();
            this.buttonInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(12, 37);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeliveryDate.TabIndex = 0;
            this.dateTimePickerDeliveryDate.ValueChanged += new System.EventHandler(this.dateTimePickerDeliveryDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "StartDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EndDate";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(12, 80);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturnDate.TabIndex = 4;
            this.dateTimePickerReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerReturnDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tilbehør";
            // 
            // textBoxDebtorID
            // 
            this.textBoxDebtorID.Location = new System.Drawing.Point(483, 56);
            this.textBoxDebtorID.Name = "textBoxDebtorID";
            this.textBoxDebtorID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDebtorID.TabIndex = 12;
            // 
            // labelDebtorID
            // 
            this.labelDebtorID.AutoSize = true;
            this.labelDebtorID.Location = new System.Drawing.Point(483, 40);
            this.labelDebtorID.Name = "labelDebtorID";
            this.labelDebtorID.Size = new System.Drawing.Size(69, 13);
            this.labelDebtorID.TabIndex = 13;
            this.labelDebtorID.Text = "CVR-nummer";
            // 
            // SearchDebtorButton
            // 
            this.SearchDebtorButton.Location = new System.Drawing.Point(404, 55);
            this.SearchDebtorButton.Name = "SearchDebtorButton";
            this.SearchDebtorButton.Size = new System.Drawing.Size(73, 23);
            this.SearchDebtorButton.TabIndex = 14;
            this.SearchDebtorButton.Text = "Find kunde";
            this.SearchDebtorButton.UseVisualStyleBackColor = true;
            this.SearchDebtorButton.Click += new System.EventHandler(this.SearchDebtorButton_Click);
            // 
            // comboBoxAccessory
            // 
            this.comboBoxAccessory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccessory.FormattingEnabled = true;
            this.comboBoxAccessory.Location = new System.Drawing.Point(16, 448);
            this.comboBoxAccessory.Name = "comboBoxAccessory";
            this.comboBoxAccessory.Size = new System.Drawing.Size(196, 21);
            this.comboBoxAccessory.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Location = new System.Drawing.Point(483, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(123, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxContactFirstName
            // 
            this.textBoxContactFirstName.Location = new System.Drawing.Point(714, 252);
            this.textBoxContactFirstName.Name = "textBoxContactFirstName";
            this.textBoxContactFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxContactFirstName.TabIndex = 17;
            // 
            // textBoxBillingAddress
            // 
            this.textBoxBillingAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBillingAddress.Location = new System.Drawing.Point(483, 133);
            this.textBoxBillingAddress.Name = "textBoxBillingAddress";
            this.textBoxBillingAddress.ReadOnly = true;
            this.textBoxBillingAddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxBillingAddress.TabIndex = 18;
            // 
            // textBoxBillingCity
            // 
            this.textBoxBillingCity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBillingCity.Location = new System.Drawing.Point(483, 172);
            this.textBoxBillingCity.Name = "textBoxBillingCity";
            this.textBoxBillingCity.ReadOnly = true;
            this.textBoxBillingCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillingCity.TabIndex = 19;
            // 
            // textBoxBillingPostCode
            // 
            this.textBoxBillingPostCode.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBillingPostCode.Location = new System.Drawing.Point(592, 172);
            this.textBoxBillingPostCode.Name = "textBoxBillingPostCode";
            this.textBoxBillingPostCode.ReadOnly = true;
            this.textBoxBillingPostCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillingPostCode.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Location = new System.Drawing.Point(483, 248);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 21;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhone.Location = new System.Drawing.Point(484, 209);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 22;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(483, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Firmanavn";
            // 
            // labelBillingAddress
            // 
            this.labelBillingAddress.AutoSize = true;
            this.labelBillingAddress.Location = new System.Drawing.Point(483, 117);
            this.labelBillingAddress.Name = "labelBillingAddress";
            this.labelBillingAddress.Size = new System.Drawing.Size(45, 13);
            this.labelBillingAddress.TabIndex = 24;
            this.labelBillingAddress.Text = "Adresse";
            // 
            // labelBillingCity
            // 
            this.labelBillingCity.AutoSize = true;
            this.labelBillingCity.Location = new System.Drawing.Point(483, 156);
            this.labelBillingCity.Name = "labelBillingCity";
            this.labelBillingCity.Size = new System.Drawing.Size(19, 13);
            this.labelBillingCity.TabIndex = 25;
            this.labelBillingCity.Text = "By";
            // 
            // labelBillingPostCode
            // 
            this.labelBillingPostCode.AutoSize = true;
            this.labelBillingPostCode.Location = new System.Drawing.Point(589, 156);
            this.labelBillingPostCode.Name = "labelBillingPostCode";
            this.labelBillingPostCode.Size = new System.Drawing.Size(65, 13);
            this.labelBillingPostCode.TabIndex = 26;
            this.labelBillingPostCode.Text = "Postnummer";
            // 
            // labelContactFirstName
            // 
            this.labelContactFirstName.AutoSize = true;
            this.labelContactFirstName.Location = new System.Drawing.Point(714, 236);
            this.labelContactFirstName.Name = "labelContactFirstName";
            this.labelContactFirstName.Size = new System.Drawing.Size(46, 13);
            this.labelContactFirstName.TabIndex = 27;
            this.labelContactFirstName.Text = "Fornavn";
            // 
            // textBoxContactPhone
            // 
            this.textBoxContactPhone.Location = new System.Drawing.Point(714, 291);
            this.textBoxContactPhone.Name = "textBoxContactPhone";
            this.textBoxContactPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactPhone.TabIndex = 28;
            // 
            // labelContactPhone
            // 
            this.labelContactPhone.AutoSize = true;
            this.labelContactPhone.Location = new System.Drawing.Point(714, 275);
            this.labelContactPhone.Name = "labelContactPhone";
            this.labelContactPhone.Size = new System.Drawing.Size(80, 13);
            this.labelContactPhone.TabIndex = 29;
            this.labelContactPhone.Text = "Telefonnummer";
            // 
            // labelDeliveryPostCode
            // 
            this.labelDeliveryPostCode.AutoSize = true;
            this.labelDeliveryPostCode.Location = new System.Drawing.Point(122, 527);
            this.labelDeliveryPostCode.Name = "labelDeliveryPostCode";
            this.labelDeliveryPostCode.Size = new System.Drawing.Size(59, 13);
            this.labelDeliveryPostCode.TabIndex = 35;
            this.labelDeliveryPostCode.Text = "Postummer";
            // 
            // labelDeliveryCity
            // 
            this.labelDeliveryCity.AutoSize = true;
            this.labelDeliveryCity.Location = new System.Drawing.Point(16, 527);
            this.labelDeliveryCity.Name = "labelDeliveryCity";
            this.labelDeliveryCity.Size = new System.Drawing.Size(19, 13);
            this.labelDeliveryCity.TabIndex = 34;
            this.labelDeliveryCity.Text = "By";
            // 
            // labelDeliveryAddress
            // 
            this.labelDeliveryAddress.AutoSize = true;
            this.labelDeliveryAddress.Location = new System.Drawing.Point(16, 489);
            this.labelDeliveryAddress.Name = "labelDeliveryAddress";
            this.labelDeliveryAddress.Size = new System.Drawing.Size(90, 13);
            this.labelDeliveryAddress.TabIndex = 33;
            this.labelDeliveryAddress.Text = "Leveringsadresse";
            // 
            // textBoxDeliveryPostCode
            // 
            this.textBoxDeliveryPostCode.Location = new System.Drawing.Point(125, 543);
            this.textBoxDeliveryPostCode.Name = "textBoxDeliveryPostCode";
            this.textBoxDeliveryPostCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeliveryPostCode.TabIndex = 32;
            // 
            // textBoxDeliveryCity
            // 
            this.textBoxDeliveryCity.Location = new System.Drawing.Point(16, 543);
            this.textBoxDeliveryCity.Name = "textBoxDeliveryCity";
            this.textBoxDeliveryCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeliveryCity.TabIndex = 31;
            // 
            // textBoxDeliveryAddress
            // 
            this.textBoxDeliveryAddress.Location = new System.Drawing.Point(16, 505);
            this.textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            this.textBoxDeliveryAddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxDeliveryAddress.TabIndex = 30;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(483, 195);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 13);
            this.labelPhone.TabIndex = 36;
            this.labelPhone.Text = "Tlfnummer";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(483, 232);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 37;
            this.labelEmail.Text = "E-mail";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(838, 123);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(123, 53);
            this.buttonCreateOrder.TabIndex = 38;
            this.buttonCreateOrder.Text = "Opret ordre";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // dataGridViewLeaseOrders
            // 
            this.dataGridViewLeaseOrders.AllowUserToAddRows = false;
            this.dataGridViewLeaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaseOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResurseID,
            this.Resurse,
            this.Leveringsdato,
            this.Slutdato,
            this.Dagspris,
            this.Levering,
            this.Gade,
            this.Postkode,
            this.By});
            this.dataGridViewLeaseOrders.Location = new System.Drawing.Point(482, 337);
            this.dataGridViewLeaseOrders.MultiSelect = false;
            this.dataGridViewLeaseOrders.Name = "dataGridViewLeaseOrders";
            this.dataGridViewLeaseOrders.Size = new System.Drawing.Size(723, 186);
            this.dataGridViewLeaseOrders.TabIndex = 39;
            this.dataGridViewLeaseOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLeaseOrders_DataError);
            // 
            // ResurseID
            // 
            this.ResurseID.HeaderText = "ResurseID";
            this.ResurseID.Name = "ResurseID";
            this.ResurseID.Visible = false;
            // 
            // Resurse
            // 
            this.Resurse.HeaderText = "Resurse";
            this.Resurse.Name = "Resurse";
            // 
            // Leveringsdato
            // 
            this.Leveringsdato.HeaderText = "Leveringsdato";
            this.Leveringsdato.Name = "Leveringsdato";
            this.Leveringsdato.Width = 80;
            // 
            // Slutdato
            // 
            this.Slutdato.HeaderText = "Slutdato";
            this.Slutdato.Name = "Slutdato";
            this.Slutdato.Width = 80;
            // 
            // Dagspris
            // 
            this.Dagspris.HeaderText = "Dagspris";
            this.Dagspris.Name = "Dagspris";
            this.Dagspris.Width = 70;
            // 
            // Levering
            // 
            this.Levering.HeaderText = "Levering";
            this.Levering.Name = "Levering";
            // 
            // Gade
            // 
            this.Gade.HeaderText = "Gade";
            this.Gade.Name = "Gade";
            // 
            // Postkode
            // 
            this.Postkode.HeaderText = "Postkode";
            this.Postkode.Name = "Postkode";
            this.Postkode.Width = 60;
            // 
            // By
            // 
            this.By.HeaderText = "By";
            this.By.Name = "By";
            this.By.Width = 90;
            // 
            // comboBoxMainGroup
            // 
            this.comboBoxMainGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainGroup.FormattingEnabled = true;
            this.comboBoxMainGroup.Location = new System.Drawing.Point(12, 135);
            this.comboBoxMainGroup.Name = "comboBoxMainGroup";
            this.comboBoxMainGroup.Size = new System.Drawing.Size(159, 21);
            this.comboBoxMainGroup.TabIndex = 40;
            this.comboBoxMainGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainGroup_SelectedIndexChanged);
            // 
            // comboBoxSubGroup
            // 
            this.comboBoxSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubGroup.FormattingEnabled = true;
            this.comboBoxSubGroup.Location = new System.Drawing.Point(181, 135);
            this.comboBoxSubGroup.Name = "comboBoxSubGroup";
            this.comboBoxSubGroup.Size = new System.Drawing.Size(159, 21);
            this.comboBoxSubGroup.TabIndex = 41;
            this.comboBoxSubGroup.TextChanged += new System.EventHandler(this.comboBoxSubGroup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kategori";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Underkategori";
            // 
            // dataGridViewResources
            // 
            this.dataGridViewResources.AllowUserToAddRows = false;
            this.dataGridViewResources.AllowUserToDeleteRows = false;
            this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResources.Location = new System.Drawing.Point(12, 182);
            this.dataGridViewResources.MultiSelect = false;
            this.dataGridViewResources.Name = "dataGridViewResources";
            this.dataGridViewResources.ReadOnly = true;
            this.dataGridViewResources.Size = new System.Drawing.Size(417, 186);
            this.dataGridViewResources.TabIndex = 44;
            this.dataGridViewResources.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResources_CellMouseClick);
            this.dataGridViewResources.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResources_CellMouseDoubleClick);
            // 
            // AddResourceToOrderButton
            // 
            this.AddResourceToOrderButton.Location = new System.Drawing.Point(12, 374);
            this.AddResourceToOrderButton.Name = "AddResourceToOrderButton";
            this.AddResourceToOrderButton.Size = new System.Drawing.Size(101, 46);
            this.AddResourceToOrderButton.TabIndex = 45;
            this.AddResourceToOrderButton.Text = "Tilføj resurse til ordren";
            this.AddResourceToOrderButton.UseVisualStyleBackColor = true;
            this.AddResourceToOrderButton.Click += new System.EventHandler(this.AddResourceToOrderButton_Click);
            // 
            // checkBoxUseBillingAddress
            // 
            this.checkBoxUseBillingAddress.AutoSize = true;
            this.checkBoxUseBillingAddress.Location = new System.Drawing.Point(251, 508);
            this.checkBoxUseBillingAddress.Name = "checkBoxUseBillingAddress";
            this.checkBoxUseBillingAddress.Size = new System.Drawing.Size(145, 17);
            this.checkBoxUseBillingAddress.TabIndex = 46;
            this.checkBoxUseBillingAddress.Text = "Lever til betalingsadresse";
            this.checkBoxUseBillingAddress.UseVisualStyleBackColor = true;
            this.checkBoxUseBillingAddress.CheckedChanged += new System.EventHandler(this.checkBoxUseBillingAddress_CheckedChanged);
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Checked = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(484, 14);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(62, 17);
            this.radioButtonBusiness.TabIndex = 47;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.Text = "Erhverv";
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            this.radioButtonBusiness.CheckedChanged += new System.EventHandler(this.radioButtonBusiness_CheckedChanged);
            // 
            // radioButtonPersonal
            // 
            this.radioButtonPersonal.AutoSize = true;
            this.radioButtonPersonal.Location = new System.Drawing.Point(567, 14);
            this.radioButtonPersonal.Name = "radioButtonPersonal";
            this.radioButtonPersonal.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPersonal.TabIndex = 48;
            this.radioButtonPersonal.Text = "Privat";
            this.radioButtonPersonal.UseVisualStyleBackColor = true;
            // 
            // textBoxLeaseNumber
            // 
            this.textBoxLeaseNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLeaseNumber.Location = new System.Drawing.Point(483, 292);
            this.textBoxLeaseNumber.Name = "textBoxLeaseNumber";
            this.textBoxLeaseNumber.ReadOnly = true;
            this.textBoxLeaseNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeaseNumber.TabIndex = 50;
            // 
            // labelLeaseNumber
            // 
            this.labelLeaseNumber.AutoSize = true;
            this.labelLeaseNumber.Location = new System.Drawing.Point(482, 275);
            this.labelLeaseNumber.Name = "labelLeaseNumber";
            this.labelLeaseNumber.Size = new System.Drawing.Size(70, 13);
            this.labelLeaseNumber.TabIndex = 51;
            this.labelLeaseNumber.Text = "Ordrenummer";
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Enabled = false;
            this.buttonUpdateOrder.Location = new System.Drawing.Point(967, 123);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(123, 53);
            this.buttonUpdateOrder.TabIndex = 52;
            this.buttonUpdateOrder.Text = "Opdater ordre";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // labelContactPerson
            // 
            this.labelContactPerson.AutoSize = true;
            this.labelContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactPerson.Location = new System.Drawing.Point(714, 216);
            this.labelContactPerson.Name = "labelContactPerson";
            this.labelContactPerson.Size = new System.Drawing.Size(90, 13);
            this.labelContactPerson.TabIndex = 53;
            this.labelContactPerson.Text = "KontaktPerson";
            // 
            // labelContactLastName
            // 
            this.labelContactLastName.AutoSize = true;
            this.labelContactLastName.Location = new System.Drawing.Point(846, 236);
            this.labelContactLastName.Name = "labelContactLastName";
            this.labelContactLastName.Size = new System.Drawing.Size(53, 13);
            this.labelContactLastName.TabIndex = 55;
            this.labelContactLastName.Text = "Efternavn";
            // 
            // textBoxContactLastName
            // 
            this.textBoxContactLastName.Location = new System.Drawing.Point(846, 252);
            this.textBoxContactLastName.Name = "textBoxContactLastName";
            this.textBoxContactLastName.Size = new System.Drawing.Size(123, 20);
            this.textBoxContactLastName.TabIndex = 54;
            // 
            // buttonAddAccessory
            // 
            this.buttonAddAccessory.Location = new System.Drawing.Point(218, 441);
            this.buttonAddAccessory.Name = "buttonAddAccessory";
            this.buttonAddAccessory.Size = new System.Drawing.Size(79, 33);
            this.buttonAddAccessory.TabIndex = 56;
            this.buttonAddAccessory.Text = "Tilføj tilbehør";
            this.buttonAddAccessory.UseVisualStyleBackColor = true;
            this.buttonAddAccessory.Click += new System.EventHandler(this.buttonAddAccessory_Click);
            // 
            // labelFindLeaseByLeaseID
            // 
            this.labelFindLeaseByLeaseID.AutoSize = true;
            this.labelFindLeaseByLeaseID.Location = new System.Drawing.Point(741, 38);
            this.labelFindLeaseByLeaseID.Name = "labelFindLeaseByLeaseID";
            this.labelFindLeaseByLeaseID.Size = new System.Drawing.Size(141, 13);
            this.labelFindLeaseByLeaseID.TabIndex = 58;
            this.labelFindLeaseByLeaseID.Text = "Find ordre med ordrenummer";
            // 
            // textBoxFindLeaseByLeaseID
            // 
            this.textBoxFindLeaseByLeaseID.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFindLeaseByLeaseID.Location = new System.Drawing.Point(744, 56);
            this.textBoxFindLeaseByLeaseID.Name = "textBoxFindLeaseByLeaseID";
            this.textBoxFindLeaseByLeaseID.Size = new System.Drawing.Size(123, 20);
            this.textBoxFindLeaseByLeaseID.TabIndex = 57;
            // 
            // buttonFindLeaseByLeaseID
            // 
            this.buttonFindLeaseByLeaseID.Location = new System.Drawing.Point(873, 55);
            this.buttonFindLeaseByLeaseID.Name = "buttonFindLeaseByLeaseID";
            this.buttonFindLeaseByLeaseID.Size = new System.Drawing.Size(55, 23);
            this.buttonFindLeaseByLeaseID.TabIndex = 59;
            this.buttonFindLeaseByLeaseID.Text = "Søg";
            this.buttonFindLeaseByLeaseID.UseVisualStyleBackColor = true;
            this.buttonFindLeaseByLeaseID.Click += new System.EventHandler(this.buttonFindLeaseByLeaseID_Click);
            // 
            // buttonFindLeases
            // 
            this.buttonFindLeases.Location = new System.Drawing.Point(589, 55);
            this.buttonFindLeases.Name = "buttonFindLeases";
            this.buttonFindLeases.Size = new System.Drawing.Size(73, 23);
            this.buttonFindLeases.TabIndex = 60;
            this.buttonFindLeases.Text = "Find ordrer";
            this.buttonFindLeases.UseVisualStyleBackColor = true;
            this.buttonFindLeases.Click += new System.EventHandler(this.buttonFindLeases_Click);
            // 
            // comboBoxLeaseStatus
            // 
            this.comboBoxLeaseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaseStatus.FormattingEnabled = true;
            this.comboBoxLeaseStatus.Items.AddRange(new object[] {
            "Ikke oprettet"});
            this.comboBoxLeaseStatus.Location = new System.Drawing.Point(1096, 251);
            this.comboBoxLeaseStatus.Name = "comboBoxLeaseStatus";
            this.comboBoxLeaseStatus.Size = new System.Drawing.Size(123, 21);
            this.comboBoxLeaseStatus.TabIndex = 61;
            // 
            // labelLeaseStatus
            // 
            this.labelLeaseStatus.AutoSize = true;
            this.labelLeaseStatus.Location = new System.Drawing.Point(1098, 232);
            this.labelLeaseStatus.Name = "labelLeaseStatus";
            this.labelLeaseStatus.Size = new System.Drawing.Size(61, 13);
            this.labelLeaseStatus.TabIndex = 62;
            this.labelLeaseStatus.Text = "Ordrestatus";
            // 
            // buttonDeleteLease
            // 
            this.buttonDeleteLease.Enabled = false;
            this.buttonDeleteLease.Location = new System.Drawing.Point(1096, 123);
            this.buttonDeleteLease.Name = "buttonDeleteLease";
            this.buttonDeleteLease.Size = new System.Drawing.Size(123, 53);
            this.buttonDeleteLease.TabIndex = 63;
            this.buttonDeleteLease.Text = "Slet ordre";
            this.buttonDeleteLease.UseVisualStyleBackColor = true;
            this.buttonDeleteLease.Click += new System.EventHandler(this.buttonDeleteLease_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(1096, 47);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(123, 53);
            this.buttonClearAll.TabIndex = 64;
            this.buttonClearAll.Text = "Ryd alt";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Enabled = false;
            this.buttonUpdateStatus.Location = new System.Drawing.Point(1117, 278);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateStatus.TabIndex = 65;
            this.buttonUpdateStatus.Text = "Opdater";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // comboBoxDeliveryZone
            // 
            this.comboBoxDeliveryZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeliveryZone.FormattingEnabled = true;
            this.comboBoxDeliveryZone.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxDeliveryZone.Location = new System.Drawing.Point(251, 543);
            this.comboBoxDeliveryZone.Name = "comboBoxDeliveryZone";
            this.comboBoxDeliveryZone.Size = new System.Drawing.Size(123, 21);
            this.comboBoxDeliveryZone.TabIndex = 66;
            // 
            // labelDeliveryZone
            // 
            this.labelDeliveryZone.AutoSize = true;
            this.labelDeliveryZone.Location = new System.Drawing.Point(248, 528);
            this.labelDeliveryZone.Name = "labelDeliveryZone";
            this.labelDeliveryZone.Size = new System.Drawing.Size(76, 13);
            this.labelDeliveryZone.TabIndex = 67;
            this.labelDeliveryZone.Text = "Leveringszone";
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Enabled = false;
            this.buttonInvoice.Location = new System.Drawing.Point(967, 47);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(123, 53);
            this.buttonInvoice.TabIndex = 68;
            this.buttonInvoice.Text = "Udskriv faktura";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 608);
            this.Controls.Add(this.buttonInvoice);
            this.Controls.Add(this.labelDeliveryZone);
            this.Controls.Add(this.comboBoxDeliveryZone);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonDeleteLease);
            this.Controls.Add(this.labelLeaseStatus);
            this.Controls.Add(this.comboBoxLeaseStatus);
            this.Controls.Add(this.buttonFindLeases);
            this.Controls.Add(this.buttonFindLeaseByLeaseID);
            this.Controls.Add(this.labelFindLeaseByLeaseID);
            this.Controls.Add(this.textBoxFindLeaseByLeaseID);
            this.Controls.Add(this.buttonAddAccessory);
            this.Controls.Add(this.labelContactLastName);
            this.Controls.Add(this.textBoxContactLastName);
            this.Controls.Add(this.labelContactPerson);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.labelLeaseNumber);
            this.Controls.Add(this.textBoxLeaseNumber);
            this.Controls.Add(this.radioButtonPersonal);
            this.Controls.Add(this.radioButtonBusiness);
            this.Controls.Add(this.checkBoxUseBillingAddress);
            this.Controls.Add(this.AddResourceToOrderButton);
            this.Controls.Add(this.dataGridViewResources);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubGroup);
            this.Controls.Add(this.comboBoxMainGroup);
            this.Controls.Add(this.dataGridViewLeaseOrders);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDeliveryPostCode);
            this.Controls.Add(this.labelDeliveryCity);
            this.Controls.Add(this.labelDeliveryAddress);
            this.Controls.Add(this.textBoxDeliveryPostCode);
            this.Controls.Add(this.textBoxDeliveryCity);
            this.Controls.Add(this.textBoxDeliveryAddress);
            this.Controls.Add(this.labelContactPhone);
            this.Controls.Add(this.textBoxContactPhone);
            this.Controls.Add(this.labelContactFirstName);
            this.Controls.Add(this.labelBillingPostCode);
            this.Controls.Add(this.labelBillingCity);
            this.Controls.Add(this.labelBillingAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxBillingPostCode);
            this.Controls.Add(this.textBoxBillingCity);
            this.Controls.Add(this.textBoxBillingAddress);
            this.Controls.Add(this.textBoxContactFirstName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxAccessory);
            this.Controls.Add(this.SearchDebtorButton);
            this.Controls.Add(this.labelDebtorID);
            this.Controls.Add(this.textBoxDebtorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeliveryDate);
            this.Name = "Lease";
            this.Text = "Leasing";
            this.Load += new System.EventHandler(this.Lease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDebtorID;
        private System.Windows.Forms.Label labelDebtorID;
        private System.Windows.Forms.Button SearchDebtorButton;
        private System.Windows.Forms.ComboBox comboBoxAccessory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxContactFirstName;
        private System.Windows.Forms.TextBox textBoxBillingAddress;
        private System.Windows.Forms.TextBox textBoxBillingCity;
        private System.Windows.Forms.TextBox textBoxBillingPostCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.Label labelBillingCity;
        private System.Windows.Forms.Label labelBillingPostCode;
        private System.Windows.Forms.Label labelContactFirstName;
        private System.Windows.Forms.TextBox textBoxContactPhone;
        private System.Windows.Forms.Label labelContactPhone;
        private System.Windows.Forms.Label labelDeliveryPostCode;
        private System.Windows.Forms.Label labelDeliveryCity;
        private System.Windows.Forms.Label labelDeliveryAddress;
        private System.Windows.Forms.TextBox textBoxDeliveryPostCode;
        private System.Windows.Forms.TextBox textBoxDeliveryCity;
        private System.Windows.Forms.TextBox textBoxDeliveryAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.DataGridView dataGridViewLeaseOrders;
        private System.Windows.Forms.ComboBox comboBoxMainGroup;
        private System.Windows.Forms.ComboBox comboBoxSubGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridViewResources;
        private System.Windows.Forms.Button AddResourceToOrderButton;
        private System.Windows.Forms.CheckBox checkBoxUseBillingAddress;
        private System.Windows.Forms.RadioButton radioButtonBusiness;
        private System.Windows.Forms.RadioButton radioButtonPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResurseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leveringsdato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slutdato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dagspris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Levering;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postkode;
        private System.Windows.Forms.DataGridViewTextBoxColumn By;
        private System.Windows.Forms.TextBox textBoxLeaseNumber;
        private System.Windows.Forms.Label labelLeaseNumber;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.Label labelContactLastName;
        private System.Windows.Forms.TextBox textBoxContactLastName;
        private System.Windows.Forms.Button buttonAddAccessory;
        private System.Windows.Forms.Label labelFindLeaseByLeaseID;
        private System.Windows.Forms.TextBox textBoxFindLeaseByLeaseID;
        private System.Windows.Forms.Button buttonFindLeaseByLeaseID;
        private System.Windows.Forms.Button buttonFindLeases;
        private System.Windows.Forms.ComboBox comboBoxLeaseStatus;
        private System.Windows.Forms.Label labelLeaseStatus;
        private System.Windows.Forms.Button buttonDeleteLease;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.ComboBox comboBoxDeliveryZone;
        private System.Windows.Forms.Label labelDeliveryZone;
        private System.Windows.Forms.Button buttonInvoice;
    }
}