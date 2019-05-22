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
            this.dataGridViewResources = new System.Windows.Forms.DataGridView();
            this.buttonSelectResource = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResources
            // 
            this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResources.Location = new System.Drawing.Point(75, 37);
            this.dataGridViewResources.Name = "dataGridViewResources";
            this.dataGridViewResources.Size = new System.Drawing.Size(571, 287);
            this.dataGridViewResources.TabIndex = 0;
            // 
            // buttonSelectResource
            // 
            this.buttonSelectResource.Location = new System.Drawing.Point(115, 356);
            this.buttonSelectResource.Name = "buttonSelectResource";
            this.buttonSelectResource.Size = new System.Drawing.Size(126, 55);
            this.buttonSelectResource.TabIndex = 1;
            this.buttonSelectResource.Text = "Vælg resurse";
            this.buttonSelectResource.UseVisualStyleBackColor = true;
            this.buttonSelectResource.Click += new System.EventHandler(this.buttonSelectResource_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(294, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 55);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Fortryd";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSelectResourceForLeaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectResource);
            this.Controls.Add(this.dataGridViewResources);
            this.Name = "FormSelectResourceForLeaseOrder";
            this.Text = "FormSelectResourceForLeaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResources;
        private System.Windows.Forms.Button buttonSelectResource;
        private System.Windows.Forms.Button buttonCancel;
    }
}