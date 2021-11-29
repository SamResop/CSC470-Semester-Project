namespace P5
{
    partial class FormModifyFeature
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
            this.FeatureModifyTitle = new System.Windows.Forms.Label();
            this.FeatureModifyAccept = new System.Windows.Forms.Button();
            this.FeatureModifyCancel = new System.Windows.Forms.Button();
            this.FeatureModifyTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FeatureModifyTitle
            // 
            this.FeatureModifyTitle.AutoSize = true;
            this.FeatureModifyTitle.Location = new System.Drawing.Point(56, 103);
            this.FeatureModifyTitle.Name = "FeatureModifyTitle";
            this.FeatureModifyTitle.Size = new System.Drawing.Size(46, 20);
            this.FeatureModifyTitle.TabIndex = 0;
            this.FeatureModifyTitle.Text = "Title:";
            // 
            // FeatureModifyAccept
            // 
            this.FeatureModifyAccept.Location = new System.Drawing.Point(457, 171);
            this.FeatureModifyAccept.Name = "FeatureModifyAccept";
            this.FeatureModifyAccept.Size = new System.Drawing.Size(140, 52);
            this.FeatureModifyAccept.TabIndex = 1;
            this.FeatureModifyAccept.Text = "Modify Feature";
            this.FeatureModifyAccept.UseVisualStyleBackColor = true;
            this.FeatureModifyAccept.Click += new System.EventHandler(this.FeatureModifyAccept_Click);
            // 
            // FeatureModifyCancel
            // 
            this.FeatureModifyCancel.Location = new System.Drawing.Point(311, 171);
            this.FeatureModifyCancel.Name = "FeatureModifyCancel";
            this.FeatureModifyCancel.Size = new System.Drawing.Size(140, 52);
            this.FeatureModifyCancel.TabIndex = 2;
            this.FeatureModifyCancel.Text = "Cancel";
            this.FeatureModifyCancel.UseVisualStyleBackColor = true;
            this.FeatureModifyCancel.Click += new System.EventHandler(this.FeatureModifyCancel_Click);
            // 
            // FeatureModifyTextbox
            // 
            this.FeatureModifyTextbox.Location = new System.Drawing.Point(109, 103);
            this.FeatureModifyTextbox.Name = "FeatureModifyTextbox";
            this.FeatureModifyTextbox.Size = new System.Drawing.Size(488, 26);
            this.FeatureModifyTextbox.TabIndex = 3;
            // 
            // FormModifyFeature
            // 
            this.AcceptButton = this.FeatureModifyAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FeatureModifyCancel;
            this.ClientSize = new System.Drawing.Size(728, 319);
            this.Controls.Add(this.FeatureModifyTextbox);
            this.Controls.Add(this.FeatureModifyCancel);
            this.Controls.Add(this.FeatureModifyAccept);
            this.Controls.Add(this.FeatureModifyTitle);
            this.Name = "FormModifyFeature";
            this.Text = "Modify Feature";
            this.Load += new System.EventHandler(this.FormModifyFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeatureModifyTitle;
        private System.Windows.Forms.Button FeatureModifyAccept;
        private System.Windows.Forms.Button FeatureModifyCancel;
        private System.Windows.Forms.TextBox FeatureModifyTextbox;
    }
}