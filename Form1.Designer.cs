namespace Program4
{
    partial class GroundPackageForm
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
            this.originZipTxtBox = new System.Windows.Forms.TextBox();
            this.destZipTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.widthTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.sendfrmULBtn = new System.Windows.Forms.Button();
            this.sendtoULBtn = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.orZipLabel = new System.Windows.Forms.Label();
            this.destZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originZipTxtBox
            // 
            this.originZipTxtBox.Location = new System.Drawing.Point(99, 52);
            this.originZipTxtBox.Name = "originZipTxtBox";
            this.originZipTxtBox.Size = new System.Drawing.Size(82, 20);
            this.originZipTxtBox.TabIndex = 0;
            // 
            // destZipTxtBox
            // 
            this.destZipTxtBox.Location = new System.Drawing.Point(99, 80);
            this.destZipTxtBox.Name = "destZipTxtBox";
            this.destZipTxtBox.Size = new System.Drawing.Size(82, 20);
            this.destZipTxtBox.TabIndex = 1;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(99, 106);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(82, 20);
            this.lengthTxtBox.TabIndex = 2;
            // 
            // widthTxtBox
            // 
            this.widthTxtBox.Location = new System.Drawing.Point(99, 132);
            this.widthTxtBox.Name = "widthTxtBox";
            this.widthTxtBox.Size = new System.Drawing.Size(82, 20);
            this.widthTxtBox.TabIndex = 3;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(99, 158);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(82, 20);
            this.heightTxtBox.TabIndex = 4;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(99, 182);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(82, 20);
            this.weightTxtBox.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(29, 238);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(346, 80);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(75, 23);
            this.detailsBtn.TabIndex = 7;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.descriptioBtn_Click);
            // 
            // sendfrmULBtn
            // 
            this.sendfrmULBtn.Location = new System.Drawing.Point(346, 116);
            this.sendfrmULBtn.Name = "sendfrmULBtn";
            this.sendfrmULBtn.Size = new System.Drawing.Size(75, 36);
            this.sendfrmULBtn.TabIndex = 8;
            this.sendfrmULBtn.Text = "Send From UofL";
            this.sendfrmULBtn.UseVisualStyleBackColor = true;
            this.sendfrmULBtn.Click += new System.EventHandler(this.sendfrmULBtn_Click);
            // 
            // sendtoULBtn
            // 
            this.sendtoULBtn.Location = new System.Drawing.Point(346, 165);
            this.sendtoULBtn.Name = "sendtoULBtn";
            this.sendtoULBtn.Size = new System.Drawing.Size(75, 37);
            this.sendtoULBtn.TabIndex = 9;
            this.sendtoULBtn.Text = "Send To UofL";
            this.sendtoULBtn.UseVisualStyleBackColor = true;
            this.sendtoULBtn.Click += new System.EventHandler(this.sendtoULBtn_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(197, 55);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(138, 147);
            this.packageListBox.TabIndex = 10;
            // 
            // orZipLabel
            // 
            this.orZipLabel.AutoSize = true;
            this.orZipLabel.Location = new System.Drawing.Point(35, 55);
            this.orZipLabel.Name = "orZipLabel";
            this.orZipLabel.Size = new System.Drawing.Size(55, 13);
            this.orZipLabel.TabIndex = 11;
            this.orZipLabel.Text = "Origin Zip:";
            // 
            // destZipLabel
            // 
            this.destZipLabel.AutoSize = true;
            this.destZipLabel.Location = new System.Drawing.Point(9, 83);
            this.destZipLabel.Name = "destZipLabel";
            this.destZipLabel.Size = new System.Drawing.Size(81, 13);
            this.destZipLabel.TabIndex = 12;
            this.destZipLabel.Text = "Destination Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(47, 109);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 13;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(52, 135);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 14;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(49, 161);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(49, 185);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 16;
            this.weightLabel.Text = "Weight:";
            // 
            // GroundPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 291);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destZipLabel);
            this.Controls.Add(this.orZipLabel);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.sendtoULBtn);
            this.Controls.Add(this.sendfrmULBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.widthTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.destZipTxtBox);
            this.Controls.Add(this.originZipTxtBox);
            this.Name = "GroundPackageForm";
            this.Text = " Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originZipTxtBox;
        private System.Windows.Forms.TextBox destZipTxtBox;
        private System.Windows.Forms.TextBox lengthTxtBox;
        private System.Windows.Forms.TextBox widthTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button sendfrmULBtn;
        private System.Windows.Forms.Button sendtoULBtn;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Label orZipLabel;
        private System.Windows.Forms.Label destZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
    }
}

