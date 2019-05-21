namespace DelpinUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.ModelIDText = new System.Windows.Forms.TextBox();
            this.ModelNameText = new System.Windows.Forms.TextBox();
            this.ModelPriceText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new DelpinUI.DataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subGroupTableAdapter = new DelpinUI.DataSet3TableAdapters.SubGroupTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.dataSet4 = new DelpinUI.DataSet4();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new DelpinUI.DataSet4TableAdapters.ModelTableAdapter();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Opret vare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModelIDText
            // 
            this.ModelIDText.Location = new System.Drawing.Point(13, 27);
            this.ModelIDText.Name = "ModelIDText";
            this.ModelIDText.Size = new System.Drawing.Size(100, 20);
            this.ModelIDText.TabIndex = 1;
            // 
            // ModelNameText
            // 
            this.ModelNameText.Location = new System.Drawing.Point(12, 63);
            this.ModelNameText.Name = "ModelNameText";
            this.ModelNameText.Size = new System.Drawing.Size(100, 20);
            this.ModelNameText.TabIndex = 2;
            // 
            // ModelPriceText
            // 
            this.ModelPriceText.Location = new System.Drawing.Point(13, 100);
            this.ModelPriceText.Name = "ModelPriceText";
            this.ModelPriceText.Size = new System.Drawing.Size(100, 20);
            this.ModelPriceText.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subGroupBindingSource, "Category", true));
            this.comboBox1.DataSource = this.subGroupBindingSource;
            this.comboBox1.DisplayMember = "Category";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ModelID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelnavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pris";
            // 
            // subGroupTableAdapter
            // 
            this.subGroupTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIDDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.subGroupIDDataGridViewTextBoxColumn});
            this.ProductGridView.DataSource = this.modelBindingSource;
            this.ProductGridView.Location = new System.Drawing.Point(341, 27);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(447, 177);
            this.ProductGridView.TabIndex = 9;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.dataSet4;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            this.modelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // subGroupIDDataGridViewTextBoxColumn
            // 
            this.subGroupIDDataGridViewTextBoxColumn.DataPropertyName = "SubGroupID";
            this.subGroupIDDataGridViewTextBoxColumn.HeaderText = "SubGroupID";
            this.subGroupIDDataGridViewTextBoxColumn.Name = "subGroupIDDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produktoversigt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Opdater vare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ModelPriceText);
            this.Controls.Add(this.ModelNameText);
            this.Controls.Add(this.ModelIDText);
            this.Controls.Add(this.button1);
            this.Name = "Resource";
            this.Text = "Resource";
            this.Load += new System.EventHandler(this.Resource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModelIDText;
        private System.Windows.Forms.TextBox ModelNameText;
        private System.Windows.Forms.TextBox ModelPriceText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource subGroupBindingSource;
        private DataSet3TableAdapters.SubGroupTableAdapter subGroupTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ProductGridView;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private DataSet4TableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}