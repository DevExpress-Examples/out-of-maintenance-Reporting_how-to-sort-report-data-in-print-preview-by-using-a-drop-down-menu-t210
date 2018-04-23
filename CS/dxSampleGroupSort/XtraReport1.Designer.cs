namespace dxSampleGroupSort {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.oddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.evenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblClearSorting = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellHeaderProdName = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHeaderQuantityPerUnit = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHeaderUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellHeaderReorderLvl = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableColumnPanelStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.calcFieldReorderLvl = new DevExpress.XtraReports.UI.CalculatedField();
            this.tableCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 25.41667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650.0001F, 25.41667F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell9,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StyleName = "tableCellStyle";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.Weight = 0.72596163823920856D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.CanShrink = true;
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.QuantityPerUnit")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StyleName = "tableCellStyle";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.Weight = 0.887499930150345D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StyleName = "tableCellStyle";
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.Weight = 0.63653818043908783D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ReorderLevel")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StyleName = "tableCellStyle";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.Weight = 0.7500004554362838D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 103.125F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 102.0833F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NorthwindConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "Categories";
            relationInfo1.ParentTable = "Products";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1});
            tableInfo1.Name = "Products";
            columnInfo1.Name = "ProductID";
            columnInfo2.Name = "ProductName";
            columnInfo3.Name = "SupplierID";
            columnInfo4.Name = "CategoryID";
            columnInfo5.Name = "QuantityPerUnit";
            columnInfo6.Name = "UnitPrice";
            columnInfo7.Name = "UnitsInStock";
            columnInfo8.Name = "UnitsOnOrder";
            columnInfo9.Name = "ReorderLevel";
            columnInfo10.Name = "Discontinued";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5,
            columnInfo6,
            columnInfo7,
            columnInfo8,
            columnInfo9,
            columnInfo10});
            tableInfo2.Name = "Categories";
            columnInfo11.Alias = "Categories_CategoryID";
            columnInfo11.Name = "CategoryID";
            columnInfo12.Name = "CategoryName";
            columnInfo13.Name = "Description";
            columnInfo14.Name = "Picture";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo11,
            columnInfo12,
            columnInfo13,
            columnInfo14});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // oddStyle
            // 
            this.oddStyle.BackColor = System.Drawing.Color.Silver;
            this.oddStyle.BorderColor = System.Drawing.Color.MistyRose;
            this.oddStyle.Name = "oddStyle";
            this.oddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // evenStyle
            // 
            this.evenStyle.Name = "evenStyle";
            this.evenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblClearSorting,
            this.xrTable2});
            this.PageHeader.HeightF = 46.33338F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblClearSorting
            // 
            this.lblClearSorting.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClearSorting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.lblClearSorting.LocationFloat = new DevExpress.Utils.PointFloat(487.4999F, 0F);
            this.lblClearSorting.Name = "lblClearSorting";
            this.lblClearSorting.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblClearSorting.SizeF = new System.Drawing.SizeF(162.5001F, 19.25002F);
            this.lblClearSorting.StylePriority.UseBackColor = false;
            this.lblClearSorting.StylePriority.UseFont = false;
            this.lblClearSorting.StylePriority.UseForeColor = false;
            this.lblClearSorting.StylePriority.UseTextAlignment = false;
            this.lblClearSorting.Tag = "Clear_Sort";
            this.lblClearSorting.Text = "Clear sorting";
            this.lblClearSorting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 19.25004F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650.0001F, 27.08333F);
            this.xrTable2.StyleName = "tableColumnPanelStyle";
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellHeaderProdName,
            this.cellHeaderQuantityPerUnit,
            this.cellHeaderUnitPrice,
            this.cellHeaderReorderLvl});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // cellHeaderProdName
            // 
            this.cellHeaderProdName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHeaderProdName.Name = "cellHeaderProdName";
            this.cellHeaderProdName.StyleName = "tableCellStyle";
            this.cellHeaderProdName.StylePriority.UseBorders = false;
            this.cellHeaderProdName.Tag = "Sort_ProductName";
            this.cellHeaderProdName.Text = "Product Name";
            this.cellHeaderProdName.Weight = 0.72596155517450645D;
            // 
            // cellHeaderQuantityPerUnit
            // 
            this.cellHeaderQuantityPerUnit.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHeaderQuantityPerUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cellHeaderQuantityPerUnit.Name = "cellHeaderQuantityPerUnit";
            this.cellHeaderQuantityPerUnit.StyleName = "tableCellStyle";
            this.cellHeaderQuantityPerUnit.StylePriority.UseBorders = false;
            this.cellHeaderQuantityPerUnit.StylePriority.UseFont = false;
            this.cellHeaderQuantityPerUnit.StylePriority.UseForeColor = false;
            this.cellHeaderQuantityPerUnit.Tag = "Sort_QuantityPerUnit";
            this.cellHeaderQuantityPerUnit.Text = "Quantity Per Unit";
            this.cellHeaderQuantityPerUnit.Weight = 0.88750008174683237D;
            // 
            // cellHeaderUnitPrice
            // 
            this.cellHeaderUnitPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHeaderUnitPrice.Name = "cellHeaderUnitPrice";
            this.cellHeaderUnitPrice.StyleName = "tableCellStyle";
            this.cellHeaderUnitPrice.StylePriority.UseBorders = false;
            this.cellHeaderUnitPrice.Tag = "Sort_UnitPrice";
            this.cellHeaderUnitPrice.Text = "Unit Price";
            this.cellHeaderUnitPrice.Weight = 0.63653819231636D;
            // 
            // cellHeaderReorderLvl
            // 
            this.cellHeaderReorderLvl.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellHeaderReorderLvl.Name = "cellHeaderReorderLvl";
            this.cellHeaderReorderLvl.StyleName = "tableCellStyle";
            this.cellHeaderReorderLvl.StylePriority.UseBorders = false;
            this.cellHeaderReorderLvl.Tag = "Sort_ReorderLevel";
            this.cellHeaderReorderLvl.Text = "Reorder Level";
            this.cellHeaderReorderLvl.Weight = 0.75000039774770211D;
            // 
            // tableColumnPanelStyle
            // 
            this.tableColumnPanelStyle.BackColor = System.Drawing.SystemColors.Info;
            this.tableColumnPanelStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableColumnPanelStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableColumnPanelStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.tableColumnPanelStyle.Name = "tableColumnPanelStyle";
            this.tableColumnPanelStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableColumnPanelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // calcFieldReorderLvl
            // 
            this.calcFieldReorderLvl.DataMember = "Products";
            this.calcFieldReorderLvl.Expression = "[ReorderLevel] < 10";
            this.calcFieldReorderLvl.Name = "calcFieldReorderLvl";
            // 
            // tableCellStyle
            // 
            this.tableCellStyle.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCellStyle.Name = "tableCellStyle";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calcFieldReorderLvl});
            this.ComponentStorage.Add(this.sqlDataSource1);
            this.DataMember = "Products";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 103, 102);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.oddStyle,
            this.evenStyle,
            this.tableColumnPanelStyle,
            this.tableCellStyle});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRControlStyle oddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle evenStyle;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellHeaderProdName;
        private DevExpress.XtraReports.UI.XRTableCell cellHeaderQuantityPerUnit;
        private DevExpress.XtraReports.UI.XRControlStyle tableColumnPanelStyle;
        private DevExpress.XtraReports.UI.XRTableCell cellHeaderUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.CalculatedField calcFieldReorderLvl;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell cellHeaderReorderLvl;
        private DevExpress.XtraReports.UI.XRLabel lblClearSorting;
        private DevExpress.XtraReports.UI.XRControlStyle tableCellStyle;
    }
}
