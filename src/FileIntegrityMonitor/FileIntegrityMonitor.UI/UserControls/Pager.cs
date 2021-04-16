using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIntegrityMonitor.UI.UserControls
{
    public partial class Pager : UserControl
    {
        public Pager()
        {
            InitializeComponent();
        }

        private void Pager_Load(object sender, EventArgs e)
        {

        }

        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalNumberOfItems { get; set; }

        public void SetCurrentPage(int pageNumber)
        {
            CurrentPage = pageNumber;
            SetPageNumberCaption();
            SetPagerCaption();
        }

        private void SetPageNumberCaption()
        {
            this.PageNumber.Text = CurrentPage.ToString();
        }

        private void SetPagerCaption()
        {
            int itemsFrom = ((CurrentPage - 1) * ItemsPerPage) + 1;
            int itemsTo = Math.Min(TotalNumberOfItems, itemsFrom + ItemsPerPage - 1);

            //this.PagerCaption.Text = string.Format("Results {0} - {1} from {2}", itemsFrom, itemsTo, TotalNumberOfItems);
        }
    }
}
