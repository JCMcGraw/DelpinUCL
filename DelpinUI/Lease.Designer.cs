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
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.accessoryLabel = new System.Windows.Forms.Label();
            this.debtorIDTextBox = new System.Windows.Forms.TextBox();
            this.debtorIDLabel = new System.Windows.Forms.Label();
            this.searchDebtorByDebtorID = new System.Windows.Forms.Button();
            this.accessoryComboBox = new System.Windows.Forms.ComboBox();
            this.debtorName = new System.Windows.Forms.TextBox();
            this.contactFirstName = new System.Windows.Forms.TextBox();
            this.billingAddress = new System.Windows.Forms.TextBox();
            this.billingCity = new System.Windows.Forms.TextBox();
            this.billingPostCode = new System.Windows.Forms.TextBox();
            this.debtorEmail = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBillingAddress = new System.Windows.Forms.Label();
            this.labelBillingCity = new System.Windows.Forms.Label();
            this.labelBillingPostCode = new System.Windows.Forms.Label();
            this.labelContactFirstName = new System.Windows.Forms.Label();
            this.contactPhone = new System.Windows.Forms.TextBox();
            this.labelContactPhone = new System.Windows.Forms.Label();
            this.deliveryPostCodeLabel = new System.Windows.Forms.Label();
            this.deliveryCityLabel = new System.Windows.Forms.Label();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.deliveryPostCodeTextBox = new System.Windows.Forms.TextBox();
            this.deliveryCityTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.createLease = new System.Windows.Forms.Button();
            this.leaseOrders = new System.Windows.Forms.DataGridView();
            this.ResurseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leveringsdato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slutdato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dagspris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Levering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postkode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainGroup = new System.Windows.Forms.ComboBox();
            this.SubGroup = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subCategoryLabel = new System.Windows.Forms.Label();
            this.esourcesDataGridView = new System.Windows.Forms.DataGridView();
            this.AddResourceToOrder = new System.Windows.Forms.Button();
            this.useBillingAddress = new System.Windows.Forms.CheckBox();
            this.businessRadioButton = new System.Windows.Forms.RadioButton();
            this.personalRadioButton = new System.Windows.Forms.RadioButton();
            this.leaseNumber = new System.Windows.Forms.TextBox();
            this.labelLeaseNumber = new System.Windows.Forms.Label();
            this.updateLease = new System.Windows.Forms.Button();
            this.labelContactPerson = new System.Windows.Forms.Label();
            this.labelContactLastName = new System.Windows.Forms.Label();
            this.contactLastName = new System.Windows.Forms.TextBox();
            this.addAccessory = new System.Windows.Forms.Button();
            this.labelFindLeaseByLeaseID = new System.Windows.Forms.Label();
            this.textBoxFindLeaseByLeaseID = new System.Windows.Forms.TextBox();
            this.findLeaseByLeaseID = new System.Windows.Forms.Button();
            this.findLeasesByLeaseID = new System.Windows.Forms.Button();
            this.leaseStatus = new System.Windows.Forms.ComboBox();
            this.labelLeaseStatus = new System.Windows.Forms.Label();
            this.deleteLease = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.updateStatus = new System.Windows.Forms.Button();
            this.deliveryZoneComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryZoneLabel = new System.Windows.Forms.Label();
            this.writeInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esourcesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Location = new System.Drawing.Point(12, 37);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.DeliveryDate.TabIndex = 122;
            this.DeliveryDate.ValueChanged += new System.EventHandler(this.dateTimePickerDeliveryDate_ValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(13, 18);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(77, 13);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Udlejningsdato";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(13, 64);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(105, 13);
            this.returnDateLabel.TabIndex = 3;
            this.returnDateLabel.Text = "Tilbageleveringsdato";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(12, 80);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.ReturnDate.TabIndex = 124;
            this.ReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerReturnDate_ValueChanged);
            // 
            // accessoryLabel
            // 
            this.accessoryLabel.AutoSize = true;
            this.accessoryLabel.Location = new System.Drawing.Point(16, 432);
            this.accessoryLabel.Name = "accessoryLabel";
            this.accessoryLabel.Size = new System.Drawing.Size(45, 13);
            this.accessoryLabel.TabIndex = 10;
            this.accessoryLabel.Text = "Tilbehør";
            // 
            // debtorIDTextBox
            // 
            this.debtorIDTextBox.Location = new System.Drawing.Point(483, 56);
            this.debtorIDTextBox.Name = "debtorIDTextBox";
            this.debtorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.debtorIDTextBox.TabIndex = 0;
            // 
            // debtorIDLabel
            // 
            this.debtorIDLabel.AutoSize = true;
            this.debtorIDLabel.Location = new System.Drawing.Point(483, 40);
            this.debtorIDLabel.Name = "debtorIDLabel";
            this.debtorIDLabel.Size = new System.Drawing.Size(69, 13);
            this.debtorIDLabel.TabIndex = 13;
            this.debtorIDLabel.Text = "CVR-nummer";
            // 
            // searchDebtorByDebtorID
            // 
            this.searchDebtorByDebtorID.Location = new System.Drawing.Point(404, 55);
            this.searchDebtorByDebtorID.Name = "searchDebtorByDebtorID";
            this.searchDebtorByDebtorID.Size = new System.Drawing.Size(73, 23);
            this.searchDebtorByDebtorID.TabIndex = 1;
            this.searchDebtorByDebtorID.Text = "Find kunde";
            this.searchDebtorByDebtorID.UseVisualStyleBackColor = true;
            this.searchDebtorByDebtorID.Click += new System.EventHandler(this.SearchDebtorButton_Click);
            // 
            // accessoryComboBox
            // 
            this.accessoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessoryComboBox.FormattingEnabled = true;
            this.accessoryComboBox.Location = new System.Drawing.Point(16, 448);
            this.accessoryComboBox.Name = "accessoryComboBox";
            this.accessoryComboBox.Size = new System.Drawing.Size(196, 21);
            this.accessoryComboBox.TabIndex = 132;
            // 
            // debtorName
            // 
            this.debtorName.BackColor = System.Drawing.SystemColors.Control;
            this.debtorName.Location = new System.Drawing.Point(483, 94);
            this.debtorName.Name = "debtorName";
            this.debtorName.ReadOnly = true;
            this.debtorName.Size = new System.Drawing.Size(123, 20);
            this.debtorName.TabIndex = 16;
            this.debtorName.TabStop = false;
            // 
            // contactFirstName
            // 
            this.contactFirstName.Location = new System.Drawing.Point(714, 252);
            this.contactFirstName.Name = "contactFirstName";
            this.contactFirstName.Size = new System.Drawing.Size(123, 20);
            this.contactFirstName.TabIndex = 3;
            // 
            // billingAddress
            // 
            this.billingAddress.BackColor = System.Drawing.SystemColors.Control;
            this.billingAddress.Location = new System.Drawing.Point(483, 133);
            this.billingAddress.Name = "billingAddress";
            this.billingAddress.ReadOnly = true;
            this.billingAddress.Size = new System.Drawing.Size(178, 20);
            this.billingAddress.TabIndex = 18;
            this.billingAddress.TabStop = false;
            // 
            // billingCity
            // 
            this.billingCity.BackColor = System.Drawing.SystemColors.Control;
            this.billingCity.Location = new System.Drawing.Point(483, 172);
            this.billingCity.Name = "billingCity";
            this.billingCity.ReadOnly = true;
            this.billingCity.Size = new System.Drawing.Size(100, 20);
            this.billingCity.TabIndex = 19;
            this.billingCity.TabStop = false;
            // 
            // billingPostCode
            // 
            this.billingPostCode.BackColor = System.Drawing.SystemColors.Control;
            this.billingPostCode.Location = new System.Drawing.Point(592, 172);
            this.billingPostCode.Name = "billingPostCode";
            this.billingPostCode.ReadOnly = true;
            this.billingPostCode.Size = new System.Drawing.Size(100, 20);
            this.billingPostCode.TabIndex = 20;
            this.billingPostCode.TabStop = false;
            // 
            // debtorEmail
            // 
            this.debtorEmail.BackColor = System.Drawing.SystemColors.Control;
            this.debtorEmail.Location = new System.Drawing.Point(483, 248);
            this.debtorEmail.Name = "debtorEmail";
            this.debtorEmail.ReadOnly = true;
            this.debtorEmail.Size = new System.Drawing.Size(100, 20);
            this.debtorEmail.TabIndex = 21;
            this.debtorEmail.TabStop = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.phoneNumber.Location = new System.Drawing.Point(484, 209);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber.TabIndex = 22;
            this.phoneNumber.TabStop = false;
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
            // contactPhone
            // 
            this.contactPhone.Location = new System.Drawing.Point(714, 291);
            this.contactPhone.Name = "contactPhone";
            this.contactPhone.Size = new System.Drawing.Size(100, 20);
            this.contactPhone.TabIndex = 5;
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
            // deliveryPostCodeLabel
            // 
            this.deliveryPostCodeLabel.AutoSize = true;
            this.deliveryPostCodeLabel.Location = new System.Drawing.Point(122, 527);
            this.deliveryPostCodeLabel.Name = "deliveryPostCodeLabel";
            this.deliveryPostCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.deliveryPostCodeLabel.TabIndex = 35;
            this.deliveryPostCodeLabel.Text = "Postummer";
            // 
            // deliveryCityLabel
            // 
            this.deliveryCityLabel.AutoSize = true;
            this.deliveryCityLabel.Location = new System.Drawing.Point(16, 527);
            this.deliveryCityLabel.Name = "deliveryCityLabel";
            this.deliveryCityLabel.Size = new System.Drawing.Size(19, 13);
            this.deliveryCityLabel.TabIndex = 34;
            this.deliveryCityLabel.Text = "By";
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Location = new System.Drawing.Point(16, 489);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(90, 13);
            this.deliveryAddressLabel.TabIndex = 33;
            this.deliveryAddressLabel.Text = "Leveringsadresse";
            // 
            // deliveryPostCodeTextBox
            // 
            this.deliveryPostCodeTextBox.Location = new System.Drawing.Point(125, 543);
            this.deliveryPostCodeTextBox.Name = "deliveryPostCodeTextBox";
            this.deliveryPostCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryPostCodeTextBox.TabIndex = 8;
            this.deliveryPostCodeTextBox.Leave += new System.EventHandler(this.textBoxDeliveryPostCode_Leave);
            // 
            // deliveryCityTextBox
            // 
            this.deliveryCityTextBox.Location = new System.Drawing.Point(16, 543);
            this.deliveryCityTextBox.Name = "deliveryCityTextBox";
            this.deliveryCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryCityTextBox.TabIndex = 7;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(16, 505);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(178, 20);
            this.deliveryAddressTextBox.TabIndex = 6;
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
            // createLease
            // 
            this.createLease.Location = new System.Drawing.Point(838, 123);
            this.createLease.Name = "createLease";
            this.createLease.Size = new System.Drawing.Size(123, 53);
            this.createLease.TabIndex = 38;
            this.createLease.Text = "Opret ordre";
            this.createLease.UseVisualStyleBackColor = true;
            this.createLease.Click += new System.EventHandler(this.CreateLease_Click);
            // 
            // leaseOrders
            // 
            this.leaseOrders.AllowUserToAddRows = false;
            this.leaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaseOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResurseID,
            this.Resurse,
            this.Leveringsdato,
            this.Slutdato,
            this.Dagspris,
            this.Levering,
            this.Gade,
            this.Postkode,
            this.By});
            this.leaseOrders.Location = new System.Drawing.Point(482, 337);
            this.leaseOrders.MultiSelect = false;
            this.leaseOrders.Name = "leaseOrders";
            this.leaseOrders.Size = new System.Drawing.Size(723, 186);
            this.leaseOrders.TabIndex = 39;
            this.leaseOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLeaseOrders_DataError);
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
            // MainGroup
            // 
            this.MainGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainGroup.FormattingEnabled = true;
            this.MainGroup.Location = new System.Drawing.Point(12, 135);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(159, 21);
            this.MainGroup.TabIndex = 126;
            this.MainGroup.SelectedIndexChanged += new System.EventHandler(this.MainGroup_SelectedIndexChanged);
            // 
            // SubGroup
            // 
            this.SubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubGroup.FormattingEnabled = true;
            this.SubGroup.Location = new System.Drawing.Point(181, 135);
            this.SubGroup.Name = "SubGroup";
            this.SubGroup.Size = new System.Drawing.Size(159, 21);
            this.SubGroup.TabIndex = 128;
            this.SubGroup.TextChanged += new System.EventHandler(this.comboBoxSubGroup_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 118);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(46, 13);
            this.categoryLabel.TabIndex = 42;
            this.categoryLabel.Text = "Kategori";
            // 
            // subCategoryLabel
            // 
            this.subCategoryLabel.AutoSize = true;
            this.subCategoryLabel.Location = new System.Drawing.Point(178, 118);
            this.subCategoryLabel.Name = "subCategoryLabel";
            this.subCategoryLabel.Size = new System.Drawing.Size(74, 13);
            this.subCategoryLabel.TabIndex = 43;
            this.subCategoryLabel.Text = "Underkategori";
            // 
            // esourcesDataGridView
            // 
            this.esourcesDataGridView.AllowUserToAddRows = false;
            this.esourcesDataGridView.AllowUserToDeleteRows = false;
            this.esourcesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.esourcesDataGridView.Location = new System.Drawing.Point(12, 182);
            this.esourcesDataGridView.MultiSelect = false;
            this.esourcesDataGridView.Name = "esourcesDataGridView";
            this.esourcesDataGridView.ReadOnly = true;
            this.esourcesDataGridView.Size = new System.Drawing.Size(417, 186);
            this.esourcesDataGridView.TabIndex = 129;
            this.esourcesDataGridView.TabStop = false;
            this.esourcesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResources_CellMouseClick);
            this.esourcesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResources_CellMouseDoubleClick);
            // 
            // AddResourceToOrder
            // 
            this.AddResourceToOrder.Location = new System.Drawing.Point(12, 374);
            this.AddResourceToOrder.Name = "AddResourceToOrder";
            this.AddResourceToOrder.Size = new System.Drawing.Size(101, 46);
            this.AddResourceToOrder.TabIndex = 130;
            this.AddResourceToOrder.Text = "Tilføj resurse til ordren";
            this.AddResourceToOrder.UseVisualStyleBackColor = true;
            this.AddResourceToOrder.Click += new System.EventHandler(this.AddResourceToOrderButton_Click);
            // 
            // useBillingAddress
            // 
            this.useBillingAddress.AutoSize = true;
            this.useBillingAddress.Location = new System.Drawing.Point(251, 508);
            this.useBillingAddress.Name = "useBillingAddress";
            this.useBillingAddress.Size = new System.Drawing.Size(145, 17);
            this.useBillingAddress.TabIndex = 9;
            this.useBillingAddress.Text = "Lever til betalingsadresse";
            this.useBillingAddress.UseVisualStyleBackColor = true;
            this.useBillingAddress.CheckedChanged += new System.EventHandler(this.checkBoxUseBillingAddress_CheckedChanged);
            // 
            // businessRadioButton
            // 
            this.businessRadioButton.AutoSize = true;
            this.businessRadioButton.Checked = true;
            this.businessRadioButton.Location = new System.Drawing.Point(484, 14);
            this.businessRadioButton.Name = "businessRadioButton";
            this.businessRadioButton.Size = new System.Drawing.Size(62, 17);
            this.businessRadioButton.TabIndex = 47;
            this.businessRadioButton.TabStop = true;
            this.businessRadioButton.Text = "Erhverv";
            this.businessRadioButton.UseVisualStyleBackColor = true;
            this.businessRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonBusiness_CheckedChanged);
            // 
            // personalRadioButton
            // 
            this.personalRadioButton.AutoSize = true;
            this.personalRadioButton.Location = new System.Drawing.Point(567, 14);
            this.personalRadioButton.Name = "personalRadioButton";
            this.personalRadioButton.Size = new System.Drawing.Size(52, 17);
            this.personalRadioButton.TabIndex = 47;
            this.personalRadioButton.Text = "Privat";
            this.personalRadioButton.UseVisualStyleBackColor = true;
            // 
            // leaseNumber
            // 
            this.leaseNumber.BackColor = System.Drawing.SystemColors.Control;
            this.leaseNumber.Location = new System.Drawing.Point(483, 292);
            this.leaseNumber.Name = "leaseNumber";
            this.leaseNumber.ReadOnly = true;
            this.leaseNumber.Size = new System.Drawing.Size(100, 20);
            this.leaseNumber.TabIndex = 50;
            this.leaseNumber.TabStop = false;
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
            // updateLease
            // 
            this.updateLease.Enabled = false;
            this.updateLease.Location = new System.Drawing.Point(967, 123);
            this.updateLease.Name = "updateLease";
            this.updateLease.Size = new System.Drawing.Size(123, 53);
            this.updateLease.TabIndex = 40;
            this.updateLease.Text = "Opdater ordre";
            this.updateLease.UseVisualStyleBackColor = true;
            this.updateLease.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
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
            // contactLastName
            // 
            this.contactLastName.Location = new System.Drawing.Point(846, 252);
            this.contactLastName.Name = "contactLastName";
            this.contactLastName.Size = new System.Drawing.Size(123, 20);
            this.contactLastName.TabIndex = 4;
            // 
            // addAccessory
            // 
            this.addAccessory.Location = new System.Drawing.Point(218, 441);
            this.addAccessory.Name = "addAccessory";
            this.addAccessory.Size = new System.Drawing.Size(79, 33);
            this.addAccessory.TabIndex = 134;
            this.addAccessory.Text = "Tilføj tilbehør";
            this.addAccessory.UseVisualStyleBackColor = true;
            this.addAccessory.Click += new System.EventHandler(this.buttonAddAccessory_Click);
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
            this.textBoxFindLeaseByLeaseID.TabIndex = 2;
            this.textBoxFindLeaseByLeaseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFindLeaseByLeaseID_KeyPress);
            // 
            // findLeaseByLeaseID
            // 
            this.findLeaseByLeaseID.Location = new System.Drawing.Point(873, 55);
            this.findLeaseByLeaseID.Name = "findLeaseByLeaseID";
            this.findLeaseByLeaseID.Size = new System.Drawing.Size(55, 23);
            this.findLeaseByLeaseID.TabIndex = 3;
            this.findLeaseByLeaseID.Text = "Søg";
            this.findLeaseByLeaseID.UseVisualStyleBackColor = true;
            this.findLeaseByLeaseID.Click += new System.EventHandler(this.buttonFindLeaseByLeaseID_Click);
            // 
            // findLeasesByLeaseID
            // 
            this.findLeasesByLeaseID.Location = new System.Drawing.Point(589, 55);
            this.findLeasesByLeaseID.Name = "findLeasesByLeaseID";
            this.findLeasesByLeaseID.Size = new System.Drawing.Size(73, 23);
            this.findLeasesByLeaseID.TabIndex = 1;
            this.findLeasesByLeaseID.Text = "Find ordrer";
            this.findLeasesByLeaseID.UseVisualStyleBackColor = true;
            this.findLeasesByLeaseID.Click += new System.EventHandler(this.buttonFindLeases_Click);
            // 
            // leaseStatus
            // 
            this.leaseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaseStatus.FormattingEnabled = true;
            this.leaseStatus.Items.AddRange(new object[] {
            "Ikke oprettet"});
            this.leaseStatus.Location = new System.Drawing.Point(1096, 251);
            this.leaseStatus.Name = "leaseStatus";
            this.leaseStatus.Size = new System.Drawing.Size(123, 21);
            this.leaseStatus.TabIndex = 61;
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
            // deleteLease
            // 
            this.deleteLease.Enabled = false;
            this.deleteLease.Location = new System.Drawing.Point(1096, 123);
            this.deleteLease.Name = "deleteLease";
            this.deleteLease.Size = new System.Drawing.Size(123, 53);
            this.deleteLease.TabIndex = 42;
            this.deleteLease.Text = "Slet ordre";
            this.deleteLease.UseVisualStyleBackColor = true;
            this.deleteLease.Click += new System.EventHandler(this.buttonDeleteLease_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(1096, 47);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(123, 53);
            this.clearAll.TabIndex = 46;
            this.clearAll.Text = "Ryd alt";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // updateStatus
            // 
            this.updateStatus.Enabled = false;
            this.updateStatus.Location = new System.Drawing.Point(1117, 278);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(75, 23);
            this.updateStatus.TabIndex = 65;
            this.updateStatus.Text = "Opdater";
            this.updateStatus.UseVisualStyleBackColor = true;
            this.updateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // deliveryZoneComboBox
            // 
            this.deliveryZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryZoneComboBox.FormattingEnabled = true;
            this.deliveryZoneComboBox.Items.AddRange(new object[] {
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
            this.deliveryZoneComboBox.Location = new System.Drawing.Point(251, 543);
            this.deliveryZoneComboBox.Name = "deliveryZoneComboBox";
            this.deliveryZoneComboBox.Size = new System.Drawing.Size(123, 21);
            this.deliveryZoneComboBox.TabIndex = 10;
            // 
            // deliveryZoneLabel
            // 
            this.deliveryZoneLabel.AutoSize = true;
            this.deliveryZoneLabel.Location = new System.Drawing.Point(248, 528);
            this.deliveryZoneLabel.Name = "deliveryZoneLabel";
            this.deliveryZoneLabel.Size = new System.Drawing.Size(76, 13);
            this.deliveryZoneLabel.TabIndex = 67;
            this.deliveryZoneLabel.Text = "Leveringszone";
            // 
            // writeInvoice
            // 
            this.writeInvoice.Enabled = false;
            this.writeInvoice.Location = new System.Drawing.Point(967, 47);
            this.writeInvoice.Name = "writeInvoice";
            this.writeInvoice.Size = new System.Drawing.Size(123, 53);
            this.writeInvoice.TabIndex = 44;
            this.writeInvoice.Text = "Udskriv faktura";
            this.writeInvoice.UseVisualStyleBackColor = true;
            this.writeInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 608);
            this.Controls.Add(this.writeInvoice);
            this.Controls.Add(this.deliveryZoneLabel);
            this.Controls.Add(this.deliveryZoneComboBox);
            this.Controls.Add(this.updateStatus);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.deleteLease);
            this.Controls.Add(this.labelLeaseStatus);
            this.Controls.Add(this.leaseStatus);
            this.Controls.Add(this.findLeasesByLeaseID);
            this.Controls.Add(this.findLeaseByLeaseID);
            this.Controls.Add(this.labelFindLeaseByLeaseID);
            this.Controls.Add(this.textBoxFindLeaseByLeaseID);
            this.Controls.Add(this.addAccessory);
            this.Controls.Add(this.labelContactLastName);
            this.Controls.Add(this.contactLastName);
            this.Controls.Add(this.labelContactPerson);
            this.Controls.Add(this.updateLease);
            this.Controls.Add(this.labelLeaseNumber);
            this.Controls.Add(this.leaseNumber);
            this.Controls.Add(this.personalRadioButton);
            this.Controls.Add(this.businessRadioButton);
            this.Controls.Add(this.useBillingAddress);
            this.Controls.Add(this.AddResourceToOrder);
            this.Controls.Add(this.esourcesDataGridView);
            this.Controls.Add(this.subCategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.SubGroup);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.leaseOrders);
            this.Controls.Add(this.createLease);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.deliveryPostCodeLabel);
            this.Controls.Add(this.deliveryCityLabel);
            this.Controls.Add(this.deliveryAddressLabel);
            this.Controls.Add(this.deliveryPostCodeTextBox);
            this.Controls.Add(this.deliveryCityTextBox);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(this.labelContactPhone);
            this.Controls.Add(this.contactPhone);
            this.Controls.Add(this.labelContactFirstName);
            this.Controls.Add(this.labelBillingPostCode);
            this.Controls.Add(this.labelBillingCity);
            this.Controls.Add(this.labelBillingAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.debtorEmail);
            this.Controls.Add(this.billingPostCode);
            this.Controls.Add(this.billingCity);
            this.Controls.Add(this.billingAddress);
            this.Controls.Add(this.contactFirstName);
            this.Controls.Add(this.debtorName);
            this.Controls.Add(this.accessoryComboBox);
            this.Controls.Add(this.searchDebtorByDebtorID);
            this.Controls.Add(this.debtorIDLabel);
            this.Controls.Add(this.debtorIDTextBox);
            this.Controls.Add(this.accessoryLabel);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.DeliveryDate);
            this.Icon = global::DelpinUI.Properties.Resources.delpinikon;
            this.Name = "Lease";
            this.Text = "Udleje";
            this.Load += new System.EventHandler(this.Lease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esourcesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label accessoryLabel;
        private System.Windows.Forms.TextBox debtorIDTextBox;
        private System.Windows.Forms.Label debtorIDLabel;
        private System.Windows.Forms.Button searchDebtorByDebtorID;
        private System.Windows.Forms.ComboBox accessoryComboBox;
        private System.Windows.Forms.TextBox debtorName;
        private System.Windows.Forms.TextBox contactFirstName;
        private System.Windows.Forms.TextBox billingAddress;
        private System.Windows.Forms.TextBox billingCity;
        private System.Windows.Forms.TextBox billingPostCode;
        private System.Windows.Forms.TextBox debtorEmail;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBillingAddress;
        private System.Windows.Forms.Label labelBillingCity;
        private System.Windows.Forms.Label labelBillingPostCode;
        private System.Windows.Forms.Label labelContactFirstName;
        private System.Windows.Forms.TextBox contactPhone;
        private System.Windows.Forms.Label labelContactPhone;
        private System.Windows.Forms.Label deliveryPostCodeLabel;
        private System.Windows.Forms.Label deliveryCityLabel;
        private System.Windows.Forms.Label deliveryAddressLabel;
        private System.Windows.Forms.TextBox deliveryPostCodeTextBox;
        private System.Windows.Forms.TextBox deliveryCityTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button createLease;
        private System.Windows.Forms.DataGridView leaseOrders;
        private System.Windows.Forms.ComboBox MainGroup;
        private System.Windows.Forms.ComboBox SubGroup;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subCategoryLabel;
        private System.Windows.Forms.DataGridView esourcesDataGridView;
        private System.Windows.Forms.Button AddResourceToOrder;
        private System.Windows.Forms.CheckBox useBillingAddress;
        private System.Windows.Forms.RadioButton businessRadioButton;
        private System.Windows.Forms.RadioButton personalRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResurseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leveringsdato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slutdato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dagspris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Levering;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postkode;
        private System.Windows.Forms.DataGridViewTextBoxColumn By;
        private System.Windows.Forms.TextBox leaseNumber;
        private System.Windows.Forms.Label labelLeaseNumber;
        private System.Windows.Forms.Button updateLease;
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.Label labelContactLastName;
        private System.Windows.Forms.TextBox contactLastName;
        private System.Windows.Forms.Button addAccessory;
        private System.Windows.Forms.Label labelFindLeaseByLeaseID;
        private System.Windows.Forms.TextBox textBoxFindLeaseByLeaseID;
        private System.Windows.Forms.Button findLeaseByLeaseID;
        private System.Windows.Forms.Button findLeasesByLeaseID;
        private System.Windows.Forms.ComboBox leaseStatus;
        private System.Windows.Forms.Label labelLeaseStatus;
        private System.Windows.Forms.Button deleteLease;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button updateStatus;
        private System.Windows.Forms.ComboBox deliveryZoneComboBox;
        private System.Windows.Forms.Label deliveryZoneLabel;
        private System.Windows.Forms.Button writeInvoice;
    }
}