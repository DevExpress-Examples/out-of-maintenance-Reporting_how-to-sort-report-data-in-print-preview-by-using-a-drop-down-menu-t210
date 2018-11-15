<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dxSampleGroupSort/Form1.cs) (VB: [Form1.vb](./VB/dxSampleGroupSort/Form1.vb))
* [Program.cs](./CS/dxSampleGroupSort/Program.cs) (VB: [Program.vb](./VB/dxSampleGroupSort/Program.vb))
* [HelpSortItem.cs](./CS/dxSampleGroupSort/SortReportTableHelpers/HelpSortItem.cs) (VB: [HelpSortItem.vb](./VB/dxSampleGroupSort/SortReportTableHelpers/HelpSortItem.vb))
* [ReportColumnSortHelper.cs](./CS/dxSampleGroupSort/SortReportTableHelpers/ReportColumnSortHelper.cs) (VB: [ReportColumnSortHelper.vb](./VB/dxSampleGroupSort/SortReportTableHelpers/ReportColumnSortHelper.vb))
* [XtraReport1.cs](./CS/dxSampleGroupSort/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/dxSampleGroupSort/XtraReport1.vb))
<!-- default file list end -->
# How to sort report data in Print Preview by using a drop-down menu 


This example demonstrates how to implement a drop-down menu that allows you to choose the sort order for a table column and then sort a table.<br />This approach implies that you initially assign a special value to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Tagtopic">Tag </a>property of the XRTableCell that represents a header cell. <br /><br />To initiate sorting for a column, assign the <strong>"Sort_<FieldName>"</strong> string to Tag.<br /> <br />You can also implement a <strong>'Clear All'</strong> label. To do so, assign the <strong>"Clear_Sort"</strong> string to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Tagtopic">XRControl.Tag</a> property.<br /><br /><em>Please note that with this approach, we do not recommend using the standard approach which implies using a band's SortFields collection.</em><br /><br />See also:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5527">How to: Sort a Report in the Preview</a> <br /><a href="https://www.devexpress.com/Support/Center/p/E770">How to sort a report in preview</a><br /><br />

<br/>


