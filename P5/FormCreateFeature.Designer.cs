namespace P5
{
    partial class FormCreateFeature
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
            this.FeatureTitleLabel = new System.Windows.Forms.Label();
            this.FeatureTitleTextbox = new System.Windows.Forms.TextBox();
            this.FeatureCreateButton = new System.Windows.Forms.Button();
            this.FeatureCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeatureTitleLabel
            // 
            this.FeatureTitleLabel.AutoSize = true;
            this.FeatureTitleLabel.Location = new System.Drawing.Point(91, 99);
            this.FeatureTitleLabel.Name = "FeatureTitleLabel";
            this.FeatureTitleLabel.Size = new System.Drawing.Size(46, 20);
            this.FeatureTitleLabel.TabIndex = 0;
            this.FeatureTitleLabel.Text = "Title:";
            // 
            // FeatureTitleTextbox
            // 
            this.FeatureTitleTextbox.Location = new System.Drawing.Point(144, 92);
            this.FeatureTitleTextbox.Name = "FeatureTitleTextbox";
            this.FeatureTitleTextbox.Size = new System.Drawing.Size(458, 26);
            this.FeatureTitleTextbox.TabIndex = 1;
            // 
            // FeatureCreateButton
            // 
            this.FeatureCreateButton.Location = new System.Drawing.Point(448, 187);
            this.FeatureCreateButton.Name = "FeatureCreateButton";
            this.FeatureCreateButton.Size = new System.Drawing.Size(154, 38);
            this.FeatureCreateButton.TabIndex = 2;
            this.FeatureCreateButton.Text = "Create Feature";
            this.FeatureCreateButton.UseVisualStyleBackColor = true;
            this.FeatureCreateButton.Click += new System.EventHandler(this.FeatureCreateButton_Click);
            // 
            // FeatureCancelButton
            // 
            this.FeatureCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FeatureCancelButton.Location = new System.Drawing.Point(288, 187);
            this.FeatureCancelButton.Name = "FeatureCancelButton";
            this.FeatureCancelButton.Size = new System.Drawing.Size(154, 38);
            this.FeatureCancelButton.TabIndex = 3;
            this.FeatureCancelButton.Text = "Cancel";
            this.FeatureCancelButton.UseVisualStyleBackColor = true;
            this.FeatureCancelButton.Click += new System.EventHandler(this.FeatureCancelButton_Click);
            // 
            // FormCreateFeature
            // 
            this.AcceptButton = this.FeatureCreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FeatureCancelButton;
            this.ClientSize = new System.Drawing.Size(667, 258);
            this.Controls.Add(this.FeatureCancelButton);
            this.Controls.Add(this.FeatureCreateButton);
            this.Controls.Add(this.FeatureTitleTextbox);
            this.Controls.Add(this.FeatureTitleLabel);
            this.Name = "FormCreateFeature";
            this.Text = "Create Feature";
            this.Load += new System.EventHandler(this.FormCreateFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeatureTitleLabel;
        private System.Windows.Forms.TextBox FeatureTitleTextbox;
        private System.Windows.Forms.Button FeatureCreateButton;
        private System.Windows.Forms.Button FeatureCancelButton;
    }
}