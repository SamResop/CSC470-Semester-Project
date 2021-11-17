namespace P5
{
    partial class FormModifyIssue
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
            this.ModifyCancelButton = new System.Windows.Forms.Button();
            this.ModifyIssueButton = new System.Windows.Forms.Button();
            this.ModifyDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ModifyStatusComboBox = new System.Windows.Forms.ComboBox();
            this.ModifyDiscovererComboBox = new System.Windows.Forms.ComboBox();
            this.ModifyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifyComponentTextbox = new System.Windows.Forms.TextBox();
            this.ModifyTitleTextbox = new System.Windows.Forms.TextBox();
            this.RecordDescriptionLabel = new System.Windows.Forms.Label();
            this.RecordStatusLabel = new System.Windows.Forms.Label();
            this.RecordComponentLabel = new System.Windows.Forms.Label();
            this.RecordDiscovererLabel = new System.Windows.Forms.Label();
            this.RecordDateLabel = new System.Windows.Forms.Label();
            this.RecordTitleLabel = new System.Windows.Forms.Label();
            this.ModifyIdTextbox = new System.Windows.Forms.TextBox();
            this.RecordIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyCancelButton
            // 
            this.ModifyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ModifyCancelButton.Location = new System.Drawing.Point(351, 523);
            this.ModifyCancelButton.Name = "ModifyCancelButton";
            this.ModifyCancelButton.Size = new System.Drawing.Size(127, 37);
            this.ModifyCancelButton.TabIndex = 31;
            this.ModifyCancelButton.Text = "Cancel";
            this.ModifyCancelButton.UseVisualStyleBackColor = true;
            this.ModifyCancelButton.Click += new System.EventHandler(this.ModifyCancelButton_Click);
            // 
            // ModifyIssueButton
            // 
            this.ModifyIssueButton.Location = new System.Drawing.Point(484, 523);
            this.ModifyIssueButton.Name = "ModifyIssueButton";
            this.ModifyIssueButton.Size = new System.Drawing.Size(126, 37);
            this.ModifyIssueButton.TabIndex = 30;
            this.ModifyIssueButton.Text = "Modify Issue";
            this.ModifyIssueButton.UseVisualStyleBackColor = true;
            this.ModifyIssueButton.Click += new System.EventHandler(this.ModifyIssueButton_Click);
            // 
            // ModifyDescriptionTextBox
            // 
            this.ModifyDescriptionTextBox.Location = new System.Drawing.Point(238, 301);
            this.ModifyDescriptionTextBox.Multiline = true;
            this.ModifyDescriptionTextBox.Name = "ModifyDescriptionTextBox";
            this.ModifyDescriptionTextBox.Size = new System.Drawing.Size(373, 204);
            this.ModifyDescriptionTextBox.TabIndex = 29;
            // 
            // ModifyStatusComboBox
            // 
            this.ModifyStatusComboBox.FormattingEnabled = true;
            this.ModifyStatusComboBox.Location = new System.Drawing.Point(239, 260);
            this.ModifyStatusComboBox.Name = "ModifyStatusComboBox";
            this.ModifyStatusComboBox.Size = new System.Drawing.Size(372, 28);
            this.ModifyStatusComboBox.TabIndex = 28;
            // 
            // ModifyDiscovererComboBox
            // 
            this.ModifyDiscovererComboBox.FormattingEnabled = true;
            this.ModifyDiscovererComboBox.Location = new System.Drawing.Point(239, 166);
            this.ModifyDiscovererComboBox.Name = "ModifyDiscovererComboBox";
            this.ModifyDiscovererComboBox.Size = new System.Drawing.Size(372, 28);
            this.ModifyDiscovererComboBox.TabIndex = 27;
            // 
            // ModifyDatePicker
            // 
            this.ModifyDatePicker.Location = new System.Drawing.Point(239, 119);
            this.ModifyDatePicker.Name = "ModifyDatePicker";
            this.ModifyDatePicker.Size = new System.Drawing.Size(372, 26);
            this.ModifyDatePicker.TabIndex = 26;
            // 
            // ModifyComponentTextbox
            // 
            this.ModifyComponentTextbox.Location = new System.Drawing.Point(239, 211);
            this.ModifyComponentTextbox.Name = "ModifyComponentTextbox";
            this.ModifyComponentTextbox.Size = new System.Drawing.Size(372, 26);
            this.ModifyComponentTextbox.TabIndex = 25;
            // 
            // ModifyTitleTextbox
            // 
            this.ModifyTitleTextbox.Location = new System.Drawing.Point(239, 70);
            this.ModifyTitleTextbox.Name = "ModifyTitleTextbox";
            this.ModifyTitleTextbox.Size = new System.Drawing.Size(372, 26);
            this.ModifyTitleTextbox.TabIndex = 24;
            // 
            // RecordDescriptionLabel
            // 
            this.RecordDescriptionLabel.AutoSize = true;
            this.RecordDescriptionLabel.Location = new System.Drawing.Point(88, 301);
            this.RecordDescriptionLabel.Name = "RecordDescriptionLabel";
            this.RecordDescriptionLabel.Size = new System.Drawing.Size(144, 20);
            this.RecordDescriptionLabel.TabIndex = 23;
            this.RecordDescriptionLabel.Text = "Initial Description:";
            // 
            // RecordStatusLabel
            // 
            this.RecordStatusLabel.AutoSize = true;
            this.RecordStatusLabel.Location = new System.Drawing.Point(170, 260);
            this.RecordStatusLabel.Name = "RecordStatusLabel";
            this.RecordStatusLabel.Size = new System.Drawing.Size(62, 20);
            this.RecordStatusLabel.TabIndex = 22;
            this.RecordStatusLabel.Text = "Status:";
            // 
            // RecordComponentLabel
            // 
            this.RecordComponentLabel.AutoSize = true;
            this.RecordComponentLabel.Location = new System.Drawing.Point(133, 214);
            this.RecordComponentLabel.Name = "RecordComponentLabel";
            this.RecordComponentLabel.Size = new System.Drawing.Size(99, 20);
            this.RecordComponentLabel.TabIndex = 21;
            this.RecordComponentLabel.Text = "Component:";
            // 
            // RecordDiscovererLabel
            // 
            this.RecordDiscovererLabel.AutoSize = true;
            this.RecordDiscovererLabel.Location = new System.Drawing.Point(136, 166);
            this.RecordDiscovererLabel.Name = "RecordDiscovererLabel";
            this.RecordDiscovererLabel.Size = new System.Drawing.Size(96, 20);
            this.RecordDiscovererLabel.TabIndex = 20;
            this.RecordDiscovererLabel.Text = "Discoverer:";
            // 
            // RecordDateLabel
            // 
            this.RecordDateLabel.AutoSize = true;
            this.RecordDateLabel.Location = new System.Drawing.Point(102, 119);
            this.RecordDateLabel.Name = "RecordDateLabel";
            this.RecordDateLabel.Size = new System.Drawing.Size(130, 20);
            this.RecordDateLabel.TabIndex = 19;
            this.RecordDateLabel.Text = "Discovery Date:";
            // 
            // RecordTitleLabel
            // 
            this.RecordTitleLabel.AutoSize = true;
            this.RecordTitleLabel.Location = new System.Drawing.Point(186, 70);
            this.RecordTitleLabel.Name = "RecordTitleLabel";
            this.RecordTitleLabel.Size = new System.Drawing.Size(46, 20);
            this.RecordTitleLabel.TabIndex = 18;
            this.RecordTitleLabel.Text = "Title:";
            // 
            // ModifyIdTextbox
            // 
            this.ModifyIdTextbox.Enabled = false;
            this.ModifyIdTextbox.Location = new System.Drawing.Point(238, 32);
            this.ModifyIdTextbox.Name = "ModifyIdTextbox";
            this.ModifyIdTextbox.Size = new System.Drawing.Size(100, 26);
            this.ModifyIdTextbox.TabIndex = 17;
            // 
            // RecordIdLabel
            // 
            this.RecordIdLabel.AutoSize = true;
            this.RecordIdLabel.Location = new System.Drawing.Point(205, 32);
            this.RecordIdLabel.Name = "RecordIdLabel";
            this.RecordIdLabel.Size = new System.Drawing.Size(27, 20);
            this.RecordIdLabel.TabIndex = 16;
            this.RecordIdLabel.Text = "Id:";
            // 
            // FormModifyIssue
            // 
            this.AcceptButton = this.ModifyIssueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ModifyCancelButton;
            this.ClientSize = new System.Drawing.Size(753, 587);
            this.Controls.Add(this.ModifyCancelButton);
            this.Controls.Add(this.ModifyIssueButton);
            this.Controls.Add(this.ModifyDescriptionTextBox);
            this.Controls.Add(this.ModifyStatusComboBox);
            this.Controls.Add(this.ModifyDiscovererComboBox);
            this.Controls.Add(this.ModifyDatePicker);
            this.Controls.Add(this.ModifyComponentTextbox);
            this.Controls.Add(this.ModifyTitleTextbox);
            this.Controls.Add(this.RecordDescriptionLabel);
            this.Controls.Add(this.RecordStatusLabel);
            this.Controls.Add(this.RecordComponentLabel);
            this.Controls.Add(this.RecordDiscovererLabel);
            this.Controls.Add(this.RecordDateLabel);
            this.Controls.Add(this.RecordTitleLabel);
            this.Controls.Add(this.ModifyIdTextbox);
            this.Controls.Add(this.RecordIdLabel);
            this.Name = "FormModifyIssue";
            this.Text = "FormModifyIssue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyCancelButton;
        private System.Windows.Forms.Button ModifyIssueButton;
        private System.Windows.Forms.TextBox ModifyDescriptionTextBox;
        private System.Windows.Forms.ComboBox ModifyStatusComboBox;
        private System.Windows.Forms.ComboBox ModifyDiscovererComboBox;
        private System.Windows.Forms.DateTimePicker ModifyDatePicker;
        private System.Windows.Forms.TextBox ModifyComponentTextbox;
        private System.Windows.Forms.TextBox ModifyTitleTextbox;
        private System.Windows.Forms.Label RecordDescriptionLabel;
        private System.Windows.Forms.Label RecordStatusLabel;
        private System.Windows.Forms.Label RecordComponentLabel;
        private System.Windows.Forms.Label RecordDiscovererLabel;
        private System.Windows.Forms.Label RecordDateLabel;
        private System.Windows.Forms.Label RecordTitleLabel;
        private System.Windows.Forms.TextBox ModifyIdTextbox;
        private System.Windows.Forms.Label RecordIdLabel;
    }
}