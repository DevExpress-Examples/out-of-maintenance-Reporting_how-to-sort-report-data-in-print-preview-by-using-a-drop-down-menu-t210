# How to sort report data in Print Preview by using a drop-down menu 


This example demonstrates how to implement a drop-down menu that allows you to choose the sort order for a table column and then sort a table.<br />This approach implies that you initially assign a special value to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Tagtopic">Tag </a>property of the XRTableCell that represents a header cell. <br /><br />To initiate sorting for a column, assign the <strong>"Sort_<FieldName>"</strong> string to Tag.<br /> <br />You can also implement a <strong>'Clear All'</strong> label. To do so, assign the <strong>"Clear_Sort"</strong> string to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Tagtopic">XRControl.Tag</a> property.<br /><br /><em>Please note that with this approach, we do not recommend using the standard approach which implies using a band's SortFields collection.</em><br /><br />See also:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5527">How to: Sort a Report in the Preview</a> <br /><a href="https://www.devexpress.com/Support/Center/p/E770">How to sort a report in preview</a><br /><br />

<br/>


