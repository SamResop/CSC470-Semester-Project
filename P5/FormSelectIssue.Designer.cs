namespace P5

{
    partial class FormSelectIssue
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
            this.CurrentIssuesGrid = new System.Windows.Forms.DataGridView();
            this.SelectIssueButton = new System.Windows.Forms.Button();
            this.CancelIssueSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIssuesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentIssuesGrid
            // 
            this.CurrentIssuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentIssuesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CurrentIssuesGrid.Location = new System.Drawing.Point(12, 57);
            this.CurrentIssuesGrid.MultiSelect = false;
            this.CurrentIssuesGrid.Name = "CurrentIssuesGrid";
            this.CurrentIssuesGrid.RowHeadersWidth = 51;
            this.CurrentIssuesGrid.RowTemplate.Height = 28;
            this.CurrentIssuesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrentIssuesGrid.Size = new System.Drawing.Size(749, 292);
            this.CurrentIssuesGrid.TabIndex = 0;
            // 
            // SelectIssueButton
            // 
            this.SelectIssueButton.Location = new System.Drawing.Point(644, 368);
            this.SelectIssueButton.Name = "SelectIssueButton";
            this.SelectIssueButton.Size = new System.Drawing.Size(117, 50);
            this.SelectIssueButton.TabIndex = 1;
            this.SelectIssueButton.Text = "Select";
            this.SelectIssueButton.UseVisualStyleBackColor = true;
            this.SelectIssueButton.Click += new System.EventHandler(this.SelectIssueButton_Click);
            // 
            // CancelIssueSelectionButton
            // 
            this.CancelIssueSelectionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelIssueSelectionButton.Location = new System.Drawing.Point(521, 368);
            this.CancelIssueSelectionButton.Name = "CancelIssueSelectionButton";
            this.CancelIssueSelectionButton.Size = new System.Drawing.Size(117, 50);
            this.CancelIssueSelectionButton.TabIndex = 2;
            this.CancelIssueSelectionButton.Text = "Cancel";
            this.CancelIssueSelectionButton.UseVisualStyleBackColor = true;
            this.CancelIssueSelectionButton.Click += new System.EventHandler(this.CancelIssueSelectionButton_Click);
            // 
            // FormSelectIssue
            // 
            this.AcceptButton = this.SelectIssueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelIssueSelectionButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelIssueSelectionButton);
            this.Controls.Add(this.SelectIssueButton);
            this.Controls.Add(this.CurrentIssuesGrid);
            this.Name = "FormSelectIssue";
            this.Text = "FormSelectIssue";
            this.Load += new System.EventHandler(this.FormSelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIssuesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CurrentIssuesGrid;
        private System.Windows.Forms.Button SelectIssueButton;
        private System.Windows.Forms.Button CancelIssueSelectionButton;
    }
}