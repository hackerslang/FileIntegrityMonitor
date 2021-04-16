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
using FileIntegrityMonitor.UI.UserControls.ScanComparer;
using FileIntegrityMonitor.UI.Forms;

namespace FileIntegrityMonitor.UI.UserControls
{
    public partial class ScanComparerContainer : UserControl
    {
        public ScanComparerContainer()
        {
            InitializeComponent();
            CurrentScanSelectionPanel = OptionsCompare2ScansPanel;
        }

        private void ScanComparerContainer_Load(object sender, EventArgs e)
        {
            LoadScansForList();
            SetPanels();
        }

        private void LoadScansForList()
        {
            DataBindScanList(SelectScanList);
            DataBindScanList(SelectScan2List);
        }

        private void DataBindScanList(ComboBox scanList)
        {
            List<Scan> allScans = Scan.GetAllScans();

            scanList.ValueMember = "Id";
            scanList.DisplayMember = "Caption";
            scanList.DataSource = allScans;
        }

        private void SetPanels()
        {
            OptionsCompare2ScansPanel.Location = new Point(20, 48);
            OptionsCompareLastWithPreviousPanel.Location = new Point(20, 48);
            OptionsCompare2DatesPanel.Location = new Point(20, 48);
        }

        private void SelectCompareStyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectCompareStyleList.SelectedIndex)
            {
                case 0:
                    ShowOptionsCompare2Scans();
                    break;
                case 1:
                    ShowOptionsCompareLastWithPrevious();
                    break;
                default:
                    ShowOptionsCompare2Dates();
                    break;
            }
        }

        private void ShowOptionsCompare2Scans()
        {
            OptionsCompare2ScansPanel.Visible = true;
            OptionsCompare2DatesPanel.Visible = false;
            OptionsCompareLastWithPreviousPanel.Visible = false;
            CurrentScanSelectionPanel = OptionsCompare2ScansPanel;
        }

        private void ShowOptionsCompare2Dates()
        {
            OptionsCompare2ScansPanel.Visible = false;
            OptionsCompare2DatesPanel.Visible = true;
            OptionsCompareLastWithPreviousPanel.Visible = false;
            CurrentScanSelectionPanel = OptionsCompare2DatesPanel;
        }

        private void ShowOptionsCompareLastWithPrevious()
        {
            OptionsCompare2ScansPanel.Visible = false;
            OptionsCompare2DatesPanel.Visible = false;
            OptionsCompareLastWithPreviousPanel.Visible = true;
            CurrentScanSelectionPanel = OptionsCompareLastWithPreviousPanel;
        }

        private void Compare2ScansButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartComparison2Scans();
            }
            catch (Exception ex)
            {

            }
        }

        private void StartComparison2Scans()
        {
            int scanOneId = TryGetScanIdFromComboBox(this.SelectScanList);
            int scanOtherId = TryGetScanIdFromComboBox(this.SelectScan2List);

            Scan scanOne = TryGetScanFromId(scanOneId);
            Scan scanOther = TryGetScanFromId(scanOtherId);

            TryCheckHashAlgorithmCompatibility(scanOne, scanOther);
            Show2ScansComparisonForm(scanOne, scanOther);
        }

        private void Show2ScansComparisonForm(Scan scanOne, Scan scanOther)
        {
            FileScanComparisonListForm comparisonForm = new FileScanComparisonListForm();

            comparisonForm.Set2ScanComparisons(scanOne, scanOther);
            comparisonForm.Show();
        }

        //private void CreateComparisonControl(Scan scanOne, Scan scanOther)
        //{
        //    FileScanComparisonList comparisonList = new FileScanComparisonList();
        //    comparisonList.InitCompare2Scans(scanOne, scanOther);

        //    comparisonList.Location = new Point(30, CurrentScanSelectionPanel.Location.Y
        //        + CurrentScanSelectionPanel.Height + PADDING);

        //    this.Controls.Add(comparisonList);
        //}

        private int TryGetScanIdFromComboBox(ComboBox selectScanList)
        {
            object value = selectScanList.SelectedValue;

            int scanId = -1; 


            if (!Int32.TryParse(value.ToString(), out scanId))
            {
                throw new Exception("Cannot get scan(s)!");
            }

            return scanId;
        }

        private Scan TryGetScanFromId(int scanId)
        {
            Scan scan = Scan.GetScan(scanId);

            if (scan == null)
            {
                throw new Exception("One or more scans were not found!");
            }

            return scan;
        }

        private void TryCheckHashAlgorithmCompatibility(Scan scanOne, Scan scanOther)
        {
            if (scanOne.HashAlgorithm.AlgorithmText != scanOther.HashAlgorithm.AlgorithmText)
            {
                throw new Exception("Hashing algorithms used for boths scans differ!");
            }
        }

        private Panel CurrentScanSelectionPanel { get; set; }
        private const int PADDING = 15;

        private void SelectScan2List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
