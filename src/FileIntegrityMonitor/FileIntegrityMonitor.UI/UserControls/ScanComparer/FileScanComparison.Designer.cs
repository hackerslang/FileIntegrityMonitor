namespace FileIntegrityMonitor.UI.UserControls.ScanComparer
{
    partial class FileScanComparison
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PreviousChecksum = new System.Windows.Forms.TextBox();
            this.LatestChecksum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Checksum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Previous checksum:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(214, 5);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(20, 17);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "...";
            // 
            // PreviousChecksum
            // 
            this.PreviousChecksum.Location = new System.Drawing.Point(217, 62);
            this.PreviousChecksum.Name = "PreviousChecksum";
            this.PreviousChecksum.ReadOnly = true;
            this.PreviousChecksum.Size = new System.Drawing.Size(642, 22);
            this.PreviousChecksum.TabIndex = 9;
            // 
            // LatestChecksum
            // 
            this.LatestChecksum.Location = new System.Drawing.Point(217, 29);
            this.LatestChecksum.Name = "LatestChecksum";
            this.LatestChecksum.ReadOnly = true;
            this.LatestChecksum.Size = new System.Drawing.Size(642, 22);
            this.LatestChecksum.TabIndex = 10;
            // 
            // FileScanComparison
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.LatestChecksum);
            this.Controls.Add(this.PreviousChecksum);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FileScanComparison";
            this.Size = new System.Drawing.Size(938, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox PreviousChecksum;
        private System.Windows.Forms.TextBox LatestChecksum;
    }
}
