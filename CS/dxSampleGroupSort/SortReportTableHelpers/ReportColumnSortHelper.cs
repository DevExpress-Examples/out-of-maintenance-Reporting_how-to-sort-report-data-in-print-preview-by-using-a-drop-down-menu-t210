using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System.Linq;
using DevExpress.Utils.Win;
using DevExpress.XtraPrinting.Control;

namespace ReportSortHelpers {
    public class ReportColumnSortHelper {        
        private string _sortPrefix = "Sort_";
        private string _clearSort = "Clear_Sort";
        private HelpSortItem ClickedItem;
        private List<HelpSortItem> sortItems;
        private BarManager manager;
        internal PopupMenu Menu;
        internal XtraReport Report { get; set; }
        internal ReportPrintTool PrintTool { get; set; }

        internal BarManager BarManager
        {
            get { return manager; }
            set
            {
                manager = value;
                if (manager != null)
                    Menu = Menu_InitSortMenu();
            }
        }

        public ReportColumnSortHelper(XtraReport report) {
            Report = report;
            PrintTool = new ReportPrintTool(report);            

            List<XRLabel> sortCells = new List<XRLabel>();
            sortItems = new List<HelpSortItem>();
            InitHeaderCells(sortCells);
            InitClearSortingCell();
        }        

        #region PreviewMethods
        public void ShowPreview()
        {
            BarManager = PrintTool.PreviewForm.PrintBarManager;
            PrintTool.ShowPreview();            
        }

        public void ShowPreviewDialog()
        {
            BarManager = PrintTool.PreviewForm.PrintBarManager;
            PrintTool.ShowPreviewDialog();
        }

        public void ShowRibbonPreview()
        {
            BarManager = PrintTool.PreviewRibbonForm.Ribbon.Manager;
            PrintTool.ShowRibbonPreview();
        }

        public void ShowRibbonPreviewDialog()
        {
            BarManager = PrintTool.PreviewRibbonForm.Ribbon.Manager;
            PrintTool.ShowRibbonPreviewDialog();
        }
        #endregion

        #region Clear_Sorting
        private void InitClearSortingCell()
        {
            XRLabel clearLabel = Report.AllControls<XRLabel>().FirstOrDefault(x => Convert.ToString(x.Tag).Equals(_clearSort));
            if (clearLabel != null)
            {
                clearLabel.PreviewMouseDown += clearLabel_PreviewMouseDown;
                clearLabel.PreviewMouseMove += clearLabel_PreviewMouseMove;
            }
        }

        void clearLabel_PreviewMouseMove(object sender, PreviewMouseEventArgs e)
        {
            SetHandCursor(e);
        }

        void clearLabel_PreviewMouseDown(object sender, PreviewMouseEventArgs e)
        {
            ClearAll(null);
        }

        private static void SetHandCursor(PreviewMouseEventArgs e)
        {
            e.PreviewControl.Cursor = Cursors.Hand;
        }
        #endregion

        #region Header Cells
        private void InitHeaderCells(List<XRLabel> sortCells)
        {
            PopulateHeaderCells(sortCells);
            foreach (XRLabel lbl in sortCells)
            {
                string fieldName = lbl.Tag.ToString().Substring(lbl.Tag.ToString().IndexOf('_') + 1);
                string caption = lbl.Text;
                HelpSortItem item = new HelpSortItem(this, lbl, Menu, fieldName, caption);
                sortItems.Add(item);
                lbl.PreviewMouseDown += lbl_PreviewMouseDown;
            }
        }
        private void lbl_PreviewMouseDown(object sender, PreviewMouseEventArgs e)
        {
            XRLabel clickedCell = sender as XRLabel;
            ClickedItem = (HelpSortItem)sortItems.FirstOrDefault(x => x.HeaderCell == clickedCell);       
        }

        private void PopulateHeaderCells(List<XRLabel> sortCells)
        {
            IEnumerable<XRLabel> allControls = GetAllReportControls();
            var cells = from c in allControls
                        where c.Tag != null && c.Tag.ToString().StartsWith(_sortPrefix)
                        select c;
            sortCells.AddRange(cells.ToList());
        }
        private IEnumerable<XRLabel> GetAllReportControls()
        {
            return Report.AllControls<XRLabel>();
        }
        #endregion

        #region Menu initialization
        private PopupMenu Menu_InitSortMenu()
        {
            PopupMenu sortMenu = new PopupMenu();
            manager.ItemClick += manager_ItemClick;
            sortMenu.Manager = BarManager;
            BarCheckItem item1 = Menu_InitSortItem(SortOrder.None);
            BarCheckItem item2 = Menu_InitSortItem(SortOrder.Ascending);
            BarCheckItem item3 = Menu_InitSortItem(SortOrder.Descending);
            item1.GroupIndex = item2.GroupIndex = item3.GroupIndex = 1;
            sortMenu.AddItems(new BarItem[] { item1, item2, item3 });
            return sortMenu;        
        }

        private static BarCheckItem Menu_InitSortItem(SortOrder sortMode)
        {
            BarCheckItem itemNone = new BarCheckItem();
            itemNone.Width = 100;
            itemNone.Tag = sortMode;
            itemNone.Caption = itemNone.Tag.ToString();
            itemNone.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
            return itemNone;
        }

        private void manager_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarItem clickedMenuItem = e.Item;
            HelpSortItem item = null;
            if (clickedMenuItem != null && clickedMenuItem.Tag != null && clickedMenuItem.Tag is SortOrder)
            {
                item = ClickedItem;
                SortOrder newSortOrder = (SortOrder)clickedMenuItem.Tag;
                item.ColumnSortOrder = newSortOrder;
            }
            if (item != null && item.Modified)
                RecreateDocument();
        }
        #endregion        

        internal void RecreateDocument() {
            Report.CreateDocument();
        }
        public bool IsMouseButtonPressed(MouseButtons button) {
            return (Control.MouseButtons & button) == button;
        }
        internal void ResetItemsCaption(HelpSortItem actualItem) {
            SortOrder order = SortOrder.None;
            foreach (HelpSortItem item in sortItems) {
                if (actualItem != null && item == actualItem) {
                    continue;
                } else {
                    item.ColumnSortOrder = order;
                }
            }
        }
        private void ClearSorting() {
            DetailBand dataBand = GetDataBand();
            dataBand.SortFields.Clear();
        }
        private DetailBand GetDataBand() {
            return (DetailBand)Report.Bands.FirstOrDefault(x => x is DetailBand);
        }
        public void ClearAll(HelpSortItem actualItem) {
            ClearAll(actualItem, true);
        }
        public void ClearAll(HelpSortItem actualItem, bool refreshDocument) {
            ClearSorting();
            ResetItemsCaption(actualItem);
            if(refreshDocument)
                RecreateDocument();
        }
        public void HidePopup() {
            if (Menu.Opened) {
                Menu.HidePopup();
            }

        }
    }
}
