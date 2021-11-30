namespace P5
{
    partial class FormModifyRequirement
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
            this.RequirementAccept = new System.Windows.Forms.Button();
            this.RequirementCancel = new System.Windows.Forms.Button();
            this.FeatureDropDown = new System.Windows.Forms.ComboBox();
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.StatementLabel = new System.Windows.Forms.Label();
            this.StatementTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RequirementAccept
            // 
            this.RequirementAccept.Location = new System.Drawing.Point(498, 382);
            this.RequirementAccept.Name = "RequirementAccept";
            this.RequirementAccept.Size = new System.Drawing.Size(170, 39);
            this.RequirementAccept.TabIndex = 0;
            this.RequirementAccept.Text = "Modify Requirement";
            this.RequirementAccept.UseVisualStyleBackColor = true;
            this.RequirementAccept.Click += new System.EventHandler(this.RequirementAccept_Click);
            // 
            // RequirementCancel
            // 
            this.RequirementCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RequirementCancel.Location = new System.Drawing.Point(322, 382);
            this.RequirementCancel.Name = "RequirementCancel";
            this.RequirementCancel.Size = new System.Drawing.Size(170, 39);
            this.RequirementCancel.TabIndex = 1;
            this.RequirementCancel.Text = "Cancel";
            this.RequirementCancel.UseVisualStyleBackColor = true;
            // 
            // FeatureDropDown
            // 
            this.FeatureDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeatureDropDown.FormattingEnabled = true;
            this.FeatureDropDown.Location = new System.Drawing.Point(152, 66);
            this.FeatureDropDown.Name = "FeatureDropDown";
            this.FeatureDropDown.Size = new System.Drawing.Size(516, 28);
            this.FeatureDropDown.TabIndex = 2;
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(75, 69);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(71, 20);
            this.FeatureLabel.TabIndex = 3;
            this.FeatureLabel.Text = "Feature:";
            // 
            // StatementLabel
            // 
            this.StatementLabel.AutoSize = true;
            this.StatementLabel.Location = new System.Drawing.Point(56, 117);
            this.StatementLabel.Name = "StatementLabel";
            this.StatementLabel.Size = new System.Drawing.Size(90, 20);
            this.StatementLabel.TabIndex = 4;
            this.StatementLabel.Text = "Statement:";
            // 
            // StatementTextBox
            // 
            this.StatementTextBox.Location = new System.Drawing.Point(152, 114);
            this.StatementTextBox.Multiline = true;
            this.StatementTextBox.Name = "StatementTextBox";
            this.StatementTextBox.Size = new System.Drawing.Size(516, 262);
            this.StatementTextBox.TabIndex = 5;
            // 
            // FormModifyRequirement
            // 
            this.AcceptButton = this.RequirementAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RequirementCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatementTextBox);
            this.Controls.Add(this.StatementLabel);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.FeatureDropDown);
            this.Controls.Add(this.RequirementCancel);
            this.Controls.Add(this.RequirementAccept);
            this.Name = "FormModifyRequirement";
            this.Text = "FormModifyRequirement";
            this.Load += new System.EventHandler(this.FormModifyRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequirementAccept;
        private System.Windows.Forms.Button RequirementCancel;
        private System.Windows.Forms.ComboBox FeatureDropDown;
        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Label StatementLabel;
        private System.Windows.Forms.TextBox StatementTextBox;
    }
}