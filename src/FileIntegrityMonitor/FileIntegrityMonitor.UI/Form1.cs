using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileIntegrityMonitor.DTO;
using FileIntegrityMonitor.UI.UserControls;

namespace FileIntegrityMonitor.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NewScanContainer newScanContainer;
        private ScanComparerContainer scanComparerContainer;

        private void Form1_Load(object sender, EventArgs e)
        {
            int containerX = NewScanPicture.Location.X;
            int containerY = NewScanPicture.Location.Y + NewScanPicture.Size.Height + 5;

            newScanContainer = new NewScanContainer();
            newScanContainer.Location = new Point(containerX, containerY);

            scanComparerContainer = new ScanComparerContainer();
            scanComparerContainer.Location = new Point(containerX, containerY);
            scanComparerContainer.Visible = false;

            Controls.Add(newScanContainer);
            Controls.Add(scanComparerContainer);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void LogoBox_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.NewScanPicture.Image = Properties.Resources.new_scan_hover;
        }

        private void NewScanPicture_MouseLeave(object sender, EventArgs e)
        {
            this.NewScanPicture.Image = Properties.Resources.new_scan;
        }

        private void ViewScansPicture_MouseHover(object sender, EventArgs e)
        {
            this.ViewScansPicture.Image = Properties.Resources.view_scans_hover;
        }

        private void ViewScansPicture_MouseLeave(object sender, EventArgs e)
        {
            this.ViewScansPicture.Image = Properties.Resources.view_scans;
        }

        private void CompareScansPicture_MouseHover(object sender, EventArgs e)
        {
            this.CompareScansPicture.Image = Properties.Resources.compare_scans_hover;
        }

        private void CompareScansPicture_MouseLeave(object sender, EventArgs e)
        {
            this.CompareScansPicture.Image = Properties.Resources.compare_scans;
        }

        private void NewScanPicture_Click(object sender, EventArgs e)
        {
            newScanContainer.Visible = true;
            scanComparerContainer.Visible = false;
        }

        private void ViewScansPicture_Click(object sender, EventArgs e)
        {
            newScanContainer.Visible = false;
            scanComparerContainer.Visible = false;
        }

        private void CompareScansPicture_Click(object sender, EventArgs e)
        {
            newScanContainer.Visible = false;
            scanComparerContainer.Visible = true;
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {

        }
    }
}
