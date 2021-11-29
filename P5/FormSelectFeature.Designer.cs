namespace P5
{
    partial class FormSelectFeature
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
            this.FeatureDataGrid = new System.Windows.Forms.DataGridView();
            this.FeatureSelect = new System.Windows.Forms.Button();
            this.FeatureCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FeatureDataGrid
            // 
            this.FeatureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeatureDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FeatureDataGrid.Location = new System.Drawing.Point(22, 29);
            this.FeatureDataGrid.MultiSelect = false;
            this.FeatureDataGrid.Name = "FeatureDataGrid";
            this.FeatureDataGrid.RowHeadersWidth = 51;
            this.FeatureDataGrid.RowTemplate.Height = 28;
            this.FeatureDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeatureDataGrid.Size = new System.Drawing.Size(754, 302);
            this.FeatureDataGrid.TabIndex = 0;
            // 
            // FeatureSelect
            // 
            this.FeatureSelect.Location = new System.Drawing.Point(637, 364);
            this.FeatureSelect.Name = "FeatureSelect";
            this.FeatureSelect.Size = new System.Drawing.Size(139, 49);
            this.FeatureSelect.TabIndex = 1;
            this.FeatureSelect.Text = "Select Feature";
            this.FeatureSelect.UseVisualStyleBackColor = true;
            this.FeatureSelect.Click += new System.EventHandler(this.FeatureSelect_Click);
            // 
            // FeatureCancel
            // 
            this.FeatureCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FeatureCancel.Location = new System.Drawing.Point(492, 364);
            this.FeatureCancel.Name = "FeatureCancel";
            this.FeatureCancel.Size = new System.Drawing.Size(139, 49);
            this.FeatureCancel.TabIndex = 2;
            this.FeatureCancel.Text = "Cancel";
            this.FeatureCancel.UseVisualStyleBackColor = true;
            this.FeatureCancel.Click += new System.EventHandler(this.FeatureCancel_Click);
            // 
            // FormSelectFeature
            // 
            this.AcceptButton = this.FeatureSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FeatureCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeatureCancel);
            this.Controls.Add(this.FeatureSelect);
            this.Controls.Add(this.FeatureDataGrid);
            this.Name = "FormSelectFeature";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormSelectFeature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeatureDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FeatureDataGrid;
        private System.Windows.Forms.Button FeatureSelect;
        private System.Windows.Forms.Button FeatureCancel;
    }
}