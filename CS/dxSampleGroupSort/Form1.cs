using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraReports.UI;
using ReportSortHelpers;

namespace dxSampleGroupSort {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void ShowReport() {
            ReportColumnSortHelper sortHelper = new ReportColumnSortHelper(new XtraReport1());
            sortHelper.ShowPreviewDialog();
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            ShowReport();
        }
    }
}
