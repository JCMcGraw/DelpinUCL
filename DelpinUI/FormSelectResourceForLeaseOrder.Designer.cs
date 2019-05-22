namespace DelpinUI
{
    partial class FormSelectResourceForLeaseOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectResource = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSelectResource
            // 
            this.buttonSelectResource.Location = new System.Drawing.Point(106, 399);
            this.buttonSelectResource.Name = "buttonSelectResource";
            this.buttonSelectResource.Size = new System.Drawing.Size(122, 56);
            this.buttonSelectResource.TabIndex = 1;
            this.buttonSelectResource.Text = "Vælg resurse";
            this.buttonSelectResource.UseVisualStyleBackColor = true;
            this.buttonSelectResource.Click += new System.EventHandler(this.buttonSelectResource_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(298, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 56);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Fortryd";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSelectResourceForLeaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 519);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectResource);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSelectResourceForLeaseOrder";
            this.Text = "FormSelectResourceForLeaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectResource;
        private System.Windows.Forms.Button buttonCancel;
    }
}