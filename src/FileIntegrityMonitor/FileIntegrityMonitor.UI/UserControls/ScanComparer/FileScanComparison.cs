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

namespace FileIntegrityMonitor.UI.UserControls.ScanComparer
{
    public partial class FileScanComparison : UserControl
    {
        public FileScanComparison()
        {
            InitializeComponent();
        }

        public void SetFileScanResult(FileScanResult result)
        {
            this.StatusLabel.Text = result.StatusString;

            if (!string.IsNullOrEmpty(result.LatestFileScan.Error.ErrorMessage))
            {
                this.LatestChecksum.Text = result.LatestFileScan.Error.ErrorMessage;
            }
            else if (result.LatestFileScan.Checksum != null)
            {
                this.LatestChecksum.Text = result.LatestFileScan.Checksum;
            }

            if (!string.IsNullOrEmpty(result.PreviousFileScan.Error.ErrorMessage))
            {
                this.PreviousChecksum.Text = result.PreviousFileScan.Error.ErrorMessage;
            }
            else if (result.PreviousFileScan.Checksum != null)
            {
                this.PreviousChecksum.Text = result.PreviousFileScan.Checksum;
            }
        }
    }
}
