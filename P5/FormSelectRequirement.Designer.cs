namespace P5
{
    partial class FormSelectRequirement
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
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RequirementDataGrid = new System.Windows.Forms.DataGridView();
            this.FeatureDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RequirementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RequirementAccept
            // 
            this.RequirementAccept.Enabled = false;
            this.RequirementAccept.Location = new System.Drawing.Point(483, 373);
            this.RequirementAccept.Name = "RequirementAccept";
            this.RequirementAccept.Size = new System.Drawing.Size(192, 47);
            this.RequirementAccept.TabIndex = 0;
            this.RequirementAccept.Text = "Select Requirement";
            this.RequirementAccept.UseVisualStyleBackColor = true;
            this.RequirementAccept.Click += new System.EventHandler(this.RequirementAccept_Click);
            // 
            // RequirementCancel
            // 
            this.RequirementCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RequirementCancel.Location = new System.Drawing.Point(285, 373);
            this.RequirementCancel.Name = "RequirementCancel";
            this.RequirementCancel.Size = new System.Drawing.Size(192, 47);
            this.RequirementCancel.TabIndex = 1;
            this.RequirementCancel.Text = "Cancel";
            this.RequirementCancel.UseVisualStyleBackColor = true;
            this.RequirementCancel.Click += new System.EventHandler(this.RequirementCancel_Click);
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(115, 45);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(71, 20);
            this.FeatureLabel.TabIndex = 2;
            this.FeatureLabel.Text = "Feature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Requirements:";
            // 
            // RequirementDataGrid
            // 
            this.RequirementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequirementDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RequirementDataGrid.Enabled = false;
            this.RequirementDataGrid.Location = new System.Drawing.Point(192, 71);
            this.RequirementDataGrid.MultiSelect = false;
            this.RequirementDataGrid.Name = "RequirementDataGrid";
            this.RequirementDataGrid.RowHeadersWidth = 51;
            this.RequirementDataGrid.RowTemplate.Height = 28;
            this.RequirementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequirementDataGrid.Size = new System.Drawing.Size(482, 296);
            this.RequirementDataGrid.TabIndex = 4;
            // 
            // FeatureDropDown
            // 
            this.FeatureDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeatureDropDown.FormattingEnabled = true;
            this.FeatureDropDown.Location = new System.Drawing.Point(192, 37);
            this.FeatureDropDown.Name = "FeatureDropDown";
            this.FeatureDropDown.Size = new System.Drawing.Size(482, 28);
            this.FeatureDropDown.TabIndex = 5;
            this.FeatureDropDown.SelectedIndexChanged += new System.EventHandler(this.FeatureDropDown_SelectedIndexChanged);
            // 
            // FormSelectRequirement
            // 
            this.AcceptButton = this.RequirementAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RequirementCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeatureDropDown);
            this.Controls.Add(this.RequirementDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.RequirementCancel);
            this.Controls.Add(this.RequirementAccept);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequirementDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequirementAccept;
        private System.Windows.Forms.Button RequirementCancel;
        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RequirementDataGrid;
        private System.Windows.Forms.ComboBox FeatureDropDown;
    }
}