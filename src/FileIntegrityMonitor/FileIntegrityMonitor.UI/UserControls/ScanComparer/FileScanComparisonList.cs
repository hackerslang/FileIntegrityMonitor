using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileIntegrityMonitor.DTO;
using FileIntegrityMonitor.UI.Properties;

namespace FileIntegrityMonitor.UI.UserControls.ScanComparer
{
    public partial class FileScanComparisonList : UserControl
    {
        public FileScanComparisonList()
        {
            InitializeComponent();
        }

        public void InitCompare2Scans(Scan scanOne, Scan scanOther)
        {
            this.Method = CompareMethod.CompareTwoScans;
            this.ScanOne = scanOne;
            this.ScanOther = scanOther;

            LoadScanResults(this.Method);
        }

        public void InitCompareLatestWithFirstPrevious()
        {
            this.Method = CompareMethod.CompareLatestWithFirstPrevious;
        }

        public void InitCompare2Dates(DateTime latestTime, DateTime previousTime)
        {
            this.Method = CompareMethod.CompareByTwoDates;
            this.LatestTime = latestTime;
            this.PreviousTime = previousTime;
        }

        public enum CompareMethod
        {
            CompareTwoScans = 0,
            CompareLatestWithFirstPrevious = 1,
            CompareByTwoDates = 2
        }

        public CompareMethod Method { get; set; }
        public Scan ScanOne { get; set; }
        public Scan ScanOther { get; set; }
        public DateTime? LatestTime { get; set; }
        public DateTime? PreviousTime { get; set; }

        private void LoadScanResults(CompareMethod method, int page = 0, int number = 10)
        {
            Results = new List<FileScanResult>();

            switch (method)
            {
                case CompareMethod.CompareTwoScans:
                    Results = GetScanResults(page, number);
                    break;
                case CompareMethod.CompareLatestWithFirstPrevious:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }

            DisplayScanResults(Results);
            InitExpanded();
            InitRecordDetails();
        }

        private List<FileScanResult> GetScanResults(int page = 0, int number = 10)
        {
            if (ScanOne == null || ScanOther == null)
            {
                MessageBox.Show("One or more scans were not found!", "Scan(s) not found",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Scan latestScan;
            Scan previousScan;

            if (ScanOne.Time >= ScanOther.Time)
            {
                latestScan = ScanOne;
                previousScan = ScanOther;
            }
            else
            {
                latestScan = ScanOther;
                previousScan = ScanOne;
            }

            if (latestScan.HashAlgorithm.Id != previousScan.HashAlgorithm.Id)
            {
                MessageBox.Show("Hashing algorithms used for boths scans differ!", "Different hashing algorithms",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            List<FileScanResult> results = FileScanResult.GetScanResultCompare2Scans(latestScan, previousScan,
                page, number);

            return results;
        }

        private void DisplayScanResults(List<FileScanResult> results)
        {
            Records = new List<Panel>();

            for (int i = 0; i < results.Count; i++)
            {
                FileScanResult currentResult = results[i];

                DisplayScanResultRecord(currentResult, i);
            }
        }

        private void InitExpanded()
        {
            ExpandedRecords = new List<bool>();
            for (int i = 0; i < Results.Count; i++)
            {
                ExpandedRecords.Add(false);
            }
        }

        private void InitRecordDetails()
        {
            RecordDetails = new List<FileScanComparison>();
        }

        private const int PADDING = 15;

        private void DisplayScanResultRecord(FileScanResult result, int number)
        {
            Panel record = new Panel();
            PictureBox icon = new PictureBox();
            ToolTip statusToolTip = new ToolTip();
            Label filePath = new Label();
            ToolTip filePathToolTip = new ToolTip();

            icon.Image = GetIconFileScanStatus(result);
            statusToolTip.SetToolTip(icon, GetToolTipTextFileScanStatus(result));
            icon.Size = new Size(28, 28);
            icon.Location = new Point(2, 2);

            filePath.Text = result.FilePath;
            filePath.ForeColor = Color.FromArgb(67, 70, 78);
            filePath.Size = new Size(this.Width - icon.Width - 10, 28);

            record.Name = "Record_" + number;
            record.Location = new Point(0, (number * RECORD_HEIGHT) + 1);
            record.Size = new Size(800, RECORD_HEIGHT);
            record.BackColor = Color.White;

            record.Controls.Add(icon);
            record.Controls.Add(filePath);
            FileScanComparisons.Controls.Add(record);

            filePath.TextAlign = ContentAlignment.MiddleLeft;
            filePath.Location = new Point(icon.Width + 2, (record.Size.Height - filePath.Height) / 2);

            icon.MouseEnter += RecordControl_MouseHover;
            filePath.MouseEnter += RecordControl_MouseHover;
            record.MouseEnter += Record_MouseHover;
            icon.Click += RecordControl_Click;
            record.Click += Record_Click;
            filePath.Click += RecordControl_Click;

            Records.Add(record);
        }

        private List<Panel> Records { get; set; }
        private List<bool> ExpandedRecords { get; set; }
        private List<FileScanComparison> RecordDetails { get; set; }
        private List<FileScanResult> Results { get; set; }

        private void RecordControl_MouseHover(object sender, EventArgs e)
        {
            RemoveHighLightAllRecords();
            HighLightRecordFromChildControl(sender);
        }

        private void Record_MouseHover(object sender, EventArgs e)
        {
            RemoveHighLightAllRecords();
            HighLightRecord(sender);
        }

        private void Record_Click(object sender, EventArgs e)
        {
            Panel currentRecord = (Panel)sender;

            ToggleShowDetailsRecord(currentRecord);
        }

        private void RecordControl_Click(object sender, EventArgs e)
        {
            Control childControl = (Control)sender;
            Panel currentRecord = (Panel)childControl.Parent;

            ToggleShowDetailsRecord(currentRecord);
        }

        private void HighLightRecordFromChildControl(object sender)
        {
            Panel record = GetRecordControlFromChildSender(sender);

            HighLightRecord(record);
        }

        private Panel GetRecordControlFromChildSender(object sender)
        {
            Control childControl = (Control)sender;
            Panel currentRecord = (Panel)childControl.Parent;

            return currentRecord;
        }

        private void HighLightRecord(object sender)
        {
            Panel currentRecord = (Panel)sender;

            HighLightRecord(currentRecord);
        }

        private void HighLightRecord(Panel currentRecord)
        {
            currentRecord.BackColor = Color.FromArgb(174, 187, 227);
        }

        void RemoveHighLightAllRecords()
        {
            foreach (Panel record in Records)
            {
                record.BackColor = Color.White;
            }
        }

        const int RECORD_HEIGHT = 32;

        private void HighLightRecord(int locationY)
        {
            int index = (int)Math.Floor((locationY / (double)RECORD_HEIGHT) + Records[0].Location.Y);

            if (index < Records.Count)
            {
                Records[index].BackColor = Color.LightGray;
            } 
        }

        private void ToggleShowDetailsRecord(Panel record)
        {
            int id = Int32.Parse(record.Name.Split('_')[1]);

            if (!ExpandedRecords[id])
            {
                ExpandDetailsRecord(id, record);
            }
            else
            {
                CollapseDetailsRecord(id, record);
            }

            ExpandedRecords[id] = !ExpandedRecords[id];
        }

        private int ExpandedDetailsHeight { get; set; }

        private void ExpandDetailsRecord(int id, Panel record)
        {
            ExpandIndividualDetailsRecord(record, id);
            ReArrangeRecordsAfterExpand(id);
            ReArrangeExpandedDetailsAfterExpand(id);
        }

        private void CollapseDetailsRecord(int id, Panel record)
        {
            ReArrangeRecordsAfterCollapse(id);
            ReArrangeExpandedDetailsAfterCollapse(id);
            HideIndividualDetailsRecord(id);
        }

        private FileScanComparison ExpandIndividualDetailsRecord(Panel record, int id)
        {
            FileScanResult fileScanResult = Results[id];
            FileScanComparison expandedRecord = new FileScanComparison();

            expandedRecord.Name = "ExpandedRecord_" + id;
            expandedRecord.SetFileScanResult(fileScanResult);
            expandedRecord.BackColor = Color.White;
            expandedRecord.ForeColor = Color.Black;
            int y = record.Location.Y + record.Height + 1;
            expandedRecord.Location = new Point(record.Location.X, y);
            //expandedRecord.AutoScaleMode = AutoScaleMode.Inherit;
            RecordDetails.Add(expandedRecord);

            FileScanComparisons.Controls.Add(expandedRecord);

            return expandedRecord;
        }

        private void HideIndividualDetailsRecord(int id)
        {
            foreach (Control control in FileScanComparisons.Controls)
            {
                if (control.Name == "ExpandedRecord_" + id)
                {
                    FileScanComparisons.Controls.Remove(control);
                    RecordDetails.Remove((FileScanComparison)control);
                }
            }
        }

        private const int EXPANDED_RECORD_HEIGHT = 90;

        private void ReArrangeRecordsAfterExpand(int id)
        {
            ReArrangeRecordsNewLocationY(id, GetRealHeightRecordDetails(id));
        }

        private void ReArrangeRecordsAfterCollapse(int id)
        {
            ReArrangeRecordsNewLocationY(id, -GetRealHeightRecordDetails(id));
        }

        private void ReArrangeRecordsNewLocationY(int id, int newLocationY)
        {
            for (int i = id + 1; i < Records.Count; i++)
            {
                Panel currentRecord = Records[i];

                currentRecord.Location = new Point(currentRecord.Location.X, currentRecord.Location.Y + newLocationY);
            }
        }

        private void ReArrangeExpandedDetailsAfterExpand(int id)
        {

            ReArrangeRecordDetailsNewLocationY(id, GetRealHeightRecordDetails(id));
        }

        private void ReArrangeExpandedDetailsAfterCollapse(int id)
        {

            ReArrangeRecordDetailsNewLocationY(id, -GetRealHeightRecordDetails(id));
        }

        private int GetRealHeightRecordDetails(int id)
        {
            FileScanComparison recordDetailsControl = FindRecordDetailsControl(id);
            int height = recordDetailsControl.Size.Height;// + (int)recordDetailsControl.CurrentAutoScaleDimensions.Height;

            return height;
        }

        private void ReArrangeRecordDetailsNewLocationY(int id, int newLocationY)
        {
            for (int i = id + 1; i < ExpandedRecords.Count; i++)
            {
                bool expanded = ExpandedRecords[i];

                if (expanded)
                {
                    FileScanComparison recordDetails = FindRecordDetailsControl(i);
                
                    if (recordDetails != null)
                        recordDetails.Location = new Point(recordDetails.Location.X, recordDetails.Location.Y + newLocationY);
                }
            }
        }

        private FileScanComparison FindRecordDetailsControl(int id)
        {
            foreach (Control control in RecordDetails)
            {
                if (control.Name == "ExpandedRecord_" + id)
                {
                    return (FileScanComparison)control;
                }
            }

            return null;
        }

        private Image GetIconFileScanStatus(FileScanResult result)
         {
            Image image;

            switch (result.Status)
            {
                case FileScanStatus.ChangedFile:
                    image = Resources.changed;
                    break;
                case FileScanStatus.UnchangedFile:
                    image = Resources.unchanged;
                    break;
                case FileScanStatus.NewFile:
                    image = Resources._new;
                    break;
                case FileScanStatus.FileRemoved:
                    image = Resources.changed;
                    break;
                default: //Error
                    image = Resources.error;
                    break;
            }

            return image;
        }

        private string GetToolTipTextFileScanStatus(FileScanResult result)
        {
            return result.StatusString;
        }

    }
}
