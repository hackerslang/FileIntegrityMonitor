namespace FileIntegrityMonitor.UI.UserControls
{
    partial class ScanComparerContainer
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
            this.components = new System.ComponentModel.Container();
            this.OptionsCompare2ScansPanel = new System.Windows.Forms.Panel();
            this.Compare2ScansButton = new System.Windows.Forms.Button();
            this.SelectScan2List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectScanList = new System.Windows.Forms.ComboBox();
            this.OptionsCompare2DatesPanel = new System.Windows.Forms.Panel();
            this.CompareByDatesButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectCompareStyleList = new System.Windows.Forms.ComboBox();
            this.OptionsCompareLastWithPreviousPanel = new System.Windows.Forms.Panel();
            this.CompareLatestWithFirstPreviousButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OptionsCompare2ScansPanel.SuspendLayout();
            this.OptionsCompare2DatesPanel.SuspendLayout();
            this.OptionsCompareLastWithPreviousPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsCompare2ScansPanel
            // 
            this.OptionsCompare2ScansPanel.Controls.Add(this.Compare2ScansButton);
            this.OptionsCompare2ScansPanel.Controls.Add(this.SelectScan2List);
            this.OptionsCompare2ScansPanel.Controls.Add(this.label1);
            this.OptionsCompare2ScansPanel.Controls.Add(this.label3);
            this.OptionsCompare2ScansPanel.Controls.Add(this.SelectScanList);
            this.OptionsCompare2ScansPanel.Location = new System.Drawing.Point(21, 48);
            this.OptionsCompare2ScansPanel.Name = "OptionsCompare2ScansPanel";
            this.OptionsCompare2ScansPanel.Size = new System.Drawing.Size(960, 93);
            this.OptionsCompare2ScansPanel.TabIndex = 10;
            this.OptionsCompare2ScansPanel.Visible = false;
            // 
            // Compare2ScansButton
            // 
            this.Compare2ScansButton.Location = new System.Drawing.Point(93, 63);
            this.Compare2ScansButton.Name = "Compare2ScansButton";
            this.Compare2ScansButton.Size = new System.Drawing.Size(75, 23);
            this.Compare2ScansButton.TabIndex = 10;
            this.Compare2ScansButton.Text = "Compare";
            this.Compare2ScansButton.UseVisualStyleBackColor = true;
            this.Compare2ScansButton.Click += new System.EventHandler(this.Compare2ScansButton_Click);
            // 
            // SelectScan2List
            // 
            this.SelectScan2List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectScan2List.FormattingEnabled = true;
            this.SelectScan2List.Location = new System.Drawing.Point(93, 33);
            this.SelectScan2List.Name = "SelectScan2List";
            this.SelectScan2List.Size = new System.Drawing.Size(860, 24);
            this.SelectScan2List.TabIndex = 9;
            this.SelectScan2List.SelectedIndexChanged += new System.EventHandler(this.SelectScan2List_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select scan 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select scan:";
            // 
            // SelectScanList
            // 
            this.SelectScanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectScanList.FormattingEnabled = true;
            this.SelectScanList.Location = new System.Drawing.Point(93, 3);
            this.SelectScanList.Name = "SelectScanList";
            this.SelectScanList.Size = new System.Drawing.Size(860, 24);
            this.SelectScanList.TabIndex = 6;
            // 
            // OptionsCompare2DatesPanel
            // 
            this.OptionsCompare2DatesPanel.Controls.Add(this.CompareByDatesButton);
            this.OptionsCompare2DatesPanel.Controls.Add(this.dateTimePicker2);
            this.OptionsCompare2DatesPanel.Controls.Add(this.dateTimePicker1);
            this.OptionsCompare2DatesPanel.Controls.Add(this.label4);
            this.OptionsCompare2DatesPanel.Controls.Add(this.label2);
            this.OptionsCompare2DatesPanel.Location = new System.Drawing.Point(21, 174);
            this.OptionsCompare2DatesPanel.Name = "OptionsCompare2DatesPanel";
            this.OptionsCompare2DatesPanel.Size = new System.Drawing.Size(960, 87);
            this.OptionsCompare2DatesPanel.TabIndex = 11;
            this.OptionsCompare2DatesPanel.Visible = false;
            // 
            // CompareByDatesButton
            // 
            this.CompareByDatesButton.Location = new System.Drawing.Point(96, 57);
            this.CompareByDatesButton.Name = "CompareByDatesButton";
            this.CompareByDatesButton.Size = new System.Drawing.Size(75, 23);
            this.CompareByDatesButton.TabIndex = 14;
            this.CompareByDatesButton.Text = "Compare";
            this.CompareByDatesButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "End date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start date:";
            // 
            // SelectCompareStyleList
            // 
            this.SelectCompareStyleList.BackColor = System.Drawing.Color.DimGray;
            this.SelectCompareStyleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCompareStyleList.FormattingEnabled = true;
            this.SelectCompareStyleList.Items.AddRange(new object[] {
            "Compare two scans ...",
            "Compare latest with first previous ...",
            "Compare by two dates ..."});
            this.SelectCompareStyleList.Location = new System.Drawing.Point(21, 18);
            this.SelectCompareStyleList.Name = "SelectCompareStyleList";
            this.SelectCompareStyleList.Size = new System.Drawing.Size(953, 24);
            this.SelectCompareStyleList.TabIndex = 12;
            this.SelectCompareStyleList.SelectedIndexChanged += new System.EventHandler(this.SelectCompareStyleList_SelectedIndexChanged);
            // 
            // OptionsCompareLastWithPreviousPanel
            // 
            this.OptionsCompareLastWithPreviousPanel.Controls.Add(this.CompareLatestWithFirstPreviousButton);
            this.OptionsCompareLastWithPreviousPanel.Location = new System.Drawing.Point(21, 276);
            this.OptionsCompareLastWithPreviousPanel.Name = "OptionsCompareLastWithPreviousPanel";
            this.OptionsCompareLastWithPreviousPanel.Size = new System.Drawing.Size(960, 35);
            this.OptionsCompareLastWithPreviousPanel.TabIndex = 13;
            this.OptionsCompareLastWithPreviousPanel.Visible = false;
            // 
            // CompareLatestWithFirstPreviousButton
            // 
            this.CompareLatestWithFirstPreviousButton.Location = new System.Drawing.Point(96, 3);
            this.CompareLatestWithFirstPreviousButton.Name = "CompareLatestWithFirstPreviousButton";
            this.CompareLatestWithFirstPreviousButton.Size = new System.Drawing.Size(75, 23);
            this.CompareLatestWithFirstPreviousButton.TabIndex = 15;
            this.CompareLatestWithFirstPreviousButton.Text = "Compare";
            this.CompareLatestWithFirstPreviousButton.UseVisualStyleBackColor = true;
            // 
            // ScanComparerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.OptionsCompareLastWithPreviousPanel);
            this.Controls.Add(this.SelectCompareStyleList);
            this.Controls.Add(this.OptionsCompare2DatesPanel);
            this.Controls.Add(this.OptionsCompare2ScansPanel);
            this.Name = "ScanComparerContainer";
            this.Size = new System.Drawing.Size(1015, 528);
            this.Load += new System.EventHandler(this.ScanComparerContainer_Load);
            this.OptionsCompare2ScansPanel.ResumeLayout(false);
            this.OptionsCompare2ScansPanel.PerformLayout();
            this.OptionsCompare2DatesPanel.ResumeLayout(false);
            this.OptionsCompare2DatesPanel.PerformLayout();
            this.OptionsCompareLastWithPreviousPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OptionsCompare2ScansPanel;
        private System.Windows.Forms.ComboBox SelectScan2List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectScanList;
        private System.Windows.Forms.Panel OptionsCompare2DatesPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectCompareStyleList;
        private System.Windows.Forms.Button Compare2ScansButton;
        private System.Windows.Forms.Button CompareByDatesButton;
        private System.Windows.Forms.Panel OptionsCompareLastWithPreviousPanel;
        private System.Windows.Forms.Button CompareLatestWithFirstPreviousButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
