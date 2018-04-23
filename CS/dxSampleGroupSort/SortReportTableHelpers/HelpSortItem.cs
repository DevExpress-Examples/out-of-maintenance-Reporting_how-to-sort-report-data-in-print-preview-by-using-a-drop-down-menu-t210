using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace ReportSortHelpers {
    public class HelpSortItem {
        internal XtraReport Report { get; set; }
        internal string FieldName { get; set; }
        internal string Caption { get; set; }
        internal XRLabel HeaderCell { get; set; }
        internal PopupMenu Menu { get { return Helper.Menu;} }
        private SortOrder _ColumnSortOrder = SortOrder.None;
        private string ascendingSortCaptionPrefix = "*";
        private string descendingSortCaptionPrefix = "**";
        private DetailBand DataBand {
            get {
                return (DetailBand)Report.Bands.FirstOrDefault(x => x is DetailBand);
            }
        }
        public bool Modified {
            get;
            set;
        }
        internal ReportColumnSortHelper Helper { get;
            set; }
        internal SortOrder ColumnSortOrder {
            get {
                return _ColumnSortOrder;
            }
            set {
                if (_ColumnSortOrder == value) {
                    Modified = false;
                    return;
                }
                Modified = true;
                _ColumnSortOrder = value;
                if (value == SortOrder.None) {
                    ClearPrevSorting();
                } else {
                    ApplySorting();
                }
                ResetCaption();
            }
        }
        public HelpSortItem(ReportColumnSortHelper helper, XRLabel cell, PopupMenu menu, string fieldName, string caption, SortOrder sortOrder) {
            DoInit(helper, helper.Report, cell, menu, fieldName, caption, sortOrder);
        }
        public HelpSortItem(ReportColumnSortHelper helper, XRLabel cell, PopupMenu menu, string fieldName, string caption) {
            DoInit(helper, helper.Report, cell, menu, fieldName, caption, SortOrder.None);
        }
        private void DoInit(ReportColumnSortHelper helper,  XtraReport report, XRLabel cell, PopupMenu menu, string fieldName, string caption, SortOrder sortOrder) {
            Helper = helper;
            Report = report;
            HeaderCell = cell;
            cell.PreviewMouseMove += cell_PreviewMouseMove;
            cell.PreviewMouseDown += cell_PreviewMouseDown;
            FieldName = fieldName;
            Caption = caption;
            ColumnSortOrder = sortOrder;
        }
        private void cell_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            SetHandCursor(e);
        }
        private static void SetHandCursor(PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }
        private void cell_PreviewMouseDown(object sender, PreviewMouseEventArgs e) {
            if (IsMouseButtonPressed(MouseButtons.Right)) {
                InitSortMenu(Control.MousePosition);
            }
            if (IsMouseButtonPressed(MouseButtons.Left)) {
                Helper.HidePopup();
                if (!ShiftKeyHeld()) {
                    Helper.ClearAll(this, false);
                }
                SortOrder newSortOrder = GetSortOrderByLeftClick(ColumnSortOrder);
                ColumnSortOrder = newSortOrder;
                RecreateDocument();
            }
        }

        private bool ShiftKeyHeld() {
            return Control.ModifierKeys == Keys.Shift;
        }
        private SortOrder GetSortOrderByLeftClick(SortOrder prevSortOrder) {
            return (prevSortOrder == SortOrder.Descending || prevSortOrder == SortOrder.None) ? SortOrder.Ascending : SortOrder.Descending;
        }
        private void ApplySorting() {
            XRColumnSortOrder realOrder = GetRealSortOrder();
            DoSort(realOrder);
        }
        private void InitSortMenu(System.Drawing.Point location) {
            CheckMenuItemBySortOrder();
            ShowMenu(location);
        }
        private void CheckMenuItemBySortOrder() {
            SortOrder sortOrder = ColumnSortOrder;
            BarCheckItemLink menuItem = Menu.ItemLinks.OfType<BarCheckItemLink>().FirstOrDefault(x => (x.Item.Tag != null && x.Item.Tag is SortOrder && (SortOrder)x.Item.Tag == sortOrder));
            (menuItem.Item as BarCheckItem).Checked = true;
        }
        private void ShowMenu(System.Drawing.Point location) {
            Menu.ShowPopup(location);
        }
        private void ClearPrevSorting() {
            if (DataBand.SortFields.Count == 0) {
                return;
            }
            List<GroupField> fToRemove = new List<GroupField>();
            foreach (GroupField field in DataBand.SortFields) {
                if (field.FieldName == FieldName) {
                    fToRemove.Add(field);
                }
            }
            if (fToRemove.Count == 0) {
                return;
            }
            foreach (GroupField item in fToRemove) {
                DataBand.SortFields.Remove(item);
            }
        }
        private void ResetCaption() {
            HeaderCell.Text = GetCaptionText();
        }
        private void RecreateDocument() {
            Helper.RecreateDocument();
        }
        private string GetCaptionText() {
            string result = Caption;
            switch (ColumnSortOrder) {
                case SortOrder.None:
                    break;
                case SortOrder.Ascending:
                case SortOrder.Descending:
                    result = Caption + " " + GetSortPrefix(ColumnSortOrder);
                    break;
            }
            return result;
        }

        private XRColumnSortOrder GetRealSortOrder() {
            XRColumnSortOrder result = XRColumnSortOrder.Ascending;
            switch (ColumnSortOrder) {
                case SortOrder.None:
                case SortOrder.Descending:
                    result = XRColumnSortOrder.Descending;
                    break;
                case SortOrder.Ascending:
                    result = XRColumnSortOrder.Ascending;
                    break;
            }
            return result;
        }

        private void DoSort(XRColumnSortOrder realOrder) {
            HelpSortItem cellSortInfo = this;
            string fieldName = cellSortInfo.FieldName;
            GroupField item = new GroupField(fieldName, realOrder);
            GroupField groupFieldToRemove = DataBand.SortFields.OfType<GroupField>().FirstOrDefault(x => x.FieldName == fieldName);
            if (groupFieldToRemove != null) {
                DataBand.SortFields.Remove(groupFieldToRemove);
            }
            DataBand.SortFields.Add(item);
        }
        private string GetSortPrefix(SortOrder newSortOrder) {
            return newSortOrder == SortOrder.Ascending ? ascendingSortCaptionPrefix : descendingSortCaptionPrefix;
        }
        public bool IsMouseButtonPressed(MouseButtons button) {
            return (Control.MouseButtons & button) == button;
        }
    }
}
