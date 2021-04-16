namespace FileIntegrityMonitor.UI.UserControls
{
    partial class NewScanContainer
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
            this.RecursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.HashAlgorithmsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartScanButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.scanningProgressBar = new System.Windows.Forms.ProgressBar();
            this.FolderToScanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanFolderSelector = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // RecursiveCheckBox
            // 
            this.RecursiveCheckBox.AutoSize = true;
            this.RecursiveCheckBox.Checked = true;
            this.RecursiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecursiveCheckBox.Location = new System.Drawing.Point(334, 36);
            this.RecursiveCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecursiveCheckBox.Name = "RecursiveCheckBox";
            this.RecursiveCheckBox.Size = new System.Drawing.Size(93, 21);
            this.RecursiveCheckBox.TabIndex = 15;
            this.RecursiveCheckBox.Text = "Recursive";
            this.RecursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // HashAlgorithmsList
            // 
            this.HashAlgorithmsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HashAlgorithmsList.FormattingEnabled = true;
            this.HashAlgorithmsList.Items.AddRange(new object[] {
            "Sha256",
            "Sha512"});
            this.HashAlgorithmsList.Location = new System.Drawing.Point(124, 32);
            this.HashAlgorithmsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HashAlgorithmsList.Name = "HashAlgorithmsList";
            this.HashAlgorithmsList.Size = new System.Drawing.Size(193, 24);
            this.HashAlgorithmsList.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Algorithm:";
            // 
            // StartScanButton
            // 
            this.StartScanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartScanButton.Location = new System.Drawing.Point(124, 64);
            this.StartScanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartScanButton.Name = "StartScanButton";
            this.StartScanButton.Size = new System.Drawing.Size(785, 30);
            this.StartScanButton.TabIndex = 12;
            this.StartScanButton.Text = "Start new scan ...";
            this.StartScanButton.UseVisualStyleBackColor = true;
            this.StartScanButton.Click += new System.EventHandler(this.StartScanButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(121, 136);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(73, 17);
            this.ProgressLabel.TabIndex = 11;
            this.ProgressLabel.Text = "Starting ...";
            this.ProgressLabel.Visible = false;
            // 
            // scanningProgressBar
            // 
            this.scanningProgressBar.Location = new System.Drawing.Point(123, 102);
            this.scanningProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanningProgressBar.Name = "scanningProgressBar";
            this.scanningProgressBar.Size = new System.Drawing.Size(785, 30);
            this.scanningProgressBar.TabIndex = 10;
            this.scanningProgressBar.Visible = false;
            // 
            // FolderToScanTextBox
            // 
            this.FolderToScanTextBox.Location = new System.Drawing.Point(124, 4);
            this.FolderToScanTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderToScanTextBox.Name = "FolderToScanTextBox";
            this.FolderToScanTextBox.Size = new System.Drawing.Size(742, 22);
            this.FolderToScanTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folder to scan:";
            // 
            // ScanFolderSelector
            // 
            this.ScanFolderSelector.Location = new System.Drawing.Point(871, 4);
            this.ScanFolderSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScanFolderSelector.Name = "ScanFolderSelector";
            this.ScanFolderSelector.Size = new System.Drawing.Size(37, 22);
            this.ScanFolderSelector.TabIndex = 16;
            this.ScanFolderSelector.Text = "...";
            this.ScanFolderSelector.UseVisualStyleBackColor = true;
            this.ScanFolderSelector.Click += new System.EventHandler(this.ScanFolderSelector_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // NewScanContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScanFolderSelector);
            this.Controls.Add(this.RecursiveCheckBox);
            this.Controls.Add(this.HashAlgorithmsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartScanButton);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.scanningProgressBar);
            this.Controls.Add(this.FolderToScanTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewScanContainer";
            this.Size = new System.Drawing.Size(972, 165);
            this.Load += new System.EventHandler(this.NewScanContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RecursiveCheckBox;
        private System.Windows.Forms.ComboBox HashAlgorithmsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartScanButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ProgressBar scanningProgressBar;
        private System.Windows.Forms.TextBox FolderToScanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScanFolderSelector;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
