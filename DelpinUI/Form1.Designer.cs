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
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Gem";
            this.button4.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delpin A/S resursemanager";
            // 
            // saveBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chooseBranchLabel);
            this.Controls.Add(this.chooseBranchComboBox);
            this.Controls.Add(this.openLeasingForm);
            this.Controls.Add(this.openResourceForm);
            this.Controls.Add(this.openDebtorForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "saveBranch";
            this.Text = "Delpin A/S";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDebtorForm;
        private System.Windows.Forms.Button openResourceForm;
        private System.Windows.Forms.Button openLeasingForm;
        private System.Windows.Forms.ComboBox chooseBranchComboBox;
        private System.Windows.Forms.Label chooseBranchLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

