namespace FileIntegrityMonitor.UI.UserControls.ScanComparer
{
    partial class FileScanComparisonList
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
            this.FileScanComparisons = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pager1 = new FileIntegrityMonitor.UI.UserControls.Pager();
            this.SuspendLayout();
            // 
            // FileScanComparisons
            // 
            this.FileScanComparisons.AutoScroll = true;
            this.FileScanComparisons.Location = new System.Drawing.Point(3, 49);
            this.FileScanComparisons.Name = "FileScanComparisons";
            this.FileScanComparisons.Size = new System.Drawing.Size(985, 368);
            this.FileScanComparisons.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 468);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // pager1
            // 
            this.pager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.pager1.CurrentPage = 0;
            this.pager1.ItemsPerPage = 0;
            this.pager1.Location = new System.Drawing.Point(0, 417);
            this.pager1.Name = "pager1";
            this.pager1.Size = new System.Drawing.Size(988, 51);
            this.pager1.TabIndex = 7;
            this.pager1.TotalNumberOfItems = 0;
            // 
            // FileScanComparisonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.FileScanComparisons);
            this.Name = "FileScanComparisonList";
            this.Size = new System.Drawing.Size(991, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FileScanComparisons;
        private System.Windows.Forms.Splitter splitter1;
        private Pager pager1;
    }
}
