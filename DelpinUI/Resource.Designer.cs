﻿namespace DelpinUI
{
    partial class Resource
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
            this.subGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new DelpinUI.DataSet3();
            this.subGroupTableAdapter = new DelpinUI.DataSet3TableAdapters.SubGroupTableAdapter();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new DelpinUI.DataSet4();
            this.modelTableAdapter = new DelpinUI.DataSet4TableAdapters.ModelTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ResourceModelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ressourceID = new System.Windows.Forms.TextBox();
            this.resourceGridView = new System.Windows.Forms.DataGridView();
            this.branchID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteRessource = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CreateRessource = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GetModel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ModelID = new System.Windows.Forms.TextBox();
            this.ModelGridView = new System.Windows.Forms.DataGridView();
            this.ComboModelSub = new System.Windows.Forms.ComboBox();
            this.ComboModelMain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.DeleteModel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateModel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelPrice = new System.Windows.Forms.TextBox();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.CreateModel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AddAccModel = new System.Windows.Forms.TextBox();
            this.AccSub = new System.Windows.Forms.ComboBox();
            this.AccMain = new System.Windows.Forms.ComboBox();
            this.AddAcc = new System.Windows.Forms.DataGridView();
            this.AccModel = new System.Windows.Forms.TextBox();
            this.AddAccesories = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AccModelView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.subGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccModelView)).BeginInit();
            this.SuspendLayout();
            // 
            // subGroupBindingSource
            // 
            this.subGroupBindingSource.DataMember = "SubGroup";
            this.subGroupBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subGroupTableAdapter
            // 
            this.subGroupTableAdapter.ClearBeforeFill = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 424);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResourceModelID);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ressourceID);
            this.tabPage3.Controls.Add(this.resourceGridView);
            this.tabPage3.Controls.Add(this.branchID);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.DeleteRessource);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.CreateRessource);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resurse";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ResourceModelID
            // 
            this.ResourceModelID.Location = new System.Drawing.Point(17, 73);
            this.ResourceModelID.Name = "ResourceModelID";
            this.ResourceModelID.Size = new System.Drawing.Size(100, 20);
            this.ResourceModelID.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "ResurseID";
            // 
            // ressourceID
            // 
            this.ressourceID.Location = new System.Drawing.Point(17, 33);
            this.ressourceID.Name = "ressourceID";
            this.ressourceID.Size = new System.Drawing.Size(100, 20);
            this.ressourceID.TabIndex = 62;
            // 
            // resourceGridView
            // 
            this.resourceGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resourceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceGridView.Location = new System.Drawing.Point(316, 44);
            this.resourceGridView.Name = "resourceGridView";
            this.resourceGridView.Size = new System.Drawing.Size(447, 177);
            this.resourceGridView.TabIndex = 61;
            // 
            // branchID
            // 
            this.branchID.FormattingEnabled = true;
            this.branchID.Location = new System.Drawing.Point(17, 119);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(121, 21);
            this.branchID.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Afdeling";
            // 
            // DeleteRessource
            // 
            this.DeleteRessource.Location = new System.Drawing.Point(124, 270);
            this.DeleteRessource.Name = "DeleteRessource";
            this.DeleteRessource.Size = new System.Drawing.Size(75, 23);
            this.DeleteRessource.TabIndex = 54;
            this.DeleteRessource.Text = "Slet resurse";
            this.DeleteRessource.UseVisualStyleBackColor = true;
            this.DeleteRessource.Click += new System.EventHandler(this.DeleteRessource_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "ModelID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Resurseoversigt";
            // 
            // CreateRessource
            // 
            this.CreateRessource.Location = new System.Drawing.Point(20, 270);
            this.CreateRessource.Name = "CreateRessource";
            this.CreateRessource.Size = new System.Drawing.Size(83, 23);
            this.CreateRessource.TabIndex = 45;
            this.CreateRessource.Text = "Opret Resurse";
            this.CreateRessource.UseVisualStyleBackColor = true;
            this.CreateRessource.Click += new System.EventHandler(this.CreateRessource_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GetModel);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.ModelID);
            this.tabPage1.Controls.Add(this.ModelGridView);
            this.tabPage1.Controls.Add(this.ComboModelSub);
            this.tabPage1.Controls.Add(this.ComboModelMain);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Weight);
            this.tabPage1.Controls.Add(this.DeleteModel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.UpdateModel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ModelPrice);
            this.tabPage1.Controls.Add(this.ModelName);
            this.tabPage1.Controls.Add(this.CreateModel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // GetModel
            // 
            this.GetModel.Location = new System.Drawing.Point(111, 26);
            this.GetModel.Name = "GetModel";
            this.GetModel.Size = new System.Drawing.Size(75, 23);
            this.GetModel.TabIndex = 45;
            this.GetModel.Text = "Hent model";
            this.GetModel.UseVisualStyleBackColor = true;
            this.GetModel.Click += new System.EventHandler(this.GetModel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "ModelID";
            // 
            // ModelID
            // 
            this.ModelID.Location = new System.Drawing.Point(3, 28);
            this.ModelID.Name = "ModelID";
            this.ModelID.Size = new System.Drawing.Size(100, 20);
            this.ModelID.TabIndex = 43;
            // 
            // ModelGridView
            // 
            this.ModelGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ModelGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelGridView.Location = new System.Drawing.Point(319, 39);
            this.ModelGridView.Name = "ModelGridView";
            this.ModelGridView.Size = new System.Drawing.Size(559, 177);
            this.ModelGridView.TabIndex = 42;
            this.ModelGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelGridView_CellClick);
            // 
            // ComboModelSub
            // 
            this.ComboModelSub.FormattingEnabled = true;
            this.ComboModelSub.Location = new System.Drawing.Point(120, 181);
            this.ComboModelSub.Name = "ComboModelSub";
            this.ComboModelSub.Size = new System.Drawing.Size(121, 21);
            this.ComboModelSub.TabIndex = 40;
            this.ComboModelSub.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubGroup_SelectedIndexChanged_1);
            this.ComboModelSub.Click += new System.EventHandler(this.comboBoxSubGroup_SelectedIndexChanged_1);
            // 
            // ComboModelMain
            // 
            this.ComboModelMain.FormattingEnabled = true;
            this.ComboModelMain.Location = new System.Drawing.Point(7, 181);
            this.ComboModelMain.Name = "ComboModelMain";
            this.ComboModelMain.Size = new System.Drawing.Size(96, 21);
            this.ComboModelMain.TabIndex = 39;
            this.ComboModelMain.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainGroup_SelectedIndexChanged_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Vægt";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(3, 141);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 20);
            this.Weight.TabIndex = 37;
            // 
            // DeleteModel
            // 
            this.DeleteModel.Location = new System.Drawing.Point(208, 223);
            this.DeleteModel.Name = "DeleteModel";
            this.DeleteModel.Size = new System.Drawing.Size(75, 23);
            this.DeleteModel.TabIndex = 35;
            this.DeleteModel.Text = "Slet model";
            this.DeleteModel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hovedkategori";
            // 
            // UpdateModel
            // 
            this.UpdateModel.Location = new System.Drawing.Point(102, 223);
            this.UpdateModel.Name = "UpdateModel";
            this.UpdateModel.Size = new System.Drawing.Size(84, 23);
            this.UpdateModel.TabIndex = 33;
            this.UpdateModel.Text = "Opdater model";
            this.UpdateModel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Modeloversigt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Undergruppe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Modelnavn";
            // 
            // ModelPrice
            // 
            this.ModelPrice.Location = new System.Drawing.Point(4, 103);
            this.ModelPrice.Name = "ModelPrice";
            this.ModelPrice.Size = new System.Drawing.Size(100, 20);
            this.ModelPrice.TabIndex = 27;
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(3, 66);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(100, 20);
            this.ModelName.TabIndex = 26;
            // 
            // CreateModel
            // 
            this.CreateModel.Location = new System.Drawing.Point(6, 223);
            this.CreateModel.Name = "CreateModel";
            this.CreateModel.Size = new System.Drawing.Size(75, 23);
            this.CreateModel.TabIndex = 24;
            this.CreateModel.Text = "Opret model";
            this.CreateModel.UseVisualStyleBackColor = true;
            this.CreateModel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.AddAccModel);
            this.tabPage2.Controls.Add(this.AccSub);
            this.tabPage2.Controls.Add(this.AccMain);
            this.tabPage2.Controls.Add(this.AddAcc);
            this.tabPage2.Controls.Add(this.AccModel);
            this.tabPage2.Controls.Add(this.AddAccesories);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.AccModelView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tilbehør";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Vælg tilbehør";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Vælg model";
            // 
            // AddAccModel
            // 
            this.AddAccModel.Location = new System.Drawing.Point(6, 296);
            this.AddAccModel.Name = "AddAccModel";
            this.AddAccModel.Size = new System.Drawing.Size(100, 20);
            this.AddAccModel.TabIndex = 60;
            // 
            // AccSub
            // 
            this.AccSub.FormattingEnabled = true;
            this.AccSub.Location = new System.Drawing.Point(122, 60);
            this.AccSub.Name = "AccSub";
            this.AccSub.Size = new System.Drawing.Size(98, 21);
            this.AccSub.TabIndex = 59;
            this.AccSub.SelectedIndexChanged += new System.EventHandler(this.AccSub_SelectedIndexChanged);
            // 
            // AccMain
            // 
            this.AccMain.FormattingEnabled = true;
            this.AccMain.Location = new System.Drawing.Point(9, 60);
            this.AccMain.Name = "AccMain";
            this.AccMain.Size = new System.Drawing.Size(100, 21);
            this.AccMain.TabIndex = 58;
            this.AccMain.SelectedIndexChanged += new System.EventHandler(this.AccMain_SelectedIndexChanged);
            // 
            // AddAcc
            // 
            this.AddAcc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddAcc.Location = new System.Drawing.Point(306, 191);
            this.AddAcc.Name = "AddAcc";
            this.AddAcc.Size = new System.Drawing.Size(447, 125);
            this.AddAcc.TabIndex = 57;
            this.AddAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddAcc_CellClick);
            // 
            // AccModel
            // 
            this.AccModel.Location = new System.Drawing.Point(6, 148);
            this.AccModel.Name = "AccModel";
            this.AccModel.Size = new System.Drawing.Size(100, 20);
            this.AccModel.TabIndex = 56;
            this.AccModel.TextChanged += new System.EventHandler(this.AccModel_TextChanged);
            // 
            // AddAccesories
            // 
            this.AddAccesories.Location = new System.Drawing.Point(12, 341);
            this.AddAccesories.Name = "AddAccesories";
            this.AddAccesories.Size = new System.Drawing.Size(102, 23);
            this.AddAccesories.TabIndex = 55;
            this.AddAccesories.Text = "Tilføj tilbehør";
            this.AddAccesories.UseVisualStyleBackColor = true;
            this.AddAccesories.Click += new System.EventHandler(this.AddAccesories_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Hovedkategori";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Undergruppe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Modeloversigt";
            // 
            // AccModelView
            // 
            this.AccModelView.Location = new System.Drawing.Point(393, 18);
            this.AccModelView.Name = "AccModelView";
            this.AccModelView.Size = new System.Drawing.Size(360, 150);
            this.AccModelView.TabIndex = 63;
            // 
            // Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "Resource";
            this.Text = "Resource";
            this.Load += new System.EventHandler(this.Resource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccModelView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource subGroupBindingSource;
        private DataSet3TableAdapters.SubGroupTableAdapter subGroupTableAdapter;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private DataSet4TableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ModelGridView;
        private System.Windows.Forms.ComboBox ComboModelSub;
        private System.Windows.Forms.ComboBox ComboModelMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AccModelView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ressourceID;
        private System.Windows.Forms.DataGridView resourceGridView;
        private System.Windows.Forms.ComboBox branchID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteRessource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CreateRessource;
        private System.Windows.Forms.Button DeleteModel;
        private System.Windows.Forms.Button UpdateModel;
        private System.Windows.Forms.Button CreateModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelPrice;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddAccesories;
        private System.Windows.Forms.DataGridView AddAcc;
        private System.Windows.Forms.TextBox AccModel;
        private System.Windows.Forms.TextBox ResourceModelID;
        private System.Windows.Forms.ComboBox AccSub;
        private System.Windows.Forms.ComboBox AccMain;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AddAccModel;
        private System.Windows.Forms.TextBox ModelID;
        private System.Windows.Forms.Button GetModel;
        private System.Windows.Forms.Label label16;
    }
}