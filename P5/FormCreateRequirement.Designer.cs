namespace P5
{
    partial class FormCreateRequirement
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
            this.StatementTextbox = new System.Windows.Forms.TextBox();
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RequirementAcceptButton = new System.Windows.Forms.Button();
            this.RequirementCancelButton = new System.Windows.Forms.Button();
            this.FeatureSelectBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StatementTextbox
            // 
            this.StatementTextbox.Enabled = false;
            this.StatementTextbox.Location = new System.Drawing.Point(148, 94);
            this.StatementTextbox.Multiline = true;
            this.StatementTextbox.Name = "StatementTextbox";
            this.StatementTextbox.Size = new System.Drawing.Size(621, 357);
            this.StatementTextbox.TabIndex = 1;
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(71, 53);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(71, 20);
            this.FeatureLabel.TabIndex = 2;
            this.FeatureLabel.Text = "Feature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statement:";
            // 
            // RequirementAcceptButton
            // 
            this.RequirementAcceptButton.Enabled = false;
            this.RequirementAcceptButton.Location = new System.Drawing.Point(594, 480);
            this.RequirementAcceptButton.Name = "RequirementAcceptButton";
            this.RequirementAcceptButton.Size = new System.Drawing.Size(175, 50);
            this.RequirementAcceptButton.TabIndex = 4;
            this.RequirementAcceptButton.Text = "Create Requirement";
            this.RequirementAcceptButton.UseVisualStyleBackColor = true;
            this.RequirementAcceptButton.Click += new System.EventHandler(this.RequirementAcceptButton_Click);
            // 
            // RequirementCancelButton
            // 
            this.RequirementCancelButton.Location = new System.Drawing.Point(413, 480);
            this.RequirementCancelButton.Name = "RequirementCancelButton";
            this.RequirementCancelButton.Size = new System.Drawing.Size(175, 50);
            this.RequirementCancelButton.TabIndex = 5;
            this.RequirementCancelButton.Text = "Cancel";
            this.RequirementCancelButton.UseVisualStyleBackColor = true;
            // 
            // FeatureSelectBox
            // 
            this.FeatureSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeatureSelectBox.FormattingEnabled = true;
            this.FeatureSelectBox.Location = new System.Drawing.Point(148, 45);
            this.FeatureSelectBox.Name = "FeatureSelectBox";
            this.FeatureSelectBox.Size = new System.Drawing.Size(621, 28);
            this.FeatureSelectBox.TabIndex = 6;
            this.FeatureSelectBox.SelectedIndexChanged += new System.EventHandler(this.FeatureSelectBox_SelectedIndexChanged);
            // 
            // FormCreateRequirement
            // 
            this.AcceptButton = this.RequirementAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RequirementCancelButton;
            this.ClientSize = new System.Drawing.Size(920, 569);
            this.Controls.Add(this.FeatureSelectBox);
            this.Controls.Add(this.RequirementCancelButton);
            this.Controls.Add(this.RequirementAcceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.StatementTextbox);
            this.Name = "FormCreateRequirement";
            this.Text = "Create Requirement";
            this.Load += new System.EventHandler(this.FormCreateRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StatementTextbox;
        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RequirementAcceptButton;
        private System.Windows.Forms.Button RequirementCancelButton;
        private System.Windows.Forms.ComboBox FeatureSelectBox;
    }
}