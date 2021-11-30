namespace P5
{
    partial class FormRemoveIssue
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
            this.RemoveIssueAccept = new System.Windows.Forms.Button();
            this.RemoveIssueCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveIssueAccept
            // 
            this.RemoveIssueAccept.Location = new System.Drawing.Point(231, 133);
            this.RemoveIssueAccept.Name = "RemoveIssueAccept";
            this.RemoveIssueAccept.Size = new System.Drawing.Size(105, 43);
            this.RemoveIssueAccept.TabIndex = 0;
            this.RemoveIssueAccept.Text = "Yes";
            this.RemoveIssueAccept.UseVisualStyleBackColor = true;
            this.RemoveIssueAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveIssueCancel
            // 
            this.RemoveIssueCancel.Location = new System.Drawing.Point(84, 133);
            this.RemoveIssueCancel.Name = "RemoveIssueCancel";
            this.RemoveIssueCancel.Size = new System.Drawing.Size(105, 43);
            this.RemoveIssueCancel.TabIndex = 1;
            this.RemoveIssueCancel.Text = "No";
            this.RemoveIssueCancel.UseVisualStyleBackColor = true;
            this.RemoveIssueCancel.Click += new System.EventHandler(this.RemoveIssueCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you want to remove this issue?";
            // 
            // FormRemoveIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveIssueCancel);
            this.Controls.Add(this.RemoveIssueAccept);
            this.Name = "FormRemoveIssue";
            this.Text = "FormRemoveIssue";
            this.Load += new System.EventHandler(this.FormRemoveIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveIssueAccept;
        private System.Windows.Forms.Button RemoveIssueCancel;
        private System.Windows.Forms.Label label1;
    }
}