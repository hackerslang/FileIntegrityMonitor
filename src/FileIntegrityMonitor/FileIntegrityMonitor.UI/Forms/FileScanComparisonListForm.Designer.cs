namespace FileIntegrityMonitor.UI.Forms
{
    partial class FileScanComparisonListForm
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
            this.fileScanComparisonList = new FileIntegrityMonitor.UI.UserControls.ScanComparer.FileScanComparisonList();
            this.SuspendLayout();
            // 
            // fileScanComparisonList
            // 
            this.fileScanComparisonList.LatestTime = null;
            this.fileScanComparisonList.Location = new System.Drawing.Point(12, 32);
            this.fileScanComparisonList.Method = FileIntegrityMonitor.UI.UserControls.ScanComparer.FileScanComparisonList.CompareMethod.CompareTwoScans;
            this.fileScanComparisonList.Name = "fileScanComparisonList";
            this.fileScanComparisonList.PreviousTime = null;
            this.fileScanComparisonList.ScanOne = null;
            this.fileScanComparisonList.ScanOther = null;
            this.fileScanComparisonList.Size = new System.Drawing.Size(1075, 517);
            this.fileScanComparisonList.TabIndex = 0;
            // 
            // FileScanComparisonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 735);
            this.Controls.Add(this.fileScanComparisonList);
            this.Name = "FileScanComparisonListForm";
            this.Text = "FileScanComparisonListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ScanComparer.FileScanComparisonList fileScanComparisonList;
    }
}