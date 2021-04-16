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

namespace FileIntegrityMonitor.UI.UserControls
{
    public partial class NewScanContainer : UserControl
    {
        public NewScanContainer()
        {
            InitializeComponent();
        }

        private string Folder { get; set; }
        private FIMHashAlgorithm Algorithm { get; set; }
        private bool Recursive { get; set; }

        private void ScanFolderSelector_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderToScanTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SetScanProperties()
        {
            Folder = FolderToScanTextBox.Text;
            Recursive = RecursiveCheckBox.Checked;

            Algorithm = new FIMHashAlgorithm();

            if (HashAlgorithmsList.SelectedText == "sha256")
            {
                Algorithm.Id = 1;
            }
            else
            {
                Algorithm.Id = 2;
            }

            Algorithm.AlgorithmText = HashAlgorithmsList.SelectedText;
        }

        private void StartScanButton_Click(object sender, EventArgs e)
        {
            SetScanProperties();
            ShowProgressBar();
            StartBackgroundScan();
        }

        private void ShowProgressBar()
        {
            scanningProgressBar.Visible = true;
            ProgressLabel.Visible = true;
        }

        private void StartBackgroundScan()
        {
            int numberOfFiles = DirectoryParser.GetAllFiles(Folder, Recursive).Count;
            backgroundWorker1.RunWorkerAsync(numberOfFiles);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            scanningProgressBar.Value = e.ProgressPercentage;
            ProgressLabel.Text = "Processing file: " + e.UserState.ToString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            StartScanForms(e);
        }

        private void StartScanForms(DoWorkEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Folder)) { return; }

            Scan scan = new Scan
            {
                FilePath = Folder,
                HashAlgorithm = Algorithm,
                Time = DateTime.Now
            };

            try
            {
                scan.Insert();
            }
            catch (Exception ex)
            {

            }

            List<string> allFiles = DirectoryParser.GetAllFiles(Folder, Recursive);

            int nFiles = allFiles.Count;
            int i = 0;

            foreach (string file in allFiles)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        FileScan.ScanFile(file, scan);
                        int progress = (int)Math.Ceiling((double)i / nFiles) * 100;

                        backgroundWorker1.ReportProgress(progress, (object)file);
                        i++;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
        }

        private void NewScanContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
