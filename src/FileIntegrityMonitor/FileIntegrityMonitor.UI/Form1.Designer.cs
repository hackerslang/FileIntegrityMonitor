namespace FileIntegrityMonitor.UI
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CompareScansPicture = new System.Windows.Forms.PictureBox();
            this.ViewScansPicture = new System.Windows.Forms.PictureBox();
            this.NewScanPicture = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompareScansPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewScansPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewScanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CompareScansPicture
            // 
            this.CompareScansPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompareScansPicture.Image = global::FileIntegrityMonitor.UI.Properties.Resources.compare_scans;
            this.CompareScansPicture.Location = new System.Drawing.Point(722, 104);
            this.CompareScansPicture.Name = "CompareScansPicture";
            this.CompareScansPicture.Size = new System.Drawing.Size(319, 50);
            this.CompareScansPicture.TabIndex = 4;
            this.CompareScansPicture.TabStop = false;
            this.CompareScansPicture.Click += new System.EventHandler(this.CompareScansPicture_Click);
            this.CompareScansPicture.MouseEnter += new System.EventHandler(this.CompareScansPicture_MouseHover);
            this.CompareScansPicture.MouseLeave += new System.EventHandler(this.CompareScansPicture_MouseLeave);
            // 
            // ViewScansPicture
            // 
            this.ViewScansPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewScansPicture.Image = global::FileIntegrityMonitor.UI.Properties.Resources.view_scans;
            this.ViewScansPicture.Location = new System.Drawing.Point(369, 104);
            this.ViewScansPicture.Name = "ViewScansPicture";
            this.ViewScansPicture.Size = new System.Drawing.Size(319, 50);
            this.ViewScansPicture.TabIndex = 3;
            this.ViewScansPicture.TabStop = false;
            this.ViewScansPicture.Click += new System.EventHandler(this.ViewScansPicture_Click);
            this.ViewScansPicture.MouseEnter += new System.EventHandler(this.ViewScansPicture_MouseHover);
            this.ViewScansPicture.MouseLeave += new System.EventHandler(this.ViewScansPicture_MouseLeave);
            // 
            // NewScanPicture
            // 
            this.NewScanPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewScanPicture.Image = global::FileIntegrityMonitor.UI.Properties.Resources.new_scan;
            this.NewScanPicture.Location = new System.Drawing.Point(12, 104);
            this.NewScanPicture.Name = "NewScanPicture";
            this.NewScanPicture.Size = new System.Drawing.Size(319, 50);
            this.NewScanPicture.TabIndex = 2;
            this.NewScanPicture.TabStop = false;
            this.NewScanPicture.Click += new System.EventHandler(this.NewScanPicture_Click);
            this.NewScanPicture.MouseEnter += new System.EventHandler(this.pictureBox1_MouseHover);
            this.NewScanPicture.MouseLeave += new System.EventHandler(this.NewScanPicture_MouseLeave);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::FileIntegrityMonitor.UI.Properties.Resources.fim;
            this.LogoBox.Location = new System.Drawing.Point(3, -1);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(1057, 105);
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click);
            this.LogoBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1132, 728);
            this.Controls.Add(this.CompareScansPicture);
            this.Controls.Add(this.ViewScansPicture);
            this.Controls.Add(this.NewScanPicture);
            this.Controls.Add(this.LogoBox);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompareScansPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewScansPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewScanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.PictureBox NewScanPicture;
        private System.Windows.Forms.PictureBox ViewScansPicture;
        private System.Windows.Forms.PictureBox CompareScansPicture;
    }
}

