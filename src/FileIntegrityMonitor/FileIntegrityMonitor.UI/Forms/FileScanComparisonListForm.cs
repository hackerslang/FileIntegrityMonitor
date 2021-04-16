using FileIntegrityMonitor.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIntegrityMonitor.UI.Forms
{
    public partial class FileScanComparisonListForm : Form
    {
        public FileScanComparisonListForm()
        {
            InitializeComponent();
        }

        private Scan LatestScan { get; set; }
        private Scan PreviousScan { get; set; }

        public void Set2ScanComparisons(Scan scanOne, Scan scanOther)
        {
            Set2Scans(scanOne, scanOther);
            DataBind2Scans();
        }

        private void Set2Scans(Scan scanOne, Scan scanOther)
        {
            if (scanOne.Time >= scanOther.Time)
            {
                LatestScan = scanOne;
                PreviousScan = scanOther;
            }
            else
            {
                LatestScan = scanOther;
                PreviousScan = scanOne;
            }
        }

        private void DataBind2Scans()
        {
            fileScanComparisonList.InitCompare2Scans(LatestScan, PreviousScan);
        }
            
    }
}
