namespace P5
{
    partial class FormDashboard
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
            this.IssueNumLabel = new System.Windows.Forms.Label();
            this.IssueMonthLabel = new System.Windows.Forms.Label();
            this.IssueMonthListBox = new System.Windows.Forms.ListBox();
            this.IssueDiscovererLabel = new System.Windows.Forms.Label();
            this.IssueDiscovererListBox = new System.Windows.Forms.ListBox();
            this.IssueCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IssueNumLabel
            // 
            this.IssueNumLabel.AutoSize = true;
            this.IssueNumLabel.Location = new System.Drawing.Point(106, 34);
            this.IssueNumLabel.Name = "IssueNumLabel";
            this.IssueNumLabel.Size = new System.Drawing.Size(217, 20);
            this.IssueNumLabel.TabIndex = 0;
            this.IssueNumLabel.Text = "Total Number of Issues:    0";
            // 
            // IssueMonthLabel
            // 
            this.IssueMonthLabel.AutoSize = true;
            this.IssueMonthLabel.Location = new System.Drawing.Point(110, 96);
            this.IssueMonthLabel.Name = "IssueMonthLabel";
            this.IssueMonthLabel.Size = new System.Drawing.Size(139, 20);
            this.IssueMonthLabel.TabIndex = 1;
            this.IssueMonthLabel.Text = "Issues By Month:";
            // 
            // IssueMonthListBox
            // 
            this.IssueMonthListBox.FormattingEnabled = true;
            this.IssueMonthListBox.ItemHeight = 20;
            this.IssueMonthListBox.Location = new System.Drawing.Point(114, 131);
            this.IssueMonthListBox.Name = "IssueMonthListBox";
            this.IssueMonthListBox.Size = new System.Drawing.Size(209, 144);
            this.IssueMonthListBox.TabIndex = 2;
            // 
            // IssueDiscovererLabel
            // 
            this.IssueDiscovererLabel.AutoSize = true;
            this.IssueDiscovererLabel.Location = new System.Drawing.Point(110, 296);
            this.IssueDiscovererLabel.Name = "IssueDiscovererLabel";
            this.IssueDiscovererLabel.Size = new System.Drawing.Size(175, 20);
            this.IssueDiscovererLabel.TabIndex = 3;
            this.IssueDiscovererLabel.Text = "Issues By Discoverer:";
            // 
            // IssueDiscovererListBox
            // 
            this.IssueDiscovererListBox.FormattingEnabled = true;
            this.IssueDiscovererListBox.ItemHeight = 20;
            this.IssueDiscovererListBox.Location = new System.Drawing.Point(110, 320);
            this.IssueDiscovererListBox.Name = "IssueDiscovererListBox";
            this.IssueDiscovererListBox.Size = new System.Drawing.Size(213, 144);
            this.IssueDiscovererListBox.TabIndex = 4;
            // 
            // IssueCloseButton
            // 
            this.IssueCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IssueCloseButton.Location = new System.Drawing.Point(248, 504);
            this.IssueCloseButton.Name = "IssueCloseButton";
            this.IssueCloseButton.Size = new System.Drawing.Size(75, 32);
            this.IssueCloseButton.TabIndex = 5;
            this.IssueCloseButton.Text = "Close";
            this.IssueCloseButton.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IssueCloseButton;
            this.ClientSize = new System.Drawing.Size(435, 580);
            this.Controls.Add(this.IssueCloseButton);
            this.Controls.Add(this.IssueDiscovererListBox);
            this.Controls.Add(this.IssueDiscovererLabel);
            this.Controls.Add(this.IssueMonthListBox);
            this.Controls.Add(this.IssueMonthLabel);
            this.Controls.Add(this.IssueNumLabel);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IssueNumLabel;
        private System.Windows.Forms.Label IssueMonthLabel;
        private System.Windows.Forms.ListBox IssueMonthListBox;
        private System.Windows.Forms.Label IssueDiscovererLabel;
        private System.Windows.Forms.ListBox IssueDiscovererListBox;
        private System.Windows.Forms.Button IssueCloseButton;
    }
}