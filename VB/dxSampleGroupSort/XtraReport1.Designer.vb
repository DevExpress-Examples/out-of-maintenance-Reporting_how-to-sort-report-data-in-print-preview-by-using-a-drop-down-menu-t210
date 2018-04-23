Namespace dxSampleGroupSort
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.evenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.lblClearSorting = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.cellHeaderProdName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.cellHeaderQuantityPerUnit = New DevExpress.XtraReports.UI.XRTableCell()
            Me.cellHeaderUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.cellHeaderReorderLvl = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableColumnPanelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.calcFieldReorderLvl = New DevExpress.XtraReports.UI.CalculatedField()
            Me.tableCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 25.41667F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0001F, 25.41667F)
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell9, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StyleName = "tableCellStyle"
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.Weight = 0.72596163823920856R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell2.CanShrink = True
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StyleName = "tableCellStyle"
            Me.xrTableCell2.StylePriority.UseBorders = False
            Me.xrTableCell2.Weight = 0.887499930150345R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice")})
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StyleName = "tableCellStyle"
            Me.xrTableCell9.StylePriority.UseBorders = False
            Me.xrTableCell9.Weight = 0.63653818043908783R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ReorderLevel")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StyleName = "tableCellStyle"
            Me.xrTableCell3.StylePriority.UseBorders = False
            Me.xrTableCell3.Weight = 0.7500004554362838R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
            Me.TopMargin.HeightF = 103.125F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel2})
            Me.BottomMargin.HeightF = 102.0833F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "selishcheva-w81\sqlexpress.NORTHWND.dbo"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Categories"
            relationInfo1.ParentTable = "Products"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1})
            tableInfo1.Name = "Products"
            columnInfo1.Name = "ProductID"
            columnInfo2.Name = "ProductName"
            columnInfo3.Name = "SupplierID"
            columnInfo4.Name = "CategoryID"
            columnInfo5.Name = "QuantityPerUnit"
            columnInfo6.Name = "UnitPrice"
            columnInfo7.Name = "UnitsInStock"
            columnInfo8.Name = "UnitsOnOrder"
            columnInfo9.Name = "ReorderLevel"
            columnInfo10.Name = "Discontinued"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10})
            tableInfo2.Name = "Categories"
            columnInfo11.Alias = "Categories_CategoryID"
            columnInfo11.Name = "CategoryID"
            columnInfo12.Name = "CategoryName"
            columnInfo13.Name = "Description"
            columnInfo14.Name = "Picture"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo11, columnInfo12, columnInfo13, columnInfo14})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' oddStyle
            ' 
            Me.oddStyle.BackColor = System.Drawing.Color.Silver
            Me.oddStyle.BorderColor = System.Drawing.Color.MistyRose
            Me.oddStyle.Name = "oddStyle"
            Me.oddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' evenStyle
            ' 
            Me.evenStyle.Name = "evenStyle"
            Me.evenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lblClearSorting, Me.xrTable2})
            Me.PageHeader.HeightF = 46.33338F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' lblClearSorting
            ' 
            Me.lblClearSorting.Font = New System.Drawing.Font("Times New Roman", 12F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)))
            Me.lblClearSorting.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(160)))))
            Me.lblClearSorting.LocationFloat = New DevExpress.Utils.PointFloat(487.4999F, 0F)
            Me.lblClearSorting.Name = "lblClearSorting"
            Me.lblClearSorting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lblClearSorting.SizeF = New System.Drawing.SizeF(162.5001F, 19.25002F)
            Me.lblClearSorting.StylePriority.UseBackColor = False
            Me.lblClearSorting.StylePriority.UseFont = False
            Me.lblClearSorting.StylePriority.UseForeColor = False
            Me.lblClearSorting.StylePriority.UseTextAlignment = False
            Me.lblClearSorting.Text = "Clear sorting"
            Me.lblClearSorting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 19.25004F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0001F, 27.08333F)
            Me.xrTable2.StyleName = "tableColumnPanelStyle"
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.cellHeaderProdName, Me.cellHeaderQuantityPerUnit, Me.cellHeaderUnitPrice, Me.cellHeaderReorderLvl})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' cellHeaderProdName
            ' 
            Me.cellHeaderProdName.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.cellHeaderProdName.Name = "cellHeaderProdName"
            Me.cellHeaderProdName.StyleName = "tableCellStyle"
            Me.cellHeaderProdName.StylePriority.UseBorders = False
            Me.cellHeaderProdName.Tag = "Sort_ProductName"
            Me.cellHeaderProdName.Text = "Product Name"
            Me.cellHeaderProdName.Weight = 0.72596155517450645R
            ' 
            ' cellHeaderQuantityPerUnit
            ' 
            Me.cellHeaderQuantityPerUnit.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.cellHeaderQuantityPerUnit.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold)
            Me.cellHeaderQuantityPerUnit.Name = "cellHeaderQuantityPerUnit"
            Me.cellHeaderQuantityPerUnit.StyleName = "tableCellStyle"
            Me.cellHeaderQuantityPerUnit.StylePriority.UseBorders = False
            Me.cellHeaderQuantityPerUnit.StylePriority.UseFont = False
            Me.cellHeaderQuantityPerUnit.StylePriority.UseForeColor = False
            Me.cellHeaderQuantityPerUnit.Tag = "Sort_QuantityPerUnit"
            Me.cellHeaderQuantityPerUnit.Text = "Quantity Per Unit"
            Me.cellHeaderQuantityPerUnit.Weight = 0.88750008174683237R
            ' 
            ' cellHeaderUnitPrice
            ' 
            Me.cellHeaderUnitPrice.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.cellHeaderUnitPrice.Name = "cellHeaderUnitPrice"
            Me.cellHeaderUnitPrice.StyleName = "tableCellStyle"
            Me.cellHeaderUnitPrice.StylePriority.UseBorders = False
            Me.cellHeaderUnitPrice.Tag = "Sort_UnitPrice"
            Me.cellHeaderUnitPrice.Text = "Unit Price"
            Me.cellHeaderUnitPrice.Weight = 0.63653819231636R
            ' 
            ' cellHeaderReorderLvl
            ' 
            Me.cellHeaderReorderLvl.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.cellHeaderReorderLvl.Name = "cellHeaderReorderLvl"
            Me.cellHeaderReorderLvl.StyleName = "tableCellStyle"
            Me.cellHeaderReorderLvl.StylePriority.UseBorders = False
            Me.cellHeaderReorderLvl.Tag = "Sort_ReorderLevel"
            Me.cellHeaderReorderLvl.Text = "Reorder Level"
            Me.cellHeaderReorderLvl.Weight = 0.75000039774770211R
            ' 
            ' tableColumnPanelStyle
            ' 
            Me.tableColumnPanelStyle.BackColor = System.Drawing.SystemColors.Info
            Me.tableColumnPanelStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableColumnPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tableColumnPanelStyle.ForeColor = System.Drawing.Color.DarkCyan
            Me.tableColumnPanelStyle.Name = "tableColumnPanelStyle"
            Me.tableColumnPanelStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableColumnPanelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' calcFieldReorderLvl
            ' 
            Me.calcFieldReorderLvl.DataMember = "Products"
            Me.calcFieldReorderLvl.Expression = "[ReorderLevel] < 10"
            Me.calcFieldReorderLvl.Name = "calcFieldReorderLvl"
            ' 
            ' tableCellStyle
            ' 
            Me.tableCellStyle.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.tableCellStyle.Name = "tableCellStyle"
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1.041667F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(649.9999F, 102.0833F)
            Me.xrPanel1.StylePriority.UseBorders = False
            ' 
            ' xrPanel2
            ' 
            Me.xrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPanel2.Name = "xrPanel2"
            Me.xrPanel2.SizeF = New System.Drawing.SizeF(649.9999F, 102.0833F)
            Me.xrPanel2.StylePriority.UseBorders = False
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
            Me.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calcFieldReorderLvl})
            Me.ComponentStorage.Add(Me.sqlDataSource1)
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 103, 102)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.oddStyle, Me.evenStyle, Me.tableColumnPanelStyle, Me.tableCellStyle})
            Me.Version = "14.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private oddStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private evenStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private cellHeaderProdName As DevExpress.XtraReports.UI.XRTableCell
        Private cellHeaderQuantityPerUnit As DevExpress.XtraReports.UI.XRTableCell
        Private tableColumnPanelStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private cellHeaderUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Private calcFieldReorderLvl As DevExpress.XtraReports.UI.CalculatedField
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private cellHeaderReorderLvl As DevExpress.XtraReports.UI.XRTableCell
        Private WithEvents lblClearSorting As DevExpress.XtraReports.UI.XRLabel
        Private tableCellStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
        Private WithEvents xrPanel2 As DevExpress.XtraReports.UI.XRPanel
    End Class
End Namespace
