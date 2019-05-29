namespace DelpinUI
{
    partial class saveBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saveBranch));
            this.openDebtorForm = new System.Windows.Forms.Button();
            this.openResourceForm = new System.Windows.Forms.Button();
            this.openLeasingForm = new System.Windows.Forms.Button();
            this.chooseBranchComboBox = new System.Windows.Forms.ComboBox();
            this.chooseBranchLabel = new System.Windows.Forms.Label();
            this.saveBranchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.deliveriesInNextTwoDays = new System.Windows.Forms.DataGridView();
            this.ordersForDeliveryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesInNextTwoDays)).BeginInit();
            this.SuspendLayout();
            // 
            // openDebtorForm
            // 
            this.openDebtorForm.Location = new System.Drawing.Point(12, 29);
            this.openDebtorForm.Name = "openDebtorForm";
            this.openDebtorForm.Size = new System.Drawing.Size(104, 42);
            this.openDebtorForm.TabIndex = 0;
            this.openDebtorForm.Text = "Debitor";
            this.openDebtorForm.UseVisualStyleBackColor = true;
            this.openDebtorForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // openResourceForm
            // 
            this.openResourceForm.Location = new System.Drawing.Point(12, 77);
            this.openResourceForm.Name = "openResourceForm";
            this.openResourceForm.Size = new System.Drawing.Size(104, 42);
            this.openResourceForm.TabIndex = 1;
            this.openResourceForm.Text = "Resurser";
            this.openResourceForm.UseVisualStyleBackColor = true;
            this.openResourceForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // openLeasingForm
            // 
            this.openLeasingForm.Location = new System.Drawing.Point(12, 125);
            this.openLeasingForm.Name = "openLeasingForm";
            this.openLeasingForm.Size = new System.Drawing.Size(104, 42);
            this.openLeasingForm.TabIndex = 2;
            this.openLeasingForm.Text = "Udleje";
            this.openLeasingForm.UseVisualStyleBackColor = true;
            this.openLeasingForm.Click += new System.EventHandler(this.button3_Click);
            // 
            // chooseBranchComboBox
            // 
            this.chooseBranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseBranchComboBox.FormattingEnabled = true;
            this.chooseBranchComboBox.Location = new System.Drawing.Point(11, 215);
            this.chooseBranchComboBox.Name = "chooseBranchComboBox";
            this.chooseBranchComboBox.Size = new System.Drawing.Size(121, 21);
            this.chooseBranchComboBox.TabIndex = 3;
            // 
            // chooseBranchLabel
            // 
            this.chooseBranchLabel.AutoSize = true;
            this.chooseBranchLabel.Location = new System.Drawing.Point(34, 199);
            this.chooseBranchLabel.Name = "chooseBranchLabel";
            this.chooseBranchLabel.Size = new System.Drawing.Size(72, 13);
            this.chooseBranchLabel.TabIndex = 4;
            this.chooseBranchLabel.Text = "Vælg afdeling";
            // 
            // saveBranchButton
            // 
            this.saveBranchButton.Location = new System.Drawing.Point(31, 242);
            this.saveBranchButton.Name = "saveBranchButton";
            this.saveBranchButton.Size = new System.Drawing.Size(75, 23);
            this.saveBranchButton.TabIndex = 5;
            this.saveBranchButton.Text = "Gem";
            this.saveBranchButton.UseVisualStyleBackColor = true;
            this.saveBranchButton.Click += new System.EventHandler(this.saveBranchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DelpinUI.Properties.Resources.delpinlogo;
            this.pictureBox1.Location = new System.Drawing.Point(187, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLabel.Location = new System.Drawing.Point(396, 57);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(280, 26);
            this.headlineLabel.TabIndex = 7;
            this.headlineLabel.Text = "Delpin A/S resursemanager";
            // 
            // deliveriesInNextTwoDays
            // 
            this.deliveriesInNextTwoDays.AllowUserToAddRows = false;
            this.deliveriesInNextTwoDays.BackgroundColor = System.Drawing.SystemColors.Control;
            this.deliveriesInNextTwoDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveriesInNextTwoDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveriesInNextTwoDays.Location = new System.Drawing.Point(187, 296);
            this.deliveriesInNextTwoDays.Name = "deliveriesInNextTwoDays";
            this.deliveriesInNextTwoDays.ReadOnly = true;
            this.deliveriesInNextTwoDays.Size = new System.Drawing.Size(565, 121);
            this.deliveriesInNextTwoDays.TabIndex = 8;
            // 
            // ordersForDeliveryLabel
            // 
            this.ordersForDeliveryLabel.AutoSize = true;
            this.ordersForDeliveryLabel.Location = new System.Drawing.Point(184, 270);
            this.ordersForDeliveryLabel.Name = "ordersForDeliveryLabel";
            this.ordersForDeliveryLabel.Size = new System.Drawing.Size(17, 13);
            this.ordersForDeliveryLabel.TabIndex = 9;
            this.ordersForDeliveryLabel.Text = "\"\"";
            // 
            // saveBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersForDeliveryLabel);
            this.Controls.Add(this.deliveriesInNextTwoDays);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveBranchButton);
            this.Controls.Add(this.chooseBranchLabel);
            this.Controls.Add(this.chooseBranchComboBox);
            this.Controls.Add(this.openLeasingForm);
            this.Controls.Add(this.openResourceForm);
            this.Controls.Add(this.openDebtorForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "saveBranch";
            this.Text = "Delpin A/S";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesInNextTwoDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDebtorForm;
        private System.Windows.Forms.Button openResourceForm;
        private System.Windows.Forms.Button openLeasingForm;
        private System.Windows.Forms.ComboBox chooseBranchComboBox;
        private System.Windows.Forms.Label chooseBranchLabel;
        private System.Windows.Forms.Button saveBranchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.DataGridView deliveriesInNextTwoDays;
        private System.Windows.Forms.Label ordersForDeliveryLabel;
    }
}

